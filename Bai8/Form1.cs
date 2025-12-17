using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Bai8
{
    public partial class Form1 : Form
    {
        private Timer timer;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Analog Clock";
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;   
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (s, e) => { this.Invalidate(); }; 
            timer.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias; 
            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;
            // Bán kính đồng hồ
            int radius = Math.Min(centerX, centerY) - 20;

    
            g.TranslateTransform(centerX, centerY);

            // mặt đồng hồ 
            DrawClockFace(g, radius);


            DateTime now = DateTime.Now;

            // kim Giờ (mỗi giờ 30 độ + phút lẻ)
            float hourAngle = (now.Hour % 12 + now.Minute / 60.0f) * 30;
            DrawHand(g, hourAngle, radius * 0.5f, 6, false);

            // kim Phút (mỗi phút 6 độ)
            float minuteAngle = (now.Minute + now.Second / 60.0f) * 6;
            DrawHand(g, minuteAngle, radius * 0.7f, 4, false);

            // Vẽ kim Giây (Mỗi giây 6 độ)
            float secondAngle = now.Second * 6;
            DrawHand(g, secondAngle, radius * 0.85f, 2, true);
        }

        private void DrawClockFace(Graphics g, int r)
        {
            Brush whiteBrush = Brushes.White;
            var state = g.Save();

            for (int i = 0; i < 60; i++)
            {
                if (i % 5 == 0)
                {
                    // Chấm giờ
                    g.FillEllipse(whiteBrush, -8, -r, 16, 16);
                }
                else
                {
                    // Chấm phút
                    g.FillEllipse(whiteBrush, -3, -r, 6, 6);
                }
                g.RotateTransform(6); 
            }
        }

        private void DrawHand(Graphics g, float angle, float length, int width, bool isSecondHand)
        {
            var state = g.Save();
            g.RotateTransform(angle);

            Pen p = new Pen(Color.White, 1.5f);
            PointF[] points = new PointF[]
            {
                new PointF(0, 20),           // Đuôi kim
                new PointF(-width * 2, 0),   // Cạnh trái
                new PointF(0, -length),      // Đỉnh kim
                new PointF(width * 2, 0)     // Cạnh phải
            };

            g.DrawPolygon(p, points); 
            if (!isSecondHand)
            {
                g.DrawLine(p, 0, 20, 0, -length);
            }

            g.Restore(state);
        }
    }
}
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Bai11
{
    public partial class Form1 : Form
    {
        Point startPoint;
        bool isDrawing = false;
        Color penColor = Color.Black; 

        public Form1()
        {
            InitializeComponent();

            textBox1.Text = "1";
            button1.Text = "Color...";
            button1.Click += Button1_Click;

            this.MouseDown += Form1_MouseDown;
            this.MouseMove += Form1_MouseMove;
            this.MouseUp += Form1_MouseUp;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                penColor = cd.Color;
                button1.BackColor = cd.Color; 
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                startPoint = e.Location;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return;

            Graphics g = this.CreateGraphics();
            int width = int.Parse(string.IsNullOrEmpty(textBox1.Text) ? "1" : textBox1.Text);
            Rectangle rect = new Rectangle(
                Math.Min(startPoint.X, e.X),
                Math.Min(startPoint.Y, e.Y),
                Math.Abs(startPoint.X - e.X),
                Math.Abs(startPoint.Y - e.Y));

            if (radioButton1.Checked) 
            {
                Pen pen = new Pen(penColor, width);
                g.DrawLine(pen, startPoint, e.Location);
            }
            else 
            {
                Brush brush = GetSelectedBrush(rect);
                if (radioButton2.Checked) 
                    g.FillRectangle(brush, rect);
                else if (radioButton3.Checked) 
                    g.FillEllipse(brush, rect);
            }

            isDrawing = false;
            g.Dispose();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private Brush GetSelectedBrush(Rectangle rect)
        {
            if (rect.Width <= 0) rect.Width = 1;
            if (rect.Height <= 0) rect.Height = 1;

            // SolidBrush
            if (radioButton6.Checked)
                return new SolidBrush(penColor);

            // HatchBrush
            if (radioButton5.Checked)
                return new HatchBrush(HatchStyle.Horizontal, penColor, Color.White);

            // TextureBrush
            if (radioButton4.Checked)
            {
                Bitmap bmp = new Bitmap(10, 10);
                using (Graphics gBmp = Graphics.FromImage(bmp)) gBmp.Clear(penColor);
                return new TextureBrush(bmp);
            }

           // LinearGradientBrush
            if (radioButton7.Checked)
                return new LinearGradientBrush(rect, penColor, Color.White, LinearGradientMode.Vertical);

            return new SolidBrush(penColor);
        }
    }
}
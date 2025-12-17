using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Bai9
{
    public partial class Form1 : Form
    {
        private bool isDrawing = false;
        private Point startPoint;
        private Point currentPoint;

        private Bitmap canvasBitmap;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            canvasBitmap = new Bitmap(2000, 2000);
            using (Graphics g = Graphics.FromImage(canvasBitmap))
            {
                g.Clear(Color.White);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            startPoint = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                currentPoint = e.Location;
                this.Invalidate(); 
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                isDrawing = false;
                currentPoint = e.Location;

                using (Graphics g = Graphics.FromImage(canvasBitmap))
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    DrawSelectedShape(g);
                }

                this.Invalidate();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(canvasBitmap, 0, 0);

            if (isDrawing)
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                DrawSelectedShape(e.Graphics);
            }
        }

        private void DrawSelectedShape(Graphics g)
        {
            if (comboBox1.SelectedIndex == -1) return;

            string shapeType = comboBox1.SelectedItem.ToString();
            Pen p = new Pen(Color.DarkRed, 3);
            Brush b = new SolidBrush(Color.DarkRed);

            int x = Math.Min(startPoint.X, currentPoint.X);
            int y = Math.Min(startPoint.Y, currentPoint.Y);
            int width = Math.Abs(startPoint.X - currentPoint.X);
            int height = Math.Abs(startPoint.Y - currentPoint.Y);
            if (width == 0 || height == 0) return;

            Rectangle rect = new Rectangle(x, y, width, height);

            int side = Math.Min(width, height);
            Rectangle rectSquare = new Rectangle(x, y, side, side);

            switch (shapeType)
            {
                case "Circle":
                    g.DrawEllipse(p, rectSquare);
                    break;
                case "Square":
                    g.DrawRectangle(p, rectSquare);
                    break;
                case "Ellipse":
                    g.DrawEllipse(p, rect);
                    break;
                case "Pie":
                    g.DrawPie(p, rect,0 ,45);
                    break;
                case "Filled Circle":
                    g.FillEllipse(b, rectSquare);
                    break;
                case "Filled Square":
                    g.FillRectangle(b, rectSquare);
                    break;
                case "Filled Ellipse":
                    g.FillEllipse(b, rect);
                    break;
                case "Filled Pie":
                    g.FillPie(b, rect, 0, 45);
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D; // Thư viện cần thiết cho DashStyle, LineCap...
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Cài đặt tiêu đề Form
            this.Text = "Pen Demo";

            // Gọi hàm khởi tạo dữ liệu cho các ComboBox khi form chạy
            LoadData();

            // Đăng ký sự kiện SelectedIndexChanged cho tất cả ComboBox
            // Để mỗi khi chọn lại, Form sẽ vẽ lại (Invalidate)
            dashStyle.SelectedIndexChanged += new EventHandler(Redraw_Event);
            Width.SelectedIndexChanged += new EventHandler(Redraw_Event);
            lineJoin.SelectedIndexChanged += new EventHandler(Redraw_Event);
            endCap.SelectedIndexChanged += new EventHandler(Redraw_Event);
            startCap.SelectedIndexChanged += new EventHandler(Redraw_Event);
            dashCap.SelectedIndexChanged += new EventHandler(Redraw_Event);
        }

        // Hàm nạp dữ liệu vào ComboBox
        private void LoadData()
        {
            // Dash Style
            foreach (DashStyle style in Enum.GetValues(typeof(DashStyle)))
            {
                dashStyle.Items.Add(style);
            }
            dashStyle.SelectedIndex = 0; 

            // Width 
            for (int i = 1; i <= 20; i++)
            {
                Width.Items.Add(i);
            }
            Width.SelectedItem = 8;

            // Line Join
            foreach (LineJoin join in Enum.GetValues(typeof(LineJoin)))
            {
                lineJoin.Items.Add(join);
            }
            lineJoin.SelectedItem = LineJoin.Round;

            // Dash Cap 
            foreach (DashCap dCap in Enum.GetValues(typeof(DashCap)))
            {
                dashCap.Items.Add(dCap);
            }
            dashCap.SelectedItem = DashCap.Triangle;

            // Start Cap 
            foreach (LineCap sCap in Enum.GetValues(typeof(LineCap)))
            {
                startCap.Items.Add(sCap);
            }
            startCap.SelectedItem = LineCap.ArrowAnchor;

            // End Cap
            foreach (LineCap eCap in Enum.GetValues(typeof(LineCap)))
            {
                endCap.Items.Add(eCap);
            }
            endCap.SelectedItem = LineCap.DiamondAnchor;
        }

        private void Redraw_Event(object sender, EventArgs e)
        {
            this.Invalidate(); 
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            try
            {
                float width = float.Parse(Width.SelectedItem.ToString());

                using (Pen p = new Pen(Color.Red, width))
                {
                    p.DashStyle = (DashStyle)dashStyle.SelectedItem;
                    p.LineJoin = (LineJoin)lineJoin.SelectedItem;
                    p.DashCap = (DashCap)dashCap.SelectedItem;
                    p.StartCap = (LineCap)startCap.SelectedItem;
                    p.EndCap = (LineCap)endCap.SelectedItem;


                    int xStart = panel1.Width + 50; 

                    Point p1 = new Point(xStart, 50);          // Điểm bắt đầu
                    Point p2 = new Point(xStart + 150, 350);   // Điểm gấp khúc (đáy)
                    Point p3 = new Point(xStart + 300, 200);   // Điểm kết thúc
                    g.DrawLines(p, new Point[] { p1, p2, p3 });
                }
            }
            catch (Exception)
            {
               
            }
        }
    }
}
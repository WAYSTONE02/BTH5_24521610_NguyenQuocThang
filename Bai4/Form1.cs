using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadFonts();
            LoadSizes();
        }

        void LoadFonts()
        {
            foreach (FontFamily f in FontFamily.Families)
                FontBox.Items.Add(f.Name);
            FontBox.SelectedIndex = 0;
        }

        void LoadSizes()
        {
            for (int i = 8; i <= 72; i++)
                sizeBox.Items.Add(i);
            sizeBox.SelectedIndex = 4;
        }

        void UpdateTextStyle()
        {
            FontStyle style = FontStyle.Regular;
            if (Bold.Checked) style |= FontStyle.Bold;
            if (Italic.Checked) style |= FontStyle.Italic;
            if (Underline.Checked) style |= FontStyle.Underline;

            float size = float.TryParse(sizeBox.Text, out float s) ? s : 12;
            string fontName = FontBox.Text;

            textBox1.Font = new Font(fontName, size, style);

            if (Allign_Left.Checked) textBox1.TextAlign = HorizontalAlignment.Left;
            if (Allign_Center.Checked) textBox1.TextAlign = HorizontalAlignment.Center;
            if (Allign_Right.Checked) textBox1.TextAlign = HorizontalAlignment.Right;
        }

        private void FontBox_SelectedIndexChanged(object sender, EventArgs e) => UpdateTextStyle();
        private void sizeBox_SelectedIndexChanged(object sender, EventArgs e) => UpdateTextStyle();
        private void Bold_CheckedChanged(object sender, EventArgs e) => UpdateTextStyle();
        private void Italic_CheckedChanged(object sender, EventArgs e) => UpdateTextStyle();
        private void Underline_CheckedChanged(object sender, EventArgs e) => UpdateTextStyle();
        private void Allign_Left_CheckedChanged(object sender, EventArgs e) => UpdateTextStyle();
        private void Allign_Center_CheckedChanged(object sender, EventArgs e) => UpdateTextStyle();
        private void Allign_Right_CheckedChanged(object sender, EventArgs e) => UpdateTextStyle();

        private void colorBox_Click_1(object sender, EventArgs e)
        {
            using (ColorDialog dlg = new ColorDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    textBox1.ForeColor = dlg.Color;
                    colorBox.BackColor = dlg.Color;   
                }
            }
        }
    }
}

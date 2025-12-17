namespace Bai4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.FontBox = new System.Windows.Forms.ComboBox();
            this.sizeBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Bold = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Italic = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Underline = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.Allign_Right = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.Allign_Center = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.Allign_Left = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.colorBox = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Font";
            // 
            // FontBox
            // 
            this.FontBox.FormattingEnabled = true;
            this.FontBox.Location = new System.Drawing.Point(128, 37);
            this.FontBox.Name = "FontBox";
            this.FontBox.Size = new System.Drawing.Size(224, 24);
            this.FontBox.TabIndex = 1;
            this.FontBox.SelectedIndexChanged += new System.EventHandler(this.FontBox_SelectedIndexChanged);
            // 
            // sizeBox
            // 
            this.sizeBox.FormattingEnabled = true;
            this.sizeBox.Location = new System.Drawing.Point(519, 38);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(81, 24);
            this.sizeBox.TabIndex = 3;
            this.sizeBox.SelectedIndexChanged += new System.EventHandler(this.sizeBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(452, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Size";
            // 
            // Bold
            // 
            this.Bold.AutoSize = true;
            this.Bold.Location = new System.Drawing.Point(44, 104);
            this.Bold.Name = "Bold";
            this.Bold.Size = new System.Drawing.Size(18, 17);
            this.Bold.TabIndex = 4;
            this.Bold.UseVisualStyleBackColor = true;
            this.Bold.CheckedChanged += new System.EventHandler(this.Bold_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(68, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(151, 87);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Italic
            // 
            this.Italic.AutoSize = true;
            this.Italic.Location = new System.Drawing.Point(127, 104);
            this.Italic.Name = "Italic";
            this.Italic.Size = new System.Drawing.Size(18, 17);
            this.Italic.TabIndex = 6;
            this.Italic.UseVisualStyleBackColor = true;
            this.Italic.CheckedChanged += new System.EventHandler(this.Italic_CheckedChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(233, 87);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // Underline
            // 
            this.Underline.AutoSize = true;
            this.Underline.Location = new System.Drawing.Point(209, 104);
            this.Underline.Name = "Underline";
            this.Underline.Size = new System.Drawing.Size(18, 17);
            this.Underline.TabIndex = 8;
            this.Underline.UseVisualStyleBackColor = true;
            this.Underline.CheckedChanged += new System.EventHandler(this.Underline_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(452, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Color";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(375, 190);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 97);
            this.textBox1.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Allign_Right);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Allign_Center);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Allign_Left);
            this.panel1.Location = new System.Drawing.Point(44, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 162);
            this.panel1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(74, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "Right";
            // 
            // Allign_Right
            // 
            this.Allign_Right.AutoSize = true;
            this.Allign_Right.Location = new System.Drawing.Point(42, 122);
            this.Allign_Right.Name = "Allign_Right";
            this.Allign_Right.Size = new System.Drawing.Size(17, 16);
            this.Allign_Right.TabIndex = 16;
            this.Allign_Right.TabStop = true;
            this.Allign_Right.UseVisualStyleBackColor = true;
            this.Allign_Right.CheckedChanged += new System.EventHandler(this.Allign_Right_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Center";
            // 
            // Allign_Center
            // 
            this.Allign_Center.AutoSize = true;
            this.Allign_Center.Location = new System.Drawing.Point(42, 80);
            this.Allign_Center.Name = "Allign_Center";
            this.Allign_Center.Size = new System.Drawing.Size(17, 16);
            this.Allign_Center.TabIndex = 14;
            this.Allign_Center.TabStop = true;
            this.Allign_Center.UseVisualStyleBackColor = true;
            this.Allign_Center.CheckedChanged += new System.EventHandler(this.Allign_Center_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Left";
            // 
            // Allign_Left
            // 
            this.Allign_Left.AutoSize = true;
            this.Allign_Left.Location = new System.Drawing.Point(42, 35);
            this.Allign_Left.Name = "Allign_Left";
            this.Allign_Left.Size = new System.Drawing.Size(17, 16);
            this.Allign_Left.TabIndex = 0;
            this.Allign_Left.TabStop = true;
            this.Allign_Left.UseVisualStyleBackColor = true;
            this.Allign_Left.CheckedChanged += new System.EventHandler(this.Allign_Left_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Allign Text";
            // 
            // colorBox
            // 
            this.colorBox.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.colorBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.colorBox.ForeColor = System.Drawing.Color.Black;
            this.colorBox.Location = new System.Drawing.Point(522, 90);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(57, 31);
            this.colorBox.TabIndex = 13;
            this.colorBox.UseVisualStyleBackColor = false;
            this.colorBox.Click += new System.EventHandler(this.colorBox_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 370);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Underline);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Italic);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Bold);
            this.Controls.Add(this.sizeBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FontBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FontBox;
        private System.Windows.Forms.ComboBox sizeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox Bold;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox Italic;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox Underline;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton Allign_Right;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton Allign_Center;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton Allign_Left;
        private System.Windows.Forms.Button colorBox;
    }
}


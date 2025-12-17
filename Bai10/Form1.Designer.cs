namespace Bai10
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.endCap = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.startCap = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dashCap = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lineJoin = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Width = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dashStyle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.endCap);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.startCap);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dashCap);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lineJoin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Width);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dashStyle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 450);
            this.panel1.TabIndex = 0;
            // 
            // endCap
            // 
            this.endCap.FormattingEnabled = true;
            this.endCap.Location = new System.Drawing.Point(107, 383);
            this.endCap.Name = "endCap";
            this.endCap.Size = new System.Drawing.Size(114, 24);
            this.endCap.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "End Cap :";
            // 
            // startCap
            // 
            this.startCap.FormattingEnabled = true;
            this.startCap.Location = new System.Drawing.Point(107, 313);
            this.startCap.Name = "startCap";
            this.startCap.Size = new System.Drawing.Size(114, 24);
            this.startCap.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Start Cap :";
            // 
            // dashCap
            // 
            this.dashCap.FormattingEnabled = true;
            this.dashCap.Location = new System.Drawing.Point(107, 245);
            this.dashCap.Name = "dashCap";
            this.dashCap.Size = new System.Drawing.Size(114, 24);
            this.dashCap.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Dash Cap :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lineJoin
            // 
            this.lineJoin.FormattingEnabled = true;
            this.lineJoin.Location = new System.Drawing.Point(107, 178);
            this.lineJoin.Name = "lineJoin";
            this.lineJoin.Size = new System.Drawing.Size(114, 24);
            this.lineJoin.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Line Join :";
            // 
            // Width
            // 
            this.Width.FormattingEnabled = true;
            this.Width.Location = new System.Drawing.Point(107, 110);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(114, 24);
            this.Width.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Width :";
            // 
            // dashStyle
            // 
            this.dashStyle.FormattingEnabled = true;
            this.dashStyle.Location = new System.Drawing.Point(107, 37);
            this.dashStyle.Name = "dashStyle";
            this.dashStyle.Size = new System.Drawing.Size(114, 24);
            this.dashStyle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dash Style : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox dashStyle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox endCap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox startCap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox dashCap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox lineJoin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Width;
        private System.Windows.Forms.Label label2;
    }
}


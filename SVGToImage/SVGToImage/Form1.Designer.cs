
namespace SVGToImage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_LinkImage = new System.Windows.Forms.Button();
            this.lb_HeightConverter = new System.Windows.Forms.Label();
            this.lb_WidthConverter = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.textBox_GetHeight = new System.Windows.Forms.TextBox();
            this.textBox_GetWidth = new System.Windows.Forms.TextBox();
            this.comboBox_SaveAs = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.caption = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_ProductOf = new System.Windows.Forms.Label();
            this.label_CopyRight = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_LinkImage);
            this.panel1.Controls.Add(this.lb_HeightConverter);
            this.panel1.Controls.Add(this.lb_WidthConverter);
            this.panel1.Controls.Add(this.btnConvert);
            this.panel1.Controls.Add(this.textBox_GetHeight);
            this.panel1.Controls.Add(this.textBox_GetWidth);
            this.panel1.Controls.Add(this.comboBox_SaveAs);
            this.panel1.Location = new System.Drawing.Point(12, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 244);
            this.panel1.TabIndex = 0;
            // 
            // btn_LinkImage
            // 
            this.btn_LinkImage.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LinkImage.Location = new System.Drawing.Point(21, 95);
            this.btn_LinkImage.Name = "btn_LinkImage";
            this.btn_LinkImage.Size = new System.Drawing.Size(310, 35);
            this.btn_LinkImage.TabIndex = 8;
            this.btn_LinkImage.Text = "Open Image";
            this.btn_LinkImage.UseVisualStyleBackColor = true;
            this.btn_LinkImage.Click += new System.EventHandler(this.btn_LinkImage_Click);
            // 
            // lb_HeightConverter
            // 
            this.lb_HeightConverter.AutoSize = true;
            this.lb_HeightConverter.Location = new System.Drawing.Point(633, 88);
            this.lb_HeightConverter.Name = "lb_HeightConverter";
            this.lb_HeightConverter.Size = new System.Drawing.Size(53, 17);
            this.lb_HeightConverter.TabIndex = 6;
            this.lb_HeightConverter.Text = "Height:";
            // 
            // lb_WidthConverter
            // 
            this.lb_WidthConverter.AutoSize = true;
            this.lb_WidthConverter.Location = new System.Drawing.Point(480, 88);
            this.lb_WidthConverter.Name = "lb_WidthConverter";
            this.lb_WidthConverter.Size = new System.Drawing.Size(48, 17);
            this.lb_WidthConverter.TabIndex = 5;
            this.lb_WidthConverter.Text = "Width:";
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Sitka Heading", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(505, 149);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(100, 42);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // textBox_GetHeight
            // 
            this.textBox_GetHeight.Location = new System.Drawing.Point(609, 108);
            this.textBox_GetHeight.Name = "textBox_GetHeight";
            this.textBox_GetHeight.Size = new System.Drawing.Size(100, 22);
            this.textBox_GetHeight.TabIndex = 3;
            // 
            // textBox_GetWidth
            // 
            this.textBox_GetWidth.Location = new System.Drawing.Point(454, 108);
            this.textBox_GetWidth.Name = "textBox_GetWidth";
            this.textBox_GetWidth.Size = new System.Drawing.Size(100, 22);
            this.textBox_GetWidth.TabIndex = 2;
            // 
            // comboBox_SaveAs
            // 
            this.comboBox_SaveAs.FormattingEnabled = true;
            this.comboBox_SaveAs.Items.AddRange(new object[] {
            "JPEG",
            "PNG",
            "GIF",
            "TIFF",
            "BMP",
            "ICON"});
            this.comboBox_SaveAs.Location = new System.Drawing.Point(454, 46);
            this.comboBox_SaveAs.Name = "comboBox_SaveAs";
            this.comboBox_SaveAs.Size = new System.Drawing.Size(255, 24);
            this.comboBox_SaveAs.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.caption);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 62);
            this.panel2.TabIndex = 1;
            // 
            // caption
            // 
            this.caption.AutoSize = true;
            this.caption.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caption.ForeColor = System.Drawing.SystemColors.Info;
            this.caption.Location = new System.Drawing.Point(241, 11);
            this.caption.Name = "caption";
            this.caption.Size = new System.Drawing.Size(296, 41);
            this.caption.TabIndex = 0;
            this.caption.Text = "Image Converter";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Controls.Add(this.label_ProductOf);
            this.panel3.Controls.Add(this.label_CopyRight);
            this.panel3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(12, 400);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 38);
            this.panel3.TabIndex = 2;
            // 
            // label_ProductOf
            // 
            this.label_ProductOf.AutoSize = true;
            this.label_ProductOf.Font = new System.Drawing.Font("Ubuntu Light", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ProductOf.Location = new System.Drawing.Point(692, 8);
            this.label_ProductOf.Name = "label_ProductOf";
            this.label_ProductOf.Size = new System.Drawing.Size(72, 23);
            this.label_ProductOf.TabIndex = 1;
            this.label_ProductOf.Text = "ThaiDM";
            // 
            // label_CopyRight
            // 
            this.label_CopyRight.AutoSize = true;
            this.label_CopyRight.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CopyRight.Location = new System.Drawing.Point(17, 10);
            this.label_CopyRight.Name = "label_CopyRight";
            this.label_CopyRight.Size = new System.Drawing.Size(149, 22);
            this.label_CopyRight.TabIndex = 0;
            this.label_CopyRight.Text = " © HUST-TECH";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 452);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Converter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_HeightConverter;
        private System.Windows.Forms.Label lb_WidthConverter;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox textBox_GetHeight;
        private System.Windows.Forms.TextBox textBox_GetWidth;
        private System.Windows.Forms.ComboBox comboBox_SaveAs;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label caption;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_ProductOf;
        private System.Windows.Forms.Label label_CopyRight;
        private System.Windows.Forms.Button btn_LinkImage;
    }
}


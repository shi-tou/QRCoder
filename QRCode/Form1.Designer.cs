namespace QRCode
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.btnCreateQrCode = new AlSkin.AlControl.AlButton.AlButton();
            this.textBox_Comtent = new System.Windows.Forms.TextBox();
            this.btnSaveQrCode = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_SelectFile = new System.Windows.Forms.Label();
            this.textBox_Logo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox_QrCode = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_Size = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_ForegroundColor = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_BackgroundColor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_QrCode)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Logo.Location = new System.Drawing.Point(36, 302);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(200, 200);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_Logo.TabIndex = 4;
            this.pictureBox_Logo.TabStop = false;
            // 
            // btnCreateQrCode
            // 
            this.btnCreateQrCode.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateQrCode.BackImg = ((System.Drawing.Bitmap)(resources.GetObject("btnCreateQrCode.BackImg")));
            this.btnCreateQrCode.BacklightLTRB = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnCreateQrCode.Location = new System.Drawing.Point(280, 362);
            this.btnCreateQrCode.Name = "btnCreateQrCode";
            this.btnCreateQrCode.Size = new System.Drawing.Size(75, 26);
            this.btnCreateQrCode.TabIndex = 5;
            this.btnCreateQrCode.Text = "生成";
            this.btnCreateQrCode.UseVisualStyleBackColor = true;
            this.btnCreateQrCode.Click += new System.EventHandler(this.btnCreateQrCode_Click);
            // 
            // textBox_Comtent
            // 
            this.textBox_Comtent.Location = new System.Drawing.Point(93, 22);
            this.textBox_Comtent.Multiline = true;
            this.textBox_Comtent.Name = "textBox_Comtent";
            this.textBox_Comtent.Size = new System.Drawing.Size(386, 61);
            this.textBox_Comtent.TabIndex = 6;
            // 
            // btnSaveQrCode
            // 
            this.btnSaveQrCode.Location = new System.Drawing.Point(280, 407);
            this.btnSaveQrCode.Name = "btnSaveQrCode";
            this.btnSaveQrCode.Size = new System.Drawing.Size(75, 29);
            this.btnSaveQrCode.TabIndex = 7;
            this.btnSaveQrCode.Text = "保存二维码";
            this.btnSaveQrCode.UseVisualStyleBackColor = true;
            this.btnSaveQrCode.Click += new System.EventHandler(this.btnSaveQrCode_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label_SelectFile);
            this.groupBox1.Controls.Add(this.textBox_Logo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_Comtent);
            this.groupBox1.Location = new System.Drawing.Point(36, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 146);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作";
            // 
            // label_SelectFile
            // 
            this.label_SelectFile.AutoSize = true;
            this.label_SelectFile.BackColor = System.Drawing.Color.Transparent;
            this.label_SelectFile.ForeColor = System.Drawing.Color.Blue;
            this.label_SelectFile.Location = new System.Drawing.Point(486, 105);
            this.label_SelectFile.Name = "label_SelectFile";
            this.label_SelectFile.Size = new System.Drawing.Size(53, 12);
            this.label_SelectFile.TabIndex = 9;
            this.label_SelectFile.Text = "选择文件";
            this.label_SelectFile.Click += new System.EventHandler(this.label_SelectFile_Click);
            // 
            // textBox_Logo
            // 
            this.textBox_Logo.Location = new System.Drawing.Point(93, 101);
            this.textBox_Logo.Name = "textBox_Logo";
            this.textBox_Logo.Size = new System.Drawing.Size(386, 21);
            this.textBox_Logo.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "嵌入Logo：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "生成内容：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(98, 513);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Logo文件";
            // 
            // pictureBox_QrCode
            // 
            this.pictureBox_QrCode.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_QrCode.Location = new System.Drawing.Point(403, 302);
            this.pictureBox_QrCode.Name = "pictureBox_QrCode";
            this.pictureBox_QrCode.Size = new System.Drawing.Size(200, 200);
            this.pictureBox_QrCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_QrCode.TabIndex = 4;
            this.pictureBox_QrCode.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(455, 514);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "生成的二维码";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label_BackgroundColor);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label_ForegroundColor);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label_Size);
            this.groupBox2.Controls.Add(this.trackBar1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(36, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 83);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "生成设置";
            // 
            // label_Size
            // 
            this.label_Size.AutoSize = true;
            this.label_Size.Location = new System.Drawing.Point(92, 27);
            this.label_Size.Name = "label_Size";
            this.label_Size.Size = new System.Drawing.Size(35, 12);
            this.label_Size.TabIndex = 11;
            this.label_Size.Text = "280px";
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.White;
            this.trackBar1.Location = new System.Drawing.Point(133, 27);
            this.trackBar1.Maximum = 800;
            this.trackBar1.Minimum = 50;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(125, 45);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 280;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "尺寸大小：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "前景色：";
            // 
            // label_ForegroundColor
            // 
            this.label_ForegroundColor.AutoSize = true;
            this.label_ForegroundColor.ForeColor = System.Drawing.Color.Blue;
            this.label_ForegroundColor.Location = new System.Drawing.Point(351, 27);
            this.label_ForegroundColor.Name = "label_ForegroundColor";
            this.label_ForegroundColor.Size = new System.Drawing.Size(47, 12);
            this.label_ForegroundColor.TabIndex = 13;
            this.label_ForegroundColor.Text = "#000000";
            this.label_ForegroundColor.Click += new System.EventHandler(this.label_ForegroundColor_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(433, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "背景色：";
            // 
            // label_BackgroundColor
            // 
            this.label_BackgroundColor.AutoSize = true;
            this.label_BackgroundColor.ForeColor = System.Drawing.Color.Blue;
            this.label_BackgroundColor.Location = new System.Drawing.Point(492, 27);
            this.label_BackgroundColor.Name = "label_BackgroundColor";
            this.label_BackgroundColor.Size = new System.Drawing.Size(47, 12);
            this.label_BackgroundColor.TabIndex = 13;
            this.label_BackgroundColor.Text = "#000000";
            this.label_BackgroundColor.Click += new System.EventHandler(this.label_BackgroundColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 600);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSaveQrCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox_QrCode);
            this.Controls.Add(this.btnCreateQrCode);
            this.Controls.Add(this.pictureBox_Logo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "二维码助手";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.pictureBox_Logo, 0);
            this.Controls.SetChildIndex(this.btnCreateQrCode, 0);
            this.Controls.SetChildIndex(this.pictureBox_QrCode, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.btnSaveQrCode, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_QrCode)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private AlSkin.AlControl.AlButton.AlButton btnCreateQrCode;
        private System.Windows.Forms.TextBox textBox_Comtent;
        private System.Windows.Forms.Button btnSaveQrCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Logo;
        private System.Windows.Forms.Label label_SelectFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox_QrCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label_Size;
        private System.Windows.Forms.Label label_ForegroundColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_BackgroundColor;
        private System.Windows.Forms.Label label8;
    }
}


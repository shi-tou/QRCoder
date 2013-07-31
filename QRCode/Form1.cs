using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ThoughtWorks.QRCode.Codec;

namespace QRCode
{
    /// <summary>
    /// 时间：2013-08-02
    /// 作者：杨良斌
    /// 网址：http://www.github.com/yksoft
    /// 主窗口
    /// </summary>
    public partial class Form1 : BaseForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBox1.SelectedIndex = 1;
            this.comboBox2.SelectedIndex = 1;
            this.textBox2.Text = "5";
            this.textBox3.Text = "2";
        }

        private void alButton1_Click(object sender, EventArgs e)
        {
            if (this.textBox2.Text == "")
            {
                MessageBox.Show("请输入Version！");
                return;
            }
            if(this.textBox3.Text=="")
            {
                MessageBox.Show("请输入Scale！");
                return;
            }
            string CT = this.comboBox1.SelectedText;
            string CC = this.comboBox2.SelectedText;
            CodeType ct = CodeType.Byte;
            Correct cc = Correct.Q;
            switch (CT)
            {
                case "Byte":
                    ct = CodeType.Byte;
                    break;
                case "AlphaNumeric":
                    ct = CodeType.AlphaNumeric;
                    break;
                case "Numeric":
                    ct = CodeType.Numeric;
                    break;
            }
            switch (CC)
            {
                case "L":
                    cc = Correct.L;
                    break;
                case "M":
                    cc = Correct.M;
                    break;
                case "Q":
                    cc = Correct.Q;
                    break;
                case "H":
                    cc = Correct.H;
                    break;
            }
            //Version比例：5=>75*75 |6=>247*247
            QRCodeHelper qr = new QRCodeHelper();
            EncoderAttribute attr = new EncoderAttribute(ct, cc, Convert.ToInt32(this.textBox2.Text), Convert.ToInt32(this.textBox2.Text));
            string path = qr.CreateNewCode(this.textBox1.Text, "D:\\二维码\\", attr);
            this.pictureBox1.ImageLocation = path;
        }
    }
}

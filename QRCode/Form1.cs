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
        }
        /// <summary>
        /// 生成二维码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateQrCode_Click(object sender, EventArgs e)
        {
            string content = this.textBox_Comtent.Text.Trim();
            if (content == "")
            {
                MessageBox.Show("请输入生成的内容！");
                return;
            }
            if (QrCodeSetting.Instance == null)
            {
                MessageBox.Show("未配置二维码生成参数！");
                return;
            }
            QRCodeHelper helper = new QRCodeHelper();
            Bitmap bitMap = helper.CreateCode(new QrCodeParam
            {
                Content = this.textBox_Comtent.Text,
                QRCodeEncodeMode = QrCodeSetting.Instance.QRCodeEncodeMode,
                QRCodeErrorCorrect = QrCodeSetting.Instance.QRCodeErrorCorrect,
                QRCodeVersion = QrCodeSetting.Instance.QRCodeVersion,
                QRCodeScale = QrCodeSetting.Instance.QRCodeScale,
                QRCodeForegroundColor = ColorTranslator.FromHtml(this.label_ForegroundColor.Text),
                QRCodeBackgroundColor = ColorTranslator.FromHtml(this.label_BackgroundColor.Text),
            });
            this.pictureBox_QrCode.Image = bitMap;
        }
        /// <summary>
        /// 选择logo文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_SelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "图像文件(JPeg, Gif, Bmp, etc.)|*.jpg;*.jpeg;*.gif;*.bmp;*.tif; *.tiff; *.png| JPeg 图像文件(*.jpg;*.jpeg)"
                + "|*.jpg;*.jpeg |GIF 图像文件(*.gif)|*.gif |BMP图像文件(*.bmp)|*.bmp|Tiff图像文件(*.tif;*.tiff)|*.tif;*.tiff|Png图像文件(*.png)"
                + "| *.png |所有文件(*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                this.textBox_Logo.Text = fileDialog.FileName;
            }
        }
        /// <summary>
        /// 保存二维码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveQrCode_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            //设置文件类型  
            fileDialog.Filter = "图像文件(JPeg, Gif, Bmp, etc.)|*.jpg;*.jpeg;*.gif;*.bmp;*.tif; *.tiff; *.png| JPeg 图像文件(*.jpg;*.jpeg)"
                + "|*.jpg;*.jpeg |GIF 图像文件(*.gif)|*.gif |BMP图像文件(*.bmp)|*.bmp|Tiff图像文件(*.tif;*.tiff)|*.tif;*.tiff|Png图像文件(*.png)"
                + "| *.png |所有文件(*.*)|*.*";
            //设置文件名称：
            fileDialog.FileName = Guid.NewGuid().ToString() + ".jpg";
            //保存对话框是否记忆上次打开的目录  
            fileDialog.RestoreDirectory = true;
            //点了保存按钮进入  
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                //获得文件路径  
                string filePath = fileDialog.FileName.ToString();
                this.pictureBox_QrCode.Image.Save(filePath);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.label_Size.Text = this.trackBar1.Value + "px";
        }
        /// <summary>
        /// 选择前景色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_ForegroundColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = true;
            colorDialog.ShowHelp = false;
            colorDialog.Color = ColorTranslator.FromHtml(this.label_ForegroundColor.Text);
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.label_ForegroundColor.Text = ColorTranslator.ToHtml(colorDialog.Color);
            }
        }
        /// <summary>
        /// 选择背景色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_BackgroundColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = true;
            colorDialog.ShowHelp = false;
            colorDialog.Color = ColorTranslator.FromHtml(this.label_BackgroundColor.Text);
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.label_BackgroundColor.Text = ColorTranslator.ToHtml(colorDialog.Color);
            }
        }
    }
}

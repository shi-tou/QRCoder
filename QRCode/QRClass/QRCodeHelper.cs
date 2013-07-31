using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using ThoughtWorks.QRCode.Codec;
using System.IO;
namespace QRCode
{
    /// <summary>
    /// 时间：2013-08-02
    /// 作者：杨良斌
    /// 网址：http://www.github.com/yksoft
    /// 二维码Helper
    /// </summary>
    public class QRCodeHelper
    {
        private string ExceptionString = string.Empty;
        /// <summary>
        /// 处理位图
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        public Bitmap BitmapTo2Bpp(Bitmap img)
        {
            int width = img.Width;
            int height = img.Height;
            //新建位图
            Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format1bppIndexed);
            //将 System.Drawing.Bitmap 锁定到系统内存中。
            BitmapData bitmapdata = bitmap.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format1bppIndexed);
            //开始复制(获取像素点颜色)
            for (int i = 0; i < height; i++)
            {
                byte[] source = new byte[(width + 7) / 8];
                for (int j = 0; j < width; j++)
                {
                    
                    if (img.GetPixel(j, i).GetBrightness() >= 0.5)
                    {
                        source[j / 8] = (byte)(source[j / 8] | ((byte)(((int)0x80) >> (j % 8))));
                    }
                }
                //将一维的托管[8]位无符号整数数组中的数据复制到非托管内存指针。
                Marshal.Copy(source, 0, (IntPtr)(((int)bitmapdata.Scan0) + (bitmapdata.Stride * i)), source.Length);
            }
            //从系统内存解锁Bitmap。
            bitmap.UnlockBits(bitmapdata);
            return bitmap;
        }
        /// <summary>
        /// 创建二维码
        /// </summary>
        /// <param name="str"></param>
        /// <param name="CT"></param>
        /// <param name="CC"></param>
        /// <param name="VersionNum"></param>
        /// <param name="CreateSize"></param>
        /// <returns></returns>
        public Bitmap CreateCode(string str, CodeType CT, Correct CC, int VersionNum, int CreateSize)
        {
            try
            {
                QRCodeEncoder encoder = new QRCodeEncoder();
                switch (CT)
                {
                    case CodeType.Byte://对英文字母作加密
                        encoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
                        break;
                    case CodeType.AlphaNumeric://对大写字母作加密
                        encoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.ALPHA_NUMERIC;
                        break;
                    case CodeType.Numeric://对数字作加密
                        encoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.NUMERIC;
                        break;
                    default://默认为大写字母作加密
                        encoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.ALPHA_NUMERIC;
                        break;
                }
                switch (CC)
                {
                    case Correct.L://7%的字码可被修正
                        encoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L;
                        break;
                    case Correct.M://15%的字码可被修正
                        encoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;
                        break;
                    case Correct.Q://25%的字码可被修正
                        encoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.Q;
                        break;
                    case Correct.H:Q://30%的字码可被修正
                        encoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.H;
                        break;
                    default://默认为30%
                        encoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.H;
                        break;
                }
                //设置二维码所能包含的字符信息量(http://www.cnblogs.com/wallis0922/archive/2013/01/22/2870979.html)
                encoder.QRCodeVersion = VersionNum;
                //设置二维码比例
                encoder.QRCodeScale = CreateSize;
                //数字、文字、字母作加密成QRCode条码
                return encoder.Encode(str);
            }
            catch (Exception exception)
            {
                this.ExceptionString = exception.Message;
                return null;
            }
        }
        /// <summary>
        /// 生成二维码
        /// </summary>
        /// <param name="str"></param>
        /// <param name="SaveFile"></param>
        public string CreateNewCode(string str, string savePath, EncoderAttribute attr)
        {
            string path = "";
            try
            {
                Bitmap bitmap = this.BitmapTo2Bpp(CreateCode(str, attr.CodeType, attr.Correct, attr.QRVersion, attr.QRScale));
               path= SaveBitmap(bitmap, savePath);
            }
            catch (Exception exception)
            {
                this.ExceptionString = exception.Message;
            }
            return path;
        }
        /// <summary>
        /// 保存位图
        /// </summary>
        /// <param name="bitmap"></param>
        /// <param name="saveFile"></param>
        public string SaveBitmap(Bitmap bitmap, string savePath)
        {
            string resFile = "";
            try
            {
                if (!Directory.Exists(savePath))
                {
                    Directory.CreateDirectory(savePath);
                }
                string fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + ".bmp";
                resFile = savePath + fileName;
                bitmap.Save(savePath + fileName, ImageFormat.Bmp);
                bitmap.Dispose();
            }
            catch (Exception exception)
            {
                this.ExceptionString = exception.Message;
            }
            return resFile;
        }
    }
    /// <summary>
    /// 加密方式
    /// </summary>
    public enum CodeType
    {
        Byte,
        AlphaNumeric,
        Numeric
    }
    /// <summary>
    /// 修正方式
    /// </summary>
    public enum Correct
    {
        L,
        M,
        Q,
        H
    }
    /// <summary>
    /// 属性
    /// </summary>
    public class EncoderAttribute
    {
        public EncoderAttribute(CodeType codeType, Correct correct, int version, int scale)
        {
            CodeType = codeType;
            Correct = correct;
            QRVersion = version;
            QRScale = scale;
        }
        public CodeType CodeType;
        public Correct Correct;
        public int QRVersion = 5;
        public int QRScale = 2;
    }
}


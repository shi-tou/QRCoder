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
        /// <summary>
        /// 创建二维码
        /// </summary>
        /// <param name="str">内容</param>
        /// <param name="encodeMode">编码模式</param>
        /// <param name="errorCorrect">容错</param>
        /// <param name="versionNum">版本</param>
        /// <param name="scale">比例</param>
        /// <returns></returns>
        public Bitmap CreateCode(QrCodeParam param)
        {
            try
            {
                QRCodeEncoder encoder = new QRCodeEncoder();
                encoder.QRCodeEncodeMode = param.QRCodeEncodeMode;
                encoder.QRCodeErrorCorrect = param.QRCodeErrorCorrect;
                //设置二维码所能包含的字符信息量(http://www.cnblogs.com/wallis0922/archive/2013/01/22/2870979.html)
                encoder.QRCodeVersion = param.QRCodeVersion;
                //设置编码测量度最大40
                encoder.QRCodeScale = param.QRCodeScale;
                //前景色
                encoder.QRCodeForegroundColor = param.QRCodeForegroundColor;
                //背景色
                encoder.QRCodeBackgroundColor = param.QRCodeBackgroundColor;
                //数字、文字、字母作加密成QRCode条码
                return encoder.Encode(param.Content);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

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
            }
            return resFile;
        }
    }
}


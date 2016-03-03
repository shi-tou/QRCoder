using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using ThoughtWorks.QRCode.Codec;

namespace QRCode
{

    /// <summary>
	/// 配置信息类
	/// </summary>
    public class QrCodeParam
    {
        /// <summary>
        /// 生成内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 编码模式
        /// </summary>
        public QRCodeEncoder.ENCODE_MODE QRCodeEncodeMode { get; set; }
        /// <summary>
        /// 错误纠正
        /// </summary>
        public QRCodeEncoder.ERROR_CORRECTION QRCodeErrorCorrect { get; set; }
        /// <summary>
        /// 二维码所能包含的字符信息量.范围值是0-40,
        /// 0的含义是表示压缩的信息量将会根据实际传入值确定，只有最高上限的控制,而且图片的大小将会根据信息量自动缩放。
        /// 1-40的范围值，则有固定的信息量上限，而且图片的大小会固定在一个大小上，不会根据信息量的多少而变化。）
        /// </summary>
        public int QRCodeVersion { get; set; }
        /// <summary>
        /// 比例
        /// </summary>
        public int QRCodeScale { get; set; }
        /// <summary>
        /// 前景色
        /// </summary>
        public Color QRCodeForegroundColor { get; set; }
        /// <summary>
        /// 背景色
        /// </summary>
        public Color QRCodeBackgroundColor { get; set; }

    }
}



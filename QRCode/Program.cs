using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QRCode
{
    static class Program
    {
        /// <summary>
        /// 时间：2013-08-02
        /// 作者：杨良斌
        /// 网址：http://www.github.com/yksoft
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

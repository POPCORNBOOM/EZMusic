using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EZMusic
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


        }

        public class AsongItem
        {
            /// <summary>
            /// 
            /// </summary>
            public string name { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string artist { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string url { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string cover { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string lrc { get; set; }
        }

        public class Root
        {
            /// <summary>
            /// 
            /// </summary>
            public List<AsongItem> asong { get; set; }
        }
    }
}

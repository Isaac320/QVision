using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace QVision.DragControl
{
    public partial class DragControl : Component
    {
        private Control selectControl;
        [Description("选中控件"), Category(""), Browsable(true)]
        public Control SelectControl
        {
            get { return selectControl; }
            set
            {
                selectControl = value;
                if (selectControl != null)
                {
                    selectControl.MouseDown += new MouseEventHandler(Form_MouseDown);
                }
            }
        }

        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public DragControl()
        {
            InitializeComponent();
        }

        public DragControl(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        //获取鼠标按下时的位置
        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(selectControl.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
    }
}

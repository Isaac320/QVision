using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QVision.Frm;
using QVision.Report;
using System.Threading;

namespace QVision
{
    public partial class MainFrm : Form
    {
       
        public MainFrm()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (this.ActiveMdiChild == MyForms.videoFrm)
                {
                    Cursor.Current = Cursors.Arrow;
                    return;
                }
                MyForms.videoFrm.MdiParent = this;
                MyForms.videoFrm.Dock = DockStyle.Fill;
                MyForms.videoFrm.Show();
                MyForms.videoFrm.Activate();
                Cursor.Current = Cursors.Arrow;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (this.ActiveMdiChild == MyForms.recipeFrm)
                {
                    Cursor.Current = Cursors.Arrow;
                    return;
                }
                MyForms.recipeFrm.MdiParent = this;
                MyForms.recipeFrm.Dock = DockStyle.Fill;
                MyForms.recipeFrm.Show();
                MyForms.recipeFrm.Activate();
                Cursor.Current = Cursors.Arrow;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            SplashFrm.num = 30;
            MyForms.videoFrm = new VideoFrm();
            MyForms.recipeFrm = new RecipeFrm();
            MyForms.settingFrm = new SettingFrm();
            MyForms.reportFrm = new ReportFrm();
            SplashFrm.num = 60;
            Thread.Sleep(1200);
            SplashFrm.num = 100;

            this.WindowState = FormWindowState.Maximized;
            this.Visible = true;
            MyForms.videoFrm.MdiParent = this;
            MyForms.videoFrm.Dock = DockStyle.Fill;
            MyForms.videoFrm.Show();
            MyForms.videoFrm.Activate();

            ImgProcess.Project.getInstance().Init();



        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (this.ActiveMdiChild == MyForms.settingFrm)
                {
                    Cursor.Current = Cursors.Arrow;
                    return;
                }
                MyForms.settingFrm.MdiParent = this;
                MyForms.settingFrm.Dock = DockStyle.Fill;
                MyForms.settingFrm.Show();
                MyForms.settingFrm.Activate();
                Cursor.Current = Cursors.Arrow;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Frm.AboutFrm aboutFrm = new Frm.AboutFrm())
            {
                aboutFrm.ShowDialog();
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (MessageBox.Show("退出本系统?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (this.ActiveMdiChild == MyForms.reportFrm)
                {
                    Cursor.Current = Cursors.Arrow;
                    return;
                }
                MyForms.reportFrm.MdiParent = this;
                MyForms.reportFrm.Dock = DockStyle.Fill;
                MyForms.reportFrm.Show();
                MyForms.reportFrm.Activate();
                Cursor.Current = Cursors.Arrow;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}

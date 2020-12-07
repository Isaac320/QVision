using QVision.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace QVision.Frm
{
    public partial class MainFrm2 : Form
    {
        public MainFrm2()
        {
            InitializeComponent();
        }

        private void moveSidePanle(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            moveSidePanle(btn_home);
            //UC_Home uch = new UC_Home();
            //AddControlToPlane(uch);
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (this.ActiveMdiChild == Frames.videoFrm)
                {
                    Cursor.Current = Cursors.Arrow;
                    return;
                }
                Frames.videoFrm.MdiParent = this;
                Frames.videoFrm.Dock = DockStyle.Fill;
                Frames.videoFrm.Show();
                Frames.videoFrm.Activate();
                Cursor.Current = Cursors.Arrow;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void btn_recipe_Click(object sender, EventArgs e)
        {
            moveSidePanle(btn_recipe);
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (this.ActiveMdiChild == Frames.recipeFrm)
                {
                    Cursor.Current = Cursors.Arrow;
                    return;
                }
                Frames.recipeFrm.MdiParent = this;
                Frames.recipeFrm.Dock = DockStyle.Fill;
                Frames.recipeFrm.Show();
                Frames.recipeFrm.Activate();
                Cursor.Current = Cursors.Arrow;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void btn_config_Click(object sender, EventArgs e)
        {
            moveSidePanle(btn_config);
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (this.ActiveMdiChild == Frames.settingFrm)
                {
                    Cursor.Current = Cursors.Arrow;
                    return;
                }
                Frames.settingFrm.MdiParent = this;
                Frames.settingFrm.Dock = DockStyle.Fill;
                Frames.settingFrm.Show();
                Frames.settingFrm.Activate();
                Cursor.Current = Cursors.Arrow;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            moveSidePanle(btn_report);
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (this.ActiveMdiChild == Frames.reportFrm)
                {
                    Cursor.Current = Cursors.Arrow;
                    return;
                }
                Frames.reportFrm.MdiParent = this;
                Frames.reportFrm.Dock = DockStyle.Fill;
                Frames.reportFrm.Show();
                Frames.reportFrm.Activate();
                Cursor.Current = Cursors.Arrow;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            moveSidePanle(btn_help);
        }

        private void MainFrm2_Load(object sender, EventArgs e)
        {
            SplashFrm.num = 30;
            Frames.videoFrm = new VideoFrm();
            Frames.recipeFrm = new RecipeFrm();
            Frames.settingFrm = new SettingFrm();
            Frames.reportFrm = new ReportFrm();
            SplashFrm.num = 60;
            Thread.Sleep(1200);
            SplashFrm.num = 100;

            this.WindowState = FormWindowState.Maximized;
            this.Visible = true;
            
            Frames.videoFrm.MdiParent = this;
            Frames.videoFrm.Dock = DockStyle.Fill;
            Frames.videoFrm.Show();
            Frames.videoFrm.Activate();
            this.Opacity = 1;
            ImgProcess.Project.getInstance().Init();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_time.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}

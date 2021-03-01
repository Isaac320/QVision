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
            using (PopTipFrm ptf = new PopTipFrm("Close?"))
            {
                if(ptf.ShowDialog()==DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            moveSidePanle(btn_home);
            //UC_Home uch = new UC_Home();
            //AddControlToPlane(uch);
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

        private void btn_recipe_Click(object sender, EventArgs e)
        {
            moveSidePanle(btn_recipe);
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

        private void btn_config_Click(object sender, EventArgs e)
        {
            moveSidePanle(btn_config);
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

        private void btn_report_Click(object sender, EventArgs e)
        {
            moveSidePanle(btn_report);
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

        private void btn_help_Click(object sender, EventArgs e)
        {
            moveSidePanle(btn_help);
            using (AboutFrm af = new AboutFrm())
            {
                af.ShowDialog();
            }
        }

        private void MainFrm2_Load(object sender, EventArgs e)
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
            this.Opacity = 1;
            ImgProcess.Project.getInstance().Init();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_time.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        private void btn_QX_Click(object sender, EventArgs e)
        {

        }
    }
}

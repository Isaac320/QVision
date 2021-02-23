using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QVision.Params;
using QVision.Tools;

namespace QVision.Frm
{
    public partial class SettingFrm : Form
    {
        public SettingFrm()
        {
            InitializeComponent();
            init();
        }


        private void init()
        {
            //lb_ConfigPath.Text = Global.ConfigPath;
            lb_SaveImagePath.Text = Global.SaveImagePath;
            lb_TempImagePath.Text = Global.TempImagePath;
            lb_XRayImagePath.Text = Global.XRayImagePath;
            lb_ReceiptPath.Text = Global.RecipePath;
            lb_inkPointPath.Text = Global.InkPointPath;
            lb_lotSummaryPath.Text = Global.LotSummaryPath;

            checkBox1.Checked = Global.needLook;
            cb_OKSave.Checked = Global.needOKSave;
            cb_NGSave.Checked = Global.needNGSave;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    FolderBrowserDialog fbd = new FolderBrowserDialog();
            //    fbd.Description = "选择数据保存路径";
            //    if (fbd.ShowDialog() == DialogResult.OK)
            //    {
            //        lb_ConfigPath.Text = fbd.SelectedPath;
            //        Global.ConfigPath = fbd.SelectedPath;
            //    }
            //}
            //catch (Exception eee)
            //{
            //    MessageBox.Show(eee.ToString());
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.Description = "选择数据保存路径";
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    lb_TempImagePath.Text = fbd.SelectedPath;
                    Global.TempImagePath = fbd.SelectedPath;
                }
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.Description = "选择数据保存路径";
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    lb_SaveImagePath.Text = fbd.SelectedPath;
                    Global.SaveImagePath = fbd.SelectedPath;
                }
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.ToString());
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.Description = "选择数据保存路径";
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    lb_XRayImagePath.Text = fbd.SelectedPath;
                    Global.XRayImagePath = fbd.SelectedPath;
                }
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.ToString());
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.Description = "选择数据保存路径";
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    lb_ReceiptPath.Text = fbd.SelectedPath;
                    Global.RecipePath = fbd.SelectedPath;
                }
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.ToString());
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Global.needLook = true;
            }
            else
            {
                Global.needLook = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.Description = "选择数据保存路径";
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    lb_inkPointPath.Text = fbd.SelectedPath;
                    Global.InkPointPath = fbd.SelectedPath;
                }
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.ToString());
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                MyConfig.SaveData();
                MessageBox.Show("保存成功");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.Description = "选择数据保存路径";
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    lb_lotSummaryPath.Text = fbd.SelectedPath;
                    Global.LotSummaryPath = fbd.SelectedPath;
                }
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.ToString());
            }
        }

        private void cb_OKSave_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_OKSave.Checked)
            {
                Global.needOKSave = true;
            }
            else
            {
                Global.needOKSave = false;
            }
        }

        private void cb_NGSave_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_NGSave.Checked)
            {
                Global.needNGSave = true;
            }
            else
            {
                Global.needNGSave = false;
            }
        }
    }
}

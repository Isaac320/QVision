﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QVision.Params;
using QVision.Tools;
using HalconDotNet;

namespace QVision.Frm
{
    public partial class VideoFrm : Form
    {
        delegate void delegateShowMessage(string s);

        delegate void delegateShowPValue(int a);
        public VideoFrm()
        {
            InitializeComponent();
        }
        private void bt_go_Click(object sender, EventArgs e)
        {
            if (!Global.ready2Go)
            {
                using (InitFrm2 initfrm = new InitFrm2())
                {
                    if (initfrm.ShowDialog() == DialogResult.OK)
                    {
                        ShowList();
                    }
                }
            }

            if (Global.ready2Go)
            {
                if (Global.mySwitch1)
                {
                    Global.mySwitch1 = false;
                    listBoxShowMessage("Continue");
                }

                if (Global.mMState == MachineState.Free)
                {
                    listBoxShowMessage("Begin Work");
                    Global.mMState = MachineState.Run;
                }
            }
        }

        public void showImage(HObject obj, int index)
        {
            HOperatorSet.SetDraw(hSmartWindowControl1.HalconWindow, "margin");
            HOperatorSet.SetLineWidth(hSmartWindowControl1.HalconWindow, 2);
            if (index == 1)
            {
                HOperatorSet.SetColor(hSmartWindowControl1.HalconWindow, "red");
            }
            else
            {
                HOperatorSet.SetColor(hSmartWindowControl1.HalconWindow, "green");
            }
            hSmartWindowControl1.HalconWindow.DispObj(obj);
        }

        public void ShowList()
        {
            if (listView1.InvokeRequired)
            {
                listView1.Invoke(new Action(ShowList), new object[] { });
            }
            else
            {
                listView1.Items.Clear();
                this.listView1.BeginUpdate();
                ListViewItem lvi = new ListViewItem();
                lvi.ImageIndex = 0;
                lvi.Text = "Lot Num";
                lvi.SubItems.Add(Global.LotNum);
                this.listView1.Items.Add(lvi);

                lvi = new ListViewItem();
                lvi.ImageIndex = 1;
                lvi.Text = "Device";
                lvi.SubItems.Add(Global.Device);
                this.listView1.Items.Add(lvi);

                lvi = new ListViewItem();
                lvi.ImageIndex = 2;
                lvi.Text = "Operator ID";
                lvi.SubItems.Add(Global.OperatorID);
                this.listView1.Items.Add(lvi);

                lvi = new ListViewItem();
                lvi.ImageIndex = 3;
                lvi.Text = "Total Frame";
                lvi.SubItems.Add(Global.TotalFrame.ToString());
                this.listView1.Items.Add(lvi);
                this.listView1.EndUpdate();

                lvi = new ListViewItem();
                lvi.ImageIndex = 4;
                lvi.Text = "Recipe Name";
                lvi.SubItems.Add(Global.RecipeName.ToString());
                this.listView1.Items.Add(lvi);
                this.listView1.EndUpdate();

            }
        }

        public void listBoxShowMessage(string s)
        {
            if (listBox1.InvokeRequired)
            {
                BeginInvoke(new delegateShowMessage(listBoxShowMessage), new object[] { s });

            }
            else
            {
                string mystring = DateTime.Now.ToString("HH:mm:ss") + " " + s;
                listBox1.Items.Add(mystring);

                //写log
                LogManager.WriteLog(s);

                if (listBox1.Items.Count > 200)
                {
                    for (int i = 80; i > -1; i--)
                    {
                        listBox1.Items.RemoveAt(i);
                    }
                }
                listBox1.TopIndex = listBox1.Items.Count - 1;
            }
        }


        public void showCheckInfo(string s)
        {
            if(lb_Check.InvokeRequired)
            {
                BeginInvoke(new delegateShowMessage(showCheckInfo), new object[] { s });
            }
            else
            {
                lb_Check.Text = s;
            }
        }

        private void bt_pause_Click(object sender, EventArgs e)
        {
            if (Global.ready2Go)
            {
                Global.mySwitch1 = true;
                listBoxShowMessage("Pause");
            }
        }

        private void bt_step_Click(object sender, EventArgs e)
        {
            if (Global.ready2Go)
            {
                Global.mySwitch2 = false;
                listBoxShowMessage("Step");
            }
        }

        private void hSmartWindowControl1_Load(object sender, EventArgs e)
        {
            hSmartWindowControl1.MouseWheel += hSmartWindowControl1.HSmartWindowControl_MouseWheel;
        }

        private void showPValue(int value)
        {
            progressBar1.Value = value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.InvokeRequired)
            {
                BeginInvoke(new delegateShowPValue(showPValue), new object[] { Global.WorkProgressNum });

            }
            else
            {
                progressBar1.Value = Global.WorkProgressNum;
            }
        }
    }
}

using QVision.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QVision.Params;
using System.IO;

namespace QVision.Frm
{
    public partial class SaveRecipeFrm : Form
    {
        public string deviceName;
        public string recipeName;
        public string description;
        public SaveRecipeFrm()
        {
            InitializeComponent();
            showTable();
        }


        private void showTable()
        {
            DataTable mydt = D2RManager.Query("SELECT * FROM Table1 WHERE 1=1");
            dataTableToListview(listView1, mydt);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim(' ') == ""|| textBox2.Text.Trim(' ') == "")
            {
                MessageBox.Show("plz write the names");
            }
            else
            {
                deviceName = textBox1.Text;
                recipeName = textBox2.Text;
                description = textBox3.Text;

                D2RManager.Save(deviceName, recipeName, description);
                
                string name = recipeName+".zl";
                RecipeTool.SerializableNow(Global.RecipePath+"\\", name, RecipeFrm.Dict);
                showTable();
            }

        }

        static public void dataTableToListview(ListView lv, DataTable dt)
        {
            if (dt != null)
            {
                lv.Items.Clear();
                lv.Columns.Clear();
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    lv.Columns.Add(dt.Columns[i].Caption.ToString());
                }
                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.SubItems[0].Text = dr[0].ToString();
                    for (int i = 1; i < dt.Columns.Count; i++)
                    {
                        lvi.SubItems.Add(dr[i].ToString());
                    }
                    lv.Items.Add(lvi);
                }
                lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                //lv.Columns[0].Width = 1;
            }

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string deviceName = listView1.SelectedItems[0].SubItems[0].Text;
                if (MessageBox.Show("Really Delete: "+ deviceName +"? ", "Tips", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    //string deviceName = listView1.SelectedItems[0].SubItems[0].Text;

                    string recipeName2 = listView1.SelectedItems[0].SubItems[1].Text;
                    //string dateStr = Convert.ToDateTime(listView1.SelectedItems[0].SubItems[2].Text).ToString("yyyyMMdd");
                    //string path = listView1.SelectedItems[0].SubItems[5].Text;

                    //List<string> list = DBMachineNum.ReadImageNames(s);

                    //删除图片
                    //string longPath = path + "//" + machineStr + "//" + dateStr;

                    //DeleteImages(list, longPath);

                    //DBMachineNum.DeleteLot(s);
                    //DBMachineNum.DeleteLot2(s);

                    D2RManager.DeleteDevice(deviceName);

                    string fileName = Global.RecipePath+"\\" + recipeName2 + ".zl";
                    try
                    {
                        File.Delete(fileName);
                    }
                    catch
                    {
                        MessageBox.Show("aaaa");
                    }

                    listView1.SelectedItems[0].Remove();
                }
                else
                {

                }

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
               
                    contextMenuStrip1.Show(listView1, e.Location);
                
            }
        }
    }
}

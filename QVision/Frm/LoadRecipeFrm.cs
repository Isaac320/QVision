using QVision.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QVision.Frm
{
    public partial class LoadRecipeFrm : Form
    {
        public string RecipeName;  //配方名字
        public LoadRecipeFrm()
        {
            InitializeComponent();
            DataTable mydt = D2RManager.Query("SELECT * FROM Table1 WHERE 1=1");
            dataTableToListview(listView1, mydt);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string tempStr= listView1.SelectedItems[0].SubItems[1].Text;
            using (PopTipFrm ltf = new PopTipFrm("Load Recipe:"+tempStr+"?"))
            {
                if(ltf.ShowDialog()==DialogResult.OK)
                {
                    RecipeName = tempStr+".zl";
                    DialogResult = DialogResult.OK;
                }
            }
                
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

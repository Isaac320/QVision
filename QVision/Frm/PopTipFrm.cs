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
    public partial class PopTipFrm : Form
    {
        public PopTipFrm()
        {
            InitializeComponent();
        }

        public PopTipFrm(string s)
        {
            InitializeComponent();
            label1.Text = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

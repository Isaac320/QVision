namespace QVision.Frm
{
    partial class EndTrayFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lb_reject = new System.Windows.Forms.Label();
            this.lb_InFrame = new System.Windows.Forms.Label();
            this.lb_lot = new System.Windows.Forms.Label();
            this.lb_noProcess = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dragControl1 = new QVision.DragControl.DragControl(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_reject
            // 
            this.lb_reject.AutoSize = true;
            this.lb_reject.Location = new System.Drawing.Point(26, 65);
            this.lb_reject.Name = "lb_reject";
            this.lb_reject.Size = new System.Drawing.Size(183, 21);
            this.lb_reject.TabIndex = 6;
            this.lb_reject.Text = "Found reject units: 199";
            // 
            // lb_InFrame
            // 
            this.lb_InFrame.AutoSize = true;
            this.lb_InFrame.Location = new System.Drawing.Point(26, 42);
            this.lb_InFrame.Name = "lb_InFrame";
            this.lb_InFrame.Size = new System.Drawing.Size(203, 21);
            this.lb_InFrame.TabIndex = 5;
            this.lb_InFrame.Text = "Inspected Frames： 1/16";
            // 
            // lb_lot
            // 
            this.lb_lot.AutoSize = true;
            this.lb_lot.Location = new System.Drawing.Point(26, 19);
            this.lb_lot.Name = "lb_lot";
            this.lb_lot.Size = new System.Drawing.Size(73, 21);
            this.lb_lot.TabIndex = 4;
            this.lb_lot.Text = "Lot : 123";
            // 
            // lb_noProcess
            // 
            this.lb_noProcess.AutoSize = true;
            this.lb_noProcess.ForeColor = System.Drawing.Color.Red;
            this.lb_noProcess.Location = new System.Drawing.Point(24, 437);
            this.lb_noProcess.Name = "lb_noProcess";
            this.lb_noProcess.Size = new System.Drawing.Size(254, 21);
            this.lb_noProcess.TabIndex = 10;
            this.lb_noProcess.Text = "Reject has not been processed!";
            this.lb_noProcess.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(354, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Please move to the tray to the reject station";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(28, 91);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(284, 298);
            this.listBox1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(160)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(274, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 64);
            this.button1.TabIndex = 7;
            this.button1.Text = "continue";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(397, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 41);
            this.button2.TabIndex = 11;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EndTrayFrm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(440, 561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lb_noProcess);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_reject);
            this.Controls.Add(this.lb_InFrame);
            this.Controls.Add(this.lb_lot);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EndTrayFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tray Finish";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_reject;
        private System.Windows.Forms.Label lb_InFrame;
        private System.Windows.Forms.Label lb_lot;
        private System.Windows.Forms.Label lb_noProcess;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private DragControl.DragControl dragControl1;
        private System.Windows.Forms.Button button2;
    }
}
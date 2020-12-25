namespace QVision.VisionTools.BlobTool
{
    partial class BlobToolCtr
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rectangle1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hSmartWindowControl1 = new HalconDotNet.HSmartWindowControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Run = new System.Windows.Forms.Button();
            this.lb_high = new System.Windows.Forms.Label();
            this.lb_low = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btn_ClearAll = new System.Windows.Forms.Button();
            this.btn_AddRect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_areaMax = new System.Windows.Forms.TextBox();
            this.tb_areaMin = new System.Windows.Forms.TextBox();
            this.cb_areaFlag = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ParamsSave = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rectangle1ToolStripMenuItem,
            this.clearAllToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(141, 48);
            // 
            // rectangle1ToolStripMenuItem
            // 
            this.rectangle1ToolStripMenuItem.Name = "rectangle1ToolStripMenuItem";
            this.rectangle1ToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.rectangle1ToolStripMenuItem.Text = "Rectangle1";
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.clearAllToolStripMenuItem.Text = "Clear All";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.90909F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.09091F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1430, 1000);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.hSmartWindowControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 1000);
            this.panel1.TabIndex = 0;
            // 
            // hSmartWindowControl1
            // 
            this.hSmartWindowControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hSmartWindowControl1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.hSmartWindowControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hSmartWindowControl1.HDoubleClickToFitContent = true;
            this.hSmartWindowControl1.HDrawingObjectsModifier = HalconDotNet.HSmartWindowControl.DrawingObjectsModifier.None;
            this.hSmartWindowControl1.HImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.hSmartWindowControl1.HKeepAspectRatio = true;
            this.hSmartWindowControl1.HMoveContent = true;
            this.hSmartWindowControl1.HZoomContent = HalconDotNet.HSmartWindowControl.ZoomContent.WheelForwardZoomsIn;
            this.hSmartWindowControl1.Location = new System.Drawing.Point(0, 0);
            this.hSmartWindowControl1.Margin = new System.Windows.Forms.Padding(0);
            this.hSmartWindowControl1.Name = "hSmartWindowControl1";
            this.hSmartWindowControl1.Size = new System.Drawing.Size(1155, 1000);
            this.hSmartWindowControl1.TabIndex = 0;
            this.hSmartWindowControl1.WindowSize = new System.Drawing.Size(1155, 1000);
            this.hSmartWindowControl1.Load += new System.EventHandler(this.hSmartWindowControl1_Load);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_ParamsSave);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tb_areaMax);
            this.panel2.Controls.Add(this.tb_areaMin);
            this.panel2.Controls.Add(this.cb_areaFlag);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btn_Run);
            this.panel2.Controls.Add(this.lb_high);
            this.panel2.Controls.Add(this.lb_low);
            this.panel2.Controls.Add(this.btn_Save);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.trackBar2);
            this.panel2.Controls.Add(this.trackBar1);
            this.panel2.Controls.Add(this.btn_ClearAll);
            this.panel2.Controls.Add(this.btn_AddRect);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1159, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 994);
            this.panel2.TabIndex = 1;
            // 
            // btn_Run
            // 
            this.btn_Run.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(160)))));
            this.btn_Run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Run.ForeColor = System.Drawing.Color.White;
            this.btn_Run.Location = new System.Drawing.Point(37, 525);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(187, 53);
            this.btn_Run.TabIndex = 9;
            this.btn_Run.Text = "Run";
            this.btn_Run.UseVisualStyleBackColor = false;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // lb_high
            // 
            this.lb_high.AutoSize = true;
            this.lb_high.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_high.Location = new System.Drawing.Point(203, 447);
            this.lb_high.Name = "lb_high";
            this.lb_high.Size = new System.Drawing.Size(21, 23);
            this.lb_high.TabIndex = 8;
            this.lb_high.Text = "0";
            // 
            // lb_low
            // 
            this.lb_low.AutoSize = true;
            this.lb_low.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_low.Location = new System.Drawing.Point(203, 396);
            this.lb_low.Name = "lb_low";
            this.lb_low.Size = new System.Drawing.Size(21, 23);
            this.lb_low.TabIndex = 7;
            this.lb_low.Text = "0";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(160)))));
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(37, 271);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(187, 48);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save All";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Threshold";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(17, 447);
            this.trackBar2.Maximum = 255;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(184, 45);
            this.trackBar2.TabIndex = 4;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(17, 396);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(184, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btn_ClearAll
            // 
            this.btn_ClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(160)))));
            this.btn_ClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClearAll.ForeColor = System.Drawing.Color.White;
            this.btn_ClearAll.Location = new System.Drawing.Point(37, 197);
            this.btn_ClearAll.Name = "btn_ClearAll";
            this.btn_ClearAll.Size = new System.Drawing.Size(187, 48);
            this.btn_ClearAll.TabIndex = 2;
            this.btn_ClearAll.Text = "Clear All";
            this.btn_ClearAll.UseVisualStyleBackColor = false;
            this.btn_ClearAll.Click += new System.EventHandler(this.btn_ClearAll_Click);
            // 
            // btn_AddRect
            // 
            this.btn_AddRect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(160)))));
            this.btn_AddRect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddRect.ForeColor = System.Drawing.Color.White;
            this.btn_AddRect.Location = new System.Drawing.Point(37, 134);
            this.btn_AddRect.Name = "btn_AddRect";
            this.btn_AddRect.Size = new System.Drawing.Size(187, 48);
            this.btn_AddRect.TabIndex = 1;
            this.btn_AddRect.Text = "Add Rectangle1";
            this.btn_AddRect.UseVisualStyleBackColor = false;
            this.btn_AddRect.Click += new System.EventHandler(this.btn_AddRect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Blob Tool";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(122, 683);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 683);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "min";
            // 
            // tb_areaMax
            // 
            this.tb_areaMax.Location = new System.Drawing.Point(172, 680);
            this.tb_areaMax.Name = "tb_areaMax";
            this.tb_areaMax.Size = new System.Drawing.Size(65, 27);
            this.tb_areaMax.TabIndex = 13;
            // 
            // tb_areaMin
            // 
            this.tb_areaMin.Location = new System.Drawing.Point(57, 680);
            this.tb_areaMin.Name = "tb_areaMin";
            this.tb_areaMin.Size = new System.Drawing.Size(59, 27);
            this.tb_areaMin.TabIndex = 12;
            // 
            // cb_areaFlag
            // 
            this.cb_areaFlag.AutoSize = true;
            this.cb_areaFlag.Location = new System.Drawing.Point(243, 687);
            this.cb_areaFlag.Name = "cb_areaFlag";
            this.cb_areaFlag.Size = new System.Drawing.Size(15, 14);
            this.cb_areaFlag.TabIndex = 11;
            this.cb_areaFlag.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 646);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "area (pix)";
            // 
            // btn_ParamsSave
            // 
            this.btn_ParamsSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(160)))));
            this.btn_ParamsSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ParamsSave.ForeColor = System.Drawing.Color.White;
            this.btn_ParamsSave.Location = new System.Drawing.Point(126, 816);
            this.btn_ParamsSave.Name = "btn_ParamsSave";
            this.btn_ParamsSave.Size = new System.Drawing.Size(121, 65);
            this.btn_ParamsSave.TabIndex = 18;
            this.btn_ParamsSave.Text = "Save";
            this.btn_ParamsSave.UseVisualStyleBackColor = false;
            this.btn_ParamsSave.Click += new System.EventHandler(this.btn_ParamsSave_Click);
            // 
            // BlobToolCtr
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.Name = "BlobToolCtr";
            this.Size = new System.Drawing.Size(1430, 1000);
            this.Load += new System.EventHandler(this.BlobToolCtr_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rectangle1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private HalconDotNet.HSmartWindowControl hSmartWindowControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ClearAll;
        private System.Windows.Forms.Button btn_AddRect;
        private System.Windows.Forms.Label lb_high;
        private System.Windows.Forms.Label lb_low;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_areaMax;
        private System.Windows.Forms.TextBox tb_areaMin;
        private System.Windows.Forms.CheckBox cb_areaFlag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ParamsSave;
    }
}

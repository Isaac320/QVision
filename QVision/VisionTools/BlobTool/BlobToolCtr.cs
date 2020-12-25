using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HalconDotNet;

namespace QVision.VisionTools.BlobTool
{
    public partial class BlobToolCtr : UserControl
    {
        private BlobTool tool;       
        private List<HDrawingObject> drawing_objects = new List<HDrawingObject>();

        HTuple rectParams = new HTuple("row1", "column1", "row2", "column2");
        public BlobToolCtr()
        {
            InitializeComponent();
        }

        public BlobToolCtr(BlobTool tool)
        {
            this.tool = tool;
            InitializeComponent();            
        }

        private void BlobToolCtr_Load(object sender, EventArgs e)
        {
            if (tool.Image != null)
            {
                hSmartWindowControl1.HalconWindow.DispObj(tool.Image);               
                hSmartWindowControl1.HalconWindow.SetPart(0, 0, -2, -2);
                loadRegions();
                update();
                trackBar1.Value = tool.Low;
                trackBar2.Value = tool.High;

                cb_areaFlag.Checked = tool.blobAreaParams.flag;
                tb_areaMax.Text = tool.blobAreaParams.max.ToString();
                tb_areaMin.Text = tool.blobAreaParams.min.ToString();
            }
        }

        private void hSmartWindowControl1_Load(object sender, EventArgs e)
        {
            hSmartWindowControl1.MouseWheel += hSmartWindowControl1.HSmartWindowControl_MouseWheel;
        }

        private void AttachDrawObj(HDrawingObject obj)
        {
            drawing_objects.Add(obj);
            hSmartWindowControl1.HalconWindow.AttachDrawingObjectToWindow(obj);
        }


        private void btn_AddRect_Click(object sender, EventArgs e)
        {
            HDrawingObject rect1 = HDrawingObject.CreateDrawingObject(
              HDrawingObject.HDrawingObjectType.RECTANGLE1, 100, 100, 210, 210);
            rect1.SetDrawingObjectParams("color", "green");
            AttachDrawObj(rect1);
        }

        private void btn_ClearAll_Click(object sender, EventArgs e)
        {
            foreach (HDrawingObject dobj in drawing_objects)
                dobj.Dispose();
            drawing_objects.Clear();
            //tool.Rects.Clear();
            //tool.blobToolRegion = null;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            tool.Low = trackBar1.Value;
            update();
            ShowBlobs();
        }

        private void update()
        {
            if (this.InvokeRequired)
            {
                BeginInvoke(new Action(update), new object[] { });
            }
            else
            {
                lb_high.Text = tool.High.ToString();
                lb_low.Text = tool.Low.ToString();
                
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            tool.High = trackBar2.Value;
            update();
            ShowBlobs();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                tool.Rects.Clear();
                foreach (var r in drawing_objects)
                {
                    HTuple htemp1 = new HTuple(r.GetDrawingObjectParams(rectParams));
                    //tool.Rect1 = new double[4] { htemp1[0], htemp1[1], htemp1[2], htemp1[3] };
                    Rect rect = new Rect { r1 = htemp1[0], c1 = htemp1[1], r2 = htemp1[2], c2 = htemp1[3] };
                    tool.Rects.Add(rect);  //tool里加入所有rect
                }
                tool.UniteRects();
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void btn_Run_Click(object sender, EventArgs e)
        {
            ShowBlobs();
            MessageBox.Show(tool.blobArea.ToString());
        }


        private void ShowBlobs()
        {
            tool.Run();
            if (tool.Blobs != null)
            {
                hSmartWindowControl1.HalconWindow.ClearWindow();
                hSmartWindowControl1.HalconWindow.DispObj(tool.Image);
                hSmartWindowControl1.HalconWindow.SetColor("green");
                hSmartWindowControl1.HalconWindow.SetDraw("margin");
                hSmartWindowControl1.HalconWindow.DispObj(tool.blobToolRegion);

                hSmartWindowControl1.HalconWindow.SetColor("red");
                hSmartWindowControl1.HalconWindow.SetDraw("fill");
                hSmartWindowControl1.HalconWindow.DispObj(tool.Blobs);
            }
            
        }


        private void loadRegions()
        {
            foreach(var r in tool.Rects)
            {
                HDrawingObject rect1 = HDrawingObject.CreateDrawingObject(
              HDrawingObject.HDrawingObjectType.RECTANGLE1, r.r1, r.c1, r.r2, r.c2);
                rect1.SetDrawingObjectParams("color", "green");
                AttachDrawObj(rect1);
            }
        }

        private void btn_ParamsSave_Click(object sender, EventArgs e)
        {
            try
            {
                tool.blobAreaParams.min = Convert.ToDouble(tb_areaMin.Text);
                tool.blobAreaParams.max = Convert.ToDouble(tb_areaMax.Text);
                tool.blobAreaParams.flag = cb_areaFlag.Checked;
               
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HalconDotNet;

namespace QVision.VisionTools.CheckLineTool
{
    [Serializable]
    public struct line_Params
    {
        public bool flag;
        public double min1;
        public double max1;
    }
    [Serializable]
    public class CheckLineTool
    {
        public HImage himage = null;
        public double[] Rect1 = new double[4] { 50, 50, 200, 200 };
        private double sigma = 1.5, low = 3, high = 10;

        private string lightDark = "dark";

       
        public line_Params contour_length = new line_Params { flag = false, min1 = 0, max1=100};
        public line_Params direction=new line_Params { flag = false, min1 = 0, max1 = 3.14 };

        public int lineNum = 3;

        public int lineNumResult = 0;

        private bool result = false;

        [NonSerialized]
        private HXLDCont lines;



        public double Sigma
        {
            set { sigma = value; }
            get { return sigma; }
        }

        public double Low
        {
            set { low = value; }
            get { return low; }
        }

        public double High
        {
            set { high = value; }
            get { return high; }
        }

        public string LightDark
        {
            set { lightDark = value; }
            get { return lightDark; }
        }



        public HImage Image
        {
            get { return himage; }
            set { himage = value; }
        }

        public HXLDCont Lines
        {
            get { return lines; }
        }

        /// <summary>
        /// 最终结果
        /// </summary>
        public bool Result
        {
            get { return result; }
        }


        public void Run()
        {
            try
            {
                HRegion hRegion = new HRegion(Rect1[0], Rect1[1], Rect1[2], Rect1[3]);
                HImage ROIImage = himage.ReduceDomain(hRegion);
                lines = ROIImage.LinesGauss(sigma, low, high, lightDark, "true", "bar-shaped", "true");
                if(contour_length.flag)
                {
                    lines = lines.SelectContoursXld("contour_length", contour_length.min1, contour_length.max1, 0, 0);
                }
                if(direction.flag)
                {
                    lines = lines.SelectContoursXld("direction", direction.min1, direction.max1, 0, 0);
                }
                lineNumResult = lines.CountObj();
                result = (lineNumResult == lineNum);
            }
            catch(Exception ee)
            {

            }
        }

        public void Run(HRegion hRegion)
        {
            try
            {               
                HImage ROIImage = himage.ReduceDomain(hRegion);
                lines = ROIImage.LinesGauss(sigma, low, high, lightDark, "true", "bar-shaped", "true");
                if (contour_length.flag)
                {
                    lines = lines.SelectContoursXld("contour_length", contour_length.min1, contour_length.max1, 0, 0);
                }
                if (direction.flag)
                {
                    lines = lines.SelectContoursXld("direction", direction.min1, direction.max1, 0, 0);
                }
                lineNumResult = lines.CountObj();
                result = (lineNumResult == lineNum);
            }
            catch (Exception ee)
            {

            }
        }





    }
}

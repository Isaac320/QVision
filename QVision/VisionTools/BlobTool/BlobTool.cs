using HalconDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QVision.VisionTools.BlobTool
{
    [Serializable]
    public struct Rect
    {
        public double r1;
        public double c1;
        public double r2;
        public double c2;
    }


    [Serializable]
    public class BlobTool
    {
        public HImage himage = null;

        private int low = 0;
        private int high = 0;

        public List<Rect> Rects = new List<Rect>();  //用来存Blob工具的那一堆矩形区域的

        public HRegion blobToolRegion = null;   //合并上面所有的矩形框框得到的区域


        [NonSerialized]
        private  HRegion blobs = null;

        public int Low
        {
            set { low = value; }
            get { return low; }
        }

        public int High
        {
            set { high = value; }
            get { return high; }
        }


        public HImage Image
        {
            get { return himage; }
            set { himage = value; }
        }

        public HRegion Blobs
        {
            get { return blobs; }
        }


        /// <summary>
        /// 合并所有rect
        /// </summary>
        public void UniteRects()
        {
            HRegion tempHReg = new HRegion();
            tempHReg.GenEmptyRegion();
            foreach(var tempRect in Rects)
            {
                HRegion r = new HRegion(tempRect.r1, tempRect.c1, tempRect.r2, tempRect.c2);
                tempHReg=tempHReg.ConcatObj(r);
            }
            blobToolRegion = tempHReg.Union1();
        }


        public void Run()
        {
            try
            {
                HImage image = himage.ReduceDomain(blobToolRegion);
                blobs = image.Threshold((HTuple)low, high);
            }
            catch(Exception ee)
            {
                
            }
        }


    }
}

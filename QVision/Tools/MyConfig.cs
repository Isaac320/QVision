﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QVision.Params;

namespace QVision.Tools
{
    class MyConfig
    {
        //static IniFile myini = new IniFile(Global.ConfigPath + "\\Config.ini");


        static string ConfigFile = Application.StartupPath + "\\Config.ini";
        static IniFile myini = new IniFile(ConfigFile);

        public static void SaveData()
        {
            try
            {
                //if(!Directory.Exists(Global.ConfigPath))
                //{
                //    Directory.CreateDirectory(Global.ConfigPath);  //创建路径
                //}   


                //myini.IniWriteValue("Threshold", "mean1", Global.Threshold1.ToString());
                //myini.IniWriteValue("Threshold", "mean2", Global.Threshold2.ToString());
                //myini.IniWriteValue("OFFSET", "height", Global.Offset.ToString());

                //myini.IniWriteValue("Path", "configPath", Global.ConfigPath);
                myini.IniWriteValue("Path", "tempImagePath", Global.TempImagePath);
                myini.IniWriteValue("Path", "saveImagePath", Global.SaveImagePath);
                myini.IniWriteValue("Path", "xRayImagePath", Global.XRayImagePath);
                myini.IniWriteValue("Path", "receiptPath", Global.RecipePath);
                myini.IniWriteValue("Path", "inkPointPath", Global.InkPointPath);
                myini.IniWriteValue("Path", "lotSummaryPath", Global.LotSummaryPath);

                myini.IniWriteValue("Params", "NeedLook", Global.needLook ? "1" : "0");
                myini.IniWriteValue("Params", "NeedOKSave", Global.needOKSave ? "1" : "0");
                myini.IniWriteValue("Params", "NeedNGSave", Global.needNGSave ? "1" : "0");


            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());

                LogManager.WriteLog("保存参数错误" + ee.ToString());
            }
        }


        public static void LoadData()
        {
            try
            {
                //Global.Threshold1 = double.Parse(myini.IniReadValue("Threshold", "mean1"));
                //Global.Threshold2 = int.Parse(myini.IniReadValue("Threshold", "mean2"));
                //Global.Offset = short.Parse(myini.IniReadValue("OFFSET", "height"));

                //if (!Directory.Exists(Global.ConfigPath))
                //{
                //    Directory.CreateDirectory(Global.ConfigPath);  //创建路径
                //    SaveData();
                //}

                if (!File.Exists(ConfigFile))
                {
                    SaveData();
                }

                //Global.ConfigPath = myini.IniReadValue("Path", "configPath");
                Global.TempImagePath = myini.IniReadValue("Path", "tempImagePath");
                Global.SaveImagePath = myini.IniReadValue("Path", "saveImagePath");
                Global.XRayImagePath = myini.IniReadValue("Path", "xRayImagePath");
                Global.RecipePath = myini.IniReadValue("Path", "receiptPath");
                Global.InkPointPath = myini.IniReadValue("Path", "inkPointPath");
                Global.LotSummaryPath = myini.IniReadValue("Path", "lotSummaryPath");

                Global.needLook = myini.IniReadValue("Params", "NeedLook") == "1" ? true : false;
                Global.needOKSave = myini.IniReadValue("Params", "NeedOKSave") == "1" ? true : false;
                Global.needNGSave = myini.IniReadValue("Params", "NeedNGSave") == "1" ? true : false;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                LogManager.WriteLog("载入参数出错" + ee.ToString());
            }
        }


    }
}

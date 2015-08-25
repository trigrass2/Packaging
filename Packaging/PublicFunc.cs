using System;
using System.Collections.Generic;
using System.Text;
using System.Net.NetworkInformation;
using System.IO;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;
using System.Security.Cryptography;
using System.Drawing;
using System.Data;
using System.ComponentModel;
using RobotKit;
using StaubliRobot;using System.Management;
using System.Security.AccessControl;





namespace Packaging
{
    class PublicFunc
    {
        public static bool SaveTxt(string FileName, string[] txt)
        {
            FileStream fs = null;
            try
            {
                if (FileName == null || txt == null || txt.Length < 1)
                {
                    return false;
                }
                 fs = new FileStream(FileName, FileMode.Create, FileAccess.Write);
                using (StreamWriter sw = new StreamWriter(fs, Encoding.Default))
                {
                    for (int i = 0; i < txt.Length; i++)
                    {

                        sw.WriteLine(txt[i]);
                    }

                }
                return true;
            }

            catch
            {
                return false;

            }
            finally
            {

                if (fs != null)
                {
                    fs.Close();

                }


            }
        }


        public static bool SaveTxt(string FileName, string txt)
        {
            return SaveTxt(FileName, new string[] { txt });
        }
        public static string SfD_Show(string Name)
        {


            return SfD_Show(Name, null);

        }

        public static string SfD_Show(string Name, string FileType)
        {
            System.Windows.Forms.SaveFileDialog sfd = null;
            try
            {
                sfd = new SaveFileDialog();
                sfd.InitialDirectory = Directory.GetCurrentDirectory();
                if (Name != null)
                {
                    sfd.FileName = Name;
                }
                if (FileType == null)
                {
                    sfd.Filter = "文本文件(*.txt)|*.txt";
                }
                else
                {
                    sfd.Filter = FileType;

                }
                if (DialogResult.OK != sfd.ShowDialog())
                {
                    return null;
                }
                return sfd.FileName;

            }
            catch
            {
                return null;
            }
            finally
            {

            }
        }
        public static string SfD_Show()
        {
            return SfD_Show(null);
        }




        public static string OpenDir_Show()
        {
            return OpenDir_Show(Application.StartupPath + "\\Txt");
        }
        public static string OpenDir_Show(string DirPath)
        {
            return OpenDir_Show(DirPath, "txt文件|*.txt");
        }



        public static string OpenDir_Show(string DirPath, string FileFilter)
        {
            System.Windows.Forms.OpenFileDialog ofg = null;
            try
            {
                //  string FileFilter = "txt文件|*.txt";
                ofg = new OpenFileDialog();
                if (Directory.Exists(DirPath))
                {
                    ofg.InitialDirectory = DirPath;
                }
                else
                {
                    ofg.InitialDirectory = Application.StartupPath;
                }
                ofg.Filter = FileFilter;

                //打开文件
                if (ofg.ShowDialog() != DialogResult.OK)
                {
                    return null;
                }
                else
                {
                    return ofg.FileName;
                }

            }
            catch
            {


                return null;
            }
            finally
            {


            }

        }
        public static bool IsRecipeOk(string FileName)
        {

            if (FileName == null || !File.Exists(FileName))
            {
                return false;
            }

            FileStream fs = null;
            StreamReader sr = null;
            string StrLine = null;
            string[] data = null;
            int LineCount = 0;
            int TrajCount = 0;
            int TrajIndex = 0;
            int TrajType = 0;
            int PointCount = 0;

            TxtData.Recipe.TrajTypeName = new string[] 
        {
        
        "",   "圆-三点法-内切","圆-圆心&直径法-内切", "三角形-内切", "矩形-内切", //5
        "正五边形-内切", "正六边形-内切", "腰形孔-内切", "", "同步空走路径", "不规则图形",//10
          "圆-三点法-外切","圆-圆心&直径法-外切","三角形-外切", "矩形-外切",//15
         "正五边形-外切", "正六边形-外切", "腰形孔-外切","","同步不规则图形",//20
         "","五角星","切圆管","","C型 三点法",//25
         "","",""
        };

            int[,] TrajFlag = null;
            try
            {

                fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);  //使用StreamReader类来读取文件 
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                while ((StrLine = sr.ReadLine()) != null)
                {
                    LineCount++;
                    StrLine = StrLine.Trim();
                    if (StrLine == "")
                    {
                        continue;

                    }


                    if (StrLine.IndexOf("TOOL=") >= 0)
                    {
                        data = StrLine.Substring(5, StrLine.Length - 6).Split(',');
                        if (data == null || data.Length != 6)
                        {
                            return false;
                        }


                    }

                    if (StrLine.IndexOf("TOTALELEMENTS=") >= 0)
                    {
                        string Buff = StrLine.Substring("TOTALELEMENTS=".Length, StrLine.Length - "TOTALELEMENTS=".Length);

                        TrajCount = int.Parse(Buff);
                        TrajFlag = new int[TrajCount + 1, 20];
                        //对数据进行判断
                        TxtData.Recipe.TotalTraj = TrajCount;
                        TrajCount++; ;
                        TxtData.Recipe.TrajFrame = new double[TrajCount, 6];
                        TxtData.Recipe.TrajOffset = new double[TrajCount, 6];
                        TxtData.Recipe.TrajType = new int[TrajCount];
                        TxtData.Recipe.TrajName = new string[TrajCount + 1];
                        TxtData.Recipe.WorkPlace = new double[TrajCount, 6];
                        TxtData.Recipe.TrajByPass = new bool[TrajCount];
                        TxtData.Recipe.Array = new double[TrajCount, 6];
                        TxtData.Recipe.DownLead = new double[TrajCount, 6];
                        TxtData.Recipe.TrajPointCount = new int[TrajCount, 3];

                        TxtData.Recipe.bAppro = new bool[TrajCount][];
                        TxtData.Recipe.bMoveC = new bool[TrajCount][];
                        TxtData.Recipe.bLeave = new bool[TrajCount][];

                        TxtData.Recipe.pAppro = new double[TrajCount][,];
                        TxtData.Recipe.pCut = new double[TrajCount][,];
                        TxtData.Recipe.pMoveC = new double[TrajCount][,];
                        TxtData.Recipe.pLeave = new double[TrajCount][,];

                        TxtData.Recipe.mAppro = new double[TrajCount][,];
                        TxtData.Recipe.mCut = new double[TrajCount][,];
                        TxtData.Recipe.mLeave = new double[TrajCount][,];
                        TrajCount--;
                        TxtData.Recipe.RecipeFrame = new double[6];
                        TxtData.Recipe.RecipeOffset = new double[6];





                    }



                    if (StrLine.IndexOf("BEGIN=") >= 0)
                    {

                        TrajIndex++;
                        TrajFlag[TrajIndex, 0]++;
                        PointCount = 0;
                        TxtData.Recipe.TrajName[TrajIndex] = StrLine.Substring("BEGIN=".Length, StrLine.Length - "BEGIN=".Length);

                    }

                    if (StrLine.IndexOf("BYPASS=") >= 0)
                    {
                        TrajFlag[TrajIndex, 1]++;
                        TxtData.Recipe.TrajByPass[TrajIndex] = (StrLine.ToUpper().IndexOf("TRUE") >= 0);

                    }
                    if (StrLine.IndexOf("CUTTYPE=") >= 0)
                    {
                        TrajFlag[TrajIndex, 2]++;
                        string Buff = StrLine.Substring("CUTTYPE=".Length, StrLine.Length - "CUTTYPE=".Length);
                        TrajType = int.Parse(Buff);
                        TxtData.Recipe.TrajType[TrajIndex] = TrajType;

                    }
                    if (StrLine.IndexOf("ARRAY=") >= 0)
                    {
                        data = StrLine.Substring(6, StrLine.Length - 6).Split(',');
                        if (data == null || data.Length != 6)
                        {
                            return false;
                        }
                        TrajFlag[TrajIndex, 3]++;
                        for (int i = 0; i < 6; i++)
                        {
                            TxtData.Recipe.Array[TrajIndex, i] = double.Parse(data[i + 0]);
                        }
                    }

                    if (StrLine.IndexOf("POINTCOUNT=") >= 0)
                    {
                        string Buff = StrLine.Substring("POINTCOUNT=".Length, StrLine.Length - "POINTCOUNT=".Length);
                        data = Buff.Split(',');
                        if (data == null || data.Length != 3)
                        {
                            return false;
                        }
                        TrajFlag[TrajIndex, 4]++;
                        TrajFlag[TrajIndex, 15] = int.Parse(data[0]);
                        TrajFlag[TrajIndex, 16] = int.Parse(data[1]);
                        TrajFlag[TrajIndex, 17] = int.Parse(data[2]);

                        data[0] = (TrajFlag[TrajIndex, 15] + 1).ToString();
                        data[1] = (TrajFlag[TrajIndex, 16] + 1).ToString();
                        data[2] = (TrajFlag[TrajIndex, 17] + 1).ToString();


                        TxtData.Recipe.TrajPointCount[TrajIndex, 0] = TrajFlag[TrajIndex, 15];
                        TxtData.Recipe.TrajPointCount[TrajIndex, 1] = TrajFlag[TrajIndex, 16];
                        TxtData.Recipe.TrajPointCount[TrajIndex, 2] = TrajFlag[TrajIndex, 17];

                        TxtData.Recipe.bAppro[TrajIndex] = new bool[int.Parse(data[0])];
                        TxtData.Recipe.bMoveC[TrajIndex] = new bool[int.Parse(data[1])];
                        TxtData.Recipe.bLeave[TrajIndex] = new bool[int.Parse(data[2])];

                        TxtData.Recipe.pAppro[TrajIndex] = new double[int.Parse(data[0]), 6];
                        TxtData.Recipe.pCut[TrajIndex] = new double[int.Parse(data[1]), 6];
                        TxtData.Recipe.pMoveC[TrajIndex] = new double[int.Parse(data[1]), 6];
                        TxtData.Recipe.pLeave[TrajIndex] = new double[int.Parse(data[2]), 6];

                        TxtData.Recipe.mAppro[TrajIndex] = new double[int.Parse(data[0]), 6];
                        TxtData.Recipe.mCut[TrajIndex] = new double[int.Parse(data[1]), 6];
                        TxtData.Recipe.mLeave[TrajIndex] = new double[int.Parse(data[2]), 6];


                    }

                    if (StrLine.IndexOf("FRAME=") >= 0)
                    {
                        data = StrLine.Substring(6, StrLine.Length - 6).Split(',');
                        if (data == null || data.Length != 6)
                        {
                            return false;
                        }
                        TrajFlag[TrajIndex, 5]++;

                        for (int i = 0; i < 6; i++)
                        {
                            if (TrajIndex < 1)
                            {
                                TxtData.Recipe.RecipeFrame[i] = double.Parse(data[i]);
                            }
                            else
                            {
                                TxtData.Recipe.TrajFrame[TrajIndex, i] = double.Parse(data[i]);
                            }

                        }



                    }
                    if (StrLine.IndexOf("OFFSET=") >= 0)
                    {
                        data = StrLine.Substring(7, StrLine.Length - 7).Split(',');
                        if (data == null || data.Length != 6)
                        {
                            return false;
                        }
                        TrajFlag[TrajIndex, 6]++;
                        for (int i = 0; i < 6; i++)
                        {
                            if (TrajIndex < 1)
                            {
                                TxtData.Recipe.RecipeOffset[i] = double.Parse(data[i]);
                            }
                            else
                            {
                                TxtData.Recipe.TrajOffset[TrajIndex, i] = double.Parse(data[i]);
                            }

                        }
                    }


                    if (StrLine.IndexOf("DOWNLEAD=") >= 0)
                    {
                        data = StrLine.Substring(9, StrLine.Length - 9).Split(',');
                        if (data == null || data.Length != 6)
                        {
                            return false;
                        }
                        TrajFlag[TrajIndex, 7]++;
                        for (int i = 0; i < 6; i++)
                        {

                            TxtData.Recipe.DownLead[TrajIndex, i] = double.Parse(data[i]);


                        }

                    }
                    if (StrLine.IndexOf("WORKPLACE=") >= 0)
                    {
                        data = StrLine.Substring(10, StrLine.Length - 10).Split(',');
                        if (data == null || data.Length != 6)
                        {
                            return false;
                        }
                        TrajFlag[TrajIndex, 8]++;
                        for (int i = 0; i < 6; i++)
                        {

                            TxtData.Recipe.WorkPlace[TrajIndex, i] = double.Parse(data[i]);


                        }
                    }
                    if (StrLine.IndexOf("MOVEJ=") >= 0)
                    {
                        data = StrLine.Substring(6, StrLine.Length - 6).Split(new char[] { ',', '/' });
                        if (data.Length != 8)
                        {
                            return false;
                        }
                        PointCount++;
                        if (TrajFlag[TrajIndex, 10] == 0)
                        {
                            TrajFlag[TrajIndex, 9]++;
                            TxtData.Recipe.bAppro[TrajIndex][PointCount] = false;
                            for (int i = 0; i < 6; i++)
                            {
                                TxtData.Recipe.pAppro[TrajIndex][PointCount, i] = double.Parse(data[i]);
                            }
                            for (int i = 0; i < 2; i++)
                            {
                                TxtData.Recipe.mAppro[TrajIndex][PointCount, i] = double.Parse(data[i + 6]);
                            }

                        }
                        else
                        {
                            TrajFlag[TrajIndex, 13]++;
                            TxtData.Recipe.bLeave[TrajIndex][PointCount] = false;
                            for (int i = 0; i < 6; i++)
                            {
                                TxtData.Recipe.pLeave[TrajIndex][PointCount, i] = double.Parse(data[i]);
                            }
                            for (int i = 0; i < 2; i++)
                            {
                                TxtData.Recipe.mLeave[TrajIndex][PointCount, i] = double.Parse(data[i + 6]);
                            }


                        }
                    }
                    if (StrLine.IndexOf("MOVEL=") >= 0)
                    {
                        PointCount++;
                        data = StrLine.Substring(6, StrLine.Length - 6).Split(new char[] { ',', '/' });
                        if (data.Length < 8)
                        {
                            return false;
                        }
                        if (TrajFlag[TrajIndex, 10] == 0)
                        {
                            TrajFlag[TrajIndex, 9]++;
                            TxtData.Recipe.bAppro[TrajIndex][PointCount] = true;
                            for (int i = 0; i < 6; i++)
                            {
                                TxtData.Recipe.pAppro[TrajIndex][PointCount, i] = double.Parse(data[i]);
                            }
                            for (int i = 0; i < 2; i++)
                            {
                                TxtData.Recipe.mAppro[TrajIndex][PointCount, i] = double.Parse(data[i + 6]);
                            }
                        }
                        else
                        {


                            if (TrajFlag[TrajIndex, 12] == 0)
                            {
                                TrajFlag[TrajIndex, 11]++;
                                TxtData.Recipe.bMoveC[TrajIndex][PointCount] = false;
                                for (int i = 0; i < 6; i++)
                                {
                                    TxtData.Recipe.pCut[TrajIndex][PointCount, i] = double.Parse(data[i]);
                                }
                                for (int i = 0; i < 5; i++)
                                {
                                    TxtData.Recipe.mCut[TrajIndex][PointCount, i] = double.Parse(data[i + 6]);
                                }
                            }
                            else
                            {
                                TrajFlag[TrajIndex, 13]++;
                                TxtData.Recipe.bLeave[TrajIndex][PointCount] = true;
                                for (int i = 0; i < 6; i++)
                                {
                                    TxtData.Recipe.pLeave[TrajIndex][PointCount, i] = double.Parse(data[i]);
                                }
                                for (int i = 0; i < 2; i++)
                                {
                                    TxtData.Recipe.mLeave[TrajIndex][PointCount, i] = double.Parse(data[i + 6]);
                                }
                            }
                        }
                    }
                    if (StrLine.IndexOf("MOVEC=") >= 0)
                    {
                        PointCount++;
                        data = StrLine.Substring(6, StrLine.Length - 6).Split(new char[] { ',', '/' });
                        if (data.Length < 17)
                        {
                            return false;
                        }
                        if (TrajFlag[TrajIndex, 12] != 0)
                        {
                            return false;
                        }
                        TrajFlag[TrajIndex, 11]++;

                        TxtData.Recipe.bMoveC[TrajIndex][PointCount] = true;
                        for (int i = 0; i < 6; i++)
                        {
                            TxtData.Recipe.pCut[TrajIndex][PointCount, i] = double.Parse(data[i]);
                        }
                        for (int i = 0; i < 6; i++)
                        {
                            TxtData.Recipe.pMoveC[TrajIndex][PointCount, i] = double.Parse(data[i + 6]);
                        }

                        for (int i = 0; i < 5; i++)
                        {
                            TxtData.Recipe.mCut[TrajIndex][PointCount, i] = double.Parse(data[i + 12]);
                        }

                    }
                    if (StrLine.IndexOf("DELAYON=") >= 0)
                    {
                        TrajFlag[TrajIndex, 10]++;
                        PointCount = 0;
                    }
                    if (StrLine.IndexOf("DELAYOFF=") >= 0)
                    {
                        TrajFlag[TrajIndex, 12]++;
                        PointCount = 0;

                    }


                    if (StrLine.IndexOf("END=") >= 0)
                    {
                        TrajFlag[TrajIndex, 14]++;
                        //if (TrajFlag[TrajIndex, 9] != TrajFlag[TrajIndex, 15] || TrajFlag[TrajIndex, 11] != TrajFlag[TrajIndex, 16] || TrajFlag[TrajIndex, 13] != TrajFlag[TrajIndex, 17])
                        //{
                        //    return false;
                        //}
                        //if (TrajType != 10 && TrajType != 2 && TrajType != 12 && TrajFlag[TrajIndex, 11] != 3)
                        //{
                        //    return false;
                        //}
                    }



                }
                if (TrajCount != 0)
                {

                    for (int j = 1; j <= TrajCount; j++)
                    {
                        for (int i = 0; i <= 14; i++)
                        {
                            if (TrajFlag[j, i] != 1 && i != 9 && i != 11 && i != 13)
                            {
                                return false;
                            }
                        }

                    }
                }

                return true;
            }
            catch
            {
                return false;

            }

            finally
            {

                if (sr != null)
                {
                    sr.Close();
                }
                if (fs != null)
                {
                    fs.Close();
                }

            }

        }

        public static bool IsTool(string FileName)
        {
            if (FileName == null || !File.Exists(FileName))
            {
                return false;
            }

            FileStream fs = null;
            StreamReader sr = null;
            string StrLine = null;


            try
            {


                fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);  //使用StreamReader类来读取文件 
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                while ((StrLine = sr.ReadLine()) != null)
                {

                    StrLine = StrLine.Trim().ToUpper();
                    if (StrLine.IndexOf("BEGIN") >= 0)
                    {
                        return true;
                    }
                    if (StrLine.IndexOf("TOOL=") >= 0)
                    {
                        StrLine = StrLine.Substring(5, StrLine.Length - 5);
                        string[] data = StrLine.Split(',');
                        if (data == null || data.Length != 6)
                        {
                            return false;
                        }
                        for (int i = 0; i < 6; i++)
                        {
                            if (double.Parse(data[i]) != TxtData.CS8CConfigure.Tool[i])
                            {
                                return false;
                            }
                        }
                        return true;
                        //    return StrLine == ("TOOL=" + TxtData.CS8CConfigure.Tool[0].ToString() + "," + TxtData.CS8CConfigure.Tool[1].ToString() + "," + TxtData.CS8CConfigure.Tool[2].ToString() + ","
                        //                    + TxtData.CS8CConfigure.Tool[3].ToString() + "," + TxtData.CS8CConfigure.Tool[4].ToString() + "," + TxtData.CS8CConfigure.Tool[5].ToString());
                        //}
                    }
                }
                return true;

            }
            catch
            {


                return false;

            }

            finally
            {

                if (sr != null)
                {
                    sr.Close();
                }
                if (fs != null)
                {
                    fs.Close();
                }

            }


        }


        public static bool IsFrame(string FileName, double[] Frame, ref string[] frm)
        {
            if (FileName == null || !File.Exists(FileName) || Frame == null || Frame.Length < 6)
            {
                return false;
            }

            FileStream fs = null;
            StreamReader sr = null;
            string StrLine = null;


            try
            {


                fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);  //使用StreamReader类来读取文件 
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                while ((StrLine = sr.ReadLine()) != null)
                {

                    StrLine = StrLine.Trim().ToUpper();
                    if (StrLine.IndexOf("BEGIN") >= 0)
                    {
                        return true;
                    }
                    if (StrLine.IndexOf("FRAME=") == 0)
                    {
                        StrLine = StrLine.Substring(6, StrLine.Length - 6);
                        string[] data = StrLine.Split(',');
                        if (data == null || data.Length != 6)
                        {
                            return false;
                        }
                        frm = data;
                        for (int i = 0; i < 6; i++)
                        {
                            if (double.Parse(data[i]) != Frame[i])
                            {
                                return false;
                            }
                        }
                        return true;
                        //    return StrLine == ("TOOL=" + TxtData.CS8CConfigure.Tool[0].ToString() + "," + TxtData.CS8CConfigure.Tool[1].ToString() + "," + TxtData.CS8CConfigure.Tool[2].ToString() + ","
                        //                    + TxtData.CS8CConfigure.Tool[3].ToString() + "," + TxtData.CS8CConfigure.Tool[4].ToString() + "," + TxtData.CS8CConfigure.Tool[5].ToString());
                        //}
                    }
                }
                return true;

            }
            catch
            {


                return false;

            }

            finally
            {

                if (sr != null)
                {
                    sr.Close();
                }
                if (fs != null)
                {
                    fs.Close();
                }

            }


        }


        /// <summary>
        /// 读取配置文件
        /// </summary>
        /// <param name="FileName"></param>
        /// <returns></returns>
        static public bool ReadCs8CConfigure(string FileName)
        {
            if (FileName == null || !File.Exists(FileName) || TxtData.CS8CConfigure.EnableItem == null)
            {
                return false;
            }

            FileStream fs = null;
            StreamReader sr = null;
            string StrLine = null;
            string[] data = null;
            int LineCount = 0;
            for (int i = 0; i < TxtData.CS8CConfigure.EnableItem.Length; i++)
            {

                TxtData.CS8CConfigure.EnableItem[i] = false;
            }
            try
            {


                fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);  //使用StreamReader类来读取文件 
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                while ((StrLine = sr.ReadLine()) != null)
                {
                    LineCount++;
                    StrLine = StrLine.Trim().ToUpper();
                    if (StrLine == "")
                    {
                        continue;

                    }

                    //工具
                    if (StrLine.IndexOf("TOOL=") >= 0)
                    {
                        data = StrLine.Substring(5, StrLine.Length - 5).Split(',');
                        if (data == null || data.Length != 6)
                        {
                            return false;
                        }
                        for (int i = 0; i < 6; i++)
                        {
                            TxtData.CS8CConfigure.Tool[i] = double.Parse(data[i]);

                        }
                    }


                    if (StrLine.IndexOf("HOME=") == 0 || StrLine.IndexOf("HOME=") == 1)
                    {
                        if (StrLine.IndexOf("HOME=") == 0)
                        {
                            data = StrLine.Substring(5, StrLine.Length - 5).Split(',');
                        }
                        else
                        {
                            data = StrLine.Substring(6, StrLine.Length - 6).Split(',');
                        }
                       
                        if (data == null || data.Length != 6)
                        {
                            return false;
                        }
                        for (int i = 0; i < 6; i++)
                        {
                            TxtData.CS8CConfigure.Home[i] = double.Parse(data[i]);

                        }
                    }


                    if (StrLine.IndexOf("CORNERDATA=") >= 0)
                    {
                        data = StrLine.Substring(11, StrLine.Length - 11).Split(',');
                        if (data == null || data.Length != 6)
                        {
                            return false;
                        }
                        for (int i = 0; i < 6; i++)
                        {
                            TxtData.CS8CConfigure.Cornerdata[i] = double.Parse(data[i]);

                        }
                    }

                    //异步7轴
                    if (StrLine.IndexOf("EXTAXIS=") == 0)
                    {
                        data = StrLine.Substring(8, StrLine.Length - 8).Split(',');
                        if (data == null || data.Length != 6)
                        {
                            return false;
                        }
                        for (int i = 0; i < 6; i++)
                        {
                            TxtData.CS8CConfigure.ExtAxisData[i] = double.Parse(data[i]);

                        }

                    }
                    //异步8轴
                    if (StrLine.IndexOf("EXT8AXIS=") == 0)
                    {
                        data = StrLine.Substring(9, StrLine.Length - 9).Split(',');
                        if (data == null || data.Length != 6)
                        {
                            return false;
                        }
                        for (int i = 0; i < 6; i++)
                        {
                            TxtData.CS8CConfigure.Ext8AxisData[i] = double.Parse(data[i]);

                        }

                    }


                    if (StrLine.IndexOf("PRESETDATA=") == 0)
                    {
                        data = StrLine.Substring(11, StrLine.Length - 11).Split(',');
                        if (data == null || data.Length != 6)
                        {
                            return false;
                        }
                        for (int i = 0; i < 6; i++)
                        {
                            TxtData.CS8CConfigure.PresetData[i] = double.Parse(data[i]);

                        }

                    }
                    if (StrLine.IndexOf("IODELAY=") == 0)
                    {
                        data = StrLine.Substring(8, StrLine.Length - 8).Split(',');
                        if (data == null || data.Length != 6)
                        {
                            return false;
                        }
                        for (int i = 0; i < 6; i++)
                        {
                            TxtData.CS8CConfigure.IODelay[i] = double.Parse(data[i]);

                        }

                    }
                    //同步7轴
                    if (StrLine.IndexOf("7AXISSYNC=") == 0)
                    {
                        data = StrLine.Substring(10, StrLine.Length - 10).Split(',');
                        if (data == null || data.Length != 6)
                        {
                            return false;
                        }
                        for (int i = 0; i < 6; i++)
                        {
                            TxtData.CS8CConfigure.Sync7Axis[i] = double.Parse(data[i]);

                        }

                    }
                    //同步8轴
                    if (StrLine.IndexOf("8AXISSYNC=") == 0)
                    {
                        data = StrLine.Substring(10, StrLine.Length - 10).Split(',');
                        if (data == null || data.Length != 6)
                        {
                            return false;
                        }
                        for (int i = 0; i < 6; i++)
                        {
                            TxtData.CS8CConfigure.Sync8Axis[i] = double.Parse(data[i]);

                        }

                    }
                    if (StrLine.IndexOf("STEPLENGTH=") >= 0)
                    {
                        string Buff = StrLine.Substring("STEPLENGTH=".Length, StrLine.Length - "STEPLENGTH=".Length);

                        TxtData.CS8CConfigure.StepLength = double.Parse(Buff);


                    }

                    if (StrLine.IndexOf("HOMESPEED=") >= 0)
                    {
                        string Buff = StrLine.Substring("HOMESPEED=".Length, StrLine.Length - "HOMESPEED=".Length);

                        TxtData.CS8CConfigure.HomeSpeed = double.Parse(Buff);


                    }


                    if (StrLine.IndexOf("WELDENABLE=") == 0)
                    {
                        TxtData.CS8CConfigure.EnableItem[1] = (StrLine == "WELDENABLE=TRUE");


                    }
                    if (StrLine.IndexOf("MOVEBACKENABLE=") == 0)
                    {
                        TxtData.CS8CConfigure.EnableItem[2] = (StrLine == "MOVEBACKENABLE=TRUE");


                    }
                    if (StrLine.IndexOf("TEACHTOOLCALENABLE=") >= 0)
                    {
                        TxtData.CS8CConfigure.EnableItem[3] = (StrLine == "TEACHTOOLCALENABLE=TRUE");

                    }


                    if (StrLine.IndexOf("7AXISENABLE=") == 0)
                    {
                        TxtData.CS8CConfigure.EnableItem[6] = (StrLine == "7AXISENABLE=TRUE");


                    }
                    if (StrLine.IndexOf("8AXISENABLE=") == 0)
                    {
                        TxtData.CS8CConfigure.EnableItem[7] = (StrLine == "8AXISENABLE=TRUE");


                    }

                    //
                    if (StrLine.IndexOf("BIGFILEMODE=") == 0)
                    {
                        TxtData.CS8CConfigure.EnableItem[4] = (StrLine == "BIGFILEMODE=TRUE");


                    }


                    if (StrLine.IndexOf("STEPMOVEENABLE=") >= 0)
                    {
                        TxtData.CS8CConfigure.EnableItem[5] = (StrLine == "STEPMOVEENABLE=TRUE");


                    }
                    if (StrLine.IndexOf("BOXCARENABLE=") >= 0)
                    {
                        TxtData.CS8CConfigure.EnableItem[0] = (StrLine == "BOXCARENABLE=TRUE");


                    }

                    //

                    if (StrLine.IndexOf("TRAJFILTERENABLE=") == 0)
                    {
                        TxtData.CS8CConfigure.EnableItem[5] = (StrLine == "TRAJFILTERENABLE=TRUE");


                    }


                    if (StrLine.IndexOf("AUTOADJSUTSPEEDENABLE=") >= 0)
                    {
                        TxtData.CS8CConfigure.EnableItem[0] = (StrLine == "AUTOADJSUTSPEEDENABLE=TRUE");


                    }
                    if (StrLine.IndexOf("MOREPRODUCT1WORKPLACE=") >= 0)
                    {
                        TxtData.CS8CConfigure.EnableItem[4] = (StrLine == "MOREPRODUCT1WORKPLACE=TRUE");


                    }






                }




                return true;
            }
            catch
            {

                // MessageBox.Show(EX.Message);
                return false;

            }

            finally
            {

                if (sr != null)
                {
                    sr.Close();
                }
                if (fs != null)
                {
                    fs.Close();
                }

            }


        }


        static public bool ReadCs8CLog(out string[] Date, out string[] Txt)
        {
            return ReadCs8CLog(out Date, out Txt, Application.StartupPath + "\\Txt\\errors.log");
        }

        static public bool ReadCs8CLog(out string[] Date, out string[] Txt, string FileName)
        {
            Date = null;
            Txt = null;
            if (FileName == null || !File.Exists(FileName))
            {
                return false;
            }

            FileStream fs = null;
            StreamReader sr = null;
            string StrLine = null;
            string[] data = null;
            int LineCount = 0;
            Txt = new string[10000];
            Date = new string[10000];
            int j = 0;
            try
            {

                fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);  //使用StreamReader类来读取文件 
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                while ((StrLine = sr.ReadLine()) != null)
                {
                    LineCount++;
                    StrLine = StrLine.Trim();
                    if (StrLine == "")
                    {
                        continue;

                    }
                    data = StrLine.Split(new char[] { '[', ']' });
                    if (data != null && data.Length >= 3 && j < 10000)
                    {
                        Date[j] = data[1];
                        Txt[j] = data[2];
                        j++;

                    }

                }
                if (j > 0)
                {
                    Array.Resize(ref Txt, j);
                    Array.Resize(ref Date, j);
                }




                return true;
            }
            catch
            {


                return false;

            }

            finally
            {

                if (sr != null)
                {
                    sr.Close();
                }
                if (fs != null)
                {
                    fs.Close();
                }

            }


        }



        static public bool ReadCs8CConfigure()
        {

            return ReadCs8CConfigure(Application.StartupPath + "\\Txt\\Configure.txt");



        }

        //static public bool ReadCs8CConfigure()
        //{

        //    return ReadCs8CConfigure(Application.StartupPath + "\\Txt\\Configure.txt");



        //}

        /// <summary>
        /// 备份下数据库
        /// </summary>
        static public void Init()
        {
            FileStream fs = null;
            if (!Directory.Exists(Application.StartupPath + "\\Log"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\Log");
            }

            if (!Directory.Exists(Application.StartupPath + "\\Txt"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\Txt");
            }
            if (!Directory.Exists(Application.StartupPath + "\\BackUpDB"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\BackUpDB");
            }

            if (!File.Exists("C:\\WINDOWS\\cfg.txt"))
            {
                fs = File.Create("C:\\WINDOWS\\cfg.txt");
                fs.Close();
            }


            //2014.1.14 添加有关
            //对于win7 如何在系统目录中建立文件夹
            if (!File.Exists("C:\\WINDOWS\\timecfg.txt"))
            {
                fs = File.Create("C:\\WINDOWS\\timecfg.txt");
                fs.Close();
            }


            if (File.Exists(Application.StartupPath + "\\Packaging.mdb"))
            {

                File.Copy(Application.StartupPath + "\\Packaging.mdb", Application.StartupPath + "\\BackUpDB\\Packaging(" + DateTime.Now.Year.ToString() + "_" +
                    DateTime.Now.Month.ToString() + "_" + DateTime.Now.Day.ToString() + ").mdb", true);


            }

        }
        public static void FileHidden(string vFileName)
        {
            try
            {
                if (!File.Exists(vFileName))
                {
                    return;
                }
                FileInfo fileInfo = new FileInfo(vFileName);
                fileInfo.Attributes |= FileAttributes.Hidden;

            }
            catch
            {

                return;
            }





        }

        public static void SetAccount(string filePath)
        {

            FileInfo fi = new FileInfo(filePath);
            System.Security.AccessControl.FileSecurity fileSecurity = fi.GetAccessControl();
            fileSecurity.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.FullControl, AccessControlType.Allow));
            fileSecurity.AddAccessRule(new FileSystemAccessRule("Users", FileSystemRights.FullControl, AccessControlType.Allow));
            fi.SetAccessControl(fileSecurity); 
        }


        /// <summary>
        /// 下位机配置文件
        /// </summary>
        /// <param name="FileName"></param>
        /// <returns></returns>
        static public bool ReadXMLConfigure()
        {


           // string cfgPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\timecfg.txt";
            string cfgPath = @"C:\windows\timecfg.txt";
            FileStream fs = null;
            TxtData.XMLConfigure.CanUsedDay = 30;
            TxtData.XMLConfigure.OverTime = true;
            int Days = 0;
            try
            { 
     


                if (!File.Exists(cfgPath))
                {
                    fs = File.Create(cfgPath, 100, System.IO.FileOptions.WriteThrough);
                 //   MessageBox.Show("hello");
                    fs.Close();
                   
                    //return false;
                }

                if (( DateTime.Now - File.GetCreationTime(cfgPath)).Milliseconds < 0)
                {
                   
                    TxtData.XMLConfigure.OverTime = true;
                    TxtData.XMLConfigure.LeftUsedDay = 0;
                    return false;

                }
   

                //********************
                //***********************************************


      



                TxtData.XMLConfigure.SoftWareUsedDay = (DateTime.Now - File.GetCreationTime(cfgPath)).Days;

                if (string.IsNullOrEmpty(TxtData.XMLConfigure.RestrictCode) || TxtData.XMLConfigure.TimeResCodes == null)
               {
                   TxtData.XMLConfigure.CanUsedDay = 30;
                   TxtData.XMLConfigure.OverTime = TxtData.XMLConfigure.SoftWareUsedDay > 30;
                   return false;
                   
               }


                //int Index = Array.IndexOf(TxtData.XMLConfigure.TimeResCodes, TxtData.XMLConfigure.RestrictCode.ToUpper());
                //int Days = 0;
                //if (Index <=0)
                //{
                //    Days = 30;
                //}
                //else
                //{
                //    Days = TxtData.XMLConfigure.Days[Index]*30;
                //}

                //*********************************************************************
                //*********************************************************************
                //2014.10.29
                //最新加密方法
                //加密
                //时间注册码
                if (TxtData.XMLConfigure.RestrictCode.Length>=6)
                {
                    int databuff = TxtData.XMLConfigure.RegCode.ToUpper().IndexOf(TxtData.XMLConfigure.RestrictCode.ToUpper());
                    if (databuff%6==0)
                    {
                        if (databuff>=(24*6))
                        {
                            Days = int.MaxValue;
                        }
                        else
                        {
                            Days = 30 *  ((int)databuff/6+1);
                        }
                       
                    }
                }
                //********************************************************************
              //  MessageBox.Show(Days.ToString());

                TxtData.XMLConfigure.CanUsedDay = Days;
                TxtData.XMLConfigure.OverTime = TxtData.XMLConfigure.SoftWareUsedDay > Days;
                TxtData.XMLConfigure.LeftUsedDay =Days-TxtData.XMLConfigure.SoftWareUsedDay;


                return true;

            }
            catch(Exception EX)
            {
               MessageBox.Show(EX.Message);
                return false;
            }



        }




        /// <summary>
        /// 读取应用程序
        /// </summary>
        /// <param name="data"></param>
        static public void ReadApplication(byte[] data)
        {

            if (data == null || data.Length < 1)
            {
                TxtData.DataBase.InterfaceType = -1;


                return;
            }
            MemoryStream sm = null;
            StreamReader rd = null;
            XmlDocument xd = null;
            try
            {
                sm = new MemoryStream(data);
                sm.Position = 0;
                rd = new StreamReader(sm);
                xd = new XmlDocument();
                xd.LoadXml(rd.ReadToEnd());
                TxtData.DataBase.Upload = StaubliXML.GetXMLBool("bUpload", xd);
                TxtData.DataBase.IsHome = StaubliXML.GetXMLBool("bIsHome", xd);
                TxtData.DataBase.PowerOn = StaubliXML.GetXMLBool("bPowerOn", xd);
                TxtData.DataBase.InterfaceType = StaubliXML.GetXMLInt("nInterfaceType", xd);
                TxtData.DataBase.ToolMode = StaubliXML.GetXMLInt("nToolMode", xd);
                TxtData.DataBase.CurrentJoint = StaubliXML.GetXMLJoint("jCurrentJoint", xd);
                TxtData.DataBase.CurrentPoint = StaubliXML.GetXMLCarten("pCurrentPoint", xd);
                TxtData.DataBase.CycleIndex = (int)StaubliXML.GetXMLDouble("nCycleIndex", xd);
                TxtData.DataBase.CycleCount = (int)StaubliXML.GetXMLDouble("nCycleCount", xd);
                TxtData.DataBase.RobotSpeed = StaubliXML.GetXMLDouble("nRobotSpeed", xd);
                TxtData.DataBase.WorkPlaceCount = StaubliXML.GetXMLInt("nWorkPlaceCount", xd);
                TxtData.DataBase.WorkPlaceIndex = StaubliXML.GetXMLInt("nWorkPlaceIndex", xd);
                TxtData.DataBase.PresetData = StaubliXML.GetXMLIntArray("nPresetData", xd);
                TxtData.DataBase.CycleTime = StaubliXML.GetXMLDouble("nCycleTime", xd);
                TxtData.DataBase.PointType = (int)StaubliXML.GetXMLDouble("nPointType", xd);
                TxtData.DataBase.TrajIndex = (int)StaubliXML.GetXMLDouble("nTrajIndex", xd);


                TxtData.DataBase.Custom = StaubliXML.GetXMLString("sCustom", xd);
                TxtData.DataBase.WorkPlaceProductCount = StaubliXML.GetXMLIntArray("nWpProduct", xd);
                TxtData.DataBase.ProductName = StaubliXML.GetXMLStringArray("sProductName", xd);
                TxtData.DataBase.AirOn = StaubliXML.GetXMLBool("bAirOn", xd);
                TxtData.DataBase.FollowOn = StaubliXML.GetXMLBool("bFollowOn", xd);
                TxtData.DataBase.LaserOn = StaubliXML.GetXMLBool("bLaserOn", xd);
            }
            catch
            {
                return;
            }
            finally
            {
                if (sm != null)
                {
                    sm.Close();
                }
                if (rd != null)
                {
                    rd.Close();
                }

            }


        }

        /// <summary>
        /// Soap轮询
        /// </summary>
        /// <returns></returns>
        static public void Poll()
        {

            //对于变量的轮询
            RobotKit.SoapInstance.SoapRead = new RobotKit.SoapClient(TxtData.XMLConfigure.IpAddress);
            RobotKit.SoapInstance.SoapRead.SoapGetAppname = @"Disk://DataBase/DataBase.pjx";
            RobotKit.SoapInstance.SoapRead.SoapSetAppname = @"Disk://DataBase/DataBase.pjx";
           // TxtData.DataBase.SoapStaus = RobotKit.SoapInstance.SoapRead.Login();
            double PollIndex = 0;
            while (!TxtData.DataBase.SoapAbort)
            {
                PollIndex++;
                if (TxtData.DataBase.SoapStaus)
                {

                    if (RobotKit.SoapInstance.SoapRead.ExistAppname(@"Disk://Packaging/Packaging.pjx"))
                    {
                        System.Threading.Thread.Sleep(10);
                        ReadApplication(RobotKit.SoapInstance.SoapRead.GetAppdata());
                        ReadProductCount();
                    }
                    else
                    {
                        TxtData.DataBase.SoapStaus = RobotKit.SoapInstance.SoapRead.PingNet();
 
                    }
                    //查看温度
                    if (PollIndex % 20 == 0 && TxtData.DataBase.SoapStaus)
                    {
                        System.Threading.Thread.Sleep(100);
                        TxtData.DataBase.ControllerTemp = SoapInstance.SoapRead.ReadIOValue("CBT_TEMP");
                    }

                }
                else
                {
                    PollIndex = 0;
                  //  if (RobotKit.SoapInstance.SoapRead.Ping())
                    if (RobotKit.SoapInstance.SoapRead.PingNet())
                    {
                        TxtData.DataBase.SoapStaus = RobotKit.SoapInstance.SoapRead.Login();

                    }
                    else
                    {
                        TxtData.DataBase.SoapStaus = false;
                    }

                }

                System.Threading.Thread.Sleep(100);
            }

        }
        /// <summary>
        /// 把生产个数给保存下来
        ///  </summary>
        static public void ReadProductCount()
        {


            if (TxtData.DataBase.ProductName != null && TxtData.DataBase.InterfaceType == 9 && TxtData.DataBase.WorkPlaceProductCount != null)
            {
                int len = 0;
                for (int j = 0; j < TxtData.DataBase.WorkPlaceProductCount.Length; j++)
                {
                    len = len + TxtData.DataBase.WorkPlaceProductCount[j];

                }
                if (len == 0)
                {
                    return;
                }
                try
                {

                    DataBaseManage db = new DataBaseManage();
                    for (int i = 1; i <= 4; i++)
                    {
                        if (TxtData.DataBase.ProductName.Length >i && TxtData.DataBase.WorkPlaceProductCount.Length > i && TxtData.DataBase.WorkPlaceProductCount[i] > 0)
                        {
                            db.AddProductCount(i, TxtData.DataBase.Custom, TxtData.DataBase.ProductName[i], TxtData.DataBase.WorkPlaceProductCount[i]);
                            SoapInstance.SoapRead.SetAppdata("nWpProduct[" + i.ToString() + "]", 0);

                        }

                    }

                }
                catch (System.Exception ex)
                {

                }


            }





        }
        public static string GetCpuSerialNumber()
        {
            try
            {
                string strCpu = null;
                ManagementClass myCpu = new ManagementClass("win32_Processor");
                ManagementObjectCollection myCpuConnection = myCpu.GetInstances();
                foreach (ManagementObject myObject in myCpuConnection)
                {
                    strCpu = myObject.Properties["Processorid"].Value.ToString();
                    break;
                }
                return strCpu;
            }
            catch (System.Exception ex)
            {
                return null;
            }

        }
        /// <summary>
        /// 获得硬盘ID
        /// </summary>
        /// <returns></returns>
        public static string GetDiskVolumeSerialNumber()
        {
            try
            {
                ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
                ManagementObject disk = new ManagementObject("win32_logicaldisk.deviceid=\"d:\"");
                disk.Get();
                return disk.GetPropertyValue("VolumeSerialNumber").ToString();
            }
            catch (System.Exception ex)
            {
                return null;
            }

        }

        /// <summary>
        /// 判断系统是32位还是64位
        /// </summary>
        /// <returns></returns>
        public static string Detect3264()
        {
            try
            {


                ConnectionOptions oConn = new ConnectionOptions();
                System.Management.ManagementScope oMs = new System.Management.ManagementScope("\\\\localhost", oConn);
                System.Management.ObjectQuery oQuery = new System.Management.ObjectQuery("select AddressWidth from Win32_Processor");
                ManagementObjectSearcher oSearcher = new ManagementObjectSearcher(oMs, oQuery);
                ManagementObjectCollection oReturnCollection = oSearcher.Get();
                string addressWidth = null;
                foreach (ManagementObject oReturn in oReturnCollection)
                {
                    addressWidth = oReturn["AddressWidth"].ToString();
                }
                return addressWidth;
            }
            catch
            {
                return null;
            }
        }







        public static bool CompareCode(string regcode)
        {
            if (regcode == null || regcode == "")
            {
                return false;
            }
            try
            {
                string toolcode = GetDiskVolumeSerialNumber() + GetCpuSerialNumber();
                string pubkey = "<RSAKeyValue><Modulus>xe3teTUwLgmbiwFJwWEQnshhKxgcasglGsfNVFTk0hdqKc9i7wb+gG7HOdPZLh65QyBcFfzdlrawwVkiPEL5kNTX1q3JW5J49mTVZqWd3w49reaLd8StHRYJdyGAL4ZovBhSTThETi+zYvgQ5SvCGkM6/xXOz+lkMaEgeFcjQQs=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
                string prikey = "<RSAKeyValue><Modulus>xe3teTUwLgmbiwFJwWEQnshhKxgcasglGsfNVFTk0hdqKc9i7wb+gG7HOdPZLh65QyBcFfzdlrawwVkiPEL5kNTX1q3JW5J49mTVZqWd3w49reaLd8StHRYJdyGAL4ZovBhSTThETi+zYvgQ5SvCGkM6/xXOz+lkMaEgeFcjQQs=</Modulus><Exponent>AQAB</Exponent><P>5flMAd7IrUTx92yomBdJBPDzp1Kclpaw4uXB1Ht+YXqwLW/9icI6mcv7d2O0kuVLSWj8DPZJol9V8AtvHkC3oQ==</P><Q>3FRA9UWcFrVPvGR5bewcL7YqkCMZlybV/t6nCH+gyMfbEvgk+p04F+j8WiHDykWj+BahjScjwyF5SGADbrfJKw==</Q><DP>b4WOU1XbERNfF3JM67xW/5ttPNX185zN2Ko8bbMZXWImr1IgrD5RNqXRo1rphVbGRKoxmIOSv7flr8uLrisKIQ==</DP><DQ>otSZlSq2qomgvgg7PaOLSS+F0TQ/i1emO0/tffhkqT4ah7BgE97xP6puJWZivjAteAGxrxHH+kPY0EY1AzRMNQ==</DQ><InverseQ>Sxyz0fEf5m7GrzAngLDRP/i+QDikJFfM6qPyr3Ub6Y5RRsFbeOWY1tX3jmV31zv4cgJ6donH7W2dSBPi67sSsw==</InverseQ><D>nVqofsIgSZltxTcC8fA/DFz1kxMaFHKFvSK3RKIxQC1JQ3ASkUEYN/baAElB0f6u/oTNcNWVPOqE31IDe7ErQelVc4D26RgFd5V7dSsF3nVz00s4mq1qUBnCBLPIrdb0rcQZ8FUQTsd96qW8Foave4tm8vspbM65iVUBBVdSYYE=</D></RSAKeyValue>";

                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {

                    rsa.FromXmlString(pubkey);

                    RSAPKCS1SignatureDeformatter f = new RSAPKCS1SignatureDeformatter(rsa);


                    f.SetHashAlgorithm("SHA1");

                    SHA1Managed sha = new SHA1Managed();

                    byte[] name = sha.ComputeHash(ASCIIEncoding.ASCII.GetBytes(toolcode));
                    byte[] key = Convert.FromBase64String(regcode);

                    return f.VerifySignature(name, key);
                }
            }
            catch
            {
                return false;
            }



        }

        //**************************************************************************************
        //为matlab程序写
        /// <summary>
        /// 读取Matlab生产的文件的机代码
        /// </summary>
        /// <param name="FileName"></param>
        /// <returns></returns>
        static public double [,]  ReadNCFile(string FileName)
        {
            if (FileName == null || !File.Exists(FileName) )
            {
                return null;
            }

            FileStream fs = null;
            StreamReader sr = null;
            string StrLine = null;
            string[] data = null;
            int LineCount = 0;
            int CutCount = ReadNCFileCount(FileName);
            if (CutCount < 1)
            {
                return null;
            }
            double [,] CutData=new double [CutCount,10];
            CutCount = 0;
            try
            {


                fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);  //使用StreamReader类来读取文件 
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                while ((StrLine = sr.ReadLine()) != null)
                {
                    LineCount++;
                    StrLine = StrLine.Trim().ToUpper();
                    if (StrLine == "" || StrLine.IndexOf("G90") >= 0 || StrLine.IndexOf("//") >= 0)
                    {
                        continue;

                    }


                    if (StrLine.IndexOf("N") >= 0)
                    {
                        data = StrLine.Split(' ');
                        if (data == null || data.Length<5)
                        {
                            return null;
                        }
                        for (int i = 0; i < data.Length;i++ )
                        {
                            if (data[i]==null||data[i]=="")
                            {
                                continue;
                            }
                            data[i] = data[i].Trim().ToUpper();
                            if (data[i].IndexOf("N") >= 0)
                            {

                                CutData[CutCount, 1] = double.Parse(data[i].Substring(1,data[i].Length-1));

                            }

                            if (data[i].IndexOf("G") >= 0)
                            {

                                CutData[CutCount,2] = double.Parse(data[i].Substring(1, data[i].Length - 1));

                            }
                            if (data[i].IndexOf("X") >= 0)
                            {
                                CutData[CutCount, 3] = double.Parse(data[i].Substring(1, data[i].Length - 1));


                            }
                            if (data[i].IndexOf("Y") >= 0)
                            {

                                CutData[CutCount, 4] = double.Parse(data[i].Substring(1, data[i].Length - 1));

                            }

                            if (data[i].IndexOf("Z") >= 0)
                            {
                                CutData[CutCount, 5] = double.Parse(data[i].Substring(1, data[i].Length - 1));


                            }
                            if (data[i].IndexOf("A") >= 0)
                            {
                                CutData[CutCount, 6] = double.Parse(data[i].Substring(1, data[i].Length - 1));


                            }
                            if (data[i].IndexOf("B") >= 0)
                            {

                                CutData[CutCount, 7] = double.Parse(data[i].Substring(1, data[i].Length - 1));

                            }

                            if (data[i].IndexOf("U=") >= 0)
                            {

                                CutData[CutCount, 8] = double.Parse(data[i].Substring(2, data[i].Length - 2));

                            }
                            if (data[i].IndexOf("F") >= 0)
                            {
                                CutData[CutCount, 9] = double.Parse(data[i].Substring(1, data[i].Length - 1));


                            }


                        }
                        CutCount++;

        
                    }



                }

               


                return CutData;
            }
            catch
            {

                // MessageBox.Show(EX.Message);
                return null;

            }

            finally
            {

                if (sr != null)
                {
                    sr.Close();
                }
                if (fs != null)
                {
                    fs.Close();
                }

            }


        }


        static private int ReadNCFileCount(string FileName)
        {
            if (FileName == null || !File.Exists(FileName))
            {
                return 0;
            }

            FileStream fs = null;
            StreamReader sr = null;
            string StrLine = null;
            string[] data = null;
            int LineCount = 0;
            int CutCount = 0;
         //   double[,] CutData = new double[10000, 10];
            try
            {


                fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);  //使用StreamReader类来读取文件 
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                while ((StrLine = sr.ReadLine()) != null)
                {
                    LineCount++;
                    StrLine = StrLine.Trim().ToUpper();
                    if (StrLine == "" || StrLine.IndexOf("G90") >= 0 || StrLine.IndexOf("//") >= 0)
                    {
                        continue;

                    }


                    if (StrLine.IndexOf("N") >= 0)
                    {
                        data = StrLine.Split(' ');
                        if (data == null || data.Length < 5)
                        {
                            return 0;
                        }
                        //for (int i = 0; i < data.Length; i++)
                        //{
                        //    if (data[i] == null || data[i] == "")
                        //    {
                        //        continue;
                        //    }
                        //    data[i] = data[i].Trim().ToUpper();
                        //    if (data[i].IndexOf("N") >= 0)
                        //    {

                        //        CutData[CutCount, 1] = double.Parse(data[i].Substring(1, data[i].Length - 1));

                        //    }

                        //    if (data[i].IndexOf("G") >= 0)
                        //    {

                        //        CutData[CutCount, 2] = double.Parse(data[i].Substring(1, data[i].Length - 1));

                        //    }
                        //    if (data[i].IndexOf("X") >= 0)
                        //    {
                        //        CutData[CutCount, 3] = double.Parse(data[i].Substring(1, data[i].Length - 1));


                        //    }
                        //    if (data[i].IndexOf("Y") >= 0)
                        //    {

                        //        CutData[CutCount, 4] = double.Parse(data[i].Substring(1, data[i].Length - 1));

                        //    }

                        //    if (data[i].IndexOf("Z") >= 0)
                        //    {
                        //        CutData[CutCount, 5] = double.Parse(data[i].Substring(1, data[i].Length - 1));


                        //    }
                        //    if (data[i].IndexOf("A") >= 0)
                        //    {
                        //        CutData[CutCount, 6] = double.Parse(data[i].Substring(1, data[i].Length - 1));


                        //    }
                        //    if (data[i].IndexOf("B") >= 0)
                        //    {

                        //        CutData[CutCount, 7] = double.Parse(data[i].Substring(1, data[i].Length - 1));

                        //    }

                        //    if (data[i].IndexOf("U=") >= 0)
                        //    {

                        //        CutData[CutCount, 8] = double.Parse(data[i].Substring(2, data[i].Length - 2));

                        //    }
                        //    if (data[i].IndexOf("F") >= 0)
                        //    {
                        //        CutData[CutCount, 9] = double.Parse(data[i].Substring(1, data[i].Length - 1));


                        //    }


                        //}
                        CutCount++;


                    }



                }




                return CutCount;
            }
            catch
            {

                return 0;

            }

            finally
            {

                if (sr != null)
                {
                    sr.Close();
                }
                if (fs != null)
                {
                    fs.Close();
                }

            }


        }

        static public bool SaveNCFile(string FileName, double[,] data, double[] Tool)
        {
             FileStream fs=null;
            try
            {
                if (FileName == null || data == null || data.Length < 1||data.GetLength(0)<1||Tool==null||Tool.Length!=6)
                {
                    return false;
                }
                fs = new FileStream(FileName, FileMode.Create, FileAccess.Write);
                using (StreamWriter sw = new StreamWriter(fs, Encoding.Default))
                {
                    sw.WriteLine("PRODUCT=TestRecipe");
                    sw.WriteLine("TOOL=" + Tool[0].ToString() + "," + Tool[1].ToString() + ","+Tool[2].ToString()+","+Tool[3].ToString()+","+Tool[4].ToString()+","+Tool[5].ToString());
                    sw.WriteLine("TOTALELEMENTS=1");
                    sw.WriteLine("FRAME=0,0,0,0,0,0");
                    sw.WriteLine("OFFSET=0,0,0,0,0,0");
                    sw.WriteLine("PRESET=StaubliPreset");
                    sw.WriteLine("");
                     sw.WriteLine("");
                     sw.WriteLine("");




                     sw.WriteLine("BEGIN=TestRecipe_1");
                     sw.WriteLine("BYPASS=FALSE");
                     sw.WriteLine("CUTTYPE=10");
                     sw.WriteLine("ARRAY=1,0,1,0,0,0");
                     sw.WriteLine("POINTCOUNT=0,"+data.GetLength(0).ToString()+",0");
                     sw.WriteLine("FRAME=0,0,0,0,0,0");
                     sw.WriteLine("OFFSET=0,0,0,0,0,0");
                     sw.WriteLine("DOWNLEAD=0,0,0,0,0,0");
                     sw.WriteLine("WORKPLACE=0,0,0,0,0,0");


                     sw.WriteLine("DELAYON=0.3");

                    for (int i = 0; i < data.GetLength(0); i++)
                    {

                        sw.WriteLine("MOVEL="+data[i,3].ToString()+","+data[i,4].ToString()+","+data[i,5].ToString()+","+data[i,6].ToString()+","+data[i,7].ToString()+","+data[i,8].ToString()+"/1,0/"
                            + data[i, 9].ToString() + ",15,3" );
                    }

                    sw.WriteLine("DELAYOFF=0");
                    sw.WriteLine("END=TestRecipe_1");
                    sw.WriteLine();


                }
                return true;
            }

            catch
            {
                return false;

            }
            finally
            {

                if (fs!=null)
                {
                    fs.Close();
                        
                }


            }

        }


       
        //***************************************************************************************



    }
}

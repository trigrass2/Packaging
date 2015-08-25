using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using RobotKit;
using StaubliRobot;
using System.Threading;


namespace Packaging
{
    public partial class Frm_Recipe : Std_Form
    {
        DataBaseManage db = new DataBaseManage();
        string[] RecipeName;
        string TrajName;
        int OperIndex = 0;
        string FileName;
        double[] Frame = new double[6];
        int WorkPlace = 1;
        public Frm_Recipe()
        {
            InitializeComponent();
        }

        private void Frm_Recipe_Load(object sender, EventArgs e)
        {
            CBE_RecipeName.Properties.Items.Clear();
            TxtData.PublicData.RecipeName = db.GetRecipeName();
            if (TxtData.PublicData.RecipeName!=null&&TxtData.PublicData.RecipeName.Rank>=1)
            {
           RecipeName = new string[
               (TxtData.PublicData.RecipeName[0] == null ? 0 : TxtData.PublicData.RecipeName[0].Length)
             + (TxtData.PublicData.RecipeName[1] == null ? 0 : TxtData.PublicData.RecipeName[1].Length)
             + (TxtData.PublicData.RecipeName[2] == null ? 0 : TxtData.PublicData.RecipeName[2].Length) 
             + (TxtData.PublicData.RecipeName[3] == null ? 0 : TxtData.PublicData.RecipeName[3].Length)
               ];
            int j = 0;

            for (int i = 0; i < 4; i++)
            {
                if (TxtData.PublicData.RecipeName[i] != null)
                {
                    for (int k = 0; k < TxtData.PublicData.RecipeName[i].Length; k++)
                    {
                        RecipeName[j] = TxtData.PublicData.RecipeName[i][k];
                        j++;
                    }


                }

            }


            CBE_RecipeName.Properties.Items.AddRange((object[])RecipeName);

            

            }
            if (CBE_RecipeName.Properties.Items.Count > 0)
            {
                //2014.10.23
                //删除文件后更新
                if (TxtData.Recipe.AdjustRecipe!=null&&RecipeName!=null&& Array.IndexOf(RecipeName,TxtData.Recipe.AdjustRecipe)>=0)
                {
                    CBE_RecipeName.EditValue = TxtData.Recipe.AdjustRecipe;
                }
                else
                {
                    CBE_RecipeName.EditValue = CBE_RecipeName.Properties.Items[0].ToString();
                    TxtData.Recipe.AdjustRecipe = CBE_RecipeName.Properties.Items[0].ToString();
                }
               
            }
            else
            {
                CBE_RecipeName.EditValue = "";
            }




        }

        private void CBE_RecipeName_TextChanged(object sender, EventArgs e)
        {
            GC_Traj.DataSource = db.GetDV_Traj(CBE_RecipeName.Text);
            if (gv.RowCount > 0)
            {
                //   gv.Columns.
                gv.Columns.Remove(gv.Columns["ID"]);
                gv.Columns.Remove(gv.Columns["RECIPENAME"]);
                gv.Columns.Remove(gv.Columns["TYPENO"]);
                gv.Columns.Remove(gv.Columns["DIAMETER"]);
                gv.Columns.Remove(gv.Columns["DELAY"]);
                gv.Columns.Remove(gv.Columns["SPEED"]);
                gv.Columns.Remove(gv.Columns["BLEND"]);
                gv.Columns.Remove(gv.Columns["FRAME_X"]);
                gv.Columns.Remove(gv.Columns["FRAME_Y"]);
                gv.Columns.Remove(gv.Columns["FRAME_Z"]);
                gv.Columns.Remove(gv.Columns["FRAME_RX"]);
                gv.Columns.Remove(gv.Columns["FRAME_RY"]);
                gv.Columns.Remove(gv.Columns["FRAME_RZ"]);
                gv.Columns.Remove(gv.Columns["OFFSET_X"]);
                gv.Columns.Remove(gv.Columns["OFFSET_Y"]);
                gv.Columns.Remove(gv.Columns["OFFSET_Z"]);
                gv.Columns.Remove(gv.Columns["OFFSET_RX"]);
                gv.Columns.Remove(gv.Columns["OFFSET_RY"]);
                gv.Columns.Remove(gv.Columns["OFFSET_RZ"]);

                gv.Columns.Remove(gv.Columns["ACTION1"]);
                gv.Columns.Remove(gv.Columns["ACTION2"]);
                gv.Columns.Remove(gv.Columns["ACTION3"]);
                gv.Columns.Remove(gv.Columns["ACTION4"]);

                gv.Columns.Remove(gv.Columns["REMARK"]);
                gv.Columns.Remove(gv.Columns["BP1"]);
                gv.Columns.Remove(gv.Columns["BP2"]);
                gv.Columns.Remove(gv.Columns["BP3"]);
                gv.Columns.Remove(gv.Columns["BP4"]);

                gv.Columns.Remove(gv.Columns["ARRAY_XCOUNT"]);
                gv.Columns.Remove(gv.Columns["ARRAY_XOFFSET"]);
                gv.Columns.Remove(gv.Columns["ARRAY_YCOUNT"]);
                gv.Columns.Remove(gv.Columns["ARRAY_YOFFSET"]);
                //gv.Columns.Remove(gv.Columns["OFFSET_X"]);
                //************************************************
                gv.Columns["INDEX"].Caption = "序号";
                gv.Columns["TRAJNAME"].Caption = "路径名称";
                gv.Columns["TYPENAME"].Caption = "路径类型";

                gv.Columns["INDEX"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;



            }
            else
            {
                TrajName = null;
            }
            RecipeInfor();
        }

        void RecipeInfor()
        {
            LL_TrajCount.Text = "路径总个数:" + gv.RowCount.ToString();
            string Remark = null;
            double[] Offset = new double[6];
            TxtData.Recipe.AdjustRecipe = CBE_RecipeName.EditValue.ToString();
            double[] Frame = db.GetRecipe(CBE_RecipeName.EditValue.ToString(), ref Offset, ref Remark, ref WorkPlace);
            if (Frame != null)
            {

                LL_RecipeFrame.Text = "产品坐标系:" + Frame[0].ToString() + "->" + Frame[1].ToString() + "->" + Frame[2].ToString() + "->" + Frame[3].ToString() + "->" + Frame[4].ToString() + "->" + Frame[5].ToString();
                LL_RecipeOffset.Text = "产品偏差  :" + Offset[0].ToString() + "->" + Offset[1].ToString() + "->" + Offset[2].ToString() + "->" + Offset[3].ToString() + "->" + Offset[4].ToString() + "->" + Offset[5].ToString();



                LL_WorkPlace.Text = "工位:" + WorkPlace.ToString();
                LL_RecipeRemark.Text = "说明:" + Remark;

            }
            else
            {
                LL_RecipeFrame.Text = "产品坐标系:";
                LL_RecipeOffset.Text = "产品偏差:";
                LL_WorkPlace.Text = "工位:" + WorkPlace.ToString();
                LL_RecipeRemark.Text = "说明:" + Remark;
            }
        }
        private void ViewPoint(DevExpress.XtraGrid.GridControl gc, DevExpress.XtraGrid.Views.Grid.GridView gv, DataView dv)
        {
            gc.DataSource = dv;
            if (gv.RowCount > 0)
            {

                gv.Columns.Remove(gv.Columns["ID"]);
                gv.Columns.Remove(gv.Columns["TRAJNAME"]);
                gv.Columns.Remove(gv.Columns["TYPENO"]);
                //  gv.Columns.Remove(gv.Columns["TYPENAME"]);
               
                gv.Columns.Remove(gv.Columns["MOVCPOS"]);

                gv.Columns.Remove(gv.Columns["REMARK"]);
                gv.Columns.Remove(gv.Columns["BP1"]);
                gv.Columns.Remove(gv.Columns["BP2"]);
                gv.Columns.Remove(gv.Columns["BP3"]);
                gv.Columns.Remove(gv.Columns["BP4"]);



                if (gv == GV_Appro)
                {
                    gv.Columns.Remove(gv.Columns["BLEND"]);
                    gv.Columns["INDEX"].Caption = "趋近";
                    gv.Columns.Remove(gv.Columns["ACTION"]);
                    gv.Columns.Remove(gv.Columns["PRESET"]);
                }
                if (gv == GV_Cut)
                {
                    gv.Columns["INDEX"].Caption = "切割";
                    gv.Columns["PRESET"].Caption = "工艺";
                    gv.Columns["ACTION"].Caption = "动作";



                    gv.Columns["X/J1"].Caption = "X";
                    gv.Columns["Y/J2"].Caption = "Y";
                    gv.Columns["Z/J3"].Caption = "Z";
                    gv.Columns["RX/J4"].Caption = "RX";
                    gv.Columns["RY/J5"].Caption = "RY";
                    gv.Columns["RZ/J6"].Caption = "RZ";

                }

                if (gv == GV_Leave)
                {
                    gv.Columns.Remove(gv.Columns["BLEND"]);
                    gv.Columns["INDEX"].Caption = "离开";
                    gv.Columns.Remove(gv.Columns["ACTION"]);
                    gv.Columns.Remove(gv.Columns["PRESET"]);
                }




                gv.Columns["TYPENAME"].Caption = "类型";
                gv.Columns["SPEED"].Caption = "速度";
                gv.Columns["ACC"].Caption = "加速度";


                gv.Columns["INDEX"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;


            }



        }



        private void gv_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TrajInfor();
            //   MessageBox.Show(TrajName);
            ViewPoint(GC_Appro, GV_Appro, db.GetDV_BeforeTrajpos(TrajName));
            ViewPoint(GC_Cut, GV_Cut, db.GetDV_Trajpos(TrajName));
            ViewPoint(GC_Leave, GV_Leave, db.GetDV_AfterTrajpos(TrajName));
             LL_PointCount.Text = "点个数:趋近点->" + GV_Appro.RowCount.ToString() + "   切割点-> " + GV_Cut.RowCount.ToString() + "   离开点->" + GV_Leave.RowCount.ToString();
       
        }

        private void BT_New_Click(object sender, EventArgs e)
        {
            Edit_Recipe frm = new Edit_Recipe(true);
            frm.ShowDialog();
            Frm_Recipe_Load(this, null);
            if (frm.RecipeName != "")
            {
                CBE_RecipeName.EditValue = frm.RecipeName;
            }


        }

        private void BT_Delete_Click(object sender, EventArgs e)
        {
            if (CBE_RecipeName.EditValue.ToString() == "")
            {
                MessageBox.Show("无产品");
                return;
            }
            if (MessageBox.Show("确定需要删除产品？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            TxtData.PublicData.ErrorCode = 0;
            OperIndex = 2;
            System.Threading.ThreadPool.QueueUserWorkItem(new WaitCallback(PollImport));
            Frm_Wait frm = new Frm_Wait(CBE_RecipeName.EditValue.ToString(), false);
            frm.ShowDialog();
            Frm_Recipe_Load(this, null);

        }

        private void BT_OutPut_Click(object sender, EventArgs e)
        {
            if (CBE_RecipeName.EditValue.ToString() == "")
            {
                MessageBox.Show("无产品");
                return;
            }
            if ((FileName = PublicFunc.SfD_Show(CBE_RecipeName.EditValue.ToString() + ".txt")) == null)
            {
                return;
            }
            TxtData.PublicData.ErrorCode = 0;
            OperIndex = 1;
            System.Threading.ThreadPool.QueueUserWorkItem(new WaitCallback(PollImport));
            Frm_Wait frm = new Frm_Wait(CBE_RecipeName.EditValue.ToString(), false);
            frm.ShowDialog();
        }

        private void BT_Import_Click(object sender, EventArgs e)
        {
            if (gv.RowCount != 0)
            {
                MessageBox.Show("产品已存在路径");
                return;
            }
            if (CBE_RecipeName.EditValue.ToString()==""||Frame==null)
            {
                MessageBox.Show("请先建立产品");
                return;
            }
            if ((FileName = PublicFunc.OpenDir_Show()) == null)
            {
                return;
            }
            string[] frm = new string[6];

            if (!PublicFunc.IsFrame(FileName, Frame,ref frm))
            {
                if (MessageBox.Show(
                    "导入文本中的产品坐标系不一致，是否继续导入?"+"\n新建产品坐标系是:"
                    + Frame[0].ToString() + ","  +Frame[1].ToString() + "," + Frame[2].ToString() + "," + Frame[3].ToString() + ","
                      + Frame[4].ToString() + "," +Frame[5].ToString() +"\n文本坐标系是:"
                    + frm[0].ToString() + ","  +frm[1].ToString() + "," + frm[2].ToString() + "," + frm[3].ToString() + ","
                      + frm[4].ToString() + "," +frm[5].ToString(),"产品坐标系不一致",MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }


            }

            TxtData.PublicData.ErrorCode = 0;
            TxtData.PublicData.ErrorLine = 0;
            OperIndex = 3;
            System.Threading.ThreadPool.QueueUserWorkItem(new WaitCallback(PollImport));
            Frm_Wait frM = new Frm_Wait(CBE_RecipeName.EditValue.ToString(), false);
            frM.ShowDialog();
            CBE_RecipeName_TextChanged(this, null);
        }


        void PollImport(object target)
        {
            DataBaseManage db = new DataBaseManage();
            switch (OperIndex)
            {
                //导出
                case 1:
                    {

                        TxtData.PublicData.ErrorCode = (db.SaveProduct(FileName, CBE_RecipeName.EditValue.ToString())) ? 40 : 34;

                        break;
                    }
                //删除产品
                case 2:
                    {
                        TxtData.PublicData.ErrorCode = (db.DeleteRecipe(CBE_RecipeName.EditValue.ToString())) ? 40 : 32;
                        break;
                    }
                //导入
                case 3:
                    {
                        if (PublicFunc.SaveNCFile(Application.StartupPath + "\\Txt\\NCFile.txt", PublicFunc.ReadNCFile(FileName),TxtData.CS8CConfigure.Tool))
                        {

                            FileName = Application.StartupPath + "\\Txt\\NCFile.txt";


                        }


                        TxtData.PublicData.ErrorCode = PublicFunc.IsTool(FileName)? 0 : 41;
                        if (TxtData.PublicData.ErrorCode != 0)
                        {
                            return;
                        }
                        TxtData.PublicData.ErrorLine=db.ImportProduct(FileName, CBE_RecipeName.EditValue.ToString());
                        TxtData.PublicData.ErrorCode = (TxtData.PublicData.ErrorLine== 0) ? 40 : 20;
                       // return;
                        break;
                    }
                //删除路径
                case 4:
                    {
                        //2013.11.19
                        //TxtData.PublicData.ErrorCode = (db.DeleteTraj(TrajName,true)) ? 40 : 32;
                        TxtData.PublicData.ErrorCode = (db.DeleteTraj(CBE_RecipeName.EditValue.ToString(),TxtData.PublicData.DeleteTrajIndex)) ? 40 : 32;
                        break;
                    }


            }




        }


        private void BT_RecipeEdit_Click(object sender, EventArgs e)
        {
            if (CBE_RecipeName.EditValue.ToString() == "")
            {
                MessageBox.Show("无产品");
                return;
            }
            Edit_Recipe frm = new Edit_Recipe(CBE_RecipeName.EditValue.ToString());
            frm.ShowDialog();
            RecipeInfor();
        }

        private void BT_Cs8c_Click(object sender, EventArgs e)
        {
            if (CBE_RecipeName.EditValue.ToString() == "")
            {
                MessageBox.Show("无产品");
                return;
            } 
            if (!TxtData.XMLConfigure.Reged&&CBE_RecipeName.Properties.Items.Count>4)
             {
                 MessageBox.Show("软件未注册，请注册！\n未注册产品总个数不能超过4个！");
                 return;

             }
                         
            
            
            
            if (TxtData.DataBase.InterfaceType != 9)
            {
                MessageBox.Show("下位机请切换到主界面!");
                return;
            }

            if (TxtData.DataBase.ToolMode != 1)
            {
                MessageBox.Show("请切换到手动模式!");
                return;
            }

            //2013.12.25
            //添加对剩余时间的支持

            if (TxtData.XMLConfigure.LeftUsedDay < 7 && TxtData.XMLConfigure.LeftUsedDay>=1)
            {
                MessageBox.Show("软件剩余使用天数是" + TxtData.XMLConfigure.LeftUsedDay.ToString() + "天");

            }
            TxtData.PublicData.ErrorCode = 0;
            System.Threading.ThreadPool.QueueUserWorkItem(new WaitCallback(Poll));
            Frm_Wait frm = new Frm_Wait(CBE_RecipeName.EditValue.ToString());
            frm.ShowDialog();
            CBE_RecipeName_TextChanged(this, null);

        }

        private void BT_ReicpeFrame_Click(object sender, EventArgs e)
        {
            if (CBE_RecipeName.EditValue.ToString() == "")
            {
                MessageBox.Show("无产品");
                return;
            }
            if (TxtData.DataBase.InterfaceType != 9)
            {
                MessageBox.Show("下位机请切换到主界面!");
                return;
            }

            if (TxtData.DataBase.ToolMode != 1)
            {
                MessageBox.Show("请切换到手动模式!");
                return;
            }
            if (!SoapInstance.SoapRead.SetAppdata("sProductName", CBE_RecipeName.EditValue.ToString()))
            {
                MessageBox.Show("设置下位机数据出错!");
                return;
            }
            if (!SoapInstance.SoapRead.SetAppdata("nInterfaceType", 10))
            {
                MessageBox.Show("设置下位机数据出错!");
                return;
            }
            //while (TxtData.DataBase.InterfaceType == 9)
            //{
            //    System.Threading.Thread.Sleep(10);
            //}
            TxtData.PublicData.ErrorCode = 0;
            Frm_Wait frm = new Frm_Wait(CBE_RecipeName.EditValue.ToString(),true);
            frm.ShowDialog();
            RecipeInfor();


        }

        private void BT_RecipeOffset_Click(object sender, EventArgs e)
        {
            if (CBE_RecipeName.EditValue.ToString() == "")
            {
                MessageBox.Show("无产品");
                return;
            }
            if (TxtData.DataBase.InterfaceType != 9)
            {
                MessageBox.Show("下位机请切换到主界面!");
                return;
            }

            if (TxtData.DataBase.ToolMode != 1)
            {
                MessageBox.Show("请切换到手动模式!");
                return;
            }

            if (!SoapInstance.SoapRead.SetAppdata("sProductName", CBE_RecipeName.EditValue.ToString()))
            {
                MessageBox.Show("设置下位机数据出错!");
                return;
            }

            if (!SoapInstance.SoapRead.SetAppdata("nInterfaceType", 11))
            {
                MessageBox.Show("设置下位机数据出错!");
                return;
            }
            //while (TxtData.DataBase.InterfaceType == 9)
            //{
            //    System.Threading.Thread.Sleep(10);
            //}
            TxtData.PublicData.ErrorCode = 0;
            Frm_Wait frm = new Frm_Wait(CBE_RecipeName.EditValue.ToString(),true);
            frm.ShowDialog();
            RecipeInfor();


        }
        void TrajInfor()
        {

            if (gv.RowCount==0||gv.GetSelectedRows().Length<1)
            {
                return;
            }

       
            double[] Offset = new double[6];
            double[] Array = new double[6];
            double[] Downlead = new double[6];
            double[] Axis = new double[6];
            double[] Para = new double[6];


            string Remark = "";
         //   string TrajName = "";
            string TypeName = "";
            string[] DownleadType = new string[] { "无","直线","圆弧"};
            DataBaseManage db = new DataBaseManage();

            if (db.GetTraj(CBE_RecipeName.EditValue.ToString(), gv.GetSelectedRows()[0] + 1, ref TrajName, ref TypeName, ref Frame, ref Offset,
                ref Array, ref Downlead,ref Axis, ref Para, ref Remark))
            {


                //LL_RecipeFrame.Text = "用户坐标系:" + "X->" + Frame[0].ToString() + " Y->" + Frame[1].ToString() + " Z->" + Frame[2].ToString() + "  RX->" + Frame[3].ToString() + "  RY->" + Frame[4].ToString() + "  RZ->" + Frame[5].ToString();
                //LL_RecipeOffset.Text = "产品偏差:" + "X->" + Offset[0].ToString() + " Y->" + Offset[1].ToString() + " Z->" + Offset[2].ToString() + "  RX->" + Offset[3].ToString() + "  RY->" + Offset[4].ToString() + " RZ->" + Offset[5].ToString();


                LL_TrajFrame.Text = "路径坐标系:" + Frame[0].ToString() + "->" + Frame[1].ToString() + "->" + Frame[2].ToString() + "->" + Frame[3].ToString() + "->" + Frame[4].ToString() + "->" + Frame[5].ToString();
                LL_TrajOffset.Text = "路径偏差  :" + Offset[0].ToString() + "->" + Offset[1].ToString() + "->" + Offset[2].ToString() + "->" + Offset[3].ToString() + "->" + Offset[4].ToString() + "->" + Offset[5].ToString();
                LL_TrajRemark.Text = "路径说明:" + Remark;
                LL_TrajArray.Text = "路径阵列:" + Array[0].ToString() + "->" + Array[1].ToString() + "->" + Array[2].ToString() + "->" + Array[3].ToString() + "->" + Array[4].ToString() + "->" + Array[5].ToString();
                LL_Circle.Text = "圆直径:"+Downlead[4].ToString()+"  圆弧度(焊):"+Downlead[5].ToString();
                LL_Delay.Text = "延时:" + "激光开->" + Para[0].ToString() + "    激光关->" + Para[1].ToString();
                LL_DownLead.Text = "引线配置:引入->" +DownleadType[ (int)Downlead[0]] + "    引出->" +DownleadType[ (int)Downlead[2]];


            }
            else
            {
                TrajName = null;
                LL_TrajFrame.Text = "路径坐标系:";
                LL_TrajOffset.Text = "路径偏差  :";
                LL_TrajRemark.Text = "路径说明:";
                LL_TrajArray.Text = "路径阵列:";
                LL_Circle.Text = "圆弧度配置:";
                LL_Delay.Text = "延时:";
                LL_DownLead.Text = "引线配置:";
            }









        }
        void Poll(object target)
        {
            DataBaseManage db = new DataBaseManage();
            if (!db.SavePreset())
            {
                TxtData.PublicData.ErrorCode = 1;
                return;
            }

            if (!db.SaveAction())
            {
                TxtData.PublicData.ErrorCode = 2;
                return;
            }
            if (!db.SaveProduct(CBE_RecipeName.EditValue.ToString()))
            {
                TxtData.PublicData.ErrorCode = 34;
                return;
            }

                        
            FtpClient ftp = new FtpClient(TxtData.XMLConfigure.IpAddress);
          //*******************************************
            //匹配tool  2013.10.15
            //匹配home
            if (!ftp.DownLoadConfigure()||!PublicFunc.ReadCs8CConfigure())
            {
                TxtData.PublicData.ErrorCode = 43;
                return;
            }

            double[] tool = db.GetTool();
            if (tool==null||tool.Length!=6||TxtData.CS8CConfigure.Tool==null||TxtData.CS8CConfigure.Tool.Length!=6)
            {
                TxtData.PublicData.ErrorCode = 42;
                return;
            }
            for (int i = 0; i < 6;i++)
            {
                if (tool[i]!=TxtData.CS8CConfigure.Tool[i])
                {
                    TxtData.PublicData.ErrorCode = 42;
                    return;
                }
            }

            //home
            double[] home = db.GetHome();
            if (home == null || home.Length != 6 || TxtData.CS8CConfigure.Home== null || TxtData.CS8CConfigure.Home.Length != 6)
            {
                TxtData.PublicData.ErrorCode = 44;
                return;
            }
            for (int i = 0; i < 6; i++)
            {
                if (home[i] != TxtData.CS8CConfigure.Home[i])
                {
                    TxtData.PublicData.ErrorCode = 44;
                    return;
                }
            }






            //**************************************
            if (!ftp.UpLoadPreset())
            {
                TxtData.PublicData.ErrorCode = 21;
                return;
            }
            if (!ftp.UploadAction())
            {
                TxtData.PublicData.ErrorCode = 22;
                return;
            }
            if (!ftp.UpLoadRecipe())
            {
                TxtData.PublicData.ErrorCode = 23;
                return;
            }

            if (TxtData.CS8CConfigure.EnableItem[7] || TxtData.CS8CConfigure.EnableItem[6])
            {

                if (!SoapInstance.SoapRead.SetAppdata("nWorkPlaceIndex", WorkPlace))
                {
                    TxtData.PublicData.ErrorCode = 24;
                    return;
                }


            }


            if (!SoapInstance.SoapRead.SetAppdata("nInterfaceType", 5))
            {
                TxtData.PublicData.ErrorCode = 24;
                return;
            }
            db.AddLog("调试产品"+CBE_RecipeName.Text);
            while (TxtData.DataBase.InterfaceType == 9)
            {
                System.Threading.Thread.Sleep(10);
            }
            TxtData.PublicData.ErrorCode = 40;
        }

        private void BT_TrajEdit_Click(object sender, EventArgs e)
        {
            if (gv.GetFocusedDataSourceRowIndex() < 0 || gv.RowCount < 1)
            {
                MessageBox.Show("没有路径");
                return;
            }
            Edit_Traj frm = new Edit_Traj(CBE_RecipeName.EditValue.ToString(), gv.GetSelectedRows()[0] + 1);
            frm.ShowDialog();
            TrajInfor();

        }

        private void BT_Speed_Click(object sender, EventArgs e)
        {
            if (gv.GetFocusedDataSourceRowIndex() < 0 || gv.RowCount < 1)
            {
                MessageBox.Show("没有路径");
                return;
            }
            Batch_Speed frm = new Batch_Speed(CBE_RecipeName.EditValue.ToString());
            frm.ShowDialog();
            CBE_RecipeName_TextChanged(this, null);

        }

        private void BT_TrajDelete_Click(object sender, EventArgs e)
        {
            if (gv.GetFocusedDataSourceRowIndex() < 0 || gv.RowCount < 1)
            {
                MessageBox.Show("没有路径");
                return;
            }
            //2013.11.19
            //添加批处理删除路径

            Batch_DeleteTraj frmChoose = new Batch_DeleteTraj(CBE_RecipeName.EditValue.ToString(), gv.GetSelectedRows()[0]);
            frmChoose.ShowDialog();
            if (TxtData.PublicData.DeleteTrajIndex==null)
            {
                return;
            }



            if (MessageBox.Show("确定需要删除路径吗？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            TxtData.PublicData.ErrorCode = 0;
            OperIndex = 4;
            System.Threading.ThreadPool.QueueUserWorkItem(new WaitCallback(PollImport));
            Frm_Wait frm = new Frm_Wait(CBE_RecipeName.EditValue.ToString(), false);
            frm.ShowDialog();
            CBE_RecipeName_TextChanged(this, null);
        }

        private void BT_EditSequ_Click(object sender, EventArgs e)
        {
            if (gv.GetFocusedDataSourceRowIndex() < 0 || gv.RowCount < 1)
            {
                MessageBox.Show("没有路径");
                return;
            }
            Edit_Sequen frm = new Edit_Sequen(CBE_RecipeName.EditValue.ToString());
            frm.ShowDialog();
            CBE_RecipeName_TextChanged(this, null);
        }

        private void BT_Batch_Click(object sender, EventArgs e)
        {
            if (gv.GetFocusedDataSourceRowIndex() < 0 || gv.RowCount < 1)
            {
                MessageBox.Show("没有路径");
                return;
            }
            Batch_Traj frm = new Batch_Traj(CBE_RecipeName.EditValue.ToString());
            frm.ShowDialog();
            CBE_RecipeName_TextChanged(this, null);

        }

        private void BT_Cut_Click(object sender, EventArgs e)
        {
            if (GV_Cut.GetFocusedDataSourceRowIndex() < 0 || GV_Cut.RowCount < 1)
            {
                MessageBox.Show("没有路径");
                return;
            }
         //   Edit_Cut frm = new Edit_Cut(TrajName, GV_Cut.GetSelectedRows()[0] + 1);
            Batch_TrajPos frm = new Batch_TrajPos(TrajName);
            frm.ShowDialog();
            ViewPoint(GC_Cut, GV_Cut, db.GetDV_Trajpos(TrajName));
        }

    }
}

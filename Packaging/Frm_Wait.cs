using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress;
using StaubliRobot;
using System.Xml;
using System.IO;
using System.Threading;
using RobotKit;
namespace Packaging
{
    public partial class Frm_Wait : Std_Form
    {
        DataBaseManage db=new DataBaseManage();
        string[] Error=new string[101];
        bool NeedUpload=false;
        string RecipeName="";
        bool IsUpload = false;
        FtpClient ftp;
        public Frm_Wait()
        {
            //DevExpress.Data.CurrencyDataController.DisableThreadingProblemsDetection = true;
            InitializeComponent();


     
        }
        public Frm_Wait(bool WaitLoad)
        {
            InitializeComponent();
            NeedUpload = true;
          
        }
        public Frm_Wait(string recipe,bool WaitLoad)
        {
            InitializeComponent();
            NeedUpload = WaitLoad;
            RecipeName = recipe;
           
        }
        public Frm_Wait(string recipe)
        {
            InitializeComponent();
            NeedUpload = true;
            RecipeName = recipe;
           
        }


        private void BT_OK_Click(object sender, EventArgs e)
        {
            this.timer_Refresh.Enabled = false;
            this.Close();
        }

        private void timer_Refresh_Tick(object sender, EventArgs e)
        {
            Frm_Wait_Load(this,null);
          //  this.Text = TxtData.DataBase.Upload.ToString();
            if (IsUpload)
            {
                PP_process.Caption = "请等待";
                PP_process.Description = "正在上传...";

                return;
            }
            if (TxtData.PublicData.ErrorCode!=0)
            {

                if (TxtData.PublicData.ErrorCode==40)
                {
                    if (!NeedUpload)
                    {
                        this.timer_Refresh.Enabled = false;
                        this.Close();
                        return;
                    }
              
                }
                else
                {
                 
                    PP_process.Caption = "报错";
                    PP_process.Description ="信息:"+Error[TxtData.PublicData.ErrorCode];//.ToString();
                    timer_Refresh.Enabled = false;
                    return;
                }




            }

            if (NeedUpload && TxtData.DataBase.InterfaceType == 9)
            {
                PP_process.Caption = "提示:";
                PP_process.Description = "信息:下位机处在等待界面";
                return;
            }

            PP_process.Caption = "请等待";
            PP_process.Description = "程序正在运行...";

            #region 需要上传
            if (TxtData.DataBase.Upload&&NeedUpload)
            {
                PP_process.Caption = "请等待";
                PP_process.Description = "正在保存文件...";
                if (File.Exists(Application.StartupPath + "\\Txt\\Recipe.txt"))
                {
                    File.Delete(Application.StartupPath + "\\Txt\\Recipe.txt");
                }
                if (File.Exists(Application.StartupPath + "\\Txt\\Configure.txt"))
                {
                    File.Delete(Application.StartupPath + "\\Txt\\Configure.txt");
                }

                if (File.Exists(Application.StartupPath + "\\Txt\\Preset.txt"))
                {
                    File.Delete(Application.StartupPath + "\\Txt\\Preset.txt");
                }
                if (File.Exists(Application.StartupPath + "\\Txt\\Action.txt"))
                {
                    File.Delete(Application.StartupPath + "\\Txt\\Action.txt");
                }

                 ftp = new FtpClient(TxtData.XMLConfigure.IpAddress);
                 string Strdate = "_" + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();

                switch (TxtData.DataBase.InterfaceType)
                {
                     //保存工艺
                    case 3:
                        {
                            TxtData.PublicData.ErrorCode = ftp.DownLoadPreset() ? 0 : 13;
                            if (TxtData.PublicData.ErrorCode==0)
                            {

                                TxtData.PublicData.ErrorCode = (db.ImportPreset(Application.StartupPath + "\\Txt\\Preset.txt","StaubliPreset") == 0) ? 0 : 17;
                                File.Copy(Application.StartupPath + "\\Txt\\Preset.txt", Application.StartupPath + "\\Log\\Preset" + Strdate + ".txt",true);
                            }
                      

                            break;


                        }


                        //动作
                    case 4:
                        {
                            TxtData.PublicData.ErrorCode = ftp.DownLoadAction() ? 0 : 14;
                            if (TxtData.PublicData.ErrorCode == 0)
                            {
                                TxtData.PublicData.ErrorCode = (db.ImportAction(Application.StartupPath+"\\Txt\\Action.txt")==0) ? 0 : 18;
                                File.Copy(Application.StartupPath + "\\Txt\\Action.txt", Application.StartupPath + "\\Log\\Action" + Strdate + ".txt", true);
                            }
                      
                       
                            break;


                        }
                        //产品
                    case 5:
                        {
                            IsUpload = true;
                            System.Threading.ThreadPool.QueueUserWorkItem(new WaitCallback(Poll));
                            return;

                        }

                    case 10:
                        {
                            TxtData.Recipe.RecipeFrame = RobotKit.StaubliXML.GetXMLCarten("fFrame", SoapInstance.SoapRead.GetAppdata());
                            TxtData.PublicData.ErrorCode =(TxtData.Recipe.RecipeFrame!=null) ? 0 : 36;
                            if (TxtData.PublicData.ErrorCode == 0)
                            {
                                TxtData.PublicData.ErrorCode = db.EditRecipeFrame(RecipeName,TxtData.Recipe.RecipeFrame)? 0 : 37;
                            }


                            break;
                            

                        }

                    case 11:
                        {
                            TxtData.Recipe.RecipeFrame = RobotKit.StaubliXML.GetXMLCarten("fOffset",SoapInstance.SoapRead.GetAppdata());
                            TxtData.PublicData.ErrorCode =(TxtData.Recipe.RecipeFrame != null) ? 0 : 36;
                            if (TxtData.PublicData.ErrorCode == 0)
                            {
                                TxtData.PublicData.ErrorCode = db.EditRecipeOffset(RecipeName, TxtData.Recipe.RecipeFrame) ? 0 : 37;
                            }
                            break;


                        }
                    case 7:
                    case 12:
                    case 14:
                    case 15:
                    case 16:
                    case 17:
                    case 18:
                    case 19:
                        {
                            TxtData.PublicData.ErrorCode = ftp.DownLoadConfigure() ? 0 : 15;
                            if (TxtData.PublicData.ErrorCode == 0)
                            {
                                TxtData.PublicData.ErrorCode = db.ImportConfigure() == 0 ? 0 : 19;
                                File.Copy(Application.StartupPath + "\\Txt\\Configure.txt", Application.StartupPath + "\\Log\\Configure" + Strdate + ".txt", true);
                            }
                      
                         
                            break;


                        }



                   
                }
                if (TxtData.PublicData.ErrorCode==0)
                {

                    TxtData.PublicData.ErrorCode = RobotKit.SoapInstance.SoapRead.SetAppdata("bUpload",false)?0:12;
                    

                }
                if (TxtData.PublicData.ErrorCode == 0)
                {
                    PP_process.Caption = "成功";
                    PP_process.Description = "信息:文件上传成功";

                    while (TxtData.DataBase.Upload)
                    {
                        System.Threading.Thread.Sleep(10);
                    }


                }

            }
            #endregion

        }
        private void Poll(object target)
        {
            TxtData.PublicData.ErrorCode = ftp.DownLoadRecipe() ? 0 : 16;
            if (TxtData.PublicData.ErrorCode == 0)
            {

                //2014.12.03
                //注释掉检查文本格式
              //  TxtData.PublicData.ErrorCode = PublicFunc.IsRecipeOk(Application.StartupPath + "\\Txt\\Recipe.txt") ? 0 : 33;
                //
            }
            if (TxtData.PublicData.ErrorCode == 0)
            {
                TxtData.PublicData.ErrorCode = db.ExistRecipe(RecipeName) ? 0 : 45;
            }

            if (TxtData.PublicData.ErrorCode == 0)
            {
                TxtData.PublicData.ErrorCode = db.DeleteAllTraj(RecipeName) ? 0 : 38;
            }

            if (TxtData.PublicData.ErrorCode == 0)
            {
                TxtData.PublicData.ErrorLine = db.ImportProduct(Application.StartupPath + "\\Txt\\Recipe.txt", RecipeName);
                TxtData.PublicData.ErrorCode = (TxtData.PublicData.ErrorLine == 0) ? 0 : 20;
               // TxtData.PublicData.ErrorCode = (db.ImportProduct(Application.StartupPath + "\\Txt\\Recipe.txt", RecipeName) == 0) ? 0 : 20;
            }
            if (TxtData.PublicData.ErrorCode == 0)
            {

                TxtData.PublicData.ErrorCode = RobotKit.SoapInstance.SoapRead.SetAppdata("bUpload", false) ? 0 : 12;


            }
            if (TxtData.PublicData.ErrorCode == 0)
            {
 

                while (TxtData.DataBase.Upload)
                {
                    System.Threading.Thread.Sleep(10);
                }


            }
            IsUpload = false;
        }
        private void Frm_Wait_Load(object sender, EventArgs e)
        {
            Error[0] = "正在设置参数";
            Error[1] = "数据库导出离散工艺文件出错";
            Error[2] = "数据库导出动作文件出错";
            Error[3] = "数据库导出配置文件出错";
            Error[4] = "数据库导出工位1生产文件出错";
            Error[5] = "数据库导出工位2生产文件出错";
            Error[6] = "数据库导出工位3生产文件出错";
            Error[7] = "数据库导出工位4生产文件出错";
            Error[8] = "数据库导出工位1工艺文件出错";
            Error[9] = "数据库导出工位2工艺文件出错";
            Error[10] = "数据库导出工位3工艺文件出错";
            Error[11] = "数据库导出工位4工艺文件出错";
            Error[12] = "Soap设置下位机数据出错";
            Error[13] = "ftp下载离散工艺文件出错";
            Error[14] = "ftp下载动作文件出错";
            Error[15] = "ftp下载配置文件出错";
            Error[16] = "ftp下载调试文件出错";
            Error[17] = "数据库导入离散工艺文件出错";
            Error[18] = "数据库导入动作文件出错";
            Error[19] = "数据库导入配置文件出错";
            Error[20] = "生产文本"+TxtData.PublicData.ErrorLine.ToString()+"行出错";
            Error[21] = "ftp上传离散工艺文件出错";
            Error[22] = "ftp上传动作文件出错";
            Error[23] = "ftp上传配置文件出错";
            Error[24] = "ftp上传工位1生产文件出错";
            Error[25] = "ftp上传工位2生产文件出错";
            Error[26] = "ftp上传工位3生产文件出错";
            Error[27] = "ftp上传工位4生产文件出错";
            Error[28] = "ftp上传工位1工艺文件出错";
            Error[29] = "ftp上传工位2工艺文件出错";
            Error[30] = "ftp上传工位3工艺文件出错";
            Error[31] = "ftp上传工位4工艺文件出错";
            Error[32] = "删除产品文件出错";
            Error[33] = "产品格式不正确";
            Error[34] = "数据库导出调试文件出错";
            Error[35] = "删除log文件出错 ";
            Error[36] = "Soap读取下位机数据出错";
            Error[37] = "编辑数据库出错";
            Error[38] = "删除路径出错";
            Error[39] = "数据库导入速度匹配工艺出错";
            Error[40] = "成功";
            Error[41] = "导入文本TCP与数据库TCP不一致";
            Error[42] = "下位机TCP与数据库TCP不一致";
            Error[43] = "读取下位机配置不正确";
            Error[44] = "下位机home与数据库home不一致";
            Error[45] = "产品名称不存在";
        }
    }
}

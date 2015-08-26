using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;

//
using DevExpress.XtraNavBar;
using RobotKit;
using StaubliRobot;
using System.IO;
using System.Diagnostics;
using System.Threading;


namespace Packaging
{
    public partial class Frm_Main : RibbonForm
    {
        Thread poll = null;
        DataBaseManage db =null;
        public Frm_Main()
        {
            //卸载与安装
            if (!File.Exists(Application.StartupPath+"\\Packaging.mdb")&&File.Exists(Application.StartupPath+"\\Backup\\Packaging.mdb"))
            {
                File.Copy(Application.StartupPath + "\\Backup\\Packaging.mdb", Application.StartupPath + "\\Packaging.mdb",true);
            }

            //2013.11.20
            //检查数据库是否存在

            if (!File.Exists(Application.StartupPath + "\\Packaging.mdb"))
            {
                MessageBox.Show("程序根目录中数据库文件Packaging.MDB不存在");
                System.Environment.Exit(System.Environment.ExitCode);
                this.Dispose();
                this.Close();
                return;
            }

            PublicFunc.Init();
            DevExpress.Data.CurrencyDataController.DisableThreadingProblemsDetection = true;
           // PublicFunc.ReadXMLConfigure();

            InitializeComponent();
            BI_ListClose_ItemClick(this, null);
            TE_Title.Text = "Packaging";
            RC_Main.DefaultPageCategory.Expanded = true;
            RC_Main.Minimized = true;
            InitSkinGallery();



            db = new DataBaseManage();

            TxtData.XMLConfigure.RegCode = db.GetRegCode();
            TxtData.XMLConfigure.Reged =PublicFunc.CompareCode(TxtData.XMLConfigure.RegCode);
            db.SaveCs8cConfigure();
            PublicFunc.ReadCs8CConfigure();

            db.GetIp(ref TxtData.XMLConfigure.IpAddress, ref TxtData.XMLConfigure.RestrictCode);
            db.GetPopedom(ref TxtData.PublicData.ScreenEnable);
    
            TxtData.XMLConfigure.User = db.GetAutoLogin();


            if (TxtData.XMLConfigure.User != null)
            {
                TxtData.XMLConfigure.Login = true;
                TxtData.XMLConfigure.PopeDom = db.GetUserPopm(TxtData.XMLConfigure.User);
                db.AddLog(TxtData.XMLConfigure.User + "登录");

            }
            PublicFunc.ReadXMLConfigure();


            poll = new Thread(new ThreadStart(PublicFunc.Poll));
            poll.Start();

        }
  

    
        /// <summary>
        /// 终止程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iExit_ItemClick(object sender, ItemClickEventArgs e)
        {


            this.Close();
           

        }



        //机械手臂信息
        private void BI_RobotImfor_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SetFrmPanel(this.SCC_ChindMain.Panel2, new Frm_Infor());
            SetTitle(sender);
            TE_Title.Text = "Packaging";

        }

        /// <summary>
        /// 系统配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BI_RobPostion_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (!TxtData.XMLConfigure.Login||!TxtData.PublicData.ScreenEnable[TxtData.XMLConfigure.PopeDom,0])
            {
                return;}

            SetFrmPanel(this.SCC_ChindMain.Panel2, new Frm_SysConfig());
            SetTitle(sender);
        }


        //动作
        private void BI_Action_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (!TxtData.XMLConfigure.Login || !TxtData.PublicData.ScreenEnable[TxtData.XMLConfigure.PopeDom, 1])
            {
                return;
            }
            SetFrmPanel(this.SCC_ChindMain.Panel2, new Frm_Action());
            SetTitle(sender);
        }
        private void BI_ActionModbus_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //if (!TxtData.XMLConfigure.Login || !TxtData.PublicData.ScreenEnable[TxtData.XMLConfigure.PopeDom, 2])
            //{
            //    return;
            //}
           // SetFrmPanel(this.SCC_ChindMain.Panel2, new Frm_Modbus());
            SetTitle(sender);
        }
        private void BI_RotAxis_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (!TxtData.XMLConfigure.Login || !TxtData.PublicData.ScreenEnable[TxtData.XMLConfigure.PopeDom, 2])
            {
                return;
            }
          //  SetFrmPanel(this.SCC_ChindMain.Panel2, new Frm_Axis());
            SetTitle(sender);
        }


        private void BI_DispersePreset_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (!TxtData.XMLConfigure.Login || !TxtData.PublicData.ScreenEnable[TxtData.XMLConfigure.PopeDom, 3])
            {
                return;
            }
           // SetFrmPanel(this.SCC_ChindMain.Panel2, new Frm_StaubliPreset());
            SetTitle(sender);
        }

        private void BI_SerPreset_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            
            if (!TxtData.XMLConfigure.Login || !TxtData.PublicData.ScreenEnable[TxtData.XMLConfigure.PopeDom, 4])
            {
                return;
            }
           // SetFrmPanel(this.SCC_ChindMain.Panel2, new Frm_Preset());
            SetTitle(sender);
        }




        //产品信息

        private void ItemRecipe_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (!TxtData.XMLConfigure.Login || !TxtData.PublicData.ScreenEnable[TxtData.XMLConfigure.PopeDom, 5])
            {
                return;
            }
            if (TxtData.XMLConfigure.OverTime)
            {
                MessageBox.Show("请联系集成商,软件超过使用期限!");

                return;
            }
            SetFrmPanel(this.SCC_ChindMain.Panel2, new Frm_Recipe());
            SetTitle(sender);
        }


        //生产控制
        private void BI_ProductSetting_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (!TxtData.XMLConfigure.Login || !TxtData.PublicData.ScreenEnable[TxtData.XMLConfigure.PopeDom, 6])
            {
                return;
            }
            if (TxtData.XMLConfigure.OverTime)
            {
                MessageBox.Show("请联系集成商,软件超过使用期限!");

                return;
            }
            SetFrmPanel(this.SCC_ChindMain.Panel2, new Frm_ProductControl());
            SetTitle(sender);
        }


        private void BI_ProductImfor_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (!TxtData.XMLConfigure.Login || !TxtData.PublicData.ScreenEnable[TxtData.XMLConfigure.PopeDom, 7])
            {
                return;
            }
          //  SetFrmPanel(this.SCC_ChindMain.Panel2, new Frm_Monitor());
            SetTitle(sender);

        }

        //生产统计
        private void BI_StatProduct_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (!TxtData.XMLConfigure.Login || !TxtData.PublicData.ScreenEnable[TxtData.XMLConfigure.PopeDom, 8])
            {
                return;
            }
            SetFrmPanel(this.SCC_ChindMain.Panel2, new Frm_Stat());
            SetTitle(sender);
        }


        //下位机报警
        private void navCS8CAlarm_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (!TxtData.XMLConfigure.Login || !TxtData.PublicData.ScreenEnable[TxtData.XMLConfigure.PopeDom, 10])
            {
                return;
            }
            
            SetFrmPanel(this.SCC_ChindMain.Panel2, new Frm_Cs8cAlarm());
            SetTitle(sender);
        }

        //上位机报警
        private void navPCAlarm_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (!TxtData.XMLConfigure.Login || !TxtData.PublicData.ScreenEnable[TxtData.XMLConfigure.PopeDom, 9])
            {
                return;
            }
            SetFrmPanel(this.SCC_ChindMain.Panel2, new Frm_PCAlarm());
            SetTitle(sender);
        }

        private void BI_User_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (!TxtData.XMLConfigure.Login || !TxtData.PublicData.ScreenEnable[TxtData.XMLConfigure.PopeDom, 11])
            {
                return;
            }
            SetFrmPanel(this.SCC_ChindMain.Panel2, new Frm_User());
            SetTitle(sender);
        }




        private void BI_Cs8cSetting_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (!TxtData.XMLConfigure.Login || !TxtData.PublicData.ScreenEnable[TxtData.XMLConfigure.PopeDom, 12])
            {
                return;
            }
           // SetFrmPanel(this.SCC_ChindMain.Panel2, new Frm_CS8C());
            SetTitle(sender);
        }





        private void BI_Sys_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (!TxtData.XMLConfigure.Login || !TxtData.PublicData.ScreenEnable[TxtData.XMLConfigure.PopeDom, 13])
            {
                return;
            }
           // SetFrmPanel(this.SCC_ChindMain.Panel2, new Frm_Sys());
            SetTitle(sender);
        }














        //***********************************************************************8
        private void Time_Refresh_Tick(object sender, EventArgs e)
        {
            //BBT_Cs8cScreen.Caption = "下位机界面:" + (TxtData.DataBase.InterfaceType<1?"":TxtData.PublicData.Cs8cScreen[TxtData.DataBase.InterfaceType]);
            //BSI_CS8CTEM.Caption = "控制器温度:" + TxtData.DataBase.ControllerTemp;

            //string[] ToolMode=new string[]{"","手动","测试","自动","远程"};
           
            //if (TxtData.DataBase.ToolMode >= 1&&TxtData.DataBase.ToolMode<=4 )
            //{
            //    BBI_ToolMode.Caption = "控制器:" + ToolMode[TxtData.DataBase.ToolMode];
            //    BBI_ToolMode.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Black;
            //}
            //else
            //{
            //    BBI_ToolMode.Caption = "下位机程序未运行";//    BBI_ToolMode.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Red;
            //}

            //BBI_IP.Caption = "CS8C的IP:"+TxtData.XMLConfigure.IpAddress;
            //BCI_Conmuni.Caption = TxtData.DataBase.SoapStaus ? "下位机通讯:正常" : "下位机通讯:异常";
            //BCI_Conmuni.ItemAppearance.Normal.ForeColor = TxtData.DataBase.SoapStaus ? System.Drawing.Color.Black : System.Drawing.Color.Red;
            //BBI_PowerOn.Caption = TxtData.DataBase.PowerOn ? "电源:开" : "电源:关";
            if (TxtData.DataBase.CurrentJoint!=null)
            {
                BBI_J1.Caption = "j1:" + TxtData.DataBase.CurrentJoint[0].ToString();
                BBI_J2.Caption = "j2:" + TxtData.DataBase.CurrentJoint[1].ToString();
                BBI_J3.Caption = "j3:" + TxtData.DataBase.CurrentJoint[2].ToString();
                BBI_J4.Caption = "j4:" + TxtData.DataBase.CurrentJoint[3].ToString();
                BBI_J5.Caption = "j5:" + TxtData.DataBase.CurrentJoint[4].ToString();
                BBI_J6.Caption = "j6:" + TxtData.DataBase.CurrentJoint[5].ToString();
            }

            if (TxtData.DataBase.CurrentPoint!=null)
            {
                BSI_1.Caption = "X:" + TxtData.DataBase.CurrentPoint[0].ToString();
                BSI_2.Caption = "Y:" + TxtData.DataBase.CurrentPoint[1].ToString();
                BSI_3.Caption = "Z:" + TxtData.DataBase.CurrentPoint[2].ToString();
                BSI_4.Caption = "RX:" + TxtData.DataBase.CurrentPoint[3].ToString();
                BSI_5.Caption = "RY:" + TxtData.DataBase.CurrentPoint[4].ToString();
                BSI_6.Caption = "RZ:" + TxtData.DataBase.CurrentPoint[5].ToString();

            }

            if (TxtData.CS8CConfigure.Tool!= null)
            {
                BSI_T1.Caption = "X:" + TxtData.CS8CConfigure.Tool[0].ToString();
                BSI_T2.Caption = "Y:" + TxtData.CS8CConfigure.Tool[1].ToString();
                BSI_T3.Caption = "Z:" + TxtData.CS8CConfigure.Tool[2].ToString();
                BSI_T4.Caption = "RX:" + TxtData.CS8CConfigure.Tool[3].ToString();
                BSI_T5.Caption = "RY:" + TxtData.CS8CConfigure.Tool[4].ToString();
                BSI_T6.Caption = "RZ:" + TxtData.CS8CConfigure.Tool[5].ToString();

            }
            if (TxtData.CS8CConfigure.Home != null)
            {
                BSI_H1.Caption = "j1:" + TxtData.CS8CConfigure.Home[0].ToString();
                BSI_H2.Caption = "j2:" + TxtData.CS8CConfigure.Home[1].ToString();
                BSI_H3.Caption = "j3:" + TxtData.CS8CConfigure.Home[2].ToString();
                BSI_H4.Caption = "j4:" + TxtData.CS8CConfigure.Home[3].ToString();
                BSI_H5.Caption = "j5:" + TxtData.CS8CConfigure.Home[4].ToString();
                BSI_H6.Caption = "j6:" + TxtData.CS8CConfigure.Home[5].ToString();
            }



            //*************************
            SS_DateTime.Caption = "日期:" + DateTime.Now.ToLongDateString() +"   "+ DateTime.Now.ToLongTimeString();
            SS_Days.Caption = "软件已使用天数:" + (TxtData.XMLConfigure.SoftWareUsedDay + 1).ToString() + "天";
            string[] Buff=new string[]{"操作员","管理员","高级管理员","超级管理员"};          
            if (TxtData.XMLConfigure.Login)
            {
                SS_User.Caption = "用户名:"+TxtData.XMLConfigure.User;
                SS_Access.Caption = "权限:"+Buff[TxtData.XMLConfigure.PopeDom];
                SS_User.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                SS_User.Caption = "用户名:未登录";
                SS_Access.Caption = "权限:未登录";
                SS_User.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Red;
            }

        }

        /// <summary>
        /// 列表全部打开
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BBI_ListOpen_ItemClick(object sender, ItemClickEventArgs e)
        {
           // //this.RobotSysParaGroup.Expanded = true;
           //// this.ActionGroup.Expanded = true;
           // this.DemoGroup.Expanded = true;
           // this.MonitorGroup.Expanded = true;
           //// this.ProductGroup.Expanded = true;
           // this.ProductGroup.Expanded = true;
           // this.StatGroup.Expanded = true;
           // this.AlarmGroup.Expanded = true;
           //// this.SettingGroup.Expanded = true;
           //// this.AccessGroup.Expanded = true;
            foreach (NavBarGroup ele in ListGroup_Main.Groups)
            {
                ele.Expanded = true;


            }



        }


        /// <summary>
        /// 列表全部收起
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BI_ListClose_ItemClick(object sender, ItemClickEventArgs e)
        {
          // // this.RobotSysParaGroup.Expanded = false;
          ////  this.ActionGroup.Expanded = false;
          //  this.DemoGroup.Expanded = false;
          //  this.MonitorGroup.Expanded = false;
          // // this.ProductGroup.Expanded = false;
          //  this.ProductGroup.Expanded = false;
          //  this.StatGroup.Expanded = false;
          //  this.AlarmGroup.Expanded = false;
          ////  this.SettingGroup.Expanded = false;
          ////  this.AccessGroup.Expanded = false;
          /// 


            foreach (NavBarGroup ele in ListGroup_Main.Groups)
            {
                ele.Expanded = false;


            }
        }




        private void Frm_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                TxtData.DataBase.SoapAbort = true;
                
                if (poll.ThreadState != System.Threading.ThreadState.Aborted)
                {
                    poll.Abort();
                }
            }
            catch (System.Exception ex)
            {
            	
            }

            
        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }



        private void SetTitle(object sender)
        {
            if (sender is DevExpress.XtraNavBar.NavBarItem)
            {
                DevExpress.XtraNavBar.NavBarItem bt = (DevExpress.XtraNavBar.NavBarItem)sender;
                TE_Title.Text = bt.Caption;
                SCC_ChindMain.Panel1.Height = TE_Title.Size.Height;
                TE_Title.ForeColor = Color.Black;
            
            
            }
                        

        }



        public  void SetFrmPanel(DevExpress.XtraEditors.SplitGroupPanel pl, Form frm)
        {

            this.RC_Main.Minimized = true;
            if (pl == null || frm == null)
            {
                return;
            }
            try
            {
                if (frm is Frm_Cs8cAlarm)
                {
                    TxtData.PublicData.FtpLog = true;
                }
                else
                {
                    TxtData.PublicData.FtpLog = false;
                }
                if (pl.Controls.Count > 0)
                {
                    int CCount = pl.Controls.Count;
                    for (int i = 0; i < CCount; i++)
                    {
     
                        pl.Controls.RemoveAt(i);
                        //if (pl.Controls[i]!=null)
                        //{
                        //    pl.Controls[i].Dispose();
                        //}
                    }
                }
                frm.TopLevel = false;
                //Dock是很重要的一个特性
                frm.Dock = DockStyle.Fill;
                //没有边框
                frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                //Form的大小
                frm.ClientSize = new System.Drawing.Size(pl.Size.Width, pl.Size.Height);
                //Panel添加上frm
                pl.Controls.Add(frm);
                //frm进行展示
                frm.Show();
               
            }
            catch
            {

            }



        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {



            BBI_Reg.Enabled = BET_ToolCode.Enabled = !TxtData.XMLConfigure.Reged;
            BSI_RegStatus.Caption = TxtData.XMLConfigure.Reged ? "已注册" : "未注册";
            BSI_ToolCode.Caption = PublicFunc.GetDiskVolumeSerialNumber() + PublicFunc.GetCpuSerialNumber();
          
            BI_RobotImfor_LinkClicked(this,null);
         

          //  TxtData.XMLConfigure.Login = true;

       
        }

        private void BBI_Login_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (this.BEI_UserName.EditValue.ToString()==""||this.BEI_PassW.EditValue.ToString()=="")
            {
                MessageBox.Show("密码和用户名不能为空！");
                return;
            }


            TxtData.XMLConfigure.Login = db.ExistUser(this.BEI_UserName.EditValue.ToString(), this.BEI_PassW.EditValue.ToString());
            if (TxtData.XMLConfigure.Login)
            {
                TxtData.XMLConfigure.User = this.BEI_UserName.EditValue.ToString();
                TxtData.XMLConfigure.PopeDom = db.GetUserPopm(this.BEI_UserName.EditValue.ToString());
                db.EditAutoLogin(this.BEI_UserName.EditValue.ToString(), this.BEI_PassW.EditValue.ToString(), (bool)BEI_AutoLogin.EditValue);

                db.AddLog(TxtData.XMLConfigure.User + "登录");
            } 
            else
            {
                MessageBox.Show("登录失败！");
                this.RC_Main.Minimized = false;
            }

        }

        private void BBI_LogOut_ItemClick(object sender, ItemClickEventArgs e)
        {
            //DevExpress.Utils.WaitDialogForm fr = new DevExpress.Utils.WaitDialogForm();
            //fr.ShowDialog();
            //DevExpress.Utils.DemoBox d = new DevExpress.Utils.DemoBox();
            //d.ShowDialog();
            TxtData.XMLConfigure.Login = false;
        }



        /// <summary>
        /// 把机器码生成文本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BBI_SaveToolCodeTxt_ItemClick(object sender, ItemClickEventArgs e)
        {
            string FileName;
            if ((FileName = PublicFunc.SfD_Show("Packaging注册码.txt", "TXT文件(*.txt)|*.txt")) == null)
            {
                return;
            }
            PublicFunc.SaveTxt(FileName, BSI_ToolCode.Caption);
           
        }
        /// <summary>
        /// 打开用户手册
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BBI_UserManual_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {

                if (File.Exists(Application.StartupPath + @"\Backup\使用手册.pdf"))
                {

                    Process.Start(Application.StartupPath + @"\Backup\使用手册.pdf");
                }
                else
                {
                    MessageBox.Show("使用手册不存在！");

                }
            }
            catch
            {


            }
        }

        private void BBI_Reg_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (BET_ToolCode.EditValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("注册码格式不正确！");
                return;
            }
            if (!PublicFunc.CompareCode(BET_ToolCode.EditValue.ToString().Trim()))
            {
                MessageBox.Show("注册码不正确！");
                return;
            }
           // db.SetRange();
          //  MessageBox.Show(BET_ToolCode.EditValue.ToString().Length.ToString());
            if (!db.EditRegCode(BET_ToolCode.EditValue.ToString().Trim()) || !PublicFunc.CompareCode(db.GetRegCode()))
            {
                MessageBox.Show("保存数据不正确！");
                return;
            }
            else
            {
                MessageBox.Show("感谢您的注册！");
                TxtData.XMLConfigure.Reged = true;
                BBI_Reg.Enabled = BET_ToolCode.Enabled = !TxtData.XMLConfigure.Reged;
                BSI_RegStatus.Caption = TxtData.XMLConfigure.Reged ? "已注册" : "未注册";
  
            }
          //  Frm_Main_Load(this, null);
        }

        private void Frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.AddLog(TxtData.XMLConfigure.User + "关闭程序");
            TxtData.DataBase.SoapAbort = true;
            SoapInstance.SoapRead.Logout();
        }
        
       //主界面
        private void BSI_Mainframe_ItemClick(object sender, ItemClickEventArgs e)
        {
            BI_RobotImfor_LinkClicked(this, null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BSI_NetAdress_ItemClick(object sender, ItemClickEventArgs e)
        {
            Process.Start("http://yunpan.cn/QbSra2i4gnGaS");
        }

        private void RobotParaGroup_CalcGroupClientHeight(object sender, DevExpress.XtraNavBar.NavBarCalcGroupClientHeightEventArgs e)
        {
          //  MessageBox.Show("ok");
        }

        private void ListGroup_Main_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void ListGroup_Main_Click(object sender, EventArgs e)
        {

        }

        private void ListGroup_Main_DoubleClick(object sender, EventArgs e)
        {
         // //  this.RobotSysParaGroup.Expanded = !this.RobotSysParaGroup.Expanded;
         ////   this.ActionGroup.Expanded = !this.ActionGroup.Expanded;
         //   this.DemoGroup.Expanded = !this.DemoGroup.Expanded;
         //   this.MonitorGroup.Expanded = !this.MonitorGroup.Expanded;
         ////   this.ProductGroup.Expanded = !this.ProductGroup.Expanded;


         //   this.ProductGroup.Expanded = !this.ProductGroup.Expanded;
         //   this.StatGroup.Expanded = !this.StatGroup.Expanded;
         //   this.AlarmGroup.Expanded = !this.AlarmGroup.Expanded;
         //  // this.SettingGroup.Expanded = !this.SettingGroup.Expanded;
           // this.AccessGroup.Expanded = !this.AccessGroup.Expanded;


            foreach (NavBarGroup ele in ListGroup_Main.Groups)
            {
                ele.Expanded = !ele.Expanded;

                                
            }


        }



        //双击打开所在安装目录的文件夹
        private void TE_Title_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            try
            {
                string FilePath = Application.StartupPath;

                Process.Start(FilePath);
            }
            catch (System.Exception ex)
            {
           
            }
 



        }

        private void TE_Title_EditValueChanged(object sender, EventArgs e)
        {
           // TE_Title_MouseDoubleClick(this,null);
        }

        private void RSB_Main_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TE_Title_MouseDoubleClick(this, null);
        }

        private void BI_ActionConfig_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SetTitle(sender);

            SetFrmPanel(this.SCC_ChindMain.Panel2, new Frm_Action());
        
        }
        private void BI_TrackConfig_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SetTitle(sender);
            SetFrmPanel(this.SCC_ChindMain.Panel2, new Frm_TrackConfig());
        }

        //比例因子标定
        private void BI_EncodeConfig_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SetTitle(sender);
        }
        //传送带坐标系标定
        private void BI_TrackFrame_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SetTitle(sender);
            SetFrmPanel(this.SCC_ChindMain.Panel2, new Frm_TrackFrame());
        }
        //视觉坐标系标定
        private void BI_VisionFrame_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SetTitle(sender);
        }
        //货盘设置
        private void BI_Pallet_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SetTitle(sender);
            SetFrmPanel(this.SCC_ChindMain.Panel2, new Frm_Pallet());
        }
                
        //拾放点设置
        private void BI_PickPlace_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SetTitle(sender);
            SetFrmPanel(this.SCC_ChindMain.Panel2, new Frm_PickPlace());
        }

        //复位程序配置
        private void BI_ResetProg_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SetTitle(sender);
            SetFrmPanel(this.SCC_ChindMain.Panel2, new Frm_ResetProg());
        }
        //生产程序配置
        private void BI_ProductProg_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SetTitle(sender);
            SetFrmPanel(this.SCC_ChindMain.Panel2, new Frm_ProductProg());
                        




        }
                

        //暂停程序配置
        private void BI_Pause_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SetTitle(sender);
            SetFrmPanel(this.SCC_ChindMain.Panel2, new Frm_PauseProg());
        }


        //结束程序配置
        private void BI_StopProg_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SetTitle(sender);

            SetFrmPanel(this.SCC_ChindMain.Panel2, new Frm_StopProg());



        }


        //急停程序配置
        private void BI_EMOProg_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SetTitle(sender);
            SetFrmPanel(this.SCC_ChindMain.Panel2, new Frm_EMOProg());
        
        
        }
        //安全区域设置
        private void BI_SafeConfig_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SetTitle(sender);

            SetFrmPanel(this.SCC_ChindMain.Panel2, new Frm_SafeConfig());


        }

                
        //在线调整
        private void BI_OnlineConfig_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SetTitle(sender);
            SetFrmPanel(this.SCC_ChindMain.Panel2, new Frm_OnlineConfig());








        }
        //仿真模拟
        private void BI_RotDemo_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SetTitle(sender);
            SetFrmPanel(this.SCC_ChindMain.Panel2, new Frm_RobotDemo());
        }

        //在线监视
        private void BI_OnlineMonitor_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SetTitle(sender);

            SetFrmPanel(this.SCC_ChindMain.Panel2, new Frm_OnlineMonitor());



        }


        //报警处理
        private void BI_AlarmManage_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SetTitle(sender);

        }

        //IO
        //IO 配置界面
        private void BI_IOconfig_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SetFrmPanel(this.SCC_ChindMain.Panel2, new Frm_IOConfig());
            SetTitle(sender);
        }

        private void BI_ToolConfig_LinkClicked(object sender, NavBarLinkEventArgs e)
        {

            SetFrmPanel(this.SCC_ChindMain.Panel2, new Frm_Tool());
            SetTitle(sender);


        }


                




    }
}


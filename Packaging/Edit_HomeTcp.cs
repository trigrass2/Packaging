using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using DevExpress.XtraEditors;
using System.Text;
using System.Windows.Forms;
using RobotKit;
using StaubliRobot;
using System.IO;

namespace Packaging
{
    public partial class Edit_HomeTcp : DevExpress.XtraEditors.XtraForm
    {
        DataBaseManage db = new DataBaseManage();
        bool EditTool = false;

        public Edit_HomeTcp(bool tool)
        {
            InitializeComponent();
            EditTool = tool;
            TxtData.DataBase.Home = null;
            TxtData.DataBase.Tool = null;




        }

        private void BT_Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (db.SaveCs8cConfigure() && File.Exists(Application.StartupPath + "\\Txt\\Configure.txt"))
                {
                    File.Copy(Application.StartupPath + "\\Txt\\Configure.txt", Application.StartupPath + "\\Log\\Configure_" +
                        DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() 
                         +DateTime.Now.Second.ToString() + ".txt", true);
                }
            }
            catch 
            {
            	
            }
  

            if (TC_Edit.SelectedTabPageIndex == 0)
            {
                if (TxtData.DataBase.ToolMode < 1 && TxtData.DataBase.Tool == null && TxtData.DataBase.Home == null)
                {
                    MessageBox.Show("下位机通讯异常！");
                    return;
                }

                if (MessageBox.Show("确定需要把下位机数据导入数据库？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }


                if (EditTool)
                {
                    if (!db.EditTool(TxtData.DataBase.Tool))
                    {
                        MessageBox.Show("操作数据库异常!");
                        return;
                    }
                }
                else
                {
                    if (!db.EditHome(TxtData.DataBase.Home))
                    {
                        MessageBox.Show("操作数据库异常!");
                        return;
                    }

                }


            }
            else
            {
                if (CK_CS8C.Checked && TxtData.DataBase.ToolMode < 1)
                {
                    MessageBox.Show("下位机通讯异常");
                    return;
                }
                if (CK_CS8C.Checked && TxtData.DataBase.InterfaceType!=9)
                {
                    MessageBox.Show("下位机不在空闲状态");
                    return;
                }

                double[] data = EditTool ? TxtData.CS8CConfigure.Tool : TxtData.CS8CConfigure.Home;

                double.TryParse(TE_O1.Text,out data[0]);
                double.TryParse(TE_O2.Text, out data[1]);
                double.TryParse(TE_O3.Text, out data[2]);
                double.TryParse(TE_O4.Text, out data[3]);
                double.TryParse(TE_O5.Text, out data[4]);
                double.TryParse(TE_O6.Text, out data[5]);

                if (EditTool)
                {
                    if (!db.EditTool(data))
                    {
                        MessageBox.Show("操作数据库异常!");
                        return;
                    }
                }
                else
                {
                    if (!db.EditHome(data))
                    {
                        MessageBox.Show("操作数据库异常!");
                        return;
                    }

                }
                if (CK_CS8C.Checked)
                {
                
                    FtpClient ftp = new FtpClient(TxtData.XMLConfigure.IpAddress);
                    if (db.SaveCs8cConfigure()==false||!ftp.UploadConfigure())
                   {
                       MessageBox.Show("发送配置文件异常!");
                       return;
                   }
                  // ;


                }



            }

            this.Close();

        }


        private void Edit_Recipe_Load(object sender, EventArgs e)
        {
            if (EditTool)
            {

                TE_O1.Text = TxtData.CS8CConfigure.Tool[0].ToString();
                TE_O2.Text = TxtData.CS8CConfigure.Tool[1].ToString();
                TE_O3.Text = TxtData.CS8CConfigure.Tool[2].ToString();
                TE_O4.Text = TxtData.CS8CConfigure.Tool[3].ToString();
                TE_O5.Text = TxtData.CS8CConfigure.Tool[4].ToString();
                TE_O6.Text = TxtData.CS8CConfigure.Tool[5].ToString();



            }
            else
            {
                TE_O1.Text = TxtData.CS8CConfigure.Home[0].ToString();
                TE_O2.Text = TxtData.CS8CConfigure.Home[1].ToString();
                TE_O3.Text = TxtData.CS8CConfigure.Home[2].ToString();
                TE_O4.Text = TxtData.CS8CConfigure.Home[3].ToString();
                TE_O5.Text = TxtData.CS8CConfigure.Home[4].ToString();
                TE_O6.Text = TxtData.CS8CConfigure.Home[5].ToString();



            }


            if (EditTool)
            {
                this.Text = "编辑工具";
                LL_1.Text = "X:";
                LL_2.Text = "Y:";
                LL_3.Text = "Z:";
                LL_4.Text = "RX:";
                LL_5.Text = "RY:";
                LL_6.Text = "RZ:";
                LL_J1.Text = "X:";
                LL_J2.Text = "Y:";
                LL_J3.Text = "Z:";
                LL_J4.Text = "RX:";
                LL_J5.Text = "RY:";
                LL_J6.Text = "RZ:";
            }
            else
            {
                this.Text = "编辑安全点";
                LL_J1.Text = "J1:";
                LL_J2.Text = "J2:";
                LL_J3.Text = "J3:";
                LL_J4.Text = "J4:";
                LL_J5.Text = "J5:";
                LL_J6.Text = "J6:";
                LL_1.Text = "J1:";
                LL_2.Text = "J2:";
                LL_3.Text = "J3:";
                LL_4.Text = "J4:";
                LL_5.Text = "J5:";
                LL_6.Text = "J6:";
            }



            if (TxtData.DataBase.ToolMode > 0&&TxtData.DataBase.SoapStaus)
            {

                FtpClient ftp = new FtpClient(TxtData.XMLConfigure.IpAddress);
                if (ftp.DownLoadConfigure() && PublicFunc.ReadCs8CConfigure())
                {

                 
                    TxtData.DataBase.Tool = TxtData.CS8CConfigure.Tool;
                    TxtData.DataBase.Home = TxtData.CS8CConfigure.Home;

                    if (EditTool)
                    {

                        LL_J1.Text = "X:" + TxtData.DataBase.Tool[0].ToString();
                        LL_J2.Text = "Y:" + TxtData.DataBase.Tool[1].ToString();
                        LL_J3.Text = "Z:" + TxtData.DataBase.Tool[2].ToString();
                        LL_J4.Text = "RX:" + TxtData.DataBase.Tool[3].ToString();
                        LL_J5.Text = "RY:" + TxtData.DataBase.Tool[4].ToString();
                        LL_J6.Text = "RZ:" + TxtData.DataBase.Tool[5].ToString();
                    }
                    else
                    {
                        LL_J1.Text = "J1:" + TxtData.DataBase.Home[0].ToString();
                        LL_J2.Text = "J2:" + TxtData.DataBase.Home[1].ToString();
                        LL_J3.Text = "J3:" + TxtData.DataBase.Home[2].ToString();
                        LL_J4.Text = "J4:" + TxtData.DataBase.Home[3].ToString();
                        LL_J5.Text = "J5:" + TxtData.DataBase.Home[4].ToString();
                        LL_J6.Text = "J6:" + TxtData.DataBase.Home[5].ToString();

                    }

                }


            }


        }
    }
}

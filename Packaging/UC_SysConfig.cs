using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using StaubliRobot;

namespace Packaging
{
    public partial class UC_SysConfig : UserControl
    {
       public int ToolID;
        public UC_SysConfig()
        {
            InitializeComponent();
            //SetData();
        }
        public UC_SysConfig(int ToolID)
        {
            InitializeComponent();
        }   





        public void BT_SET1_Click(object sender, EventArgs e)
        {
            //SetAction = false;
            //if (sender!=null)
            //{
            //    if (MessageBox.Show("确定需要进行设置吗？", "设置", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            //    {
            //        return;
            //    }
            //}

            //    //if (TE_Prog.Text.Trim() == "" || TE_Prog.Text.Trim().IndexOf("Disk://")!=0)
            //    //{
            //    //    MessageBox.Show("程序名称不正确");
            //    //    return;
            //    //}
            //    if (TE_Ip.Text.Trim()=="")
            //    {
            //        MessageBox.Show("序号"+ToolID.ToString()+"机器"+"IP不正确");
            //        return;
            //    }
            //    string[] dataIp = TE_Ip.Text.Trim().Split('.');
            //    if (dataIp==null||dataIp.Length!=4)
            //    {
            //        MessageBox.Show("序号" + ToolID.ToString() + "机器" + "IP不正确");
            //        return;
            //    }

            //    for (int i = 1; i < 9;i++ )
            //    {
            //        if (TE_Ip.Text==TxtData.RobotCfg[i].IpAddress&&i!=ToolID)
            //        {
            //            MessageBox.Show("序号" + ToolID.ToString() + "机器" + "IP与其他IP相同");
            //            return;
            //        }

            //        //if (TE_Prog.Text== TxtData.RobotCfg[i].RunApp && i != ToolID)
            //        //{
            //        //    MessageBox.Show("程序名与其他程序名相同");
            //        //    return;
            //        //}


            //    }



            //    string[] data=new string[4];
            //    data[0] = TE_Ip.Text.Trim();
            //    data[1] = TE_Prog.Text.Trim();
            //    data[2] = TE_Remark.Text.Trim();
            //    data[3] = CE_Link.Checked ? "TRUE" : "FALSE";
            //    if (db.EditTpCfg(ToolID,data))
            //    {
            //        SetAction = true;
            //            if(sender!=null)
            //            {
            //                      MessageBox.Show("设置成功,请重启软件");
            //            }
              
            //    }
            //    else
            //    {
            //        MessageBox.Show("设置失败");
            //    }

            //    SetData();



            ////}
        }

        private void GC_Robot_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

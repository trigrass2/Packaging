using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using StaubliRobot;

namespace Packaging
{
    public partial class Edit_Ip : DevExpress.XtraEditors.XtraForm
    {

        int Type = 0;
        DataBaseManage db = new DataBaseManage();
        public Edit_Ip()
        {
            InitializeComponent();
        }
        public Edit_Ip(int type)
        {
            InitializeComponent();
            Type = type;
        }

        private void Edit_Ip_Load(object sender, EventArgs e)
        {
            switch (Type)
            {
                case 1:
                    {
                        this.Text = "编辑CS8C(下位机)IP";
                        LL_Text.Text = "新CS8C(下位机)IP:";
                        LL_Mark.Text = "请输入新CS8C(下位机)IP";
                        break;
                    }

                case 2:
                    {
                        this.Text = "编辑使用期限";
                        LL_Text.Text = "请输入时间码:";
                        LL_Mark.Text = "原可使用天数:" + TxtData.XMLConfigure.CanUsedDay+"天";
                        break;
                    }



            }
        }

        private void BT_ok_Click(object sender, EventArgs e)
        {
            if (TB_Code.Text.Trim() == "")
            {
                MessageBox.Show("输入不能为空！");
                return;

            }
            switch (Type)
            {
                case 1:
                    {
                        string[] data = TB_Code.Text.Trim().Split('.');
                        if (data.Length != 4)
                        {

                            MessageBox.Show("输入位数不正确！");
                            return;

                        }
                        TxtData.XMLConfigure.IpAddress = TB_Code.Text.Trim();
                        break;
                    }

                case 2:
                    {


                        if (TB_Code.Text.Trim().Length!=6)
                        {
                            MessageBox.Show("输入位数不等于6！");
                            return;

                        }
                        
                        //2014.08.08
                        //修改加密方式

                        int Ind = TxtData.XMLConfigure.RegCode.ToUpper().IndexOf(TB_Code.Text.Trim().ToUpper());
                        if (Ind < 0||Ind%6!=0)
                        {
                            MessageBox.Show("输入不正确！");
                            return;

                        }
                        
                        TxtData.XMLConfigure.RestrictCode = TB_Code.Text.Trim();
                        break;
                        }


            }

            if (!db.EditIp(TxtData.XMLConfigure.IpAddress, TxtData.XMLConfigure.RestrictCode))
            {
                MessageBox.Show("数据库出错");
                return;

            }
            if (Type==2)
            {
               // TxtData.XMLConfigure.RestrictCode=
                PublicFunc.ReadXMLConfigure();
            }

            this.Close();
        }

        private void BT_Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using StaubliRobot;

namespace Packaging
{
    public partial class Edit_User : DevExpress.XtraEditors.XtraForm
    {
        string Username;
        bool Add = false;
        DataBaseManage db = new DataBaseManage();

        string[] Infor;
        public Edit_User()
        {
            InitializeComponent();
            this.Text = "添加用户";
            Add = true;
        }



        public Edit_User(string UserName)
        {
            InitializeComponent();
            Username = UserName;
            this.Text = "编辑用户";
            Add = false;
        }

        public Edit_User(string UserName,bool option)
        {
            //InitializeComponent();
            //Username = UserName;
            //this.Text = "编辑用户";
            //Add = false;
            db.DeleteUser(UserName);
        }

        private void BT_Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Edit_User_Load(object sender, EventArgs e)
        {
            if (!Add)
            {
                Infor=db.GetUser(Username);
                TE_Name.Text = Username;
                SE_1.Text = Infor[1];
                SE_2.Text = Infor[2];
                SE_3.Text = Infor[3];
                SE_4.Text = Infor[4];
                SE_5.Text = Infor[5];
                TE_Name.Enabled = false;
                SE_1.Enabled = false;

            }

 

        }

        private void BT_ok_Click(object sender, EventArgs e)
        {
            string[] data=new string[6];
            data[0] = TE_Name.Text;
            data[1] = SE_1.EditValue.ToString();
            data[2] = SE_2.EditValue.ToString();
            data[3] = SE_3.EditValue.ToString();
            data[4] = SE_4.EditValue.ToString();
            data[5] = SE_5.EditValue.ToString();
            if (data[0].Trim() == "" || data[1].Trim() == "")
            {
                MessageBox.Show("用户名或者密码不能为空");
                return;
            }
            bool Res;
            if (Add)
            {
                if (db.GetUser(data[0])!=null)
                {
                    MessageBox.Show("用户名已存在");

                    return;
                }
                Res=db.AddUser(data);
            }
            else
            {
               Res= db.EditUser(data);
            }

            if (Res)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("操作数据库报错");
            }

               


        }
    }
}

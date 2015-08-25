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
    public partial class Add_Preset : DevExpress.XtraEditors.XtraForm
    {

        DataBaseManage db = new DataBaseManage();
        public Add_Preset()
        {
            InitializeComponent();
        }

                
        private void Edit_Ip_Load(object sender, EventArgs e)
        {

        }

        private void BT_ok_Click(object sender, EventArgs e)
        {
            if (db.GetPresetList(TB_Name.Text,1)!=null)
            {
                MessageBox.Show("名称已存在");
                return;
            }
            if (!db.AddPreset(TB_Name.Text, TB_Remark.Text))
            {
                MessageBox.Show("数据库异常");
                return;
            }
          


            this.Close();
        }

        private void BT_Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }



 
    }
}

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
    public partial class Edit_Modbus : DevExpress.XtraEditors.XtraForm
    {
        DataBaseManage db = new DataBaseManage();
        int SelectIndex;
        string[] IORemark;
        string[] IOName;
        public Edit_Modbus(int index){
            InitializeComponent();
            SelectIndex = Math.Max(index, 0);
        }

        private void BT_Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void BT_ok_Click(object sender, EventArgs e)
        {
            BT_Apply_Click(this, null);
            BT_Cancle_Click(this, null);

        }

        private void BT_Apply_Click(object sender, EventArgs e)
        {



            db.EditModbusRemark(CBE_IO.SelectedIndex + 1, TE_Remark.Text);

        }

        private void Edit_Action_Load(object sender, EventArgs e)
        {

            IORemark = db.GetModbusRemark(out IOName);
            if (IORemark == null || IOName == null)
            {
                return;
            }

            string[] Buff = new string[IORemark.Length];
            for (int i = 1; i <= Buff.Length; i++)
            {
                Buff[i - 1] = i.ToString();

            }
            CBE_IO.Properties.Items.AddRange((object[])Buff);
            CBE_IO.SelectedIndex = SelectIndex;
        }

        private void CBE_IO_SelectedIndexChanged(object sender, EventArgs e)
        {

            TB_Name.Text = IOName[CBE_IO.SelectedIndex];
            TE_Remark.Text = IORemark[CBE_IO.SelectedIndex];

        }
    }
}

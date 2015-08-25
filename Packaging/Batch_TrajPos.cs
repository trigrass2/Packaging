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
    public partial class Batch_TrajPos : DevExpress.XtraEditors.XtraForm
    {
        DataBaseManage db = new DataBaseManage();
        string TrajName;
        bool[] PointType = new bool[3];
        bool[] ParaType = new bool[5];

        public Batch_TrajPos()
        {
            InitializeComponent();
        }
        public Batch_TrajPos(string Traj)
        {
            InitializeComponent();
            TrajName = Traj;
        }

        private void BT_Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CE_Set_CheckedChanged(object sender, EventArgs e)
        {
            CE_Replace.Checked = !CE_Set.Checked;
            TE_A6.Enabled = TE_A4.Enabled = TE_A2.Enabled = CE_Replace.Checked;
        }

        private void CE_Replace_CheckedChanged(object sender, EventArgs e)
        {
            CE_Set.Checked=!CE_Replace.Checked ;
         SE2.Enabled=SE4.Enabled=TE_A6.Enabled = TE_A4.Enabled = TE_A2.Enabled = CE_Replace.Checked;
        }

        private void Batch_Speed_Load(object sender, EventArgs e)
        {
            LL_RecipeName.Text = "路径名称:" + TrajName;
            int TrajCount = db.GetTrajPosCount(TrajName);
            if (TrajCount != 0)
            {
                string[] Traj = new string[TrajCount];
                for (int i = 0; i < TrajCount; i++)
                {
                    Traj[i] = (i + 1).ToString();


                }
                CBE_id.Properties.Items.Clear();
                CBE_id.Properties.Items.AddRange((object[])Traj);
                CBE_id.SelectedIndex = 0;

                CBE_idend.Properties.Items.Clear();
                CBE_idend.Properties.Items.AddRange((object[])Traj);
                CBE_idend.SelectedIndex = Traj.Length - 1;

            }
            TE_A6.Enabled = TE_A4.Enabled = TE_A2.Enabled = CE_Replace.Checked;
        }

        private void BT_Apply_Click(object sender, EventArgs e)
        {
            if (CBE_id.SelectedIndex > CBE_idend.SelectedIndex)
            {

                MessageBox.Show("开始序号不能超过结束序号");

                return;
            }
            bool Flag = false;
            //for (int i = 0; i < Clb_Check.ItemCount; i++)
            //{
            //   PointType[i] =Clb_Check.GetItemChecked(i);
            //   Flag = PointType[i] ? true : Flag;
            //}
            //if (!Flag)
            //{

            //    MessageBox.Show("请进行点位选择");

            //    return;
            //}
            //Flag = false;
            for (int i = 0; i <CBK_Para.ItemCount; i++)
            {
                ParaType[i] = CBK_Para.GetItemChecked(i);
                Flag = ParaType[i] ? true : Flag;
            }
            if (!Flag)
            {

                MessageBox.Show("请进行参数选择");

                return;
            }

            double[] data=new double[10];
            double.TryParse(TE_A1.Text,out data[0]);
            double.TryParse(TE_A2.Text, out data[1]); 
            double.TryParse(TE_A3.Text, out data[2]);
            double.TryParse(TE_A4.Text, out data[3]);
            double.TryParse(TE_A5.Text, out data[4]);
            double.TryParse(TE_A6.Text, out data[5]);
            data[6] = (int)SE1.Value;
            data[7] = (int)SE2.Value;
            data[8] = (int)SE3.Value;
            data[9] = (int)SE4.Value;

            if (data[0]<=0||data[2]<=0||data[4]<0)
            {
                MessageBox.Show("速度与加速度不能小于0");
                return;
            }

            string Mess = db.BatchTrajPos(TrajName,CBE_id.SelectedIndex+1,CBE_idend.SelectedIndex+1,CE_Replace.Checked,ParaType,data) ? "成功" : "操作异常";
            MessageBox.Show(Mess);

        }

        private void BT_ok_Click(object sender, EventArgs e)
        {
            BT_Apply_Click(this,null);
            BT_Cancle_Click(this, null);
            
        }
    }
}

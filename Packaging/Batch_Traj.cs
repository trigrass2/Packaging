using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using DevExpress.XtraEditors;
using System.Text;
using System.Windows.Forms;
using StaubliRobot;


namespace Packaging
{
    public partial class Batch_Traj : DevExpress.XtraEditors.XtraForm
    {
        DataBaseManage db = new DataBaseManage();
        string Recipename;
        int TrajIndex;
        public Batch_Traj()
        {
            InitializeComponent();
        }

        public Batch_Traj(string Recipe)
        {
            InitializeComponent();
            Recipename = Recipe;
        }

        private void BT_Cancle_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void BT_Apply_Click(object sender, EventArgs e)
        {
            if (CBE_id.SelectedIndex > CBE_idend.SelectedIndex)
            {

                MessageBox.Show("开始序号不能超过结束序号");

                return;
            }



            bool Flag = false;
            bool[] Item = new bool[12];
            for (int i = 0; i < 12; i++)
            {
                Item[i] = Clb_Check.GetItemChecked(i);
                Flag = Item[i] ? true : Flag;
            }
            if (!Flag)
            {

                MessageBox.Show("请进行选择项目");

                return;
            }

            double[] Frame = new double[6];
            double.TryParse(TE_F1.Text, out Frame[0]);
            double.TryParse(TE_F2.Text, out Frame[1]);
            double.TryParse(TE_F3.Text, out Frame[2]);
            double.TryParse(TE_F4.Text, out Frame[3]);
            double.TryParse(TE_F5.Text, out Frame[4]);
            double.TryParse(TE_F6.Text, out Frame[5]);

            double[] Offset = new double[6];
            double.TryParse(TE_O1.Text, out Offset[0]);
            double.TryParse(TE_O2.Text, out Offset[1]);
            double.TryParse(TE_O3.Text, out Offset[2]);
            double.TryParse(TE_O4.Text, out Offset[3]);
            double.TryParse(TE_O5.Text, out Offset[4]);
            double.TryParse(TE_O6.Text, out Offset[5]);

            double[] Array = new double[6];
            double.TryParse(TE_A1.Text, out Array[0]);
            double.TryParse(TE_A2.Text, out Array[1]);
            double.TryParse(TE_A3.Text, out Array[2]);
            double.TryParse(TE_A4.Text, out Array[3]);
            double.TryParse(TE_A5.Text, out Array[4]);
            double.TryParse(TE_A6.Text, out Array[5]);

            double[] DownLead = new double[6];
           //double.TryParse(TE_D1.Text, out DownLead[0]);
            double.TryParse(TE_D2.Text, out DownLead[1]);
          //  double.TryParse(TE_D3.Text, out DownLead[2]);
            double.TryParse(TE_D4.Text, out DownLead[3]);

            DownLead[0] = TE_D1.SelectedIndex;
            DownLead[2] = TE_D3.SelectedIndex;

            double[] Axis = new double[6];
            double.TryParse(TE_S1.Text, out Axis[0]);
            double.TryParse(TE_S2.Text, out Axis[1]);
            double.TryParse(TE_S3.Text, out Axis[2]);
            double.TryParse(TE_S4.Text, out Axis[3]);
            double.TryParse(TE_S5.Text, out Axis[4]);
            double.TryParse(TE_S6.Text, out Axis[5]);

            Axis[5] = Math.Max(1, Axis[5]);
            Axis[5] = Math.Min(50, Axis[5]);
            Axis[5] = (int)Axis[5];


            double[] Delay = new double[6];
            Delay[0] = (double)SE_1.Value;
            Delay[1] = (double)SE_2.Value;
            Delay[2] = (double)SE_3.Value;
            Delay[3] = (double)SE_4.Value;
            for (int i = 0; i < 4; i++)
            {
              if (Delay[i]<0)
              {
                  MessageBox.Show("设置参数不正确");
                  return;
              }
            }

            string Mess = db.BatchTraj(Recipename, CBE_id.SelectedIndex + 1, CBE_idend.SelectedIndex + 1, Item, Frame, Offset, Array, DownLead, Axis, Delay) ? "成功" : "操作异常";
            MessageBox.Show(Mess);





        }

        private void BT_ok_Click(object sender, EventArgs e)
        {
            BT_Apply_Click(this, null);
            BT_Cancle_Click(this, null);
        }

        private void Edit_Traj_Load(object sender, EventArgs e)
        {
            LL_RecipeName.Text = "产品名称:" + Recipename;
            int TrajCount = db.GetTrajCount(Recipename);
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
                CBE_idend.SelectedIndex = TrajCount - 1;

            }

            TE_D1.Properties.Items.Clear();
            TE_D1.Properties.Items.AddRange((object[])new string[] { "无", "直线", "圆弧" });
            TE_D3.Properties.Items.Clear();
            TE_D3.Properties.Items.AddRange((object[])new string[] { "无", "直线", "圆弧" });
            TE_D1.SelectedIndex = 0;
            TE_D3.SelectedIndex = 0;
        }
    }
}

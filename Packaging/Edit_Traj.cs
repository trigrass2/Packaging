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
    public partial class Edit_Traj : DevExpress.XtraEditors.XtraForm
    {
        DataBaseManage db = new DataBaseManage();
        string Recipename;
        int TrajIndex;
        double[] TrajFrame = new double[6];
        double[] TrajOffset = new double[6];
        double[] Array=new double[6];
        double[] Downlead=new double[6];
        double[] Axis=new double[6];
        double[] Para=new double[6];


        string Remark = "";
        string TrajName = "";
        string TypeName = "";
        public Edit_Traj()
        {
            InitializeComponent();
        }

        public Edit_Traj(string Recipe,int Index)
        {
            InitializeComponent();
            Recipename = Recipe;
            TrajIndex = Index;
        }

        private void BT_Cancle_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void BT_Apply_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show(TE_D1.SelectedIndex.ToString() + "    " + TE_D3.SelectedIndex.ToString());
            bool [] Item=new bool [12];
            for (int i = 0; i < 12;i++ )
            {
                Item[i] = true;
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




            double[] Axis = new double[6];
            double.TryParse(TE_S1.Text, out Axis[0]);
            double.TryParse(TE_S2.Text, out Axis[1]);
            double.TryParse(TE_S3.Text, out Axis[2]);
            double.TryParse(TE_S4.Text, out Axis[3]);
            double.TryParse(TE_S5.Text, out Axis[4]);
            double.TryParse(TE_S6.Text, out Axis[5]);

            if (Axis[5]!=-1)
            {
                Axis[5] = Math.Max(1, Axis[5]);
            }
          
            Axis[5] = Math.Min(50, Axis[5]);
            Axis[5] = (int)Axis[5];

            double[] Delay = new double[6];
            Delay[0] = (double)SE_1.Value;
            Delay[1] = (double)SE_2.Value;
            Delay[2] = (double)SE_3.Value;
            Delay[3] = (double)SE_4.Value;
            for (int i = 0; i < 4; i++)
            {
                if (Delay[i] < 0)
                {
                    MessageBox.Show("设置参数不正确");
                    return;
                }
            }
            double[] DownLeaddata = new double[6];
            // double.TryParse(TE_D1.Text, out DownLead[0]);
            double.TryParse(TE_D2.Text, out DownLeaddata[1]);
            // double.TryParse(TE_D3.Text, out DownLead[2]);
            double.TryParse(TE_D4.Text, out DownLeaddata[3]);

            DownLeaddata[0] = TE_D1.SelectedIndex;
            DownLeaddata[2] = TE_D3.SelectedIndex;

            db.EditTrajRemark(Recipename, CBE_id.SelectedIndex + 1,TE_Remark.Text);
            //MessageBox.Show(Downlead[0].ToString()+"   "+Downlead[2].ToString());
            string Mess = db.BatchTraj(Recipename, CBE_id.SelectedIndex + 1, CBE_id.SelectedIndex + 1, Item, Frame, Offset, Array, DownLeaddata, Axis, Delay) ? "成功" : "操作异常";
            MessageBox.Show(Mess);

        }

        private void BT_ok_Click(object sender, EventArgs e)
        {
            BT_Apply_Click(this,null);
            BT_Cancle_Click(this, null);
        }

        private void Edit_Traj_Load(object sender, EventArgs e)
        {
            TE_D1.Properties.Items.Clear();
            TE_D1.Properties.Items.AddRange((object[])new string[] { "无", "直线", "圆弧" });
            TE_D3.Properties.Items.Clear();
            TE_D3.Properties.Items.AddRange((object[])new string[] { "无", "直线", "圆弧" });
            LL_RecipeName.Text = "产品名称:" + Recipename;
            int TrajCount = db.GetTrajCount(Recipename);
            if (TrajCount!=0)
            {
                string[] Traj=new string[TrajCount];
                for (int i = 0; i < TrajCount;i++ )
                {
                    Traj[i] = (i + 1).ToString();


                }
                CBE_id.Properties.Items.Clear();
                CBE_id.Properties.Items.AddRange((object[])Traj);
                CBE_id.SelectedIndex = TrajIndex - 1;



            }



        }





        private void CBE_id_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (db.GetTraj(Recipename,CBE_id.SelectedIndex+1,ref TrajName,ref TypeName,
                ref TrajFrame,ref TrajOffset,ref Array,ref Downlead, ref Axis,ref Para,ref Remark))
            {

                LL_TrajName.Text = "路径名称:" + TrajName;
                TE_F1.Text = TrajFrame[0].ToString();
                TE_F2.Text = TrajFrame[1].ToString();
                TE_F3.Text = TrajFrame[2].ToString();
                TE_F4.Text = TrajFrame[3].ToString();
                TE_F5.Text = TrajFrame[4].ToString();
                TE_F6.Text = TrajFrame[5].ToString();

                TE_O1.Text = TrajOffset[0].ToString();
                TE_O2.Text = TrajOffset[1].ToString();
                TE_O3.Text = TrajOffset[2].ToString();
                TE_O4.Text = TrajOffset[3].ToString();
                TE_O5.Text = TrajOffset[4].ToString();
                TE_O6.Text = TrajOffset[5].ToString();

                TE_A1.Text = Array[0].ToString();
                TE_A2.Text = Array[1].ToString();
                TE_A3.Text = Array[2].ToString();
                TE_A4.Text = Array[3].ToString();

            
                TE_D2.Text = Downlead[1].ToString();
               // TE_D3.Text = Downlead[2].ToString();
                TE_D4.Text = Downlead[3].ToString();


                TE_D3.SelectedIndex = (int)Downlead[2];
                TE_D1.SelectedIndex = (int)Downlead[0];



                TE_S1.Text = Axis[0].ToString();
                TE_S2.Text = Axis[1].ToString();
                TE_S3.Text = Axis[2].ToString();
                TE_S4.Text = Axis[3].ToString();
                TE_S5.Text = Axis[4].ToString();
                TE_S6.Text = Axis[5].ToString();



                TE_Remark.Text = Remark;
                TE_Type.Text = TypeName;

                SE_3.Value = (decimal)Downlead[4];
                SE_4.Value = (decimal)Downlead[5];

                SE_1.Value = (decimal)Para[0];
                SE_2.Value = (decimal)Para[1];


            }



        }
    }
}

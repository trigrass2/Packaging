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
    public partial class Edit_Cut : DevExpress.XtraEditors.XtraForm
    {
        DataBaseManage db = new DataBaseManage();
        double[] Point=new double[6];
        double[] MovC=new double[6];
        double[] Para=new double[6];
        bool IsMovC = false;
        string Trajname;
        int CutIndex;
        public Edit_Cut()
        {
            InitializeComponent();
        }

        public Edit_Cut(string Traj, int Index)
        {
            InitializeComponent();
            Trajname = Traj;

            CutIndex = Index;
        }

        private void BT_Cancle_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void BT_Apply_Click(object sender, EventArgs e)
        {

            double.TryParse(TE_A1.Text, out Para[0]);
            double.TryParse(TE_A2.Text, out Para[1]);
            double.TryParse(TE_A3.Text, out Para[2]);
            double.TryParse(TE_A4.Text, out Para[3]);
            double.TryParse(TE_A5.Text, out Para[4]);

           string Buff=db.EditCutInfor(Trajname,CBE_id.SelectedIndex+1,Para)?"成功":"错误";
            MessageBox.Show(Buff);


        }

        private void BT_ok_Click(object sender, EventArgs e)
        {
            BT_Apply_Click(this,null);
            BT_Cancle_Click(this, null);
        }

        private void Edit_Traj_Load(object sender, EventArgs e)
        {
            string[] Item = new string[51];
            for (int i = 0; i <= 50; i++)
            {
                Item[i] = i.ToString();
            }
            TE_A4.Properties.Items.Clear();
            TE_A4.Properties.Items.AddRange((object[])Item);

            TE_A5.Properties.Items.Clear();
            TE_A5.Properties.Items.AddRange((object[])Item);
            GC_Preset.DataSource = db.GetDV_Presetlist("StaubliPreset");
            //去除其中的列和题头
            //   GC_Modbus.
            if (gv.RowCount > 12)
            {
                gv.Columns.Remove(gv.Columns["PRESETNAME"]);
                gv.Columns.Remove(gv.Columns["ID"]);
                gv.Columns.Remove(gv.Columns["BP1"]);
                gv.Columns.Remove(gv.Columns["BP2"]);
                gv.Columns.Remove(gv.Columns["BP3"]);
                gv.Columns.Remove(gv.Columns["BP4"]);
                gv.Columns["INDEX"].Caption = "序号";
                gv.Columns["POWERATE"].Caption = "激光功率";
                gv.Columns["FREQUEN"].Caption = "占空比频率";
                gv.Columns["PWM"].Caption = "占空比";
                gv.Columns["PRESSURE"].Caption = "气体压力";
                gv.Columns["FOLLOWSEN"].Caption = "随动高度";
                gv.Columns["REMARK"].Caption = "备注";
                gv.Columns["INDEX"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;

            }

            GC_Action.DataSource = db.GetDV_Action();
            //去除其中的列和题头
            //   GC_Modbus.
            if (gv1.RowCount > 12)
            {
                gv1.Columns.Remove(gv.Columns["ID"]);

                for (int i = 13; i < 21; i++)
                {
                    gv1.Columns.Remove(gv.Columns["IO" + i.ToString()]);
                }
                for (int i = 1; i < 5; i++)
                {
                    gv1.Columns.Remove(gv.Columns["BP" + i.ToString()]);
                }
                gv1.Columns["INDEX"].Caption = "序号";
                gv1.Columns["REMARK"].Caption = "备注";
                gv1.Columns["INDEX"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            }



            LL_RecipeName.Text = "路径名称:" +Trajname;
            int TrajCount = db.GetTrajPosCount(Trajname);
            if (TrajCount!=0)
            {
                string[] Traj=new string[TrajCount];
                for (int i = 0; i < TrajCount;i++ )
                {
                    Traj[i] = (i + 1).ToString();


                }
                CBE_id.Properties.Items.Clear();
                CBE_id.Properties.Items.AddRange((object[])Traj);
                CBE_id.SelectedIndex = CutIndex - 1;
                CBE_id_SelectedIndexChanged(this,null);
            }
      
        }


        private void CBE_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            Point = db.GetCutInfor(Trajname, CBE_id.SelectedIndex + 1, ref MovC, ref Para, ref IsMovC);
            TP_MovC.PageVisible = IsMovC;
            if (Point != null)
            {
                TE_O1.Text = Point[0].ToString();
                TE_O2.Text = Point[1].ToString();
                TE_O3.Text = Point[2].ToString();
                TE_O4.Text = Point[3].ToString();
                TE_O5.Text = Point[4].ToString();
                TE_O6.Text = Point[5].ToString();

                TE_F1.Text = MovC[0].ToString();
                TE_F2.Text = MovC[1].ToString();
                TE_F3.Text = MovC[2].ToString();
                TE_F4.Text = MovC[3].ToString();
                TE_F5.Text = MovC[4].ToString();
                TE_F6.Text = MovC[5].ToString();


                TE_A1.Text = Para[0].ToString();
                TE_A2.Text = Para[1].ToString();
                TE_A3.Text = Para[2].ToString();
                //  TE_A4.Text = Para[3].ToString();
                //  TE_A5.Text = Para[4].ToString();
                TE_A4.SelectedIndex = Math.Min((int)Para[3], 50);
                TE_A5.SelectedIndex = Math.Min((int)Para[4], 50);
            }
        }

    }
}

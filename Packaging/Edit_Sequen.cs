using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using DevExpress.XtraEditors;
using System.Text;
using System.Windows.Forms;
using StaubliRobot;

namespace Packaging
{
    public partial class Edit_Sequen : DevExpress.XtraEditors.XtraForm
    {
        string RecipeName;
        DataBaseManage db = new DataBaseManage();
        int TrajCount = 0;
        string[] TrajInfor;
        public Edit_Sequen(string Recipe)
        {
            InitializeComponent();
            this.RecipeName = Recipe;
        }

        private void BT_Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Edit_Sequen_Load(object sender, EventArgs e)
        {
           // CEL_Trajs.Items.AddRange(db.GetTrajInfor(CBE_Recipe.Text));
            TrajCount = db.GetTrajCount(RecipeName);
            LL_ID.Text = "路径总个数:" + TrajCount.ToString();
            LL_RecipeName.Text = "产品名称:" + RecipeName;
            TrajInfor = db.GetTrajInfor(RecipeName);

            TableShow();


        }

        private void BT_ok_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("路径排序，由于趋近点可能会碰撞，继续吗？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            int [] NewId=new int [TrajCount];
            string[] Buff=db.GetTrajInfor(RecipeName);

            for (int i = 0; i < TrajCount;i++ )
            {
                NewId[i] = Array.IndexOf(TrajInfor, Buff[i])+1;
            }

            string[] TrajName = db.GetTrajName(RecipeName,1,TrajCount);
            if (db.EditTrajIndex(TrajName,NewId))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("数据库异常！");
            }




        }

        private void TableShow()
        {
            DataView dv = new DataView();
            dv.Table = new System.Data.DataTable("Sequen");
            dv.Table.Columns.Add();
            dv.Table.Columns.Add();
            dv.Table.Rows.Clear();
            if (TrajInfor != null && TrajInfor.Length == TrajCount)
            {
                for (int i = 0; i < TrajCount; i++)
                {
                    dv.Table.Rows.Add((object[])new string[] { (i + 1).ToString(), TrajInfor[i] });
                }
                GC_Traj.DataSource = dv;
                gv.Columns[0].Caption = "新路径序号";
                gv.Columns[1].Caption = "路径信息";
            }
       
    

        }

        private void pic_up_Click(object sender, EventArgs e)
        {
            int index = gv.GetFocusedDataSourceRowIndex();
            Up(index);
            TableShow();
            gv.FocusedRowHandle = Math.Max(index-1,0);


        }

        private void pic_top_Click(object sender, EventArgs e)
        {
            for (int i = gv.GetFocusedDataSourceRowIndex(); i >= 0;i-- )
            {
                Up(i);
            }
            TableShow();
            gv.FocusedRowHandle = 0;
        }

        private void pic_down_Click(object sender, EventArgs e)
        {
            int index = gv.GetFocusedDataSourceRowIndex();
            Down(index);
            TableShow();
            gv.FocusedRowHandle = Math.Min(index+1, TrajCount-1);
        }

        private void pic_bottom_Click(object sender, EventArgs e)
        {
            for (int i = gv.GetFocusedDataSourceRowIndex(); i <TrajCount; i++)
            {
                Up(i);
            }
            TableShow();
            gv.FocusedRowHandle = TrajCount-1;
        }

        void Up(int index)
        {
           if (index==0)
           {
               return;
           }

           string Buff = TrajInfor[index-1];
           TrajInfor[index -1] = TrajInfor[index];
           TrajInfor[index] = Buff;
         
            

        }

        void Down(int index)
        {
            if (index == TrajCount-1)
            {
                return;
            }

            string Buff = TrajInfor[index];
            TrajInfor[index] = TrajInfor[index+1];
            TrajInfor[index+1] = Buff;
            
        }
    }
}

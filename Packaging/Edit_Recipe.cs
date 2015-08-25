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
    public partial class Edit_Recipe : DevExpress.XtraEditors.XtraForm
    {
        DataBaseManage db = new DataBaseManage();
        bool CreatRecipe=false;
        public string RecipeName = "";
        double[] frame = new double[6];
        double[] offset = new double[6];
        string Remark = "";
        public Edit_Recipe(string RecipeName)
        {
            InitializeComponent();
            this.RecipeName = RecipeName;
            TE_RecipeName.Text = RecipeName;
            TE_RecipeName.Enabled = false;
        }

        public Edit_Recipe(bool CreatRecipe)
        {
            InitializeComponent();
            this.CreatRecipe = CreatRecipe;
            if (CreatRecipe)
            {
                this.Text = "新建产品";
                CBE_Type.EditValue = 1;

            }
        }

        private void BT_Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_ok_Click(object sender, EventArgs e)
        {

           Remark = TE_Remark.Text;
           RecipeName = TE_RecipeName.Text.Trim();
            double.TryParse(TE_F1.Text, out frame[0]);
            double.TryParse(TE_F2.Text, out frame[1]);
            double.TryParse(TE_F3.Text, out frame[2]);
            double.TryParse(TE_F4.Text, out frame[3]);
            double.TryParse(TE_F5.Text, out frame[4]);
            double.TryParse(TE_F6.Text, out frame[5]);


            double.TryParse(TE_O1.Text, out offset[0]);
            double.TryParse(TE_O2.Text, out offset[1]);
            double.TryParse(TE_O3.Text, out offset[2]);
            double.TryParse(TE_O4.Text, out offset[3]);
            double.TryParse(TE_O5.Text, out offset[4]);
            double.TryParse(TE_O6.Text, out offset[5]);




            if (CreatRecipe)
            {
                if (RecipeName.Trim() == "")
                {
                    MessageBox.Show("名称为空");
                    return;
                }
                if (db.ExistRecipe(RecipeName))
                {
                    MessageBox.Show("产品名称已存在！");
                    return;
                }
                else
                {

                    if (db.AddRecipe(RecipeName, int.Parse(CBE_Type.EditValue.ToString()),frame,offset,Remark))
                    {
                        
                        this.Close();
                        
                    }
                    else
                    {
                        RecipeName = "";
                        MessageBox.Show("操作错误！");
                        return;
                    }


                }


            }
            else
            {
                if (db.EditRecipe(RecipeName, int.Parse(CBE_Type.EditValue.ToString()), frame, offset, Remark))
                {

                    this.Close();
                }
                else
                {
                    MessageBox.Show("操作错误！");
                    return;
                }

            }

        }

        private void TP_Frame_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Edit_Recipe_Load(object sender, EventArgs e)
        {
            int i = 0;
            if (!CreatRecipe)
            {
                if ((frame = db.GetRecipe(RecipeName, ref offset, ref Remark, ref i)) != null && offset!=null)
                {

                    TE_Remark.Text = Remark;
                    CBE_Type.EditValue = i;

                    TE_F1.Text = frame[0].ToString();
                    TE_F2.Text = frame[1].ToString();
                    TE_F3.Text = frame[2].ToString();
                    TE_F4.Text = frame[3].ToString();
                    TE_F5.Text = frame[4].ToString();
                    TE_F6.Text = frame[5].ToString();

                    TE_O1.Text = offset[0].ToString();

                    TE_O2.Text = offset[1].ToString();

                    TE_O3.Text = offset[2].ToString();

                    TE_O4.Text = offset[3].ToString();

                    TE_O5.Text = offset[4].ToString();

                    TE_O6.Text = offset[5].ToString();


                }

            }
        }
    }
}

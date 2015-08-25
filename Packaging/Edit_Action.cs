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
    public partial class Edit_Action : DevExpress.XtraEditors.XtraForm
    {
        DataBaseManage db = new DataBaseManage();
        int SelectIndex;
        public Edit_Action(int index)
        {
            InitializeComponent();
            SelectIndex = index;
        }

        private void BT_Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_Empty_Click(object sender, EventArgs e)
        {
            CBE_1.SelectedIndex = 0;
            CBE_2.SelectedIndex = 0;
            CBE_3.SelectedIndex = 0;
            CBE_4.SelectedIndex = 0;
            CBE_5.SelectedIndex = 0;
            CBE_6.SelectedIndex = 0;
            CBE_7.SelectedIndex = 0;
            CBE_8.SelectedIndex = 0;
            CBE_9.SelectedIndex = 0;
            CBE_10.SelectedIndex = 0;
            CBE_11.SelectedIndex = 0;
            CBE_12.SelectedIndex = 0;



            TE_1.Text = "0";
            TE_2.Text = "0";
            TE_3.Text = "0";
            TE_4.Text = "0";
            TE_5.Text = "0";
            TE_6.Text = "0";
            TE_7.Text = "0";
            TE_8.Text = "0";
            TE_9.Text = "0";
            TE_10.Text = "0";
            TE_11.Text = "0";
            TE_12.Text = "0";


        }

        private void BT_ok_Click(object sender, EventArgs e)
        {
            BT_Apply_Click(this, null);
            BT_Cancle_Click(this, null);

        }

        private void BT_Apply_Click(object sender, EventArgs e)
        {


            double[,] data = new double[12, 2];
            data[0, 0] = CBE_1.SelectedIndex;
            double.TryParse(TE_1.Text, out data[0, 1]);

            data[1, 0] = CBE_2.SelectedIndex;
            double.TryParse(TE_2.Text, out data[1, 1]);

            data[2, 0] = CBE_3.SelectedIndex;
            double.TryParse(TE_3.Text, out data[2, 1]);

            data[3, 0] = CBE_4.SelectedIndex;
            double.TryParse(TE_4.Text, out data[3, 1]);

            data[4, 0] = CBE_5.SelectedIndex;
            double.TryParse(TE_5.Text, out data[4, 1]);

            data[5, 0] = CBE_6.SelectedIndex;
            double.TryParse(TE_6.Text, out data[5, 1]);

            data[6, 0] = CBE_7.SelectedIndex;
            double.TryParse(TE_7.Text, out data[6, 1]);

            data[7, 0] = CBE_8.SelectedIndex;
            double.TryParse(TE_8.Text, out data[7, 1]);

            data[8, 0] = CBE_9.SelectedIndex;
            double.TryParse(TE_9.Text, out data[8, 1]);

            data[9, 0] = CBE_10.SelectedIndex;
            double.TryParse(TE_10.Text, out data[9, 1]);

            data[10, 0] = CBE_11.SelectedIndex;
            double.TryParse(TE_11.Text, out data[10, 1]);

            data[11, 0] = CBE_12.SelectedIndex;
            double.TryParse(TE_12.Text, out data[11, 1]);
            for (int i = 0; i < 12;i++ )
            {
                if (data[i,0]!=165)
                {
                    data[i,1]=(int)data[i,1];

                }

            }

            db.EditAction(CBE_IO.SelectedIndex + 1, data, TE_Remark.Text);

        }

        private void Edit_Action_Load(object sender, EventArgs e)
        {

            string[] IOlist = db.GetIoName();
            CBE_1.Properties.Items.AddRange((object[])IOlist);
            CBE_2.Properties.Items.AddRange((object[])IOlist);
            CBE_3.Properties.Items.AddRange((object[])IOlist);
            CBE_4.Properties.Items.AddRange((object[])IOlist);
            CBE_5.Properties.Items.AddRange((object[])IOlist);
            CBE_6.Properties.Items.AddRange((object[])IOlist);
            CBE_7.Properties.Items.AddRange((object[])IOlist);
            CBE_8.Properties.Items.AddRange((object[])IOlist);
            CBE_9.Properties.Items.AddRange((object[])IOlist);
            CBE_10.Properties.Items.AddRange((object[])IOlist);
            CBE_11.Properties.Items.AddRange((object[])IOlist);
            CBE_12.Properties.Items.AddRange((object[])IOlist);
            IOlist = new string[50];
            for (int i = 1; i <= 50; i++)
            {
                IOlist[i - 1] = i.ToString();

            }
            CBE_IO.Properties.Items.AddRange((object[])IOlist);
            CBE_IO.SelectedIndex = SelectIndex;
        }

        private void CBE_IO_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Remark = null;
            int[,] data = db.GetAction(CBE_IO.SelectedIndex + 1, ref Remark);

            if (data != null)
            {
                TE_Remark.Text = Remark;

                CBE_1.SelectedIndex = data[0, 0];
                TE_1.Text = data[0, 1].ToString();

                CBE_2.SelectedIndex = data[1, 0];
                TE_2.Text = data[1, 1].ToString();

                CBE_3.SelectedIndex = data[2, 0];
                TE_3.Text = data[2, 1].ToString();

                CBE_4.SelectedIndex = data[3, 0];
                TE_4.Text = data[3, 1].ToString();


                CBE_5.SelectedIndex = data[4, 0];
                TE_5.Text = data[4, 1].ToString();


                CBE_6.SelectedIndex = data[5, 0];
                TE_6.Text = data[5, 1].ToString();


                CBE_7.SelectedIndex = data[6, 0];
                TE_7.Text = data[6, 1].ToString();

                CBE_8.SelectedIndex = data[7, 0];
                TE_8.Text = data[7, 1].ToString();

                CBE_9.SelectedIndex = data[8, 0];
                TE_9.Text = data[8, 1].ToString();

                CBE_10.SelectedIndex = data[9, 0];
                TE_10.Text = data[9, 1].ToString();


                CBE_11.SelectedIndex = data[10, 0];
                TE_11.Text = data[10, 1].ToString();

                CBE_12.SelectedIndex = data[11, 0];
                TE_12.Text = data[11, 1].ToString();


            }
        }
    }
}

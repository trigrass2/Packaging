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
    public partial class Edit_Preset : DevExpress.XtraEditors.XtraForm
    {
        DataBaseManage db = new DataBaseManage();
        string PresetName = null;
        int SelectIndex;
        public Edit_Preset(string preset, int index)
        {
            InitializeComponent();
            PresetName = preset;
            SelectIndex = index;
            LL_Preset.Text = "工艺名:" + PresetName;
            if (preset.ToUpper()!="Staublipreset".ToUpper())
            {
                LC_Name.Text = "速度:";
            }
        }

        private void BT_Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_Empty_Click(object sender, EventArgs e)
        {

            SE_1.Value = 0;
            SE_2.Value = 0;
            SE_3.Value = 0;
            SE_4.Value = 0;
            SE_5.Value = 0;
        }

        private void BT_Apply_Click(object sender, EventArgs e)
        {
            db.EditPresetList(PresetName, new int[] { CBE_IO.SelectedIndex+1, (int)(SE_1.Value), (int)(SE_2.Value), (int)(SE_3.Value), (int)(SE_4.Value), (int)(SE_5.Value) }, TE_Remark.Text);
        }

        private void BT_ok_Click(object sender, EventArgs e)
        {
            BT_Apply_Click(this, null);
            BT_Cancle_Click(this, null);
        }

        private void Edit_Preset_Leave(object sender, EventArgs e)
        {

        }

        private void Edit_Preset_Load(object sender, EventArgs e)
        {
            CBE_IO.Properties.Items.Clear();
            string[] Item;
            if (PresetName=="StaubliPreset")
            {
                Item=new string[50];
                for (int i=1;i<=50;i++)
                {
                    Item[i-1]=i.ToString();
                }
             

            }
            else
            {
                Item=new string[200];
                for (int i=1;i<=200;i++)
                {
                    Item[i-1]=i.ToString();
                }

            }
               CBE_IO.Properties.Items.AddRange((object[])Item);
               CBE_IO.SelectedIndex = SelectIndex;

        }

        private void CBE_IO_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] data = db.GetPresetList(PresetName,CBE_IO.SelectedIndex+1);
            if (data!=null)
            {

                SE_1.Value = decimal.Parse(data[0]);
                SE_2.Value = decimal.Parse(data[1]);
                SE_3.Value = decimal.Parse(data[2]);
                SE_4.Value = decimal.Parse(data[3]);
                SE_5.Value = decimal.Parse(data[4]);
                TE_Remark.Text = data[5];

            }

        }
    }
}

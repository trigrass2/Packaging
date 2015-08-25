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
    public partial class Sel_Recipe : DevExpress.XtraEditors.XtraForm
    {
        DataBaseManage db = new DataBaseManage();
        int WorkPlaceIndex = 0;
        bool ViewRecipe = false;
        public Sel_Recipe(int Index)
        {
            InitializeComponent();
            WorkPlaceIndex = Index;
           CBE_ProductCount.Visible=CBE_ProductIndex.Visible=TxtData.CS8CConfigure.EnableItem[4];
           CBE_ProductCount.EditValue = 1;
           CBE_ProductIndex.EditValue = 1;
        }


        public Sel_Recipe(int Index, bool View)
        {
            InitializeComponent();
            WorkPlaceIndex = Index;
            ViewRecipe = View;
            CBE_ProductCount.Visible = CBE_ProductIndex.Visible = TxtData.CS8CConfigure.EnableItem[4];
            CBE_ProductCount.EditValue = 1;
            CBE_ProductIndex.EditValue = 1;
        }

        private void Sel_Recipe_Load(object sender, EventArgs e)
        {
            TxtData.PublicData.RecipeName = db.GetRecipeName();
            TxtData.PublicData.PresetName = db.GetPresetName();

            string [] ItemId=new string [TxtData.PublicData.WorkPlaceCount];
            for (int i = 1; i <= TxtData.PublicData.WorkPlaceCount;i++)
            {
                ItemId[i - 1] = i.ToString();
            }
            this.CBE_id.Properties.Items.AddRange((object[])ItemId);
            ItemId = new string[8];
            for (int i = 1; i <= 8; i++)
            {
                ItemId[i - 1] = i.ToString();
            }
            this.CBE_ProductCount.Properties.Items.AddRange((object[])ItemId);


        
            if (TxtData.PublicData.PresetName != null && TxtData.PublicData.PresetName.Length >= 1)
            {
                CBE_Preset.Properties.Items.AddRange((object[])(TxtData.PublicData.PresetName));
            }
            CBE_Preset.Enabled = CBK_Match.Checked;

            CBE_ProductIndex.SelectedIndex = 0;
            //表示查看所有的产品
            if (ViewRecipe)
            {
                CBK_Match.Enabled = BT_ok.Enabled = BT_Apply.Enabled = CBE_Recipe.Enabled = CBE_Preset.Enabled = false;
            }

            CBE_id.SelectedIndex = Math.Min(Math.Max(WorkPlaceIndex - 1, 0), TxtData.PublicData.WorkPlaceCount - 1);
            CBE_id_SelectedIndexChanged(this, null);

        }

        private void BT_Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CBE_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = CBE_id.SelectedIndex;
            CBE_Recipe.Properties.Items.Clear();
            CBE_Recipe.EditValue = "";
            if (TxtData.PublicData.RecipeName != null && TxtData.PublicData.RecipeName.Length>i&&TxtData.PublicData.RecipeName[i] != null)
            {

                CBE_Recipe.Properties.Items.AddRange((object[])(TxtData.PublicData.RecipeName[i]));
                
            }
            CBE_ProductCount.SelectedIndex = TxtData.PublicData.ProductCount[i] - 1;

            CBE_ProductIndex_SelectedIndexChanged(this, null);

            

        }

        private void CBK_Match_CheckedChanged(object sender, EventArgs e)
        {
            CBE_Preset.Enabled = CBK_Match.Checked;
        }

        private void BT_ok_Click(object sender, EventArgs e)
        {
            BT_Apply_Click(this, null);
            BT_Cancle_Click(this, null);
        }

        private void BT_Apply_Click(object sender, EventArgs e)
        {
            if (CEL_Trajs.ItemCount == 0)
            {
                MessageBox.Show("路径为空");
                return;
            }

            if (CBK_Match.Checked && CBE_Preset.Text.Trim() == "")
            {
                MessageBox.Show("工艺不能为空");
                return;
            }

            CBE_ProductIndex.SelectedIndex = Math.Max(CBE_ProductIndex.SelectedIndex,0);
            WorkPlaceIndex = Math.Max(CBE_id.SelectedIndex,0);

            //产品名
            if (TxtData.PublicData.ProductName == null || TxtData.PublicData.ProductName.Length<=WorkPlaceIndex)
            {
                Array.Resize(ref TxtData.PublicData.ProductName, WorkPlaceIndex+1);
            }

            if (TxtData.PublicData.ProductName[WorkPlaceIndex]==null||TxtData.PublicData.ProductName[WorkPlaceIndex].Length<=CBE_ProductIndex.SelectedIndex)
            {
                Array.Resize(ref TxtData.PublicData.ProductName[WorkPlaceIndex], CBE_ProductIndex.SelectedIndex + 1);
            }
            TxtData.PublicData.ProductName[WorkPlaceIndex][CBE_ProductIndex.SelectedIndex] = CBE_Recipe.Text;

            //工艺
            if (TxtData.PublicData.MatchPresetName == null || TxtData.PublicData.MatchPresetName.Length <= WorkPlaceIndex)
            {
                Array.Resize(ref TxtData.PublicData.MatchPresetName, WorkPlaceIndex+1);
            }

            if (TxtData.PublicData.MatchPresetName[WorkPlaceIndex] == null || TxtData.PublicData.MatchPresetName[WorkPlaceIndex].Length <= CBE_ProductIndex.SelectedIndex)
            {
                Array.Resize(ref  TxtData.PublicData.MatchPresetName[WorkPlaceIndex], CBE_ProductIndex.SelectedIndex + 1);
            }
            TxtData.PublicData.MatchPresetName[WorkPlaceIndex][CBE_ProductIndex.SelectedIndex] = CBK_Match.Checked ? CBE_Preset.Text : "StaubliPreset";
          

            //路径信息
            if (TxtData.PublicData.TrajByPass == null || TxtData.PublicData.TrajByPass.Length <= WorkPlaceIndex)
            {
                Array.Resize(ref TxtData.PublicData.TrajByPass, WorkPlaceIndex+1);
            }
            if (TxtData.PublicData.TrajByPass[WorkPlaceIndex] == null || TxtData.PublicData.TrajByPass[WorkPlaceIndex].Length <= CBE_ProductIndex.SelectedIndex)
            {
                Array.Resize(ref TxtData.PublicData.TrajByPass[WorkPlaceIndex], CBE_ProductIndex.SelectedIndex + 1);
            }

            TxtData.PublicData.TrajByPass[WorkPlaceIndex][CBE_ProductIndex.SelectedIndex] = new bool[CEL_Trajs.ItemCount];
            for (int i = 0; i < CEL_Trajs.ItemCount; i++)
            {
                TxtData.PublicData.TrajByPass[WorkPlaceIndex][CBE_ProductIndex.SelectedIndex][i] =!CEL_Trajs.GetItemChecked(i);
            }



        }
        /// <summary>
        /// 选择产品名称改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CBE_Recipe_TextChanged(object sender, EventArgs e)
        {

            int SelProductIndex = Math.Max(CBE_ProductIndex.SelectedIndex,0);
            CEL_Trajs.Items.Clear();
            CEL_Trajs.Items.AddRange(db.GetTrajInfor(CBE_Recipe.Text));
            if (CEL_Trajs.Items.Count>= 1)
            {
                for (int j = 0; j < CEL_Trajs.Items.Count; j++)
                {
                    CEL_Trajs.SetItemChecked(j,true);
                }

            }
            WorkPlaceIndex = CBE_id.SelectedIndex;

            ////测试
            //if (ViewRecipe)
            //{
            //    MessageBox.Show(TxtData.PublicData.TrajByPass[WorkPlaceIndex-1].Length.ToString());
            //}

            if (TxtData.PublicData.TrajByPass[WorkPlaceIndex] != null && TxtData.PublicData.TrajByPass[WorkPlaceIndex][SelProductIndex].Length == CEL_Trajs.ItemCount)
            {

                //表示选择的路径
                //是否被选择
                for (int i = 0; i < CEL_Trajs.ItemCount; i++)
                {
                    if (TxtData.PublicData.TrajByPass[WorkPlaceIndex] != null && TxtData.PublicData.TrajByPass[WorkPlaceIndex][SelProductIndex] != null && TxtData.PublicData.TrajByPass[WorkPlaceIndex][CBE_ProductIndex.SelectedIndex].Length > CBE_ProductIndex.SelectedIndex)
                    {
                        CEL_Trajs.SetItemChecked(i, !TxtData.PublicData.TrajByPass[WorkPlaceIndex][SelProductIndex][i]);
                        if (ViewRecipe)
                        {
                           // MessageBox.Show(TxtData.PublicData.TrajByPass[WorkPlaceIndex][SelProductIndex][i].ToString());
                        }
                    }
                }



              

                if (TxtData.PublicData.MatchPresetName[WorkPlaceIndex].Length > CBE_ProductIndex.SelectedIndex)
                {

                    CBK_Match.Checked = TxtData.PublicData.MatchPresetName[WorkPlaceIndex][SelProductIndex] != "StaubliPreset";
                }
          
                if (CBK_Match.Checked)
                {
                    CBE_Preset.Text = TxtData.PublicData.MatchPresetName[WorkPlaceIndex][SelProductIndex];
                }
                if (ViewRecipe)
                {
                    CBK_Match.Enabled = CBE_Preset.Enabled = false;

                }

            }
        }

        private void CBE_ProductCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBE_ProductIndex.Properties.Items.Clear();
            string[] ItemId = new string[CBE_ProductCount.SelectedIndex+1];
            for (int i = 1; i <= ItemId.Length; i++)
            {
                ItemId[i - 1] = i.ToString();
            }
            this.CBE_ProductIndex.Properties.Items.AddRange((object[])ItemId);
            this.CBE_ProductIndex.SelectedIndex = 0;
            TxtData.PublicData.ProductCount[CBE_id.SelectedIndex] = CBE_ProductCount.SelectedIndex + 1;
        }

        private void CBE_ProductIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = CBE_id.SelectedIndex;
            if (TxtData.PublicData.ProductName != null && TxtData.PublicData.ProductName.Length > i && TxtData.PublicData.ProductName[i] != null && TxtData.PublicData.ProductName[i].Length > CBE_ProductIndex.SelectedIndex)
            {
                CBE_Recipe.Text = TxtData.PublicData.ProductName[i][CBE_ProductIndex.SelectedIndex];
            }
            if (TxtData.PublicData.MatchPresetName != null && TxtData.PublicData.MatchPresetName.Length > i && TxtData.PublicData.MatchPresetName[i] != null && TxtData.PublicData.MatchPresetName[i].Length > CBE_ProductIndex.SelectedIndex)
            {
                CBE_Preset.Text = TxtData.PublicData.MatchPresetName[i][CBE_ProductIndex.SelectedIndex];
            }
        }
    }
}

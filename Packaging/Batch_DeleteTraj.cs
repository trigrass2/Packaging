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
    public partial class Batch_DeleteTraj : DevExpress.XtraEditors.XtraForm
    {
        DataBaseManage db = new DataBaseManage();
        int TrajIndex= 0;
        string RecipeName;
        public Batch_DeleteTraj(string recipe,int Index)
        {
            TxtData.PublicData.DeleteTrajIndex = null;
            InitializeComponent();
       
            TrajIndex= Index;
            RecipeName = recipe;
            this.Text = "选择产品" + recipe + "需要删除的路径";
        }


        private void Sel_Recipe_Load(object sender, EventArgs e)
        {
            CEL_Trajs.Items.Clear();
            CEL_Trajs.Items.AddRange(db.GetTrajInfor(RecipeName));
            if (CEL_Trajs.Items.Count >= 1)
            {
                for (int j = 0; j < CEL_Trajs.Items.Count; j++)
                {
                    if (j==TrajIndex)
                    {
                        CEL_Trajs.SetItemChecked(j, true);
                    }
                    else
                    {
                        CEL_Trajs.SetItemChecked(j, false);
                    }
                    
                }

            }
        }

        private void BT_Cancle_Click(object sender, EventArgs e)
        {
            TxtData.PublicData.DeleteTrajIndex = null;
            this.Close();
        }

        private void BT_ok_Click(object sender, EventArgs e)
        {
            if (CEL_Trajs.ItemCount==0)
            {
                MessageBox.Show("没有可删除路径");
                return;
            }
            int DeleteCount=0;
            for (int i=0;i<CEL_Trajs.ItemCount;i++)
            {
                if (CEL_Trajs.GetItemChecked(i))
                {
                    DeleteCount++;
                }
            }
           if (DeleteCount==0)
            {
                MessageBox.Show("没有可删除路径");
                return;
            }
            TxtData.PublicData.DeleteTrajIndex =new int[DeleteCount];

             DeleteCount = 0;
            for (int i = 0; i < CEL_Trajs.ItemCount; i++)
            {
                if (CEL_Trajs.GetItemChecked(i))
                {
                    TxtData.PublicData.DeleteTrajIndex[DeleteCount] = i+1;
                    DeleteCount++;
                }
            }
            this.Close();

        }

        //private void CBE_id_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    int i = CBE_id.SelectedIndex;
        //    CBE_Recipe.Properties.Items.Clear();
        //    CBE_Recipe.EditValue = "";
        //    if (TxtData.PublicData.RecipeName != null && TxtData.PublicData.RecipeName.Length>i&&TxtData.PublicData.RecipeName[i] != null)
        //    {

        //        CBE_Recipe.Properties.Items.AddRange((object[])(TxtData.PublicData.RecipeName[i]));
                
        //    }
        //    CBE_ProductCount.SelectedIndex = TxtData.PublicData.ProductCount[i] - 1;

        //    CBE_ProductIndex_SelectedIndexChanged(this, null);

            

        //}

        //private void BT_ok_Click(object sender, EventArgs e)
        //{
        //    BT_Apply_Click(this, null);
        //    BT_Cancle_Click(this, null);
        //}

        //private void BT_Apply_Click(object sender, EventArgs e)
        //{
        //    if (CEL_Trajs.ItemCount == 0)
        //    {
        //        MessageBox.Show("路径为空");
        //        return;
        //    }

        //    if (CBK_Match.Checked && CBE_Preset.Text.Trim() == "")
        //    {
        //        MessageBox.Show("工艺不能为空");
        //        return;
        //    }

        //    CBE_ProductIndex.SelectedIndex = Math.Max(CBE_ProductIndex.SelectedIndex,0);
        //    WorkPlaceIndex = Math.Max(CBE_id.SelectedIndex,0);

        //    //产品名
        //    if (TxtData.PublicData.ProductName == null || TxtData.PublicData.ProductName.Length<=WorkPlaceIndex)
        //    {
        //        Array.Resize(ref TxtData.PublicData.ProductName, WorkPlaceIndex+1);
        //    }

        //    if (TxtData.PublicData.ProductName[WorkPlaceIndex]==null||TxtData.PublicData.ProductName[WorkPlaceIndex].Length<=CBE_ProductIndex.SelectedIndex)
        //    {
        //        Array.Resize(ref TxtData.PublicData.ProductName[WorkPlaceIndex], CBE_ProductIndex.SelectedIndex + 1);
        //    }
        //    TxtData.PublicData.ProductName[WorkPlaceIndex][CBE_ProductIndex.SelectedIndex] = CBE_Recipe.Text;

        //    //工艺
        //    if (TxtData.PublicData.MatchPresetName == null || TxtData.PublicData.MatchPresetName.Length <= WorkPlaceIndex)
        //    {
        //        Array.Resize(ref TxtData.PublicData.MatchPresetName, WorkPlaceIndex+1);
        //    }

        //    if (TxtData.PublicData.MatchPresetName[WorkPlaceIndex] == null || TxtData.PublicData.MatchPresetName[WorkPlaceIndex].Length <= CBE_ProductIndex.SelectedIndex)
        //    {
        //        Array.Resize(ref  TxtData.PublicData.MatchPresetName[WorkPlaceIndex], CBE_ProductIndex.SelectedIndex + 1);
        //    }
        //    TxtData.PublicData.MatchPresetName[WorkPlaceIndex][CBE_ProductIndex.SelectedIndex] = CBK_Match.Checked ? CBE_Preset.Text : "StaubliPreset";
          

        //    //路径信息
        //    if (TxtData.PublicData.TrajByPass == null || TxtData.PublicData.TrajByPass.Length <= WorkPlaceIndex)
        //    {
        //        Array.Resize(ref TxtData.PublicData.TrajByPass, WorkPlaceIndex+1);
        //    }
        //    if (TxtData.PublicData.TrajByPass[WorkPlaceIndex] == null || TxtData.PublicData.TrajByPass[WorkPlaceIndex].Length <= CBE_ProductIndex.SelectedIndex)
        //    {
        //        Array.Resize(ref TxtData.PublicData.TrajByPass[WorkPlaceIndex], CBE_ProductIndex.SelectedIndex + 1);
        //    }

        //    TxtData.PublicData.TrajByPass[WorkPlaceIndex][CBE_ProductIndex.SelectedIndex] = new bool[CEL_Trajs.ItemCount];
        //    for (int i = 0; i < CEL_Trajs.ItemCount; i++)
        //    {
        //        TxtData.PublicData.TrajByPass[WorkPlaceIndex][CBE_ProductIndex.SelectedIndex][i] =!CEL_Trajs.GetItemChecked(i);
        //    }



        //}
        ///// <summary>
        ///// 选择产品名称改变
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void CBE_Recipe_TextChanged(object sender, EventArgs e)
        //{
        //    CEL_Trajs.Items.Clear();
        //    CEL_Trajs.Items.AddRange(db.GetTrajInfor(CBE_Recipe.Text));
        //    if (CEL_Trajs.Items.Count>= 1)
        //    {
        //        for (int j = 0; j < CEL_Trajs.Items.Count; j++)
        //        {
        //            CEL_Trajs.SetItemChecked(j,true);
        //        }

        //    }
        //    WorkPlaceIndex = CBE_id.SelectedIndex;
        //    if (TxtData.PublicData.TrajByPass[WorkPlaceIndex] != null && TxtData.PublicData.TrajByPass[WorkPlaceIndex].Length == CEL_Trajs.ItemCount)
        //    {
        //        for (int i = 0; i < CEL_Trajs.ItemCount; i++)
        //        {
        //            if (TxtData.PublicData.TrajByPass[WorkPlaceIndex] != null && TxtData.PublicData.TrajByPass[WorkPlaceIndex][i] != null && TxtData.PublicData.TrajByPass[WorkPlaceIndex][i].Length > CBE_ProductIndex.SelectedIndex)
        //            {
        //                CEL_Trajs.SetItemChecked(i, !TxtData.PublicData.TrajByPass[WorkPlaceIndex][i][CBE_ProductIndex.SelectedIndex]);
        //            }
        //        }
        //        if (TxtData.PublicData.MatchPresetName[WorkPlaceIndex].Length > CBE_ProductIndex.SelectedIndex)
        //        {
        //            CBK_Match.Checked = TxtData.PublicData.MatchPresetName[WorkPlaceIndex][CBE_ProductIndex.SelectedIndex] != "StaubliPreset";
        //        }
          
        //        if (CBK_Match.Checked)
        //        {
        //            CBE_Preset.Text = TxtData.PublicData.MatchPresetName[WorkPlaceIndex][CBE_ProductIndex.SelectedIndex];
        //        }


        //    }
        //}

        //private void CBE_ProductCount_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    CBE_ProductIndex.Properties.Items.Clear();
        //    string[] ItemId = new string[CBE_ProductCount.SelectedIndex+1];
        //    for (int i = 1; i <= ItemId.Length; i++)
        //    {
        //        ItemId[i - 1] = i.ToString();
        //    }
        //    this.CBE_ProductIndex.Properties.Items.AddRange((object[])ItemId);
        //    this.CBE_ProductIndex.SelectedIndex = 0;
        //    TxtData.PublicData.ProductCount[CBE_id.SelectedIndex] = CBE_ProductCount.SelectedIndex + 1;
        //}

        //private void CBE_ProductIndex_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    int i = CBE_id.SelectedIndex;
        //    if (TxtData.PublicData.ProductName != null && TxtData.PublicData.ProductName.Length > i && TxtData.PublicData.ProductName[i] != null && TxtData.PublicData.ProductName[i].Length > CBE_ProductIndex.SelectedIndex)
        //    {
        //        CBE_Recipe.Text = TxtData.PublicData.ProductName[i][CBE_ProductIndex.SelectedIndex];
        //    }
        //    if (TxtData.PublicData.MatchPresetName != null && TxtData.PublicData.MatchPresetName.Length > i && TxtData.PublicData.MatchPresetName[i] != null && TxtData.PublicData.MatchPresetName[i].Length > CBE_ProductIndex.SelectedIndex)
        //    {
        //        CBE_Preset.Text = TxtData.PublicData.MatchPresetName[i][CBE_ProductIndex.SelectedIndex];
        //    }
        //}
    }
}

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
    public partial class Frm_Stat : Std_Form
    {
        DataBaseManage db = new DataBaseManage();
        public Frm_Stat()
        {
            InitializeComponent();
        }

        private void Frm_Stat_Load(object sender, EventArgs e)
        {
            TxtData.PublicData.Customs = db.GetCustom();
            DE_1.DateTime = DE_3.DateTime = DE_5.DateTime = DateTime.Now.AddDays(-1);
            DE_2.DateTime = DE_4.DateTime = DE_6.DateTime = DateTime.Now.AddDays(1);
            CBE_Product.Properties.Items.Clear();
            TxtData.PublicData.RecipeName = db.GetRecipeName();
            if (TxtData.PublicData.RecipeName != null && TxtData.PublicData.RecipeName.Rank >= 1)
            {
                string[] RecipeName = new string[
                      (TxtData.PublicData.RecipeName[0] == null ? 0 : TxtData.PublicData.RecipeName[0].Length)
                    + (TxtData.PublicData.RecipeName[1] == null ? 0 : TxtData.PublicData.RecipeName[1].Length)
                    + (TxtData.PublicData.RecipeName[2] == null ? 0 : TxtData.PublicData.RecipeName[2].Length)
                    + (TxtData.PublicData.RecipeName[3] == null ? 0 : TxtData.PublicData.RecipeName[3].Length)
                      ];
                int j = 0;

                for (int i = 0; i < 4; i++)
                {
                    if (TxtData.PublicData.RecipeName[i] != null)
                    {
                        for (int k = 0; k < TxtData.PublicData.RecipeName[i].Length; k++)
                        {
                            RecipeName[j] = TxtData.PublicData.RecipeName[i][k];
                            j++;
                        }


                    }

                }


                CBE_Product.Properties.Items.AddRange((object[])RecipeName);
                CBE_Product.SelectedIndex = 0;

            }

            if (TxtData.PublicData.Customs != null)
            {
                CBE_Customs.Properties.Items.AddRange((object[])TxtData.PublicData.Customs);
                CBE_Customs.SelectedIndex = 0;
            }

            BT_OK1_Click(this,null);

            BT_OK2_Click(this, null);

            BT_OK3_Click(this, null);


        }
        private int GetCount(DevExpress.XtraGrid.Views.Grid.GridView gv)
        {
            if (gv==null||gv.RowCount<=0)
            {
                return 0;
            }

            try
            {
                int Count = 0;
                for (int i = 0; i < gv.RowCount; i++)
                {

                    Count = Count + int.Parse(gv.GetRowCellValue(i, "COUNT").ToString());


                }

                return Count;
            }
            catch (System.Exception ex)
            {
                return 0;
            	
            }

        }

        private void BT_OK1_Click(object sender, EventArgs e)
        {
            if (DE_2.DateTime<DE_1.DateTime)
            {
                MessageBox.Show("开始时间超过结束时间!");
                return;
            }
            GC_1.DataSource = db.GetDV_ProductCount(DE_1.DateTime.ToString(),DE_2.DateTime.ToString());
            Refreshgv(gv1);
          //  //DevExpress.XtraGrid.Views.Grid.GridView gv =(DevExpress.XtraGrid.Views.Grid.GridView)gv1;
        
          //  int Count = 0;
          //  for (int i = 0; i < gv1.RowCount;i++ )
          //  {
          //      gv1.GetRowCellValue(i,)
          ////  gv1.
          //    /// Count=Count+gv.GetDataRow(i).V
                 


          //  }
            LL_1.Text = "总件数:" + GetCount(gv1).ToString();

        }

        private void BT_OK2_Click(object sender, EventArgs e)
        {
            if (DE_4.DateTime < DE_3.DateTime)
            {
                MessageBox.Show("开始时间超过结束时间!");
                return;
            }
            if (CBE_Customs.EditValue!=null)
            {
                GC_2.DataSource = db.GetDV_CustomCount(CBE_Customs.EditValue.ToString(), DE_3.DateTime.ToString(), DE_4.DateTime.ToString());
                Refreshgv(gv2);
                LL_2.Text = "总件数:" +GetCount(gv2).ToString();
            }
       

        }

        private void BT_OK3_Click(object sender, EventArgs e)
        {
            if (DE_6.DateTime < DE_5.DateTime)
            {
                MessageBox.Show("开始时间超过结束时间!");
                return;
            }
            if (CBE_Product.EditValue!=null)
            {
                GC_3.DataSource = db.GetDV_ProductCount(CBE_Product.EditValue.ToString(), DE_5.DateTime.ToString(), DE_6.DateTime.ToString());
                Refreshgv(gv3);
                LL_3.Text = "总件数:" + GetCount(gv3).ToString();
            }

        }


      void Refreshgv(DevExpress.XtraGrid.Views.Grid.GridView gv)
        {
            if (gv!=null)
            {

                gv.Columns.Remove(gv.Columns["ID"]);
                gv.Columns.Remove(gv.Columns["OPERATOR"]);
                gv.Columns.Remove(gv.Columns["TOTALTIME"]);

                gv.Columns.Remove(gv.Columns["REMARK"]);
                gv.Columns.Remove(gv.Columns["BP1"]);
                gv.Columns.Remove(gv.Columns["BP2"]);
                gv.Columns.Remove(gv.Columns["BP3"]);
                gv.Columns.Remove(gv.Columns["BP4"]);

                //gv.Columns.Remove(gv.Columns["OFFSET_X"]);
                //************************************************
                gv.Columns["CUSTOMER"].Caption = "客户";
                gv.Columns["RECIPENAME"].Caption = "产品名称";
                gv.Columns["DATETIME"].Caption = "时间";
                gv.Columns["COUNT"].Caption = "总个数";
                gv.Columns["DATETIME"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;


            }




        }

      private void BT_PDF_Click(object sender, EventArgs e)
      {
          string FileName;
          if ((FileName = PublicFunc.SfD_Show(Application.StartupPath,"PDF文件|*.pdf")) == null)
          {
              return;
          }
          gv1.ExportToPdf(FileName);
      }

      private void BT_X1_Click(object sender, EventArgs e)
      {
          string FileName;
          if ((FileName = PublicFunc.SfD_Show(Application.StartupPath, "XLS文件|*.xls")) == null)
          {
              return;
          }
          gv1.ExportToXls(FileName);
      }

      private void BT_P3_Click(object sender, EventArgs e)
      {
          string FileName;
          if ((FileName = PublicFunc.SfD_Show(Application.StartupPath, "PDF文件|*.pdf")) == null)
          {
              return;
          }
          gv3.ExportToPdf(FileName);
      }

      private void BT_X3_Click(object sender, EventArgs e)
      {
          string FileName;
          if ((FileName = PublicFunc.SfD_Show(Application.StartupPath, "XLS文件|*.xls")) == null)
          {
              return;
          }
          gv3.ExportToXls(FileName);
      }

      private void BT_P2_Click(object sender, EventArgs e)
      {
          string FileName;
          if ((FileName = PublicFunc.SfD_Show(Application.StartupPath, "PDF文件|*.pdf")) == null)
          {
              return;
          }
          gv2.ExportToPdf(FileName);
      }

      private void BT_X2_Click(object sender, EventArgs e)
      {
          string FileName;
          if ((FileName = PublicFunc.SfD_Show(Application.StartupPath, "XLS文件|*.xls")) == null)
          {
              return;
          }
          gv2.ExportToXls(FileName);

      }



    }
}

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
    public partial class Frm_IOConfig : Std_Form
    {
        private DataBaseManage db = new DataBaseManage();
        
        public Frm_IOConfig()
        {
            InitializeComponent();
        }

        private void CB_RobotCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            gv.Columns.Clear();
            GC_Modbus.DataSource = db.GetDV_Iolist();
            //去除其中的列和题头
            //   GC_Modbus.
            if (gv.RowCount > 12)
            
            
            {
                //gv.Columns.Remove(gv.Columns["INDEX"]);
                gv.Columns.Remove(gv.Columns["编号"]);
                gv.Columns.Remove(gv.Columns["ID"]);
               // gv.Columns.Remove(gv.Columns["BP1"]);
                gv.Columns.Remove(gv.Columns["BP2"]);
                gv.Columns.Remove(gv.Columns["BP3"]);
                gv.Columns.Remove(gv.Columns["BP4"]);
                  gv.Columns.Remove(gv.Columns["REMARK"]);
                   gv.Columns["INDEX"].Caption = "序号";
                gv.Columns["IONAME"].Caption = "IO名称";
                gv.Columns["TYPE"].Caption = "类型";
                gv.Columns["MOUDLE"].Caption = "模块";
                //gv.Columns.Remove(gv.Columns["REMARK"]);
                //gv.Columns["FOLLOWSEN"].Caption = "随动高度";
                gv.Columns["BP1"].Caption = "值";


                for (int i=0;i<9;i++)
                {
                    if (i == CB_RobotCount.SelectedIndex)
                    {
                        gv.Columns["REMARK" + i.ToString()].Caption = "备注";

                    }
                    else
                    {

                        gv.Columns.Remove(gv.Columns["REMARK" + i.ToString()]);
                    }
                }



            }

            SetDataRowValue();
        }

        private void gv_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            //if (gv.GetFocusedRowCellDisplayText())
            //{
            //}
            Edit_IOMess frm = new Edit_IOMess(gv.GetSelectedRows()[0] - 1,CB_RobotCount.SelectedIndex);
            frm.ShowDialog();
           // Frm_Modbus_Load(this, null);
            CB_RobotCount_SelectedIndexChanged(this,null);




                        
        }

        private void SetDataRowValue()
        {

            if (gv.RowCount < 20 || gv.Columns.IndexOf(gv.Columns["BP1"]) < 0)
            {
                return;
            }for (int i=0;i<gv.RowCount;i++){

                gv.SetRowCellValue(i, gv.Columns["BP1"], "不存在");
            }





        }




    }
}
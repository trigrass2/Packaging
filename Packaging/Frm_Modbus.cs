using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Packaging
{
    public partial class Frm_Modbus : Std_DataView
    {
        public Frm_Modbus()
        {
            InitializeComponent();

        }

        private void Frm_Modbus_Load(object sender, EventArgs e)
        {




            GC_Modbus.DataSource = db.GetDV_Iolist();
            //去除其中的列和题头
            //   GC_Modbus.
            if (gv.RowCount > 12)
            {
                gv.Columns.Remove(gv.Columns["INDEX"]);
                gv.Columns.Remove(gv.Columns["编号"]);
                gv.Columns.Remove(gv.Columns["ID"]);
                gv.Columns.Remove(gv.Columns["BP1"]);
                gv.Columns.Remove(gv.Columns["BP2"]);
                gv.Columns.Remove(gv.Columns["BP3"]);
                gv.Columns.Remove(gv.Columns["BP4"]);
              //  gv.Columns.Remove(gv.Columns["REMARK"]);
             //   gv.Columns["INDEX"].Caption = "序号";
                gv.Columns["IONAME"].Caption = "IO名称";
                gv.Columns["TYPE"].Caption = "类型";
                gv.Columns["MOUDLE"].Caption = "模块";
                gv.Columns["REMARK"].Caption = "备注";
                //gv.Columns["FOLLOWSEN"].Caption = "随动高度";
                //gv.Columns["REMARK"].Caption = "备注";

            }

            //gc_control.Visible = false;
            BT_Teach.Visible = BT_Import.Visible = BT_OutPort.Visible = false;
            BT_Edit.Visible = true;
        }

        private void BT_Edit_Click(object sender, EventArgs e)
        {
            //Edit_Action frm = new Edit_Action(gv.GetSelectedRows()[0]);
            Edit_IOMess frm = new Edit_IOMess(gv.GetSelectedRows()[0] - 1);
            frm.ShowDialog();
            Frm_Modbus_Load(this, null);
        }}
}

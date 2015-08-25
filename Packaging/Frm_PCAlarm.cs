using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using StaubliRobot;
using System.Threading;

namespace Packaging
{
    public partial class Frm_PCAlarm: Std_Form
    {
        DataBaseManage db = new DataBaseManage();
        public Frm_PCAlarm()
        {
            InitializeComponent();
        }

        private void timer_Refresh_Tick(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void Frm_PCAlarm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }




        private void RefreshData()
        {
            GC_Alarm.DataSource = db.GetDV_Event();
            if (gv.RowCount > 0)
            {


                gv.Columns.Remove(gv.Columns["REMARK"]);
                gv.Columns.Remove(gv.Columns["BP1"]);
                gv.Columns.Remove(gv.Columns["BP2"]);
                gv.Columns.Remove(gv.Columns["BP3"]);
                gv.Columns.Remove(gv.Columns["BP4"]);

                //gv.Columns.Remove(gv.Columns["ARRAY_XCOUNT"]);
                //gv.Columns.Remove(gv.Columns["ARRAY_XOFFSET"]);
                //gv.Columns.Remove(gv.Columns["ARRAY_YCOUNT"]);
                //gv.Columns.Remove(gv.Columns["ARRAY_YOFFSET"]);
                ////gv.Columns.Remove(gv.Columns["OFFSET_X"]);
                ////************************************************
                gv.Columns["ID"].Caption = "序号";
                gv.Columns["DATETIME"].Caption = "日期";
              //   gv.Columns["DATETIME"].
                gv.Columns["EVENTLOG"].Caption = "事件内容";

                gv.Columns["ALARM"].Caption = "报警";
                gv.Columns["ID"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;



            }
  


        }

        private void BT_OutPort_Click(object sender, EventArgs e)
        {
            string FileName;
            if ((FileName = PublicFunc.SfD_Show(Application.StartupPath, "XLS文件|*.xls")) == null)
            {
                return;
            }
            gv.ExportToXls(FileName);
        }

        private void BT_Edit_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("确定需要全部清空吗？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            TxtData.PublicData.ErrorCode = 0;
            System.Threading.ThreadPool.QueueUserWorkItem(new WaitCallback(PollImport));
            Frm_Wait frm = new Frm_Wait();
            frm.ShowDialog();
            Frm_PCAlarm_Load(this,null);
        }

        void PollImport(object target)
        {
            DataBaseManage db = new DataBaseManage();
            TxtData.PublicData.ErrorCode = db.DeleteLog() ? 40 : 35;
        }
    }
}

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
    public partial class Frm_ConveyorConfig : Std_Form

    {

        private DataBaseManage db = new DataBaseManage();
        public Frm_ConveyorConfig()
        {
            InitializeComponent();
            CB_RobotIndex.Items.Clear();
            CB_RobotIndex.Items.AddRange(TxtData.RobotIndex);
        }

        private void CB_RobotCount_SelectedIndexChanged(object sender, EventArgs e)
        {


            string[] ConveryName = db.GetConveyorName(CB_RobotIndex.SelectedIndex+1);
            CB_Conveyor.Items.Clear();
            if (ConveryName!=null)
            {

            
                CB_Conveyor.Items.AddRange(ConveryName);
            }


        }


        private void CB_Conveyor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Conveyor.SelectedItem!=null&&CB_Conveyor.SelectedItem.ToString() != "")
            {

                string[] data = db.GetConveyorInfor(CB_Conveyor.SelectedItem.ToString());

                if (data != null && data.Length > 10)
                {



                    CB_Commun.Checked = (data[3] != null && data[3].ToUpper() == "TRUE") ? true : false;






                }





            }
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_New_Click(object sender, EventArgs e)
        {

        }

        private void BT_Save_Click(object sender, EventArgs e)
        {

        }

        private void BT_Download_Click(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Packaging
{
    public partial class Frm_Pallet : Std_Form
    {
        public Frm_Pallet()
        {
            InitializeComponent();
        }

        private void BT_PalletPara_Click(object sender, EventArgs e)
        {

            Frm_PalletPara frm = new Frm_PalletPara();
            frm.ShowDialog();

        }
    }
}
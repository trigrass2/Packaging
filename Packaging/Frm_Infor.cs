using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Packaging
{
    public partial class Frm_Infor : Std_Form
    {
        public Frm_Infor()
        {
            InitializeComponent();
        }

        private void Frm_Infor_Load(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath+"\\MainShow.jpg"))
            {
                this.PE_Main.Image =Image.FromFile(Application.StartupPath + "\\MainShow.jpg");
            }
        }
    }
}

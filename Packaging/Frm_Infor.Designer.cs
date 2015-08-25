namespace Packaging
{
    partial class Frm_Infor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PE_Main = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.PE_Main.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // PE_Main
            // 
            this.PE_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PE_Main.EditValue = global::Packaging.Properties.Resources._2014_03_12_101049;
            this.PE_Main.Location = new System.Drawing.Point(0, 0);
            this.PE_Main.Name = "PE_Main";
            this.PE_Main.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.PE_Main.Size = new System.Drawing.Size(564, 363);
            this.PE_Main.TabIndex = 0;
            // 
            // Frm_Infor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 363);
            this.Controls.Add(this.PE_Main);
            this.Name = "Frm_Infor";
            this.Text = "Frm_Infor";
            this.Load += new System.EventHandler(this.Frm_Infor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PE_Main.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit PE_Main;
    }
}
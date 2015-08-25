namespace Packaging
{
    partial class Frm_Wait
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
            this.components = new System.ComponentModel.Container();
            this.PP_process = new DevExpress.XtraWaitForm.ProgressPanel();
            this.BT_OK = new DevExpress.XtraEditors.SimpleButton();
            this.timer_Refresh = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // PP_process
            // 
            this.PP_process.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.PP_process.Appearance.Options.UseBackColor = true;
            this.PP_process.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PP_process.AppearanceCaption.Options.UseFont = true;
            this.PP_process.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PP_process.AppearanceDescription.Options.UseFont = true;
            this.PP_process.Caption = "请耐心等待";
            this.PP_process.Description = "程序正在运行......";
            this.PP_process.Location = new System.Drawing.Point(4, 16);
            this.PP_process.Name = "PP_process";
            this.PP_process.Size = new System.Drawing.Size(227, 65);
            this.PP_process.TabIndex = 0;
            this.PP_process.Text = "进度条";
            // 
            // BT_OK
            // 
            this.BT_OK.Location = new System.Drawing.Point(65, 110);
            this.BT_OK.Name = "BT_OK";
            this.BT_OK.Size = new System.Drawing.Size(75, 23);
            this.BT_OK.TabIndex = 1;
            this.BT_OK.Text = "终止";
            this.BT_OK.Click += new System.EventHandler(this.BT_OK_Click);
            // 
            // timer_Refresh
            // 
            this.timer_Refresh.Enabled = true;
            this.timer_Refresh.Tick += new System.EventHandler(this.timer_Refresh_Tick);
            // 
            // Frm_Wait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 169);
            this.Controls.Add(this.BT_OK);
            this.Controls.Add(this.PP_process);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_Wait";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "请等待";
            this.Load += new System.EventHandler(this.Frm_Wait_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWaitForm.ProgressPanel PP_process;
        private DevExpress.XtraEditors.SimpleButton BT_OK;
        private System.Windows.Forms.Timer timer_Refresh;
    }
}
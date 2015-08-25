namespace Packaging
{
    partial class Edit_Ip
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
            this.BT_ok = new DevExpress.XtraEditors.SimpleButton();
            this.BT_Cancle = new DevExpress.XtraEditors.SimpleButton();
            this.LL_Text = new DevExpress.XtraEditors.LabelControl();
            this.TB_Code = new DevExpress.XtraEditors.TextEdit();
            this.LL_Mark = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.TB_Code.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_ok
            // 
            this.BT_ok.Location = new System.Drawing.Point(20, 131);
            this.BT_ok.Name = "BT_ok";
            this.BT_ok.Size = new System.Drawing.Size(75, 23);
            this.BT_ok.TabIndex = 0;
            this.BT_ok.Text = "确定";
            this.BT_ok.Click += new System.EventHandler(this.BT_ok_Click);
            // 
            // BT_Cancle
            // 
            this.BT_Cancle.Location = new System.Drawing.Point(128, 131);
            this.BT_Cancle.Name = "BT_Cancle";
            this.BT_Cancle.Size = new System.Drawing.Size(75, 23);
            this.BT_Cancle.TabIndex = 1;
            this.BT_Cancle.Text = "取消";
            this.BT_Cancle.Click += new System.EventHandler(this.BT_Cancle_Click);
            // 
            // LL_Text
            // 
            this.LL_Text.Location = new System.Drawing.Point(13, 41);
            this.LL_Text.Name = "LL_Text";
            this.LL_Text.Size = new System.Drawing.Size(26, 13);
            this.LL_Text.TabIndex = 2;
            this.LL_Text.Text = "新IP:";
            // 
            // TB_Code
            // 
            this.TB_Code.Location = new System.Drawing.Point(110, 41);
            this.TB_Code.Name = "TB_Code";
            this.TB_Code.Size = new System.Drawing.Size(100, 20);
            this.TB_Code.TabIndex = 3;
            // 
            // LL_Mark
            // 
            this.LL_Mark.Location = new System.Drawing.Point(13, 82);
            this.LL_Mark.Name = "LL_Mark";
            this.LL_Mark.Size = new System.Drawing.Size(24, 13);
            this.LL_Mark.TabIndex = 4;
            this.LL_Mark.Text = "备注";
            // 
            // Edit_Ip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 174);
            this.ControlBox = false;
            this.Controls.Add(this.LL_Mark);
            this.Controls.Add(this.TB_Code);
            this.Controls.Add(this.LL_Text);
            this.Controls.Add(this.BT_Cancle);
            this.Controls.Add(this.BT_ok);
            this.Name = "Edit_Ip";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit_Ip";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Edit_Ip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TB_Code.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BT_ok;
        private DevExpress.XtraEditors.SimpleButton BT_Cancle;
        private DevExpress.XtraEditors.LabelControl LL_Text;
        private DevExpress.XtraEditors.TextEdit TB_Code;
        private DevExpress.XtraEditors.LabelControl LL_Mark;
    }
}
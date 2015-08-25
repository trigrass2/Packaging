namespace Packaging
{
    partial class Add_Preset
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
            this.TB_Name = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TB_Remark = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_Remark.Properties)).BeginInit();
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
            this.LL_Text.Location = new System.Drawing.Point(32, 48);
            this.LL_Text.Name = "LL_Text";
            this.LL_Text.Size = new System.Drawing.Size(28, 13);
            this.LL_Text.TabIndex = 2;
            this.LL_Text.Text = "名称:";
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(90, 41);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(120, 20);
            this.TB_Name.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(32, 80);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "备注:";
            // 
            // TB_Remark
            // 
            this.TB_Remark.Location = new System.Drawing.Point(90, 77);
            this.TB_Remark.Name = "TB_Remark";
            this.TB_Remark.Size = new System.Drawing.Size(120, 20);
            this.TB_Remark.TabIndex = 5;
            // 
            // Add_Preset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 174);
            this.ControlBox = false;
            this.Controls.Add(this.TB_Remark);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.LL_Text);
            this.Controls.Add(this.BT_Cancle);
            this.Controls.Add(this.BT_ok);
            this.Name = "Add_Preset";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加速度匹配工艺";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Edit_Ip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TB_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_Remark.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BT_ok;
        private DevExpress.XtraEditors.SimpleButton BT_Cancle;
        private DevExpress.XtraEditors.LabelControl LL_Text;
        private DevExpress.XtraEditors.TextEdit TB_Name;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TB_Remark;
    }
}
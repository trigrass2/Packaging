namespace Packaging
{
    partial class Edit_IOMess
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
            this.BT_Apply = new DevExpress.XtraEditors.SimpleButton();
            this.CBE_IO = new DevExpress.XtraEditors.ComboBoxEdit();
            this.BT_Cancle = new DevExpress.XtraEditors.SimpleButton();
            this.LC_Name = new DevExpress.XtraEditors.LabelControl();
            this.LL_Remark = new DevExpress.XtraEditors.LabelControl();
            this.TE_Remark = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TB_Name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CBE_IO.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_ok
            // 
            this.BT_ok.Location = new System.Drawing.Point(8, 160);
            this.BT_ok.Name = "BT_ok";
            this.BT_ok.Size = new System.Drawing.Size(75, 23);
            this.BT_ok.TabIndex = 0;
            this.BT_ok.Text = "确定";
            this.BT_ok.Click += new System.EventHandler(this.BT_ok_Click);
            // 
            // BT_Apply
            // 
            this.BT_Apply.Location = new System.Drawing.Point(108, 160);
            this.BT_Apply.Name = "BT_Apply";
            this.BT_Apply.Size = new System.Drawing.Size(75, 23);
            this.BT_Apply.TabIndex = 1;
            this.BT_Apply.Text = "应用";
            this.BT_Apply.Click += new System.EventHandler(this.BT_Apply_Click);
            // 
            // CBE_IO
            // 
            this.CBE_IO.Location = new System.Drawing.Point(70, 6);
            this.CBE_IO.Name = "CBE_IO";
            this.CBE_IO.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CBE_IO.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.CBE_IO.Size = new System.Drawing.Size(100, 20);
            this.CBE_IO.TabIndex = 3;
            this.CBE_IO.SelectedIndexChanged += new System.EventHandler(this.CBE_IO_SelectedIndexChanged);
            // 
            // BT_Cancle
            // 
            this.BT_Cancle.Location = new System.Drawing.Point(207, 160);
            this.BT_Cancle.Name = "BT_Cancle";
            this.BT_Cancle.Size = new System.Drawing.Size(75, 23);
            this.BT_Cancle.TabIndex = 6;
            this.BT_Cancle.Text = "取消";
            this.BT_Cancle.Click += new System.EventHandler(this.BT_Cancle_Click);
            // 
            // LC_Name
            // 
            this.LC_Name.Location = new System.Drawing.Point(18, 9);
            this.LC_Name.Name = "LC_Name";
            this.LC_Name.Size = new System.Drawing.Size(28, 13);
            this.LC_Name.TabIndex = 7;
            this.LC_Name.Text = "序号:";
            // 
            // LL_Remark
            // 
            this.LL_Remark.Location = new System.Drawing.Point(18, 71);
            this.LL_Remark.Name = "LL_Remark";
            this.LL_Remark.Size = new System.Drawing.Size(28, 13);
            this.LL_Remark.TabIndex = 8;
            this.LL_Remark.Text = "备注:";
            // 
            // TE_Remark
            // 
            this.TE_Remark.Location = new System.Drawing.Point(69, 68);
            this.TE_Remark.Multiline = true;
            this.TE_Remark.Name = "TE_Remark";
            this.TE_Remark.Size = new System.Drawing.Size(213, 74);
            this.TE_Remark.TabIndex = 9;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 13);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "名称:";
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(70, 41);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.ReadOnly = true;
            this.TB_Name.Size = new System.Drawing.Size(213, 21);
            this.TB_Name.TabIndex = 11;
            // 
            // Edit_Modbus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 204);
            this.ControlBox = false;
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.TE_Remark);
            this.Controls.Add(this.LL_Remark);
            this.Controls.Add(this.LC_Name);
            this.Controls.Add(this.BT_Cancle);
            this.Controls.Add(this.CBE_IO);
            this.Controls.Add(this.BT_Apply);
            this.Controls.Add(this.BT_ok);
            this.Name = "Edit_Modbus";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "IO信息";
            this.Load += new System.EventHandler(this.Edit_Action_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CBE_IO.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BT_ok;
        private DevExpress.XtraEditors.SimpleButton BT_Apply;
        private DevExpress.XtraEditors.ComboBoxEdit CBE_IO;
        private DevExpress.XtraEditors.SimpleButton BT_Cancle;
        private DevExpress.XtraEditors.LabelControl LC_Name;
        private DevExpress.XtraEditors.LabelControl LL_Remark;
        private System.Windows.Forms.TextBox TE_Remark;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox TB_Name;
    }
}
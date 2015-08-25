namespace Packaging
{
    partial class Edit_User
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
            this.BT_Cancle = new DevExpress.XtraEditors.SimpleButton();
            this.BT_ok = new DevExpress.XtraEditors.SimpleButton();
            this.GC_Context = new DevExpress.XtraEditors.GroupControl();
            this.LL_5 = new DevExpress.XtraEditors.LabelControl();
            this.LL_4 = new DevExpress.XtraEditors.LabelControl();
            this.LL_3 = new DevExpress.XtraEditors.LabelControl();
            this.LL_2 = new DevExpress.XtraEditors.LabelControl();
            this.LL_1 = new DevExpress.XtraEditors.LabelControl();
            this.SE_1 = new DevExpress.XtraEditors.TextEdit();
            this.SE_3 = new DevExpress.XtraEditors.TextEdit();
            this.SE_4 = new DevExpress.XtraEditors.TextEdit();
            this.SE_5 = new DevExpress.XtraEditors.TextEdit();
            this.TE_Name = new DevExpress.XtraEditors.TextEdit();
            this.LL_RecipeName = new DevExpress.XtraEditors.LabelControl();
            this.SE_2 = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Context)).BeginInit();
            this.GC_Context.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SE_1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SE_3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SE_4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SE_5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TE_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SE_2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_Cancle
            // 
            this.BT_Cancle.Location = new System.Drawing.Point(139, 230);
            this.BT_Cancle.Name = "BT_Cancle";
            this.BT_Cancle.Size = new System.Drawing.Size(75, 23);
            this.BT_Cancle.TabIndex = 3;
            this.BT_Cancle.Text = "取消";
            this.BT_Cancle.Click += new System.EventHandler(this.BT_Cancle_Click);
            // 
            // BT_ok
            // 
            this.BT_ok.Location = new System.Drawing.Point(31, 230);
            this.BT_ok.Name = "BT_ok";
            this.BT_ok.Size = new System.Drawing.Size(75, 23);
            this.BT_ok.TabIndex = 2;
            this.BT_ok.Text = "确定";
            this.BT_ok.Click += new System.EventHandler(this.BT_ok_Click);
            // 
            // GC_Context
            // 
            this.GC_Context.Controls.Add(this.LL_5);
            this.GC_Context.Controls.Add(this.LL_4);
            this.GC_Context.Controls.Add(this.LL_3);
            this.GC_Context.Controls.Add(this.LL_2);
            this.GC_Context.Controls.Add(this.LL_1);
            this.GC_Context.Controls.Add(this.SE_1);
            this.GC_Context.Controls.Add(this.SE_3);
            this.GC_Context.Controls.Add(this.SE_4);
            this.GC_Context.Controls.Add(this.SE_5);
            this.GC_Context.Controls.Add(this.SE_2);
            this.GC_Context.Location = new System.Drawing.Point(-3, 40);
            this.GC_Context.Name = "GC_Context";
            this.GC_Context.Size = new System.Drawing.Size(272, 174);
            this.GC_Context.TabIndex = 6;
            // 
            // LL_5
            // 
            this.LL_5.Location = new System.Drawing.Point(19, 129);
            this.LL_5.Name = "LL_5";
            this.LL_5.Size = new System.Drawing.Size(28, 13);
            this.LL_5.TabIndex = 18;
            this.LL_5.Text = "电话:";
            // 
            // LL_4
            // 
            this.LL_4.Location = new System.Drawing.Point(19, 104);
            this.LL_4.Name = "LL_4";
            this.LL_4.Size = new System.Drawing.Size(52, 13);
            this.LL_4.TabIndex = 15;
            this.LL_4.Text = "电子邮件:";
            // 
            // LL_3
            // 
            this.LL_3.Location = new System.Drawing.Point(19, 79);
            this.LL_3.Name = "LL_3";
            this.LL_3.Size = new System.Drawing.Size(28, 13);
            this.LL_3.TabIndex = 12;
            this.LL_3.Text = "名称:";
            // 
            // LL_2
            // 
            this.LL_2.Location = new System.Drawing.Point(19, 54);
            this.LL_2.Name = "LL_2";
            this.LL_2.Size = new System.Drawing.Size(28, 13);
            this.LL_2.TabIndex = 9;
            this.LL_2.Text = "权限:";
            // 
            // LL_1
            // 
            this.LL_1.Location = new System.Drawing.Point(19, 29);
            this.LL_1.Name = "LL_1";
            this.LL_1.Size = new System.Drawing.Size(28, 13);
            this.LL_1.TabIndex = 6;
            this.LL_1.Text = "密码:";
            // 
            // SE_1
            // 
            this.SE_1.EditValue = "";
            this.SE_1.Location = new System.Drawing.Point(118, 26);
            this.SE_1.Name = "SE_1";
            this.SE_1.Properties.PasswordChar = '*';
            this.SE_1.Size = new System.Drawing.Size(100, 20);
            this.SE_1.TabIndex = 19;
            // 
            // SE_3
            // 
            this.SE_3.EditValue = "";
            this.SE_3.Location = new System.Drawing.Point(118, 78);
            this.SE_3.Name = "SE_3";
            this.SE_3.Size = new System.Drawing.Size(100, 20);
            this.SE_3.TabIndex = 21;
            // 
            // SE_4
            // 
            this.SE_4.EditValue = "";
            this.SE_4.Location = new System.Drawing.Point(118, 104);
            this.SE_4.Name = "SE_4";
            this.SE_4.Size = new System.Drawing.Size(100, 20);
            this.SE_4.TabIndex = 22;
            // 
            // SE_5
            // 
            this.SE_5.EditValue = "";
            this.SE_5.Location = new System.Drawing.Point(118, 130);
            this.SE_5.Name = "SE_5";
            this.SE_5.Size = new System.Drawing.Size(100, 20);
            this.SE_5.TabIndex = 23;
            // 
            // TE_Name
            // 
            this.TE_Name.EditValue = "";
            this.TE_Name.Location = new System.Drawing.Point(115, 8);
            this.TE_Name.Name = "TE_Name";
            this.TE_Name.Size = new System.Drawing.Size(99, 20);
            this.TE_Name.TabIndex = 27;
            // 
            // LL_RecipeName
            // 
            this.LL_RecipeName.Location = new System.Drawing.Point(21, 13);
            this.LL_RecipeName.Name = "LL_RecipeName";
            this.LL_RecipeName.Size = new System.Drawing.Size(40, 13);
            this.LL_RecipeName.TabIndex = 26;
            this.LL_RecipeName.Text = "用户名:";
            // 
            // SE_2
            // 
            this.SE_2.EditValue = "操作员";
            this.SE_2.Location = new System.Drawing.Point(118, 52);
            this.SE_2.Name = "SE_2";
            this.SE_2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SE_2.Properties.Items.AddRange(new object[] {
            "操作员",
            "一般管理员",
            "高级管理员",
            "超级管理员"});
            this.SE_2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.SE_2.Size = new System.Drawing.Size(100, 20);
            this.SE_2.TabIndex = 20;
            // 
            // Edit_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 268);
            this.ControlBox = false;
            this.Controls.Add(this.TE_Name);
            this.Controls.Add(this.LL_RecipeName);
            this.Controls.Add(this.GC_Context);
            this.Controls.Add(this.BT_Cancle);
            this.Controls.Add(this.BT_ok);
            this.Name = "Edit_User";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit_User";
            this.Load += new System.EventHandler(this.Edit_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GC_Context)).EndInit();
            this.GC_Context.ResumeLayout(false);
            this.GC_Context.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SE_1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SE_3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SE_4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SE_5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TE_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SE_2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BT_Cancle;
        private DevExpress.XtraEditors.SimpleButton BT_ok;
        private DevExpress.XtraEditors.GroupControl GC_Context;
        private DevExpress.XtraEditors.LabelControl LL_5;
        private DevExpress.XtraEditors.LabelControl LL_4;
        private DevExpress.XtraEditors.LabelControl LL_3;
        private DevExpress.XtraEditors.LabelControl LL_2;
        private DevExpress.XtraEditors.LabelControl LL_1;
        private DevExpress.XtraEditors.TextEdit SE_1;
        private DevExpress.XtraEditors.TextEdit SE_3;
        private DevExpress.XtraEditors.TextEdit SE_4;
        private DevExpress.XtraEditors.TextEdit SE_5;
        private DevExpress.XtraEditors.TextEdit TE_Name;
        private DevExpress.XtraEditors.LabelControl LL_RecipeName;
        private DevExpress.XtraEditors.ComboBoxEdit SE_2;
    }
}
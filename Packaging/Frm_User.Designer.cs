namespace Packaging
{
    partial class Frm_User
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
            this.CBE_Screen = new DevExpress.XtraEditors.ComboBoxEdit();
            this.CBC_Check = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.GC_User = new DevExpress.XtraGrid.GridControl();
            this.gv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GC_Set = new DevExpress.XtraEditors.GroupControl();
            this.BT_OK = new DevExpress.XtraEditors.SimpleButton();
            this.GC_Oper = new DevExpress.XtraEditors.GroupControl();
            this.BT_Add = new DevExpress.XtraEditors.SimpleButton();
            this.BT_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.BT_Edit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.CBE_Screen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBC_Check)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Set)).BeginInit();
            this.GC_Set.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Oper)).BeginInit();
            this.GC_Oper.SuspendLayout();
            this.SuspendLayout();
            // 
            // CBE_Screen
            // 
            this.CBE_Screen.EditValue = "操作员";
            this.CBE_Screen.Location = new System.Drawing.Point(25, 39);
            this.CBE_Screen.Name = "CBE_Screen";
            this.CBE_Screen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CBE_Screen.Properties.Items.AddRange(new object[] {
            "操作员",
            "一般管理员",
            "高级管理员"});
            this.CBE_Screen.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.CBE_Screen.Size = new System.Drawing.Size(184, 20);
            this.CBE_Screen.TabIndex = 4;
            this.CBE_Screen.SelectedIndexChanged += new System.EventHandler(this.CBE_Screen_SelectedIndexChanged);
            // 
            // CBC_Check
            // 
            this.CBC_Check.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "型号与位置"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "动作列表"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "外部轴"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "离散工艺"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "速度匹配"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "产品"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "生产"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "监控信息"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "统计"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "上位机报警"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "下位机报警"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "用户权限"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "参数配置"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "系统集成"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "生产配置")});
            this.CBC_Check.Location = new System.Drawing.Point(25, 65);
            this.CBC_Check.Name = "CBC_Check";
            this.CBC_Check.Size = new System.Drawing.Size(184, 420);
            this.CBC_Check.TabIndex = 3;
            // 
            // GC_User
            // 
            this.GC_User.Dock = System.Windows.Forms.DockStyle.Top;
            this.GC_User.Location = new System.Drawing.Point(0, 0);
            this.GC_User.MainView = this.gv;
            this.GC_User.Name = "GC_User";
            this.GC_User.Size = new System.Drawing.Size(822, 442);
            this.GC_User.TabIndex = 9;
            this.GC_User.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv});
            // 
            // gv
            // 
            this.gv.GridControl = this.GC_User;
            this.gv.Name = "gv";
            this.gv.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gv.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gv.OptionsBehavior.Editable = false;
            this.gv.OptionsCustomization.AllowColumnMoving = false;
            this.gv.OptionsCustomization.AllowColumnResizing = false;
            this.gv.OptionsCustomization.AllowFilter = false;
            this.gv.OptionsCustomization.AllowGroup = false;
            this.gv.OptionsCustomization.AllowSort = false;
            this.gv.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gv.OptionsView.EnableAppearanceOddRow = true;
            this.gv.OptionsView.ShowGroupPanel = false;
            this.gv.SynchronizeClones = false;
            // 
            // GC_Set
            // 
            this.GC_Set.Controls.Add(this.BT_OK);
            this.GC_Set.Controls.Add(this.CBE_Screen);
            this.GC_Set.Controls.Add(this.CBC_Check);
            this.GC_Set.Dock = System.Windows.Forms.DockStyle.Right;
            this.GC_Set.Location = new System.Drawing.Point(822, 0);
            this.GC_Set.Name = "GC_Set";
            this.GC_Set.Size = new System.Drawing.Size(244, 537);
            this.GC_Set.TabIndex = 10;
            this.GC_Set.Text = "权限定义";
            // 
            // BT_OK
            // 
            this.BT_OK.Location = new System.Drawing.Point(80, 502);
            this.BT_OK.Name = "BT_OK";
            this.BT_OK.Size = new System.Drawing.Size(75, 23);
            this.BT_OK.TabIndex = 0;
            this.BT_OK.Text = "确定";
            this.BT_OK.Click += new System.EventHandler(this.BT_OK_Click);
            // 
            // GC_Oper
            // 
            this.GC_Oper.Controls.Add(this.BT_Add);
            this.GC_Oper.Controls.Add(this.BT_Delete);
            this.GC_Oper.Controls.Add(this.BT_Edit);
            this.GC_Oper.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GC_Oper.Location = new System.Drawing.Point(0, 448);
            this.GC_Oper.Name = "GC_Oper";
            this.GC_Oper.Size = new System.Drawing.Size(822, 89);
            this.GC_Oper.TabIndex = 11;
            this.GC_Oper.Text = "操作";
            // 
            // BT_Add
            // 
            this.BT_Add.Location = new System.Drawing.Point(24, 40);
            this.BT_Add.Name = "BT_Add";
            this.BT_Add.Size = new System.Drawing.Size(75, 23);
            this.BT_Add.TabIndex = 5;
            this.BT_Add.Text = "增加";
            this.BT_Add.Click += new System.EventHandler(this.BT_Add_Click);
            // 
            // BT_Delete
            // 
            this.BT_Delete.Location = new System.Drawing.Point(145, 40);
            this.BT_Delete.Name = "BT_Delete";
            this.BT_Delete.Size = new System.Drawing.Size(75, 23);
            this.BT_Delete.TabIndex = 6;
            this.BT_Delete.Text = "删除";
            this.BT_Delete.Click += new System.EventHandler(this.BT_Delete_Click);
            // 
            // BT_Edit
            // 
            this.BT_Edit.Location = new System.Drawing.Point(268, 40);
            this.BT_Edit.Name = "BT_Edit";
            this.BT_Edit.Size = new System.Drawing.Size(75, 23);
            this.BT_Edit.TabIndex = 7;
            this.BT_Edit.Text = "编辑";
            this.BT_Edit.Click += new System.EventHandler(this.BT_Edit_Click);
            // 
            // Frm_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 537);
            this.Controls.Add(this.GC_Oper);
            this.Controls.Add(this.GC_User);
            this.Controls.Add(this.GC_Set);
            this.Name = "Frm_User";
            this.Text = "Frm_User";
            this.Load += new System.EventHandler(this.Frm_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CBE_Screen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBC_Check)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Set)).EndInit();
            this.GC_Set.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GC_Oper)).EndInit();
            this.GC_Oper.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit CBE_Screen;
        private DevExpress.XtraEditors.CheckedListBoxControl CBC_Check;
        public DevExpress.XtraGrid.Views.Grid.GridView gv;
        private DevExpress.XtraEditors.GroupControl GC_Set;
        private DevExpress.XtraEditors.SimpleButton BT_OK;
        private DevExpress.XtraEditors.GroupControl GC_Oper;
        public DevExpress.XtraEditors.SimpleButton BT_Add;
        public DevExpress.XtraEditors.SimpleButton BT_Delete;
        public DevExpress.XtraEditors.SimpleButton BT_Edit;
        public DevExpress.XtraGrid.GridControl GC_User;
    }
}
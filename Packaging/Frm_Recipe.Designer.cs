namespace Packaging
{
    partial class Frm_Recipe
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
            this.gv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GC_Traj = new DevExpress.XtraGrid.GridControl();
            this.GV_Appro = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GC_Appro = new DevExpress.XtraGrid.GridControl();
            this.GC_Cut = new DevExpress.XtraGrid.GridControl();
            this.GV_Cut = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GC_Leave = new DevExpress.XtraGrid.GridControl();
            this.GV_Leave = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Gp_TrajInfor = new DevExpress.XtraEditors.GroupControl();
            this.LL_TrajRemark = new DevExpress.XtraEditors.LabelControl();
            this.LL_PointCount = new DevExpress.XtraEditors.LabelControl();
            this.LL_Circle = new DevExpress.XtraEditors.LabelControl();
            this.LL_Delay = new DevExpress.XtraEditors.LabelControl();
            this.LL_DownLead = new DevExpress.XtraEditors.LabelControl();
            this.LL_TrajArray = new DevExpress.XtraEditors.LabelControl();
            this.LL_TrajOffset = new DevExpress.XtraEditors.LabelControl();
            this.LL_TrajFrame = new DevExpress.XtraEditors.LabelControl();
            this.GC_Recipe = new DevExpress.XtraEditors.GroupControl();
            this.LL_WorkPlace = new DevExpress.XtraEditors.LabelControl();
            this.LL_RecipeRemark = new DevExpress.XtraEditors.LabelControl();
            this.LL_RecipeOffset = new DevExpress.XtraEditors.LabelControl();
            this.LL_RecipeFrame = new DevExpress.XtraEditors.LabelControl();
            this.LL_TrajCount = new DevExpress.XtraEditors.LabelControl();
            this.LL_RecipeName = new DevExpress.XtraEditors.LabelControl();
            this.CBE_RecipeName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.GC_RecipeOper = new DevExpress.XtraEditors.GroupControl();
            this.BT_RecipeOffset = new DevExpress.XtraEditors.SimpleButton();
            this.BT_ReicpeFrame = new DevExpress.XtraEditors.SimpleButton();
            this.BT_Cs8c = new DevExpress.XtraEditors.SimpleButton();
            this.BT_RecipeEdit = new DevExpress.XtraEditors.SimpleButton();
            this.BT_OutPut = new DevExpress.XtraEditors.SimpleButton();
            this.BT_Import = new DevExpress.XtraEditors.SimpleButton();
            this.BT_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.BT_New = new DevExpress.XtraEditors.SimpleButton();
            this.GC_TrajOper = new DevExpress.XtraEditors.GroupControl();
            this.BT_Cut = new DevExpress.XtraEditors.SimpleButton();
            this.BT_Batch = new DevExpress.XtraEditors.SimpleButton();
            this.BT_EditSequ = new DevExpress.XtraEditors.SimpleButton();
            this.BT_TrajEdit = new DevExpress.XtraEditors.SimpleButton();
            this.BT_TrajDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BT_Speed = new DevExpress.XtraEditors.SimpleButton();
            this.SCC = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Traj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Appro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Appro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Cut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Cut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Leave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Leave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gp_TrajInfor)).BeginInit();
            this.Gp_TrajInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Recipe)).BeginInit();
            this.GC_Recipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CBE_RecipeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_RecipeOper)).BeginInit();
            this.GC_RecipeOper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_TrajOper)).BeginInit();
            this.GC_TrajOper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SCC)).BeginInit();
            this.SCC.SuspendLayout();
            this.SuspendLayout();
            // 
            // gv
            // 
            this.gv.ActiveFilterEnabled = false;
            this.gv.GridControl = this.GC_Traj;
            this.gv.Name = "gv";
            this.gv.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gv.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
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
            this.gv.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv_FocusedRowChanged);
            // 
            // GC_Traj
            // 
            this.GC_Traj.Dock = System.Windows.Forms.DockStyle.Left;
            this.GC_Traj.Location = new System.Drawing.Point(0, 0);
            this.GC_Traj.MainView = this.gv;
            this.GC_Traj.Name = "GC_Traj";
            this.GC_Traj.Size = new System.Drawing.Size(268, 589);
            this.GC_Traj.TabIndex = 2;
            this.GC_Traj.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv});
            // 
            // GV_Appro
            // 
            this.GV_Appro.ActiveFilterEnabled = false;
            this.GV_Appro.GridControl = this.GC_Appro;
            this.GV_Appro.Name = "GV_Appro";
            this.GV_Appro.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.GV_Appro.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.GV_Appro.OptionsBehavior.AutoSelectAllInEditor = false;
            this.GV_Appro.OptionsBehavior.Editable = false;
            this.GV_Appro.OptionsCustomization.AllowColumnMoving = false;
            this.GV_Appro.OptionsCustomization.AllowFilter = false;
            this.GV_Appro.OptionsCustomization.AllowGroup = false;
            this.GV_Appro.OptionsCustomization.AllowSort = false;
            this.GV_Appro.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GV_Appro.OptionsView.EnableAppearanceOddRow = true;
            this.GV_Appro.OptionsView.ShowGroupPanel = false;
            this.GV_Appro.SynchronizeClones = false;
            // 
            // GC_Appro
            // 
            this.GC_Appro.Location = new System.Drawing.Point(277, 126);
            this.GC_Appro.MainView = this.GV_Appro;
            this.GC_Appro.Name = "GC_Appro";
            this.GC_Appro.Size = new System.Drawing.Size(584, 121);
            this.GC_Appro.TabIndex = 3;
            this.GC_Appro.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GV_Appro});
            // 
            // GC_Cut
            // 
            this.GC_Cut.Location = new System.Drawing.Point(277, 250);
            this.GC_Cut.MainView = this.GV_Cut;
            this.GC_Cut.Name = "GC_Cut";
            this.GC_Cut.Size = new System.Drawing.Size(584, 209);
            this.GC_Cut.TabIndex = 4;
            this.GC_Cut.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GV_Cut});
            // 
            // GV_Cut
            // 
            this.GV_Cut.ActiveFilterEnabled = false;
            this.GV_Cut.GridControl = this.GC_Cut;
            this.GV_Cut.Name = "GV_Cut";
            this.GV_Cut.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.GV_Cut.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.GV_Cut.OptionsBehavior.AutoSelectAllInEditor = false;
            this.GV_Cut.OptionsBehavior.Editable = false;
            this.GV_Cut.OptionsCustomization.AllowColumnMoving = false;
            this.GV_Cut.OptionsCustomization.AllowFilter = false;
            this.GV_Cut.OptionsCustomization.AllowGroup = false;
            this.GV_Cut.OptionsCustomization.AllowSort = false;
            this.GV_Cut.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GV_Cut.OptionsView.EnableAppearanceOddRow = true;
            this.GV_Cut.OptionsView.ShowGroupPanel = false;
            this.GV_Cut.SynchronizeClones = false;
            // 
            // GC_Leave
            // 
            this.GC_Leave.Location = new System.Drawing.Point(277, 470);
            this.GC_Leave.MainView = this.GV_Leave;
            this.GC_Leave.Name = "GC_Leave";
            this.GC_Leave.Size = new System.Drawing.Size(584, 117);
            this.GC_Leave.TabIndex = 5;
            this.GC_Leave.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GV_Leave});
            // 
            // GV_Leave
            // 
            this.GV_Leave.ActiveFilterEnabled = false;
            this.GV_Leave.GridControl = this.GC_Leave;
            this.GV_Leave.Name = "GV_Leave";
            this.GV_Leave.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.GV_Leave.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.GV_Leave.OptionsBehavior.AutoSelectAllInEditor = false;
            this.GV_Leave.OptionsBehavior.Editable = false;
            this.GV_Leave.OptionsCustomization.AllowColumnMoving = false;
            this.GV_Leave.OptionsCustomization.AllowFilter = false;
            this.GV_Leave.OptionsCustomization.AllowGroup = false;
            this.GV_Leave.OptionsCustomization.AllowSort = false;
            this.GV_Leave.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GV_Leave.OptionsView.EnableAppearanceOddRow = true;
            this.GV_Leave.OptionsView.ShowGroupPanel = false;
            this.GV_Leave.SynchronizeClones = false;
            // 
            // Gp_TrajInfor
            // 
            this.Gp_TrajInfor.Controls.Add(this.LL_TrajRemark);
            this.Gp_TrajInfor.Controls.Add(this.LL_PointCount);
            this.Gp_TrajInfor.Controls.Add(this.LL_Circle);
            this.Gp_TrajInfor.Controls.Add(this.LL_Delay);
            this.Gp_TrajInfor.Controls.Add(this.LL_DownLead);
            this.Gp_TrajInfor.Controls.Add(this.LL_TrajArray);
            this.Gp_TrajInfor.Controls.Add(this.LL_TrajOffset);
            this.Gp_TrajInfor.Controls.Add(this.LL_TrajFrame);
            this.Gp_TrajInfor.Location = new System.Drawing.Point(276, 9);
            this.Gp_TrajInfor.Name = "Gp_TrajInfor";
            this.Gp_TrajInfor.Size = new System.Drawing.Size(584, 112);
            this.Gp_TrajInfor.TabIndex = 6;
            this.Gp_TrajInfor.Text = "路径信息";
            // 
            // LL_TrajRemark
            // 
            this.LL_TrajRemark.Location = new System.Drawing.Point(301, 94);
            this.LL_TrajRemark.Name = "LL_TrajRemark";
            this.LL_TrajRemark.Size = new System.Drawing.Size(52, 13);
            this.LL_TrajRemark.TabIndex = 11;
            this.LL_TrajRemark.Text = "路径说明:";
            // 
            // LL_PointCount
            // 
            this.LL_PointCount.Location = new System.Drawing.Point(15, 94);
            this.LL_PointCount.Name = "LL_PointCount";
            this.LL_PointCount.Size = new System.Drawing.Size(40, 13);
            this.LL_PointCount.TabIndex = 10;
            this.LL_PointCount.Text = "点个数:";
            // 
            // LL_Circle
            // 
            this.LL_Circle.Location = new System.Drawing.Point(301, 72);
            this.LL_Circle.Name = "LL_Circle";
            this.LL_Circle.Size = new System.Drawing.Size(40, 13);
            this.LL_Circle.TabIndex = 9;
            this.LL_Circle.Text = "圆配置:";
            // 
            // LL_Delay
            // 
            this.LL_Delay.Location = new System.Drawing.Point(15, 72);
            this.LL_Delay.Name = "LL_Delay";
            this.LL_Delay.Size = new System.Drawing.Size(28, 13);
            this.LL_Delay.TabIndex = 8;
            this.LL_Delay.Text = "延时:";
            // 
            // LL_DownLead
            // 
            this.LL_DownLead.Location = new System.Drawing.Point(301, 49);
            this.LL_DownLead.Name = "LL_DownLead";
            this.LL_DownLead.Size = new System.Drawing.Size(52, 13);
            this.LL_DownLead.TabIndex = 7;
            this.LL_DownLead.Text = "引线配置:";
            // 
            // LL_TrajArray
            // 
            this.LL_TrajArray.Location = new System.Drawing.Point(15, 49);
            this.LL_TrajArray.Name = "LL_TrajArray";
            this.LL_TrajArray.Size = new System.Drawing.Size(52, 13);
            this.LL_TrajArray.TabIndex = 6;
            this.LL_TrajArray.Text = "路径阵列:";
            // 
            // LL_TrajOffset
            // 
            this.LL_TrajOffset.Location = new System.Drawing.Point(301, 26);
            this.LL_TrajOffset.Name = "LL_TrajOffset";
            this.LL_TrajOffset.Size = new System.Drawing.Size(52, 13);
            this.LL_TrajOffset.TabIndex = 5;
            this.LL_TrajOffset.Text = "路径偏移:";
            // 
            // LL_TrajFrame
            // 
            this.LL_TrajFrame.Location = new System.Drawing.Point(15, 26);
            this.LL_TrajFrame.Name = "LL_TrajFrame";
            this.LL_TrajFrame.Size = new System.Drawing.Size(64, 13);
            this.LL_TrajFrame.TabIndex = 4;
            this.LL_TrajFrame.Text = "用户坐标系:";
            // 
            // GC_Recipe
            // 
            this.GC_Recipe.Controls.Add(this.LL_WorkPlace);
            this.GC_Recipe.Controls.Add(this.LL_RecipeRemark);
            this.GC_Recipe.Controls.Add(this.LL_RecipeOffset);
            this.GC_Recipe.Controls.Add(this.LL_RecipeFrame);
            this.GC_Recipe.Controls.Add(this.LL_TrajCount);
            this.GC_Recipe.Controls.Add(this.LL_RecipeName);
            this.GC_Recipe.Controls.Add(this.CBE_RecipeName);
            this.GC_Recipe.Location = new System.Drawing.Point(7, 12);
            this.GC_Recipe.Name = "GC_Recipe";
            this.GC_Recipe.Size = new System.Drawing.Size(213, 166);
            this.GC_Recipe.TabIndex = 7;
            this.GC_Recipe.Text = "产品信息";
            // 
            // LL_WorkPlace
            // 
            this.LL_WorkPlace.Location = new System.Drawing.Point(15, 52);
            this.LL_WorkPlace.Name = "LL_WorkPlace";
            this.LL_WorkPlace.Size = new System.Drawing.Size(28, 13);
            this.LL_WorkPlace.TabIndex = 6;
            this.LL_WorkPlace.Text = "工位:";
            // 
            // LL_RecipeRemark
            // 
            this.LL_RecipeRemark.Location = new System.Drawing.Point(15, 148);
            this.LL_RecipeRemark.Name = "LL_RecipeRemark";
            this.LL_RecipeRemark.Size = new System.Drawing.Size(28, 13);
            this.LL_RecipeRemark.TabIndex = 5;
            this.LL_RecipeRemark.Text = "说明:";
            // 
            // LL_RecipeOffset
            // 
            this.LL_RecipeOffset.Location = new System.Drawing.Point(15, 124);
            this.LL_RecipeOffset.Name = "LL_RecipeOffset";
            this.LL_RecipeOffset.Size = new System.Drawing.Size(52, 13);
            this.LL_RecipeOffset.TabIndex = 4;
            this.LL_RecipeOffset.Text = "产品偏移:";
            // 
            // LL_RecipeFrame
            // 
            this.LL_RecipeFrame.Location = new System.Drawing.Point(15, 100);
            this.LL_RecipeFrame.Name = "LL_RecipeFrame";
            this.LL_RecipeFrame.Size = new System.Drawing.Size(64, 13);
            this.LL_RecipeFrame.TabIndex = 3;
            this.LL_RecipeFrame.Text = "用户坐标系:";
            // 
            // LL_TrajCount
            // 
            this.LL_TrajCount.Location = new System.Drawing.Point(15, 76);
            this.LL_TrajCount.Name = "LL_TrajCount";
            this.LL_TrajCount.Size = new System.Drawing.Size(64, 13);
            this.LL_TrajCount.TabIndex = 2;
            this.LL_TrajCount.Text = "路径总个数:";
            // 
            // LL_RecipeName
            // 
            this.LL_RecipeName.Location = new System.Drawing.Point(15, 28);
            this.LL_RecipeName.Name = "LL_RecipeName";
            this.LL_RecipeName.Size = new System.Drawing.Size(52, 13);
            this.LL_RecipeName.TabIndex = 1;
            this.LL_RecipeName.Text = "产品名称:";
            // 
            // CBE_RecipeName
            // 
            this.CBE_RecipeName.EditValue = "";
            this.CBE_RecipeName.Location = new System.Drawing.Point(73, 24);
            this.CBE_RecipeName.Name = "CBE_RecipeName";
            this.CBE_RecipeName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CBE_RecipeName.Properties.Items.AddRange(new object[] {
            "1",
            "2"});
            this.CBE_RecipeName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.CBE_RecipeName.Size = new System.Drawing.Size(130, 20);
            this.CBE_RecipeName.TabIndex = 0;
            this.CBE_RecipeName.TextChanged += new System.EventHandler(this.CBE_RecipeName_TextChanged);
            // 
            // GC_RecipeOper
            // 
            this.GC_RecipeOper.Controls.Add(this.BT_RecipeOffset);
            this.GC_RecipeOper.Controls.Add(this.BT_ReicpeFrame);
            this.GC_RecipeOper.Controls.Add(this.BT_Cs8c);
            this.GC_RecipeOper.Controls.Add(this.BT_RecipeEdit);
            this.GC_RecipeOper.Controls.Add(this.BT_OutPut);
            this.GC_RecipeOper.Controls.Add(this.BT_Import);
            this.GC_RecipeOper.Controls.Add(this.BT_Delete);
            this.GC_RecipeOper.Controls.Add(this.BT_New);
            this.GC_RecipeOper.Location = new System.Drawing.Point(13, 213);
            this.GC_RecipeOper.Name = "GC_RecipeOper";
            this.GC_RecipeOper.Size = new System.Drawing.Size(207, 157);
            this.GC_RecipeOper.TabIndex = 8;
            this.GC_RecipeOper.Text = "产品编辑";
            // 
            // BT_RecipeOffset
            // 
            this.BT_RecipeOffset.Location = new System.Drawing.Point(112, 120);
            this.BT_RecipeOffset.Name = "BT_RecipeOffset";
            this.BT_RecipeOffset.Size = new System.Drawing.Size(75, 23);
            this.BT_RecipeOffset.TabIndex = 7;
            this.BT_RecipeOffset.Text = "偏差";
            this.BT_RecipeOffset.Click += new System.EventHandler(this.BT_RecipeOffset_Click);
            // 
            // BT_ReicpeFrame
            // 
            this.BT_ReicpeFrame.Location = new System.Drawing.Point(112, 91);
            this.BT_ReicpeFrame.Name = "BT_ReicpeFrame";
            this.BT_ReicpeFrame.Size = new System.Drawing.Size(75, 23);
            this.BT_ReicpeFrame.TabIndex = 6;
            this.BT_ReicpeFrame.Text = "坐标系";
            this.BT_ReicpeFrame.Click += new System.EventHandler(this.BT_ReicpeFrame_Click);
            // 
            // BT_Cs8c
            // 
            this.BT_Cs8c.Appearance.BackColor = System.Drawing.Color.White;
            this.BT_Cs8c.Appearance.BackColor2 = System.Drawing.Color.White;
            this.BT_Cs8c.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.BT_Cs8c.Appearance.ForeColor = System.Drawing.Color.Red;
            this.BT_Cs8c.Appearance.Options.UseBackColor = true;
            this.BT_Cs8c.Appearance.Options.UseFont = true;
            this.BT_Cs8c.Appearance.Options.UseForeColor = true;
            this.BT_Cs8c.Location = new System.Drawing.Point(112, 62);
            this.BT_Cs8c.Name = "BT_Cs8c";
            this.BT_Cs8c.Size = new System.Drawing.Size(75, 23);
            this.BT_Cs8c.TabIndex = 5;
            this.BT_Cs8c.Text = "调试";
            this.BT_Cs8c.Click += new System.EventHandler(this.BT_Cs8c_Click);
            // 
            // BT_RecipeEdit
            // 
            this.BT_RecipeEdit.Location = new System.Drawing.Point(112, 33);
            this.BT_RecipeEdit.Name = "BT_RecipeEdit";
            this.BT_RecipeEdit.Size = new System.Drawing.Size(75, 23);
            this.BT_RecipeEdit.TabIndex = 4;
            this.BT_RecipeEdit.Text = "编辑";
            this.BT_RecipeEdit.Click += new System.EventHandler(this.BT_RecipeEdit_Click);
            // 
            // BT_OutPut
            // 
            this.BT_OutPut.Location = new System.Drawing.Point(19, 120);
            this.BT_OutPut.Name = "BT_OutPut";
            this.BT_OutPut.Size = new System.Drawing.Size(75, 23);
            this.BT_OutPut.TabIndex = 3;
            this.BT_OutPut.Text = "导出";
            this.BT_OutPut.Click += new System.EventHandler(this.BT_OutPut_Click);
            // 
            // BT_Import
            // 
            this.BT_Import.Location = new System.Drawing.Point(19, 91);
            this.BT_Import.Name = "BT_Import";
            this.BT_Import.Size = new System.Drawing.Size(75, 23);
            this.BT_Import.TabIndex = 2;
            this.BT_Import.Text = "导入";
            this.BT_Import.Click += new System.EventHandler(this.BT_Import_Click);
            // 
            // BT_Delete
            // 
            this.BT_Delete.Location = new System.Drawing.Point(19, 62);
            this.BT_Delete.Name = "BT_Delete";
            this.BT_Delete.Size = new System.Drawing.Size(75, 23);
            this.BT_Delete.TabIndex = 1;
            this.BT_Delete.Text = "删除";
            this.BT_Delete.Click += new System.EventHandler(this.BT_Delete_Click);
            // 
            // BT_New
            // 
            this.BT_New.Location = new System.Drawing.Point(19, 33);
            this.BT_New.Name = "BT_New";
            this.BT_New.Size = new System.Drawing.Size(75, 23);
            this.BT_New.TabIndex = 0;
            this.BT_New.Text = "新建";
            this.BT_New.Click += new System.EventHandler(this.BT_New_Click);
            // 
            // GC_TrajOper
            // 
            this.GC_TrajOper.Controls.Add(this.BT_Cut);
            this.GC_TrajOper.Controls.Add(this.BT_Batch);
            this.GC_TrajOper.Controls.Add(this.BT_EditSequ);
            this.GC_TrajOper.Controls.Add(this.BT_TrajEdit);
            this.GC_TrajOper.Controls.Add(this.BT_TrajDelete);
            this.GC_TrajOper.Controls.Add(this.BT_Speed);
            this.GC_TrajOper.Location = new System.Drawing.Point(13, 386);
            this.GC_TrajOper.Name = "GC_TrajOper";
            this.GC_TrajOper.Size = new System.Drawing.Size(202, 145);
            this.GC_TrajOper.TabIndex = 9;
            this.GC_TrajOper.Text = "路径编辑";
            // 
            // BT_Cut
            // 
            this.BT_Cut.Location = new System.Drawing.Point(107, 103);
            this.BT_Cut.Name = "BT_Cut";
            this.BT_Cut.Size = new System.Drawing.Size(75, 23);
            this.BT_Cut.TabIndex = 8;
            this.BT_Cut.Text = "切割点";
            this.BT_Cut.Click += new System.EventHandler(this.BT_Cut_Click);
            // 
            // BT_Batch
            // 
            this.BT_Batch.Location = new System.Drawing.Point(14, 74);
            this.BT_Batch.Name = "BT_Batch";
            this.BT_Batch.Size = new System.Drawing.Size(75, 23);
            this.BT_Batch.TabIndex = 7;
            this.BT_Batch.Text = "批处理";
            this.BT_Batch.Click += new System.EventHandler(this.BT_Batch_Click);
            // 
            // BT_EditSequ
            // 
            this.BT_EditSequ.Location = new System.Drawing.Point(107, 45);
            this.BT_EditSequ.Name = "BT_EditSequ";
            this.BT_EditSequ.Size = new System.Drawing.Size(75, 23);
            this.BT_EditSequ.TabIndex = 6;
            this.BT_EditSequ.Text = "调序";
            this.BT_EditSequ.Click += new System.EventHandler(this.BT_EditSequ_Click);
            // 
            // BT_TrajEdit
            // 
            this.BT_TrajEdit.Location = new System.Drawing.Point(14, 45);
            this.BT_TrajEdit.Name = "BT_TrajEdit";
            this.BT_TrajEdit.Size = new System.Drawing.Size(75, 23);
            this.BT_TrajEdit.TabIndex = 5;
            this.BT_TrajEdit.Text = "编辑";
            this.BT_TrajEdit.Click += new System.EventHandler(this.BT_TrajEdit_Click);
            // 
            // BT_TrajDelete
            // 
            this.BT_TrajDelete.Location = new System.Drawing.Point(14, 103);
            this.BT_TrajDelete.Name = "BT_TrajDelete";
            this.BT_TrajDelete.Size = new System.Drawing.Size(75, 23);
            this.BT_TrajDelete.TabIndex = 2;
            this.BT_TrajDelete.Text = "删除";
            this.BT_TrajDelete.Click += new System.EventHandler(this.BT_TrajDelete_Click);
            // 
            // BT_Speed
            // 
            this.BT_Speed.Location = new System.Drawing.Point(107, 74);
            this.BT_Speed.Name = "BT_Speed";
            this.BT_Speed.Size = new System.Drawing.Size(75, 23);
            this.BT_Speed.TabIndex = 1;
            this.BT_Speed.Text = "调速";
            this.BT_Speed.Click += new System.EventHandler(this.BT_Speed_Click);
            // 
            // SCC
            // 
            this.SCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SCC.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.SCC.Location = new System.Drawing.Point(0, 0);
            this.SCC.Name = "SCC";
            this.SCC.Panel1.Controls.Add(this.Gp_TrajInfor);
            this.SCC.Panel1.Controls.Add(this.GC_Appro);
            this.SCC.Panel1.Controls.Add(this.GC_Leave);
            this.SCC.Panel1.Controls.Add(this.GC_Traj);
            this.SCC.Panel1.Controls.Add(this.GC_Cut);
            this.SCC.Panel1.Text = "Panel1";
            this.SCC.Panel2.Controls.Add(this.GC_Recipe);
            this.SCC.Panel2.Controls.Add(this.GC_RecipeOper);
            this.SCC.Panel2.Controls.Add(this.GC_TrajOper);
            this.SCC.Panel2.Text = "Panel2";
            this.SCC.Size = new System.Drawing.Size(1097, 589);
            this.SCC.SplitterPosition = 225;
            this.SCC.TabIndex = 10;
            this.SCC.Text = "splitContainerControl1";
            // 
            // Frm_Recipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 589);
            this.Controls.Add(this.SCC);
            this.Name = "Frm_Recipe";
            this.Text = "Frm_Recipe";
            this.Load += new System.EventHandler(this.Frm_Recipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Traj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Appro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Appro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Cut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Cut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Leave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Leave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gp_TrajInfor)).EndInit();
            this.Gp_TrajInfor.ResumeLayout(false);
            this.Gp_TrajInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Recipe)).EndInit();
            this.GC_Recipe.ResumeLayout(false);
            this.GC_Recipe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CBE_RecipeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_RecipeOper)).EndInit();
            this.GC_RecipeOper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GC_TrajOper)).EndInit();
            this.GC_TrajOper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SCC)).EndInit();
            this.SCC.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraGrid.GridControl GC_Traj;
        protected DevExpress.XtraGrid.GridControl GC_Appro;
        protected DevExpress.XtraGrid.GridControl GC_Cut;
        protected DevExpress.XtraGrid.GridControl GC_Leave;
        public DevExpress.XtraGrid.Views.Grid.GridView GV_Cut;
        public DevExpress.XtraGrid.Views.Grid.GridView GV_Leave;
        private DevExpress.XtraEditors.GroupControl Gp_TrajInfor;
        private DevExpress.XtraEditors.GroupControl GC_Recipe;
        private DevExpress.XtraEditors.GroupControl GC_RecipeOper;
        private DevExpress.XtraEditors.GroupControl GC_TrajOper;
        private DevExpress.XtraEditors.LabelControl LL_RecipeName;
        private DevExpress.XtraEditors.ComboBoxEdit CBE_RecipeName;
        private DevExpress.XtraEditors.LabelControl LL_RecipeFrame;
        private DevExpress.XtraEditors.LabelControl LL_TrajCount;
        private DevExpress.XtraEditors.LabelControl LL_RecipeRemark;
        private DevExpress.XtraEditors.LabelControl LL_RecipeOffset;
        private DevExpress.XtraEditors.LabelControl LL_Delay;
        private DevExpress.XtraEditors.LabelControl LL_DownLead;
        private DevExpress.XtraEditors.LabelControl LL_TrajArray;
        private DevExpress.XtraEditors.LabelControl LL_TrajOffset;
        private DevExpress.XtraEditors.LabelControl LL_TrajFrame;
        private DevExpress.XtraEditors.LabelControl LL_Circle;
        private DevExpress.XtraEditors.LabelControl LL_PointCount;
        private DevExpress.XtraEditors.SimpleButton BT_Cs8c;
        private DevExpress.XtraEditors.SimpleButton BT_RecipeEdit;
        private DevExpress.XtraEditors.SimpleButton BT_OutPut;
        private DevExpress.XtraEditors.SimpleButton BT_Import;
        private DevExpress.XtraEditors.SimpleButton BT_Delete;
        private DevExpress.XtraEditors.SimpleButton BT_New;
        private DevExpress.XtraEditors.SimpleButton BT_RecipeOffset;
        private DevExpress.XtraEditors.SimpleButton BT_ReicpeFrame;
        private DevExpress.XtraEditors.SimpleButton BT_TrajEdit;
        private DevExpress.XtraEditors.SimpleButton BT_TrajDelete;
        private DevExpress.XtraEditors.SimpleButton BT_Speed;
        private DevExpress.XtraEditors.SimpleButton BT_EditSequ;
        public DevExpress.XtraGrid.Views.Grid.GridView gv;
        public DevExpress.XtraGrid.Views.Grid.GridView GV_Appro;
        private DevExpress.XtraEditors.LabelControl LL_TrajRemark;
        private DevExpress.XtraEditors.LabelControl LL_WorkPlace;
        private DevExpress.XtraEditors.SimpleButton BT_Batch;
        private DevExpress.XtraEditors.SimpleButton BT_Cut;
        private DevExpress.XtraEditors.SplitContainerControl SCC;



    }
}
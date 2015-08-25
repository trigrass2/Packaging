namespace Packaging
{
    partial class UC_DataGridView
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.GC_Cut = new DevExpress.XtraGrid.GridControl();
            this.GV_Cut = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Cut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Cut)).BeginInit();
            this.SuspendLayout();
            // 
            // GC_Cut
            // 
            this.GC_Cut.Location = new System.Drawing.Point(0, 0);
            this.GC_Cut.MainView = this.GV_Cut;
            this.GC_Cut.Name = "GC_Cut";
            this.GC_Cut.Size = new System.Drawing.Size(437, 416);
            this.GC_Cut.TabIndex = 5;
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
            // UC_DataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GC_Cut);
            this.Name = "UC_DataGridView";
            this.Size = new System.Drawing.Size(440, 416);
            ((System.ComponentModel.ISupportInitialize)(this.GC_Cut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Cut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraGrid.GridControl GC_Cut;
        public DevExpress.XtraGrid.Views.Grid.GridView GV_Cut;
    }
}

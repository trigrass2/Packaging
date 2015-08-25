namespace Packaging
{
    partial class Std_DataView
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
            this.GC_Modbus = new DevExpress.XtraGrid.GridControl();
            this.gv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BT_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.BT_Teach = new DevExpress.XtraEditors.SimpleButton();
            this.BT_Import = new DevExpress.XtraEditors.SimpleButton();
            this.BT_OutPort = new DevExpress.XtraEditors.SimpleButton();
            this.gc_control = new DevExpress.XtraEditors.GroupControl();
            this.SCC = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Modbus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_control)).BeginInit();
            this.gc_control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SCC)).BeginInit();
            this.SCC.SuspendLayout();
            this.SuspendLayout();
            // 
            // GC_Modbus
            // 
            this.GC_Modbus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GC_Modbus.Location = new System.Drawing.Point(0, 0);
            this.GC_Modbus.MainView = this.gv;
            this.GC_Modbus.Name = "GC_Modbus";
            this.GC_Modbus.Size = new System.Drawing.Size(808, 465);
            this.GC_Modbus.TabIndex = 1;
            this.GC_Modbus.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv});
            // 
            // gv
            // 
            this.gv.ActiveFilterEnabled = false;
            this.gv.GridControl = this.GC_Modbus;
            this.gv.Name = "gv";
            this.gv.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gv.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gv.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gv.OptionsBehavior.Editable = false;
            this.gv.OptionsCustomization.AllowColumnMoving = false;
            this.gv.OptionsCustomization.AllowFilter = false;
            this.gv.OptionsCustomization.AllowGroup = false;
            this.gv.OptionsCustomization.AllowSort = false;
            this.gv.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gv.OptionsView.EnableAppearanceOddRow = true;
            this.gv.OptionsView.ShowGroupPanel = false;
            this.gv.SynchronizeClones = false;
            // 
            // BT_Edit
            // 
            this.BT_Edit.Location = new System.Drawing.Point(40, 30);
            this.BT_Edit.Name = "BT_Edit";
            this.BT_Edit.Size = new System.Drawing.Size(75, 23);
            this.BT_Edit.TabIndex = 2;
            this.BT_Edit.Text = "编辑";
            // 
            // BT_Teach
            // 
            this.BT_Teach.Location = new System.Drawing.Point(161, 30);
            this.BT_Teach.Name = "BT_Teach";
            this.BT_Teach.Size = new System.Drawing.Size(75, 23);
            this.BT_Teach.TabIndex = 3;
            this.BT_Teach.Text = "示教";
            // 
            // BT_Import
            // 
            this.BT_Import.Location = new System.Drawing.Point(284, 30);
            this.BT_Import.Name = "BT_Import";
            this.BT_Import.Size = new System.Drawing.Size(75, 23);
            this.BT_Import.TabIndex = 4;
            this.BT_Import.Text = "导入";
            // 
            // BT_OutPort
            // 
            this.BT_OutPort.Location = new System.Drawing.Point(396, 30);
            this.BT_OutPort.Name = "BT_OutPort";
            this.BT_OutPort.Size = new System.Drawing.Size(75, 23);
            this.BT_OutPort.TabIndex = 5;
            this.BT_OutPort.Text = "导出";
            // 
            // gc_control
            // 
            this.gc_control.Controls.Add(this.BT_Edit);
            this.gc_control.Controls.Add(this.BT_Teach);
            this.gc_control.Controls.Add(this.BT_Import);
            this.gc_control.Controls.Add(this.BT_OutPort);
            this.gc_control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_control.Location = new System.Drawing.Point(0, 0);
            this.gc_control.Name = "gc_control";
            this.gc_control.Size = new System.Drawing.Size(808, 58);
            this.gc_control.TabIndex = 6;
            // 
            // SCC
            // 
            this.SCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SCC.Horizontal = false;
            this.SCC.Location = new System.Drawing.Point(0, 0);
            this.SCC.Name = "SCC";
            this.SCC.Panel1.Controls.Add(this.GC_Modbus);
            this.SCC.Panel1.Text = "Panel1";
            this.SCC.Panel2.Controls.Add(this.gc_control);
            this.SCC.Panel2.Text = "Panel2";
            this.SCC.Size = new System.Drawing.Size(808, 528);
            this.SCC.SplitterPosition = 465;
            this.SCC.TabIndex = 7;
            // 
            // Std_DataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 528);
            this.Controls.Add(this.SCC);
            this.Name = "Std_DataView";
            this.Text = "Frm_Modbus";
            ((System.ComponentModel.ISupportInitialize)(this.GC_Modbus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_control)).EndInit();
            this.gc_control.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SCC)).EndInit();
            this.SCC.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraGrid.Views.Grid.GridView gv;
        public DevExpress.XtraEditors.GroupControl gc_control;
        public DevExpress.XtraEditors.SplitContainerControl SCC;
        public DevExpress.XtraGrid.GridControl GC_Modbus;
        public DevExpress.XtraEditors.SimpleButton BT_Edit;
        public DevExpress.XtraEditors.SimpleButton BT_Teach;
        public DevExpress.XtraEditors.SimpleButton BT_Import;
        public DevExpress.XtraEditors.SimpleButton BT_OutPort;

    }
}
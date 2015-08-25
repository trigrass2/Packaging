namespace Packaging
{
    partial class Frm_PCAlarm
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
            this.GC_Alarm = new DevExpress.XtraGrid.GridControl();
            this.gv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.timer_Refresh = new System.Windows.Forms.Timer(this.components);
            this.gc_control = new DevExpress.XtraEditors.GroupControl();
            this.BT_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.BT_OutPort = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Alarm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_control)).BeginInit();
            this.gc_control.SuspendLayout();
            this.SuspendLayout();
            // 
            // GC_Alarm
            // 
            this.GC_Alarm.Dock = System.Windows.Forms.DockStyle.Top;
            this.GC_Alarm.Location = new System.Drawing.Point(0, 0);
            this.GC_Alarm.MainView = this.gv;
            this.GC_Alarm.Name = "GC_Alarm";
            this.GC_Alarm.Size = new System.Drawing.Size(858, 517);
            this.GC_Alarm.TabIndex = 3;
            this.GC_Alarm.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv});
            // 
            // gv
            // 
            this.gv.ActiveFilterEnabled = false;
            this.gv.GridControl = this.GC_Alarm;
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
            // 
            // timer_Refresh
            // 
            this.timer_Refresh.Enabled = true;
            this.timer_Refresh.Interval = 3000;
            this.timer_Refresh.Tick += new System.EventHandler(this.timer_Refresh_Tick);
            // 
            // gc_control
            // 
            this.gc_control.Controls.Add(this.BT_Edit);
            this.gc_control.Controls.Add(this.BT_OutPort);
            this.gc_control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_control.Location = new System.Drawing.Point(0, 517);
            this.gc_control.Name = "gc_control";
            this.gc_control.Size = new System.Drawing.Size(858, 72);
            this.gc_control.TabIndex = 7;
            // 
            // BT_Edit
            // 
            this.BT_Edit.Location = new System.Drawing.Point(40, 30);
            this.BT_Edit.Name = "BT_Edit";
            this.BT_Edit.Size = new System.Drawing.Size(75, 23);
            this.BT_Edit.TabIndex = 2;
            this.BT_Edit.Text = "清空";
            this.BT_Edit.Click += new System.EventHandler(this.BT_Edit_Click);
            // 
            // BT_OutPort
            // 
            this.BT_OutPort.Location = new System.Drawing.Point(173, 30);
            this.BT_OutPort.Name = "BT_OutPort";
            this.BT_OutPort.Size = new System.Drawing.Size(75, 23);
            this.BT_OutPort.TabIndex = 5;
            this.BT_OutPort.Text = "导出";
            this.BT_OutPort.Click += new System.EventHandler(this.BT_OutPort_Click);
            // 
            // Frm_PCAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 589);
            this.Controls.Add(this.gc_control);
            this.Controls.Add(this.GC_Alarm);
            this.Name = "Frm_PCAlarm";
            this.Text = "Frm_Config";
            this.Load += new System.EventHandler(this.Frm_PCAlarm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GC_Alarm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_control)).EndInit();
            this.gc_control.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraGrid.GridControl GC_Alarm;
        public DevExpress.XtraGrid.Views.Grid.GridView gv;
        private System.Windows.Forms.Timer timer_Refresh;
        public DevExpress.XtraEditors.GroupControl gc_control;
        public DevExpress.XtraEditors.SimpleButton BT_Edit;
        public DevExpress.XtraEditors.SimpleButton BT_OutPort;
    }
}
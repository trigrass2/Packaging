namespace Packaging
{
    partial class Frm_Cs8cAlarm
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
            this.BT_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.gc_control = new DevExpress.XtraEditors.GroupControl();
            this.CB_ViewPackaging = new System.Windows.Forms.CheckBox();
            this.BT_OutPort = new DevExpress.XtraEditors.SimpleButton();
            this.timer_Refresh = new System.Windows.Forms.Timer(this.components);
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
            this.GC_Alarm.Size = new System.Drawing.Size(871, 444);
            this.GC_Alarm.TabIndex = 8;
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
            // BT_Edit
            // 
            this.BT_Edit.Enabled = false;
            this.BT_Edit.Location = new System.Drawing.Point(40, 30);
            this.BT_Edit.Name = "BT_Edit";
            this.BT_Edit.Size = new System.Drawing.Size(75, 23);
            this.BT_Edit.TabIndex = 2;
            this.BT_Edit.Text = "清空";
            // 
            // gc_control
            // 
            this.gc_control.Controls.Add(this.CB_ViewPackaging);
            this.gc_control.Controls.Add(this.BT_Edit);
            this.gc_control.Controls.Add(this.BT_OutPort);
            this.gc_control.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gc_control.Location = new System.Drawing.Point(0, 450);
            this.gc_control.Name = "gc_control";
            this.gc_control.Size = new System.Drawing.Size(871, 72);
            this.gc_control.TabIndex = 9;
            // 
            // CB_ViewPackaging
            // 
            this.CB_ViewPackaging.AutoSize = true;
            this.CB_ViewPackaging.Location = new System.Drawing.Point(312, 35);
            this.CB_ViewPackaging.Name = "CB_ViewPackaging";
            this.CB_ViewPackaging.Size = new System.Drawing.Size(107, 17);
            this.CB_ViewPackaging.TabIndex = 6;
            this.CB_ViewPackaging.Text = "只看Packaging日志";
            this.CB_ViewPackaging.UseVisualStyleBackColor = true;
            this.CB_ViewPackaging.CheckedChanged += new System.EventHandler(this.CB_ViewPackaging_CheckedChanged);
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
            // timer_Refresh
            // 
            this.timer_Refresh.Enabled = true;
            this.timer_Refresh.Interval = 20000;
            this.timer_Refresh.Tick += new System.EventHandler(this.timer_Refresh_Tick);
            // 
            // Frm_Cs8cAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 522);
            this.Controls.Add(this.GC_Alarm);
            this.Controls.Add(this.gc_control);
            this.Name = "Frm_Cs8cAlarm";
            this.Text = "Frm_Config";
            this.Load += new System.EventHandler(this.Frm_Cs8cAlarm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GC_Alarm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_control)).EndInit();
            this.gc_control.ResumeLayout(false);
            this.gc_control.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraGrid.GridControl GC_Alarm;
        public DevExpress.XtraGrid.Views.Grid.GridView gv;
        public DevExpress.XtraEditors.SimpleButton BT_Edit;
        public DevExpress.XtraEditors.GroupControl gc_control;
        public DevExpress.XtraEditors.SimpleButton BT_OutPort;
        private System.Windows.Forms.Timer timer_Refresh;
        private System.Windows.Forms.CheckBox CB_ViewPackaging;
    }
}
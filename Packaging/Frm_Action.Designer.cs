namespace Packaging
{
    partial class Frm_Action
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
            this.LL_Task = new System.Windows.Forms.Label();
            this.CB_RobotCount = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GC_Modbus = new DevExpress.XtraGrid.GridControl();
            this.gv = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Modbus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.SuspendLayout();
            // 
            // LL_Task
            // 
            this.LL_Task.AutoSize = true;
            this.LL_Task.Location = new System.Drawing.Point(300, 20);
            this.LL_Task.Name = "LL_Task";
            this.LL_Task.Size = new System.Drawing.Size(67, 13);
            this.LL_Task.TabIndex = 13;
            this.LL_Task.Text = "当前任务：";
            // 
            // CB_RobotCount
            // 
            this.CB_RobotCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_RobotCount.FormattingEnabled = true;
            this.CB_RobotCount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.CB_RobotCount.Location = new System.Drawing.Point(104, 16);
            this.CB_RobotCount.Name = "CB_RobotCount";
            this.CB_RobotCount.Size = new System.Drawing.Size(121, 21);
            this.CB_RobotCount.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "当前机器人:";
            // 
            // GC_Modbus
            // 
            this.GC_Modbus.Location = new System.Drawing.Point(24, 55);
            this.GC_Modbus.MainView = this.gv;
            this.GC_Modbus.Name = "GC_Modbus";
            this.GC_Modbus.Size = new System.Drawing.Size(565, 465);
            this.GC_Modbus.TabIndex = 14;
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
            // Frm_Action
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1027, 562);
            this.Controls.Add(this.GC_Modbus);
            this.Controls.Add(this.LL_Task);
            this.Controls.Add(this.CB_RobotCount);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Action";
            ((System.ComponentModel.ISupportInitialize)(this.GC_Modbus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LL_Task;
        private System.Windows.Forms.ComboBox CB_RobotCount;
        private System.Windows.Forms.Label label1;
        public DevExpress.XtraGrid.GridControl GC_Modbus;
        public DevExpress.XtraGrid.Views.Grid.GridView gv;
    }
}
namespace Packaging
{
    partial class Edit_Preset
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
            this.BT_Empty = new DevExpress.XtraEditors.SimpleButton();
            this.CBE_IO = new DevExpress.XtraEditors.ComboBoxEdit();
            this.TE_Remark = new DevExpress.XtraEditors.TextEdit();
            this.GC_Context = new DevExpress.XtraEditors.GroupControl();
            this.SE_5 = new DevExpress.XtraEditors.SpinEdit();
            this.SE_4 = new DevExpress.XtraEditors.SpinEdit();
            this.SE_3 = new DevExpress.XtraEditors.SpinEdit();
            this.SE_2 = new DevExpress.XtraEditors.SpinEdit();
            this.SE_1 = new DevExpress.XtraEditors.SpinEdit();
            this.LL_5 = new DevExpress.XtraEditors.LabelControl();
            this.LL_4 = new DevExpress.XtraEditors.LabelControl();
            this.LL_3 = new DevExpress.XtraEditors.LabelControl();
            this.LL_2 = new DevExpress.XtraEditors.LabelControl();
            this.LL_1 = new DevExpress.XtraEditors.LabelControl();
            this.BT_Cancle = new DevExpress.XtraEditors.SimpleButton();
            this.LC_Name = new DevExpress.XtraEditors.LabelControl();
            this.LL_Remark = new DevExpress.XtraEditors.LabelControl();
            this.LL_Preset = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.CBE_IO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TE_Remark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Context)).BeginInit();
            this.GC_Context.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SE_5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SE_4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SE_3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SE_2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SE_1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_ok
            // 
            this.BT_ok.Location = new System.Drawing.Point(18, 269);
            this.BT_ok.Name = "BT_ok";
            this.BT_ok.Size = new System.Drawing.Size(57, 23);
            this.BT_ok.TabIndex = 0;
            this.BT_ok.Text = "确定";
            this.BT_ok.Click += new System.EventHandler(this.BT_ok_Click);
            // 
            // BT_Apply
            // 
            this.BT_Apply.Location = new System.Drawing.Point(88, 269);
            this.BT_Apply.Name = "BT_Apply";
            this.BT_Apply.Size = new System.Drawing.Size(57, 23);
            this.BT_Apply.TabIndex = 1;
            this.BT_Apply.Text = "应用";
            this.BT_Apply.Click += new System.EventHandler(this.BT_Apply_Click);
            // 
            // BT_Empty
            // 
            this.BT_Empty.Location = new System.Drawing.Point(158, 269);
            this.BT_Empty.Name = "BT_Empty";
            this.BT_Empty.Size = new System.Drawing.Size(57, 23);
            this.BT_Empty.TabIndex = 2;
            this.BT_Empty.Text = "置空";
            this.BT_Empty.Click += new System.EventHandler(this.BT_Empty_Click);
            // 
            // CBE_IO
            // 
            this.CBE_IO.EditValue = "<Null>";
            this.CBE_IO.Location = new System.Drawing.Point(220, 12);
            this.CBE_IO.Name = "CBE_IO";
            this.CBE_IO.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CBE_IO.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.CBE_IO.Size = new System.Drawing.Size(65, 20);
            this.CBE_IO.TabIndex = 3;
            this.CBE_IO.SelectedIndexChanged += new System.EventHandler(this.CBE_IO_SelectedIndexChanged);
            // 
            // TE_Remark
            // 
            this.TE_Remark.Location = new System.Drawing.Point(70, 43);
            this.TE_Remark.Name = "TE_Remark";
            this.TE_Remark.Size = new System.Drawing.Size(215, 20);
            this.TE_Remark.TabIndex = 4;
            // 
            // GC_Context
            // 
            this.GC_Context.Controls.Add(this.SE_5);
            this.GC_Context.Controls.Add(this.SE_4);
            this.GC_Context.Controls.Add(this.SE_3);
            this.GC_Context.Controls.Add(this.SE_2);
            this.GC_Context.Controls.Add(this.SE_1);
            this.GC_Context.Controls.Add(this.LL_5);
            this.GC_Context.Controls.Add(this.LL_4);
            this.GC_Context.Controls.Add(this.LL_3);
            this.GC_Context.Controls.Add(this.LL_2);
            this.GC_Context.Controls.Add(this.LL_1);
            this.GC_Context.Location = new System.Drawing.Point(13, 78);
            this.GC_Context.Name = "GC_Context";
            this.GC_Context.Size = new System.Drawing.Size(272, 174);
            this.GC_Context.TabIndex = 5;
            // 
            // SE_5
            // 
            this.SE_5.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SE_5.Location = new System.Drawing.Point(118, 130);
            this.SE_5.Name = "SE_5";
            this.SE_5.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.SE_5.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SE_5.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.SE_5.Size = new System.Drawing.Size(100, 20);
            this.SE_5.TabIndex = 23;
            // 
            // SE_4
            // 
            this.SE_4.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SE_4.Location = new System.Drawing.Point(118, 104);
            this.SE_4.Name = "SE_4";
            this.SE_4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.SE_4.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SE_4.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.SE_4.Size = new System.Drawing.Size(100, 20);
            this.SE_4.TabIndex = 22;
            // 
            // SE_3
            // 
            this.SE_3.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SE_3.Location = new System.Drawing.Point(118, 78);
            this.SE_3.Name = "SE_3";
            this.SE_3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.SE_3.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SE_3.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.SE_3.Size = new System.Drawing.Size(100, 20);
            this.SE_3.TabIndex = 21;
            // 
            // SE_2
            // 
            this.SE_2.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SE_2.Location = new System.Drawing.Point(118, 52);
            this.SE_2.Name = "SE_2";
            this.SE_2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.SE_2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SE_2.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.SE_2.Size = new System.Drawing.Size(100, 20);
            this.SE_2.TabIndex = 20;
            // 
            // SE_1
            // 
            this.SE_1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SE_1.Location = new System.Drawing.Point(118, 26);
            this.SE_1.Name = "SE_1";
            this.SE_1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.SE_1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SE_1.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.SE_1.Size = new System.Drawing.Size(100, 20);
            this.SE_1.TabIndex = 19;
            // 
            // LL_5
            // 
            this.LL_5.Location = new System.Drawing.Point(19, 129);
            this.LL_5.Name = "LL_5";
            this.LL_5.Size = new System.Drawing.Size(83, 13);
            this.LL_5.TabIndex = 18;
            this.LL_5.Text = "随动高度(%):";
            // 
            // LL_4
            // 
            this.LL_4.Location = new System.Drawing.Point(19, 104);
            this.LL_4.Name = "LL_4";
            this.LL_4.Size = new System.Drawing.Size(71, 13);
            this.LL_4.TabIndex = 15;
            this.LL_4.Text = "气体压力(%):";
            // 
            // LL_3
            // 
            this.LL_3.Location = new System.Drawing.Point(19, 79);
            this.LL_3.Name = "LL_3";
            this.LL_3.Size = new System.Drawing.Size(83, 13);
            this.LL_3.TabIndex = 12;
            this.LL_3.Text = "占空比大小(%):";
            // 
            // LL_2
            // 
            this.LL_2.Location = new System.Drawing.Point(19, 54);
            this.LL_2.Name = "LL_2";
            this.LL_2.Size = new System.Drawing.Size(83, 13);
            this.LL_2.TabIndex = 9;
            this.LL_2.Text = "占空比频率(%):";
            // 
            // LL_1
            // 
            this.LL_1.Location = new System.Drawing.Point(19, 29);
            this.LL_1.Name = "LL_1";
            this.LL_1.Size = new System.Drawing.Size(71, 13);
            this.LL_1.TabIndex = 6;
            this.LL_1.Text = "激光功率(%):";
            // 
            // BT_Cancle
            // 
            this.BT_Cancle.Location = new System.Drawing.Point(228, 269);
            this.BT_Cancle.Name = "BT_Cancle";
            this.BT_Cancle.Size = new System.Drawing.Size(57, 23);
            this.BT_Cancle.TabIndex = 6;
            this.BT_Cancle.Text = "取消";
            this.BT_Cancle.Click += new System.EventHandler(this.BT_Cancle_Click);
            // 
            // LC_Name
            // 
            this.LC_Name.Location = new System.Drawing.Point(174, 15);
            this.LC_Name.Name = "LC_Name";
            this.LC_Name.Size = new System.Drawing.Size(28, 13);
            this.LC_Name.TabIndex = 7;
            this.LC_Name.Text = "序号:";
            // 
            // LL_Remark
            // 
            this.LL_Remark.Location = new System.Drawing.Point(18, 46);
            this.LL_Remark.Name = "LL_Remark";
            this.LL_Remark.Size = new System.Drawing.Size(28, 13);
            this.LL_Remark.TabIndex = 8;
            this.LL_Remark.Text = "备注:";
            // 
            // LL_Preset
            // 
            this.LL_Preset.Location = new System.Drawing.Point(18, 15);
            this.LL_Preset.Name = "LL_Preset";
            this.LL_Preset.Size = new System.Drawing.Size(103, 13);
            this.LL_Preset.TabIndex = 9;
            this.LL_Preset.Text = "工艺名:StaubliPreset";
            // 
            // Edit_Preset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 303);
            this.ControlBox = false;
            this.Controls.Add(this.LL_Preset);
            this.Controls.Add(this.LL_Remark);
            this.Controls.Add(this.LC_Name);
            this.Controls.Add(this.BT_Cancle);
            this.Controls.Add(this.GC_Context);
            this.Controls.Add(this.TE_Remark);
            this.Controls.Add(this.CBE_IO);
            this.Controls.Add(this.BT_Empty);
            this.Controls.Add(this.BT_Apply);
            this.Controls.Add(this.BT_ok);
            this.Name = "Edit_Preset";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "编辑工艺";
            this.Load += new System.EventHandler(this.Edit_Preset_Load);
            this.Leave += new System.EventHandler(this.Edit_Preset_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.CBE_IO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TE_Remark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Context)).EndInit();
            this.GC_Context.ResumeLayout(false);
            this.GC_Context.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SE_5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SE_4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SE_3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SE_2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SE_1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BT_ok;
        private DevExpress.XtraEditors.SimpleButton BT_Apply;
        private DevExpress.XtraEditors.SimpleButton BT_Empty;
        private DevExpress.XtraEditors.ComboBoxEdit CBE_IO;
        private DevExpress.XtraEditors.TextEdit TE_Remark;
        private DevExpress.XtraEditors.GroupControl GC_Context;
        private DevExpress.XtraEditors.LabelControl LL_5;
        private DevExpress.XtraEditors.LabelControl LL_4;
        private DevExpress.XtraEditors.LabelControl LL_3;
        private DevExpress.XtraEditors.LabelControl LL_2;
        private DevExpress.XtraEditors.LabelControl LL_1;
        private DevExpress.XtraEditors.SimpleButton BT_Cancle;
        private DevExpress.XtraEditors.LabelControl LC_Name;
        private DevExpress.XtraEditors.LabelControl LL_Remark;
        private DevExpress.XtraEditors.SpinEdit SE_1;
        private DevExpress.XtraEditors.LabelControl LL_Preset;
        private DevExpress.XtraEditors.SpinEdit SE_5;
        private DevExpress.XtraEditors.SpinEdit SE_4;
        private DevExpress.XtraEditors.SpinEdit SE_3;
        private DevExpress.XtraEditors.SpinEdit SE_2;
    }
}
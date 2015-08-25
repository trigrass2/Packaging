namespace Packaging
{
    partial class Sel_Recipe
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
            this.LL_ID = new DevExpress.XtraEditors.LabelControl();
            this.CBE_id = new DevExpress.XtraEditors.ComboBoxEdit();
            this.BT_Cancle = new DevExpress.XtraEditors.SimpleButton();
            this.BT_Apply = new DevExpress.XtraEditors.SimpleButton();
            this.BT_ok = new DevExpress.XtraEditors.SimpleButton();
            this.LL_Type = new DevExpress.XtraEditors.LabelControl();
            this.CBE_Recipe = new DevExpress.XtraEditors.ComboBoxEdit();
            this.CBE_Preset = new DevExpress.XtraEditors.ComboBoxEdit();
            this.GC_Trajs = new DevExpress.XtraEditors.GroupControl();
            this.CEL_Trajs = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.CBK_Match = new DevExpress.XtraEditors.CheckEdit();
            this.CBE_ProductCount = new DevExpress.XtraEditors.ComboBoxEdit();
            this.CBE_ProductIndex = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.CBE_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBE_Recipe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBE_Preset.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Trajs)).BeginInit();
            this.GC_Trajs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CEL_Trajs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBK_Match.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBE_ProductCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBE_ProductIndex.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LL_ID
            // 
            this.LL_ID.Location = new System.Drawing.Point(9, 11);
            this.LL_ID.Name = "LL_ID";
            this.LL_ID.Size = new System.Drawing.Size(52, 13);
            this.LL_ID.TabIndex = 15;
            this.LL_ID.Text = "工位序号:";
            // 
            // CBE_id
            // 
            this.CBE_id.Location = new System.Drawing.Point(90, 8);
            this.CBE_id.Name = "CBE_id";
            this.CBE_id.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CBE_id.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.CBE_id.ShowToolTips = false;
            this.CBE_id.Size = new System.Drawing.Size(140, 20);
            this.CBE_id.TabIndex = 14;
            this.CBE_id.SelectedIndexChanged += new System.EventHandler(this.CBE_id_SelectedIndexChanged);
            // 
            // BT_Cancle
            // 
            this.BT_Cancle.Location = new System.Drawing.Point(201, 295);
            this.BT_Cancle.Name = "BT_Cancle";
            this.BT_Cancle.Size = new System.Drawing.Size(57, 23);
            this.BT_Cancle.TabIndex = 18;
            this.BT_Cancle.Text = "取消";
            this.BT_Cancle.Click += new System.EventHandler(this.BT_Cancle_Click);
            // 
            // BT_Apply
            // 
            this.BT_Apply.Location = new System.Drawing.Point(119, 295);
            this.BT_Apply.Name = "BT_Apply";
            this.BT_Apply.Size = new System.Drawing.Size(57, 23);
            this.BT_Apply.TabIndex = 17;
            this.BT_Apply.Text = "应用";
            this.BT_Apply.Click += new System.EventHandler(this.BT_Apply_Click);
            // 
            // BT_ok
            // 
            this.BT_ok.Location = new System.Drawing.Point(27, 295);
            this.BT_ok.Name = "BT_ok";
            this.BT_ok.Size = new System.Drawing.Size(57, 23);
            this.BT_ok.TabIndex = 16;
            this.BT_ok.Text = "确定";
            this.BT_ok.Click += new System.EventHandler(this.BT_ok_Click);
            // 
            // LL_Type
            // 
            this.LL_Type.Location = new System.Drawing.Point(9, 39);
            this.LL_Type.Name = "LL_Type";
            this.LL_Type.Size = new System.Drawing.Size(28, 13);
            this.LL_Type.TabIndex = 20;
            this.LL_Type.Text = "产品:";
            // 
            // CBE_Recipe
            // 
            this.CBE_Recipe.Location = new System.Drawing.Point(90, 37);
            this.CBE_Recipe.Name = "CBE_Recipe";
            this.CBE_Recipe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CBE_Recipe.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.CBE_Recipe.Size = new System.Drawing.Size(140, 20);
            this.CBE_Recipe.TabIndex = 19;
            this.CBE_Recipe.TextChanged += new System.EventHandler(this.CBE_Recipe_TextChanged);
            // 
            // CBE_Preset
            // 
            this.CBE_Preset.Location = new System.Drawing.Point(90, 66);
            this.CBE_Preset.Name = "CBE_Preset";
            this.CBE_Preset.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CBE_Preset.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.CBE_Preset.Size = new System.Drawing.Size(140, 20);
            this.CBE_Preset.TabIndex = 22;
            // 
            // GC_Trajs
            // 
            this.GC_Trajs.Controls.Add(this.CEL_Trajs);
            this.GC_Trajs.Location = new System.Drawing.Point(7, 97);
            this.GC_Trajs.Name = "GC_Trajs";
            this.GC_Trajs.Size = new System.Drawing.Size(270, 182);
            this.GC_Trajs.TabIndex = 23;
            this.GC_Trajs.Text = "路径选择(打勾生产,不打勾过滤)";
            // 
            // CEL_Trajs
            // 
            this.CEL_Trajs.Location = new System.Drawing.Point(6, 25);
            this.CEL_Trajs.Name = "CEL_Trajs";
            this.CEL_Trajs.Size = new System.Drawing.Size(259, 152);
            this.CEL_Trajs.TabIndex = 0;
            // 
            // CBK_Match
            // 
            this.CBK_Match.Location = new System.Drawing.Point(9, 67);
            this.CBK_Match.Name = "CBK_Match";
            this.CBK_Match.Properties.Caption = "速度匹配";
            this.CBK_Match.Size = new System.Drawing.Size(75, 19);
            this.CBK_Match.TabIndex = 24;
            this.CBK_Match.CheckedChanged += new System.EventHandler(this.CBK_Match_CheckedChanged);
            // 
            // CBE_ProductCount
            // 
            this.CBE_ProductCount.Location = new System.Drawing.Point(236, 8);
            this.CBE_ProductCount.Name = "CBE_ProductCount";
            this.CBE_ProductCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CBE_ProductCount.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.CBE_ProductCount.ShowToolTips = false;
            this.CBE_ProductCount.Size = new System.Drawing.Size(41, 20);
            this.CBE_ProductCount.TabIndex = 25;
            this.CBE_ProductCount.SelectedIndexChanged += new System.EventHandler(this.CBE_ProductCount_SelectedIndexChanged);
            // 
            // CBE_ProductIndex
            // 
            this.CBE_ProductIndex.Location = new System.Drawing.Point(236, 37);
            this.CBE_ProductIndex.Name = "CBE_ProductIndex";
            this.CBE_ProductIndex.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CBE_ProductIndex.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.CBE_ProductIndex.ShowToolTips = false;
            this.CBE_ProductIndex.Size = new System.Drawing.Size(41, 20);
            this.CBE_ProductIndex.TabIndex = 26;
            this.CBE_ProductIndex.SelectedIndexChanged += new System.EventHandler(this.CBE_ProductIndex_SelectedIndexChanged);
            // 
            // Sel_Recipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 328);
            this.ControlBox = false;
            this.Controls.Add(this.CBE_ProductIndex);
            this.Controls.Add(this.CBE_ProductCount);
            this.Controls.Add(this.CBK_Match);
            this.Controls.Add(this.GC_Trajs);
            this.Controls.Add(this.CBE_Preset);
            this.Controls.Add(this.LL_Type);
            this.Controls.Add(this.CBE_Recipe);
            this.Controls.Add(this.BT_Cancle);
            this.Controls.Add(this.BT_Apply);
            this.Controls.Add(this.BT_ok);
            this.Controls.Add(this.LL_ID);
            this.Controls.Add(this.CBE_id);
            this.Name = "Sel_Recipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "选择产品";
            this.Load += new System.EventHandler(this.Sel_Recipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CBE_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBE_Recipe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBE_Preset.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Trajs)).EndInit();
            this.GC_Trajs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CEL_Trajs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBK_Match.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBE_ProductCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBE_ProductIndex.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl LL_ID;
        private DevExpress.XtraEditors.ComboBoxEdit CBE_id;
        private DevExpress.XtraEditors.SimpleButton BT_Cancle;
        private DevExpress.XtraEditors.SimpleButton BT_Apply;
        private DevExpress.XtraEditors.SimpleButton BT_ok;
        private DevExpress.XtraEditors.LabelControl LL_Type;
        private DevExpress.XtraEditors.ComboBoxEdit CBE_Recipe;
        private DevExpress.XtraEditors.ComboBoxEdit CBE_Preset;
        private DevExpress.XtraEditors.GroupControl GC_Trajs;
        private DevExpress.XtraEditors.CheckedListBoxControl CEL_Trajs;
        private DevExpress.XtraEditors.CheckEdit CBK_Match;
        private DevExpress.XtraEditors.ComboBoxEdit CBE_ProductCount;
        private DevExpress.XtraEditors.ComboBoxEdit CBE_ProductIndex;

    }
}
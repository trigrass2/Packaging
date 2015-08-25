namespace Packaging
{
    partial class Edit_Sequen
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
            this.LL_RecipeName = new DevExpress.XtraEditors.LabelControl();
            this.LL_ID = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BT_Cancle = new DevExpress.XtraEditors.SimpleButton();
            this.BT_ok = new DevExpress.XtraEditors.SimpleButton();
            this.GC_Traj = new DevExpress.XtraGrid.GridControl();
            this.gv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pic_bottom = new System.Windows.Forms.PictureBox();
            this.pic_down = new System.Windows.Forms.PictureBox();
            this.pic_up = new System.Windows.Forms.PictureBox();
            this.pic_top = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Traj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_bottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_top)).BeginInit();
            this.SuspendLayout();
            // 
            // LL_RecipeName
            // 
            this.LL_RecipeName.Location = new System.Drawing.Point(19, 33);
            this.LL_RecipeName.Name = "LL_RecipeName";
            this.LL_RecipeName.Size = new System.Drawing.Size(73, 13);
            this.LL_RecipeName.TabIndex = 1;
            this.LL_RecipeName.Text = "产品名称:Test";
            // 
            // LL_ID
            // 
            this.LL_ID.Location = new System.Drawing.Point(137, 33);
            this.LL_ID.Name = "LL_ID";
            this.LL_ID.Size = new System.Drawing.Size(64, 13);
            this.LL_ID.TabIndex = 14;
            this.LL_ID.Text = "路径总个数:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.LL_ID);
            this.groupControl1.Controls.Add(this.LL_RecipeName);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(309, 58);
            this.groupControl1.TabIndex = 15;
            this.groupControl1.Text = "产品信息:";
            // 
            // BT_Cancle
            // 
            this.BT_Cancle.Location = new System.Drawing.Point(156, 317);
            this.BT_Cancle.Name = "BT_Cancle";
            this.BT_Cancle.Size = new System.Drawing.Size(57, 23);
            this.BT_Cancle.TabIndex = 17;
            this.BT_Cancle.Text = "取消";
            this.BT_Cancle.Click += new System.EventHandler(this.BT_Cancle_Click);
            // 
            // BT_ok
            // 
            this.BT_ok.Location = new System.Drawing.Point(54, 317);
            this.BT_ok.Name = "BT_ok";
            this.BT_ok.Size = new System.Drawing.Size(57, 23);
            this.BT_ok.TabIndex = 16;
            this.BT_ok.Text = "确定";
            this.BT_ok.Click += new System.EventHandler(this.BT_ok_Click);
            // 
            // GC_Traj
            // 
            this.GC_Traj.Location = new System.Drawing.Point(3, 66);
            this.GC_Traj.MainView = this.gv;
            this.GC_Traj.Name = "GC_Traj";
            this.GC_Traj.Size = new System.Drawing.Size(272, 245);
            this.GC_Traj.TabIndex = 18;
            this.GC_Traj.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv});
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
            this.gv.OptionsCustomization.AllowFilter = false;
            this.gv.OptionsCustomization.AllowGroup = false;
            this.gv.OptionsCustomization.AllowSort = false;
            this.gv.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gv.OptionsView.EnableAppearanceOddRow = true;
            this.gv.OptionsView.ShowGroupPanel = false;
            this.gv.SynchronizeClones = false;
            // 
            // pic_bottom
            // 
            this.pic_bottom.BackColor = System.Drawing.Color.Transparent;
            this.pic_bottom.Image = global::Packaging.Properties.Resources._093650191;
            this.pic_bottom.Location = new System.Drawing.Point(281, 271);
            this.pic_bottom.Name = "pic_bottom";
            this.pic_bottom.Size = new System.Drawing.Size(28, 28);
            this.pic_bottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_bottom.TabIndex = 22;
            this.pic_bottom.TabStop = false;
            this.pic_bottom.Click += new System.EventHandler(this.pic_bottom_Click);
            // 
            // pic_down
            // 
            this.pic_down.BackColor = System.Drawing.Color.Transparent;
            this.pic_down.Image = global::Packaging.Properties.Resources._093650182;
            this.pic_down.Location = new System.Drawing.Point(281, 237);
            this.pic_down.Name = "pic_down";
            this.pic_down.Size = new System.Drawing.Size(28, 28);
            this.pic_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_down.TabIndex = 21;
            this.pic_down.TabStop = false;
            this.pic_down.Click += new System.EventHandler(this.pic_down_Click);
            // 
            // pic_up
            // 
            this.pic_up.BackColor = System.Drawing.Color.Transparent;
            this.pic_up.Image = global::Packaging.Properties.Resources._093650189;
            this.pic_up.Location = new System.Drawing.Point(281, 109);
            this.pic_up.Name = "pic_up";
            this.pic_up.Size = new System.Drawing.Size(28, 28);
            this.pic_up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_up.TabIndex = 20;
            this.pic_up.TabStop = false;
            this.pic_up.Click += new System.EventHandler(this.pic_up_Click);
            // 
            // pic_top
            // 
            this.pic_top.BackColor = System.Drawing.Color.Transparent;
            this.pic_top.Image = global::Packaging.Properties.Resources._093650216;
            this.pic_top.Location = new System.Drawing.Point(281, 75);
            this.pic_top.Name = "pic_top";
            this.pic_top.Size = new System.Drawing.Size(28, 28);
            this.pic_top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_top.TabIndex = 19;
            this.pic_top.TabStop = false;
            this.pic_top.Click += new System.EventHandler(this.pic_top_Click);
            // 
            // Edit_Sequen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 346);
            this.ControlBox = false;
            this.Controls.Add(this.pic_bottom);
            this.Controls.Add(this.pic_down);
            this.Controls.Add(this.pic_up);
            this.Controls.Add(this.pic_top);
            this.Controls.Add(this.GC_Traj);
            this.Controls.Add(this.BT_Cancle);
            this.Controls.Add(this.BT_ok);
            this.Controls.Add(this.groupControl1);
            this.DoubleBuffered = true;
            this.Name = "Edit_Sequen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "调整路径顺序";
            this.Load += new System.EventHandler(this.Edit_Sequen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Traj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_bottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_top)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl LL_RecipeName;
        private DevExpress.XtraEditors.LabelControl LL_ID;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BT_Cancle;
        private DevExpress.XtraEditors.SimpleButton BT_ok;
        protected DevExpress.XtraGrid.GridControl GC_Traj;
        public DevExpress.XtraGrid.Views.Grid.GridView gv;
        private System.Windows.Forms.PictureBox pic_bottom;
        private System.Windows.Forms.PictureBox pic_down;
        private System.Windows.Forms.PictureBox pic_up;
        private System.Windows.Forms.PictureBox pic_top;
    }
}
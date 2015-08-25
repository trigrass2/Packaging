namespace Packaging
{
    partial class Batch_DeleteTraj
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
            this.BT_Cancle = new DevExpress.XtraEditors.SimpleButton();
            this.BT_ok = new DevExpress.XtraEditors.SimpleButton();
            this.GC_Trajs = new DevExpress.XtraEditors.GroupControl();
            this.CEL_Trajs = new DevExpress.XtraEditors.CheckedListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Trajs)).BeginInit();
            this.GC_Trajs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CEL_Trajs)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_Cancle
            // 
            this.BT_Cancle.Location = new System.Drawing.Point(194, 293);
            this.BT_Cancle.Name = "BT_Cancle";
            this.BT_Cancle.Size = new System.Drawing.Size(57, 23);
            this.BT_Cancle.TabIndex = 18;
            this.BT_Cancle.Text = "取消";
            this.BT_Cancle.Click += new System.EventHandler(this.BT_Cancle_Click);
            // 
            // BT_ok
            // 
            this.BT_ok.Location = new System.Drawing.Point(39, 293);
            this.BT_ok.Name = "BT_ok";
            this.BT_ok.Size = new System.Drawing.Size(57, 23);
            this.BT_ok.TabIndex = 16;
            this.BT_ok.Text = "确定";
            this.BT_ok.Click += new System.EventHandler(this.BT_ok_Click);
            // 
            // GC_Trajs
            // 
            this.GC_Trajs.Controls.Add(this.CEL_Trajs);
            this.GC_Trajs.Location = new System.Drawing.Point(7, 12);
            this.GC_Trajs.Name = "GC_Trajs";
            this.GC_Trajs.Size = new System.Drawing.Size(270, 267);
            this.GC_Trajs.TabIndex = 23;
            this.GC_Trajs.Text = "路径选择(打勾删除)";
            // 
            // CEL_Trajs
            // 
            this.CEL_Trajs.Location = new System.Drawing.Point(6, 25);
            this.CEL_Trajs.Name = "CEL_Trajs";
            this.CEL_Trajs.Size = new System.Drawing.Size(259, 237);
            this.CEL_Trajs.TabIndex = 0;
            // 
            // Batch_DeleteTraj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 328);
            this.ControlBox = false;
            this.Controls.Add(this.GC_Trajs);
            this.Controls.Add(this.BT_Cancle);
            this.Controls.Add(this.BT_ok);
            this.Name = "Batch_DeleteTraj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "选择需要删除路径";
            this.Load += new System.EventHandler(this.Sel_Recipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GC_Trajs)).EndInit();
            this.GC_Trajs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CEL_Trajs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BT_Cancle;
        private DevExpress.XtraEditors.SimpleButton BT_ok;
        private DevExpress.XtraEditors.GroupControl GC_Trajs;
        private DevExpress.XtraEditors.CheckedListBoxControl CEL_Trajs;

    }
}
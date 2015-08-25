namespace Packaging
{
    partial class UC_SysConfig
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GC_Robot = new DevExpress.XtraEditors.GroupControl();
            this.CE_Link = new DevExpress.XtraEditors.CheckEdit();
            this.TE_Remark = new DevExpress.XtraEditors.TextEdit();
            this.LL_Remark = new DevExpress.XtraEditors.LabelControl();
            this.TE_Prog = new DevExpress.XtraEditors.TextEdit();
            this.LL_Prog = new DevExpress.XtraEditors.LabelControl();
            this.TE_Ip = new DevExpress.XtraEditors.TextEdit();
            this.LL_IP = new DevExpress.XtraEditors.LabelControl();
            this.LL_ID = new DevExpress.XtraEditors.LabelControl();
            this.CE_Server = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Robot)).BeginInit();
            this.GC_Robot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CE_Link.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TE_Remark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TE_Prog.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TE_Ip.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GC_Robot
            // 
            this.GC_Robot.Controls.Add(this.CE_Server);
            this.GC_Robot.Controls.Add(this.CE_Link);
            this.GC_Robot.Controls.Add(this.TE_Remark);
            this.GC_Robot.Controls.Add(this.LL_Remark);
            this.GC_Robot.Controls.Add(this.TE_Prog);
            this.GC_Robot.Controls.Add(this.LL_Prog);
            this.GC_Robot.Controls.Add(this.TE_Ip);
            this.GC_Robot.Controls.Add(this.LL_IP);
            this.GC_Robot.Controls.Add(this.LL_ID);
            this.GC_Robot.Location = new System.Drawing.Point(0, 2);
            this.GC_Robot.Name = "GC_Robot";
            this.GC_Robot.Size = new System.Drawing.Size(360, 218);
            this.GC_Robot.TabIndex = 6;
            this.GC_Robot.Text = "机器人信息";
            this.GC_Robot.Paint += new System.Windows.Forms.PaintEventHandler(this.GC_Robot_Paint);
            // 
            // CE_Link
            // 
            this.CE_Link.Location = new System.Drawing.Point(163, 26);
            this.CE_Link.Name = "CE_Link";
            this.CE_Link.Properties.Caption = "链接";
            this.CE_Link.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CE_Link.Size = new System.Drawing.Size(75, 19);
            this.CE_Link.TabIndex = 13;
            // 
            // TE_Remark
            // 
            this.TE_Remark.Location = new System.Drawing.Point(70, 148);
            this.TE_Remark.Name = "TE_Remark";
            this.TE_Remark.Size = new System.Drawing.Size(252, 20);
            this.TE_Remark.TabIndex = 12;
            // 
            // LL_Remark
            // 
            this.LL_Remark.Location = new System.Drawing.Point(12, 150);
            this.LL_Remark.Name = "LL_Remark";
            this.LL_Remark.Size = new System.Drawing.Size(28, 13);
            this.LL_Remark.TabIndex = 11;
            this.LL_Remark.Text = "备注:";
            // 
            // TE_Prog
            // 
            this.TE_Prog.Location = new System.Drawing.Point(70, 103);
            this.TE_Prog.Name = "TE_Prog";
            this.TE_Prog.Size = new System.Drawing.Size(252, 20);
            this.TE_Prog.TabIndex = 8;
            // 
            // LL_Prog
            // 
            this.LL_Prog.Location = new System.Drawing.Point(12, 106);
            this.LL_Prog.Name = "LL_Prog";
            this.LL_Prog.Size = new System.Drawing.Size(48, 13);
            this.LL_Prog.TabIndex = 7;
            this.LL_Prog.Text = "程序名：";
            // 
            // TE_Ip
            // 
            this.TE_Ip.Location = new System.Drawing.Point(70, 58);
            this.TE_Ip.Name = "TE_Ip";
            this.TE_Ip.Size = new System.Drawing.Size(252, 20);
            this.TE_Ip.TabIndex = 6;
            // 
            // LL_IP
            // 
            this.LL_IP.Location = new System.Drawing.Point(12, 62);
            this.LL_IP.Name = "LL_IP";
            this.LL_IP.Size = new System.Drawing.Size(50, 13);
            this.LL_IP.TabIndex = 1;
            this.LL_IP.Text = "控制器IP:";
            // 
            // LL_ID
            // 
            this.LL_ID.Location = new System.Drawing.Point(12, 29);
            this.LL_ID.Name = "LL_ID";
            this.LL_ID.Size = new System.Drawing.Size(64, 13);
            this.LL_ID.TabIndex = 0;
            this.LL_ID.Text = "机器人序号:";
            // 
            // CE_Server
            // 
            this.CE_Server.AutoSize = true;
            this.CE_Server.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CE_Server.Location = new System.Drawing.Point(12, 187);
            this.CE_Server.Name = "CE_Server";
            this.CE_Server.Size = new System.Drawing.Size(77, 17);
            this.CE_Server.TabIndex = 47;
            this.CE_Server.Text = " 作为主机";
            this.CE_Server.UseVisualStyleBackColor = true;
            // 
            // UC_SysConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GC_Robot);
            this.Name = "UC_SysConfig";
            this.Size = new System.Drawing.Size(360, 220);
            ((System.ComponentModel.ISupportInitialize)(this.GC_Robot)).EndInit();
            this.GC_Robot.ResumeLayout(false);
            this.GC_Robot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CE_Link.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TE_Remark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TE_Prog.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TE_Ip.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
                
        private DevExpress.XtraEditors.GroupControl GC_Robot;
        private DevExpress.XtraEditors.CheckEdit CE_Link;
        private DevExpress.XtraEditors.TextEdit TE_Remark;
        private DevExpress.XtraEditors.LabelControl LL_Remark;
        private DevExpress.XtraEditors.TextEdit TE_Prog;
        private DevExpress.XtraEditors.LabelControl LL_Prog;
        private DevExpress.XtraEditors.TextEdit TE_Ip;
        private DevExpress.XtraEditors.LabelControl LL_IP;
        private DevExpress.XtraEditors.LabelControl LL_ID;
        private System.Windows.Forms.CheckBox CE_Server;
    }
}

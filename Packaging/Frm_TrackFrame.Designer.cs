namespace Packaging
{
    partial class Frm_TrackFrame
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
            this.GB_Setting = new System.Windows.Forms.GroupBox();
            this.CE_Server = new DevExpress.XtraEditors.CheckEdit();
            this.CB_Detector = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_Encode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_EncodeIndex = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_Track = new System.Windows.Forms.ComboBox();
            this.LL_Track = new System.Windows.Forms.Label();
            this.LL_Task = new System.Windows.Forms.Label();
            this.CB_RobotCount = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Pic_Show = new System.Windows.Forms.PictureBox();
            this.BT_Save = new System.Windows.Forms.Button();
            this.GB_Setting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CE_Server.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Show)).BeginInit();
            this.SuspendLayout();
            // 
            // GB_Setting
            // 
            this.GB_Setting.Controls.Add(this.CE_Server);
            this.GB_Setting.Location = new System.Drawing.Point(512, 272);
            this.GB_Setting.Name = "GB_Setting";
            this.GB_Setting.Size = new System.Drawing.Size(498, 240);
            this.GB_Setting.TabIndex = 38;
            this.GB_Setting.TabStop = false;
            this.GB_Setting.Text = "调速功能设置";
            // 
            // CE_Server
            // 
            this.CE_Server.Location = new System.Drawing.Point(25, 30);
            this.CE_Server.Name = "CE_Server";
            this.CE_Server.Properties.Caption = "启用调速功能";
            this.CE_Server.Size = new System.Drawing.Size(107, 19);
            this.CE_Server.TabIndex = 15;
            // 
            // CB_Detector
            // 
            this.CB_Detector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Detector.FormattingEnabled = true;
            this.CB_Detector.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.CB_Detector.Location = new System.Drawing.Point(99, 174);
            this.CB_Detector.Name = "CB_Detector";
            this.CB_Detector.Size = new System.Drawing.Size(121, 21);
            this.CB_Detector.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(7, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "定位设备选择:";
            // 
            // TB_Encode
            // 
            this.TB_Encode.Location = new System.Drawing.Point(99, 138);
            this.TB_Encode.Name = "TB_Encode";
            this.TB_Encode.Size = new System.Drawing.Size(121, 21);
            this.TB_Encode.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(14, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "编码器分辨率:";
            // 
            // CB_EncodeIndex
            // 
            this.CB_EncodeIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_EncodeIndex.FormattingEnabled = true;
            this.CB_EncodeIndex.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.CB_EncodeIndex.Location = new System.Drawing.Point(99, 101);
            this.CB_EncodeIndex.Name = "CB_EncodeIndex";
            this.CB_EncodeIndex.Size = new System.Drawing.Size(121, 21);
            this.CB_EncodeIndex.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(26, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "编码器:";
            // 
            // CB_Track
            // 
            this.CB_Track.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Track.FormattingEnabled = true;
            this.CB_Track.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.CB_Track.Location = new System.Drawing.Point(99, 63);
            this.CB_Track.Name = "CB_Track";
            this.CB_Track.Size = new System.Drawing.Size(121, 21);
            this.CB_Track.TabIndex = 30;
            // 
            // LL_Track
            // 
            this.LL_Track.AutoSize = true;
            this.LL_Track.ForeColor = System.Drawing.Color.Black;
            this.LL_Track.Location = new System.Drawing.Point(26, 66);
            this.LL_Track.Name = "LL_Track";
            this.LL_Track.Size = new System.Drawing.Size(47, 13);
            this.LL_Track.TabIndex = 29;
            this.LL_Track.Text = "传送带:";
            // 
            // LL_Task
            // 
            this.LL_Task.AutoSize = true;
            this.LL_Task.Location = new System.Drawing.Point(295, 34);
            this.LL_Task.Name = "LL_Task";
            this.LL_Task.Size = new System.Drawing.Size(67, 13);
            this.LL_Task.TabIndex = 27;
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
            this.CB_RobotCount.Location = new System.Drawing.Point(99, 27);
            this.CB_RobotCount.Name = "CB_RobotCount";
            this.CB_RobotCount.Size = new System.Drawing.Size(121, 21);
            this.CB_RobotCount.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "当前机器人:";
            // 
            // Pic_Show
            // 
            this.Pic_Show.Image = global::Packaging.Properties.Resources.trackframe;
            this.Pic_Show.Location = new System.Drawing.Point(512, 4);
            this.Pic_Show.Name = "Pic_Show";
            this.Pic_Show.Size = new System.Drawing.Size(510, 258);
            this.Pic_Show.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Show.TabIndex = 28;
            this.Pic_Show.TabStop = false;
            // 
            // BT_Save
            // 
            this.BT_Save.Location = new System.Drawing.Point(664, 518);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(175, 40);
            this.BT_Save.TabIndex = 44;
            this.BT_Save.Text = "保存";
            this.BT_Save.UseVisualStyleBackColor = true;
            // 
            // Frm_TrackFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 562);
            this.Controls.Add(this.BT_Save);
            this.Controls.Add(this.GB_Setting);
            this.Controls.Add(this.CB_Detector);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_Encode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CB_EncodeIndex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CB_Track);
            this.Controls.Add(this.LL_Track);
            this.Controls.Add(this.Pic_Show);
            this.Controls.Add(this.LL_Task);
            this.Controls.Add(this.CB_RobotCount);
            this.Controls.Add(this.label1);
            this.Name = "Frm_TrackFrame";
            this.Text = "Frm_TrackFrame";
            this.GB_Setting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CE_Server.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_Setting;
        private DevExpress.XtraEditors.CheckEdit CE_Server;
        private System.Windows.Forms.ComboBox CB_Detector;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_Encode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB_EncodeIndex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_Track;
        private System.Windows.Forms.Label LL_Track;
        private System.Windows.Forms.PictureBox Pic_Show;
        private System.Windows.Forms.Label LL_Task;
        private System.Windows.Forms.ComboBox CB_RobotCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_Save;
    }
}
namespace Packaging
{
    partial class Frm_SysConfig
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
            this.R1 = new Packaging.UC_SysConfig();
            this.R2 = new Packaging.UC_SysConfig();
            this.uC_SysConfig2 = new Packaging.UC_SysConfig();
            this.uC_SysConfig3 = new Packaging.UC_SysConfig();
            this.LL_Mark = new System.Windows.Forms.Label();
            this.BT_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_RobotCount = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // R1
            // 
            this.R1.Location = new System.Drawing.Point(62, 57);
            this.R1.Name = "R1";
            this.R1.Size = new System.Drawing.Size(368, 226);
            this.R1.TabIndex = 0;
            // 
            // R2
            // 
            this.R2.Location = new System.Drawing.Point(571, 57);
            this.R2.Name = "R2";
            this.R2.Size = new System.Drawing.Size(368, 226);
            this.R2.TabIndex = 1;
            // 
            // uC_SysConfig2
            // 
            this.uC_SysConfig2.Location = new System.Drawing.Point(62, 282);
            this.uC_SysConfig2.Name = "uC_SysConfig2";
            this.uC_SysConfig2.Size = new System.Drawing.Size(368, 226);
            this.uC_SysConfig2.TabIndex = 2;
            // 
            // uC_SysConfig3
            // 
            this.uC_SysConfig3.Location = new System.Drawing.Point(571, 282);
            this.uC_SysConfig3.Name = "uC_SysConfig3";
            this.uC_SysConfig3.Size = new System.Drawing.Size(368, 226);
            this.uC_SysConfig3.TabIndex = 3;
            // 
            // LL_Mark
            // 
            this.LL_Mark.AutoSize = true;
            this.LL_Mark.ForeColor = System.Drawing.Color.Red;
            this.LL_Mark.Location = new System.Drawing.Point(62, 531);
            this.LL_Mark.Name = "LL_Mark";
            this.LL_Mark.Size = new System.Drawing.Size(283, 13);
            this.LL_Mark.TabIndex = 4;
            this.LL_Mark.Text = "备注：做主机的机器人负责接收外部启停等控制信号";
            // 
            // BT_Save
            // 
            this.BT_Save.Location = new System.Drawing.Point(615, 512);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(204, 38);
            this.BT_Save.TabIndex = 5;
            this.BT_Save.Text = "保存";
            this.BT_Save.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(62, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "机器人数量";
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
            this.CB_RobotCount.Location = new System.Drawing.Point(145, 26);
            this.CB_RobotCount.Name = "CB_RobotCount";
            this.CB_RobotCount.Size = new System.Drawing.Size(121, 21);
            this.CB_RobotCount.TabIndex = 7;
            // 
            // Frm_SysConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 562);
            this.Controls.Add(this.CB_RobotCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_Save);
            this.Controls.Add(this.LL_Mark);
            this.Controls.Add(this.uC_SysConfig3);
            this.Controls.Add(this.uC_SysConfig2);
            this.Controls.Add(this.R2);
            this.Controls.Add(this.R1);
            this.Name = "Frm_SysConfig";
            this.Text = "Frm_SysConfig";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UC_SysConfig R1;
        private UC_SysConfig R2;
        private UC_SysConfig uC_SysConfig2;
        private UC_SysConfig uC_SysConfig3;
        private System.Windows.Forms.Label LL_Mark;
        private System.Windows.Forms.Button BT_Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_RobotCount;
    }
}
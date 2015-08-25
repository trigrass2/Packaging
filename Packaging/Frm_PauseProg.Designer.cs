namespace Packaging
{
    partial class Frm_PauseProg
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.spinEdit4 = new DevExpress.XtraEditors.SpinEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CB_TriggerIO = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit4.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LL_Task
            // 
            this.LL_Task.AutoSize = true;
            this.LL_Task.Location = new System.Drawing.Point(290, 15);
            this.LL_Task.Name = "LL_Task";
            this.LL_Task.Size = new System.Drawing.Size(67, 13);
            this.LL_Task.TabIndex = 56;
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
            this.CB_RobotCount.Location = new System.Drawing.Point(109, 12);
            this.CB_RobotCount.Name = "CB_RobotCount";
            this.CB_RobotCount.Size = new System.Drawing.Size(121, 21);
            this.CB_RobotCount.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(26, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "当前机器人:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CB_TriggerIO);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.spinEdit4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(1, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 471);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "程序配置";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox3.Location = new System.Drawing.Point(36, 394);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 68;
            this.checkBox3.Text = "传送带1：";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.Location = new System.Drawing.Point(36, 367);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 66;
            this.checkBox2.Text = "传送带1：";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Location = new System.Drawing.Point(36, 340);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 64;
            this.checkBox1.Text = "传送带1：";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "停止传送带：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "停止在当前位置，并下电";
            // 
            // spinEdit4
            // 
            this.spinEdit4.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit4.Location = new System.Drawing.Point(118, 58);
            this.spinEdit4.Name = "spinEdit4";
            this.spinEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEdit4.Size = new System.Drawing.Size(86, 20);
            this.spinEdit4.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "回零速度设定";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(514, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 471);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "暂停后，输出信号设置：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(295, 13);
            this.label8.TabIndex = 64;
            this.label8.Text = "②列出所有链接正确的模拟量输出信号，设置其初始值";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(387, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "列出所有链接正确的开关量输出信号 ，设置其初始状态为on还是off         ";
            // 
            // CB_TriggerIO
            // 
            this.CB_TriggerIO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_TriggerIO.FormattingEnabled = true;
            this.CB_TriggerIO.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.CB_TriggerIO.Location = new System.Drawing.Point(155, 30);
            this.CB_TriggerIO.Name = "CB_TriggerIO";
            this.CB_TriggerIO.Size = new System.Drawing.Size(121, 21);
            this.CB_TriggerIO.TabIndex = 75;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(34, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 74;
            this.label9.Text = "机器人动作设置";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "自动提升，回jHome位，并下电";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 13);
            this.label6.TabIndex = 77;
            this.label6.Text = "自动提升，回暂停位，并下电  ";
            // 
            // Frm_ResetProg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 562);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LL_Task);
            this.Controls.Add(this.CB_RobotCount);
            this.Controls.Add(this.label1);
            this.Name = "Frm_ResetProg";
            this.Text = "Frm_ResetProg";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit4.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LL_Task;
        private System.Windows.Forms.ComboBox CB_RobotCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SpinEdit spinEdit4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CB_TriggerIO;
        private System.Windows.Forms.Label label9;
    }
}
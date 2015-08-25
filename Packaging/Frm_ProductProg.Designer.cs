namespace Packaging
{
    partial class Frm_ProductProg
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CB_TriggerIO = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.spinEdit7 = new DevExpress.XtraEditors.SpinEdit();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.spinEdit5 = new DevExpress.XtraEditors.SpinEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.spinEdit6 = new DevExpress.XtraEditors.SpinEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.spinEdit2 = new DevExpress.XtraEditors.SpinEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.spinEdit3 = new DevExpress.XtraEditors.SpinEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.spinEdit4 = new DevExpress.XtraEditors.SpinEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.CE_Server = new System.Windows.Forms.CheckBox();
            this.BT_Save = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit4.Properties)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(1, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 406);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "程序配置";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.CB_TriggerIO);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.spinEdit7);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.spinEdit5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.spinEdit6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.spinEdit2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.spinEdit3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.spinEdit1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.spinEdit4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.CE_Server);
            this.groupBox2.Location = new System.Drawing.Point(514, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 406);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "产品选择策略";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox1.Location = new System.Drawing.Point(140, 335);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 75;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(19, 338);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 74;
            this.label10.Text = "选择传送带";
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
            this.CB_TriggerIO.Location = new System.Drawing.Point(140, 253);
            this.CB_TriggerIO.Name = "CB_TriggerIO";
            this.CB_TriggerIO.Size = new System.Drawing.Size(121, 21);
            this.CB_TriggerIO.TabIndex = 73;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(19, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 13);
            this.label9.TabIndex = 72;
            this.label9.Text = "选择接受的产品类型";
            // 
            // spinEdit7
            // 
            this.spinEdit7.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit7.Location = new System.Drawing.Point(156, 32);
            this.spinEdit7.Name = "spinEdit7";
            this.spinEdit7.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEdit7.Size = new System.Drawing.Size(86, 20);
            this.spinEdit7.TabIndex = 71;
            this.spinEdit7.EditValueChanged += new System.EventHandler(this.spinEdit7_EditValueChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.Location = new System.Drawing.Point(20, 218);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(98, 17);
            this.checkBox2.TabIndex = 70;
            this.checkBox2.Text = "产品类型选择";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // spinEdit5
            // 
            this.spinEdit5.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit5.Location = new System.Drawing.Point(273, 178);
            this.spinEdit5.Name = "spinEdit5";
            this.spinEdit5.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEdit5.Size = new System.Drawing.Size(86, 20);
            this.spinEdit5.TabIndex = 69;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(211, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 68;
            this.label7.Text = "最大：";
            // 
            // spinEdit6
            // 
            this.spinEdit6.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit6.Location = new System.Drawing.Point(92, 177);
            this.spinEdit6.Name = "spinEdit6";
            this.spinEdit6.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEdit6.Size = new System.Drawing.Size(86, 20);
            this.spinEdit6.TabIndex = 67;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 66;
            this.label8.Text = "③最小：";
            // 
            // spinEdit2
            // 
            this.spinEdit2.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit2.Location = new System.Drawing.Point(273, 152);
            this.spinEdit2.Name = "spinEdit2";
            this.spinEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEdit2.Size = new System.Drawing.Size(86, 20);
            this.spinEdit2.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "最大：";
            // 
            // spinEdit3
            // 
            this.spinEdit3.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit3.Location = new System.Drawing.Point(92, 151);
            this.spinEdit3.Name = "spinEdit3";
            this.spinEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEdit3.Size = new System.Drawing.Size(86, 20);
            this.spinEdit3.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = " ②最小：";
            // 
            // spinEdit1
            // 
            this.spinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit1.Location = new System.Drawing.Point(273, 126);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEdit1.Size = new System.Drawing.Size(86, 20);
            this.spinEdit1.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "最大：";
            // 
            // spinEdit4
            // 
            this.spinEdit4.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit4.Location = new System.Drawing.Point(92, 125);
            this.spinEdit4.Name = "spinEdit4";
            this.spinEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEdit4.Size = new System.Drawing.Size(86, 20);
            this.spinEdit4.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "①最小：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "设定接受的传送带Y向范围 ";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Location = new System.Drawing.Point(20, 70);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 17);
            this.checkBox1.TabIndex = 49;
            this.checkBox1.Text = " 作为主机";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // CE_Server
            // 
            this.CE_Server.AutoSize = true;
            this.CE_Server.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CE_Server.Location = new System.Drawing.Point(20, 34);
            this.CE_Server.Name = "CE_Server";
            this.CE_Server.Size = new System.Drawing.Size(80, 17);
            this.CE_Server.TabIndex = 48;
            this.CE_Server.Text = "平均分配  ";
            this.CE_Server.UseVisualStyleBackColor = true;
            // 
            // BT_Save
            // 
            this.BT_Save.Location = new System.Drawing.Point(654, 512);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(204, 38);
            this.BT_Save.TabIndex = 62;
            this.BT_Save.Text = "保存";
            this.BT_Save.UseVisualStyleBackColor = true;
            // 
            // Frm_ProductProg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 562);
            this.Controls.Add(this.BT_Save);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LL_Task);
            this.Controls.Add(this.CB_RobotCount);
            this.Controls.Add(this.label1);
            this.Name = "Frm_ProductProg";
            this.Text = "Frm_ResetProg";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit4.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LL_Task;
        private System.Windows.Forms.ComboBox CB_RobotCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox CE_Server;
        private DevExpress.XtraEditors.SpinEdit spinEdit7;
        private System.Windows.Forms.CheckBox checkBox2;
        private DevExpress.XtraEditors.SpinEdit spinEdit5;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SpinEdit spinEdit6;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.SpinEdit spinEdit2;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SpinEdit spinEdit3;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SpinEdit spinEdit4;
        private System.Windows.Forms.ComboBox CB_TriggerIO;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BT_Save;
    }
}
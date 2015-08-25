namespace Packaging
{
    partial class Frm_OnlineMonitor
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
            this.uC_Monitor1 = new Packaging.UC_Monitor();
            this.uC_Monitor2 = new Packaging.UC_Monitor();
            this.uC_Monitor3 = new Packaging.UC_Monitor();
            this.uC_Monitor4 = new Packaging.UC_Monitor();
            this.SuspendLayout();
            // 
            // uC_Monitor1
            // 
            this.uC_Monitor1.Location = new System.Drawing.Point(2, 12);
            this.uC_Monitor1.Name = "uC_Monitor1";
            this.uC_Monitor1.Size = new System.Drawing.Size(239, 494);
            this.uC_Monitor1.TabIndex = 0;
            // 
            // uC_Monitor2
            // 
            this.uC_Monitor2.Location = new System.Drawing.Point(263, 12);
            this.uC_Monitor2.Name = "uC_Monitor2";
            this.uC_Monitor2.Size = new System.Drawing.Size(239, 494);
            this.uC_Monitor2.TabIndex = 1;
            // 
            // uC_Monitor3
            // 
            this.uC_Monitor3.Location = new System.Drawing.Point(524, 12);
            this.uC_Monitor3.Name = "uC_Monitor3";
            this.uC_Monitor3.Size = new System.Drawing.Size(239, 494);
            this.uC_Monitor3.TabIndex = 2;
            // 
            // uC_Monitor4
            // 
            this.uC_Monitor4.Location = new System.Drawing.Point(785, 12);
            this.uC_Monitor4.Name = "uC_Monitor4";
            this.uC_Monitor4.Size = new System.Drawing.Size(239, 494);
            this.uC_Monitor4.TabIndex = 3;
            this.uC_Monitor4.Load += new System.EventHandler(this.uC_Monitor4_Load);
            // 
            // Frm_OnlineMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 562);
            this.Controls.Add(this.uC_Monitor4);
            this.Controls.Add(this.uC_Monitor3);
            this.Controls.Add(this.uC_Monitor2);
            this.Controls.Add(this.uC_Monitor1);
            this.Name = "Frm_OnlineMonitor";
            this.Text = "Frm_OnlineMonitor";
            this.ResumeLayout(false);

        }

        #endregion

        private UC_Monitor uC_Monitor1;
        private UC_Monitor uC_Monitor2;
        private UC_Monitor uC_Monitor3;
        private UC_Monitor uC_Monitor4;
    }
}
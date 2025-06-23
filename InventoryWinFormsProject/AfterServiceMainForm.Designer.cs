namespace AfterServiceApp
{

    partial class AfterServiceMainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnReport;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnView = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(183, 73);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(200, 47);
            this.btnView.TabIndex = 0;
            this.btnView.Text = "Query / Service Status Tracking";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(183, 206);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(200, 47);
            this.btnReport.TabIndex = 1;
            this.btnReport.Text = "report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // AfterServiceMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 401);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AfterServiceMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "After-Service management";
            this.Load += new System.EventHandler(this.AfterServiceMainForm_Load);
            this.ResumeLayout(false);

        }

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }

}

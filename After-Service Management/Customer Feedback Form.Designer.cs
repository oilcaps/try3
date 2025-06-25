namespace YourNamespace
{
    partial class CustomerFeedbackForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox grpFeedbackType;
        private System.Windows.Forms.RadioButton radioProductIssue;
        private System.Windows.Forms.RadioButton radioServiceFeedback;
        private System.Windows.Forms.RadioButton radioOther;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.grpFeedbackType = new System.Windows.Forms.GroupBox();
            this.radioOther = new System.Windows.Forms.RadioButton();
            this.radioServiceFeedback = new System.Windows.Forms.RadioButton();
            this.radioProductIssue = new System.Windows.Forms.RadioButton();
            this.lblComments = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpFeedbackType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(100, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 25);
            this.txtName.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(30, 60);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 15);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(100, 57);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 25);
            this.txtEmail.TabIndex = 3;
            // 
            // grpFeedbackType
            // 
            this.grpFeedbackType.Controls.Add(this.radioOther);
            this.grpFeedbackType.Controls.Add(this.radioServiceFeedback);
            this.grpFeedbackType.Controls.Add(this.radioProductIssue);
            this.grpFeedbackType.Location = new System.Drawing.Point(12, 95);
            this.grpFeedbackType.Name = "grpFeedbackType";
            this.grpFeedbackType.Size = new System.Drawing.Size(360, 70);
            this.grpFeedbackType.TabIndex = 4;
            this.grpFeedbackType.TabStop = false;
            this.grpFeedbackType.Text = "Feedback Type";
            // 
            // radioOther
            // 
            this.radioOther.AutoSize = true;
            this.radioOther.Checked = true;
            this.radioOther.Location = new System.Drawing.Point(292, 30);
            this.radioOther.Name = "radioOther";
            this.radioOther.Size = new System.Drawing.Size(68, 19);
            this.radioOther.TabIndex = 2;
            this.radioOther.TabStop = true;
            this.radioOther.Text = "Other";
            this.radioOther.UseVisualStyleBackColor = true;
            // 
            // radioServiceFeedback
            // 
            this.radioServiceFeedback.AutoSize = true;
            this.radioServiceFeedback.Location = new System.Drawing.Point(138, 30);
            this.radioServiceFeedback.Name = "radioServiceFeedback";
            this.radioServiceFeedback.Size = new System.Drawing.Size(156, 19);
            this.radioServiceFeedback.TabIndex = 1;
            this.radioServiceFeedback.TabStop = true;
            this.radioServiceFeedback.Text = "Service Feedback";
            this.radioServiceFeedback.UseVisualStyleBackColor = true;
            // 
            // radioProductIssue
            // 
            this.radioProductIssue.AutoSize = true;
            this.radioProductIssue.Location = new System.Drawing.Point(0, 30);
            this.radioProductIssue.Name = "radioProductIssue";
            this.radioProductIssue.Size = new System.Drawing.Size(132, 19);
            this.radioProductIssue.TabIndex = 0;
            this.radioProductIssue.TabStop = true;
            this.radioProductIssue.Text = "Product Issue";
            this.radioProductIssue.UseVisualStyleBackColor = true;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(30, 180);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(79, 15);
            this.lblComments.TabIndex = 5;
            this.lblComments.Text = "Comments:";
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(33, 200);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(317, 100);
            this.txtComments.TabIndex = 6;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(100, 320);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(90, 30);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(220, 320);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 30);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // CustomerFeedbackForm
            // 
            this.ClientSize = new System.Drawing.Size(384, 371);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.grpFeedbackType);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "CustomerFeedbackForm";
            this.Text = "Customer Feedback";
            this.grpFeedbackType.ResumeLayout(false);
            this.grpFeedbackType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

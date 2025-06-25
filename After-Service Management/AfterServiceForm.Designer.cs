namespace AfterServiceApp
{
    partial class AfterServiceForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOrder = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvService = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
            this.SuspendLayout();

            // Labels
            this.label1.Text = "Customer:";
            this.label1.Location = new System.Drawing.Point(30, 20);

            this.label2.Text = "Order ID:";
            this.label2.Location = new System.Drawing.Point(30, 60);

            this.label3.Text = "Service Type:";
            this.label3.Location = new System.Drawing.Point(30, 100);

            this.label4.Text = "Details:";
            this.label4.Location = new System.Drawing.Point(30, 140);

            this.label5.Text = "Status:";
            this.label5.Location = new System.Drawing.Point(30, 220);

            this.label6.Text = "Employee:";
            this.label6.Location = new System.Drawing.Point(30, 260);

            // ComboBoxes
            this.cmbCustomer.Location = new System.Drawing.Point(130, 17);
            this.cmbOrder.Location = new System.Drawing.Point(130, 57);
            this.cmbType.Location = new System.Drawing.Point(130, 97);
            this.cmbType.Items.AddRange(new object[] { "Return", "Repair", "Feedback" });

            this.cmbStatus.Location = new System.Drawing.Point(130, 217);
            this.cmbStatus.Items.AddRange(new object[] { "Pending", "Processing", "Completed" });

            this.cmbEmployee.Location = new System.Drawing.Point(130, 257);

            // TextBox for Details
            this.txtDetails.Location = new System.Drawing.Point(130, 137);
            this.txtDetails.Size = new System.Drawing.Size(250, 60);
            this.txtDetails.Multiline = true;

            // Buttons
            this.btnAdd.Text = "Add Service";
            this.btnAdd.Location = new System.Drawing.Point(420, 17);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnUpdate.Text = "Update Status";
            this.btnUpdate.Location = new System.Drawing.Point(420, 57);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnClear.Text = "Clear";
            this.btnClear.Location = new System.Drawing.Point(420, 97);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // DataGridView
            this.dgvService.Location = new System.Drawing.Point(30, 300);
            this.dgvService.Size = new System.Drawing.Size(600, 200);
            this.dgvService.ReadOnly = true;
            this.dgvService.AllowUserToAddRows = false;
            this.dgvService.AllowUserToDeleteRows = false;

            // Form Settings
            this.ClientSize = new System.Drawing.Size(700, 550);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvService);
            this.Text = "After-Service Management";

            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1, label2, label3, label4, label5, label6;
        private System.Windows.Forms.ComboBox cmbCustomer, cmbOrder, cmbType, cmbStatus, cmbEmployee;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Button btnAdd, btnUpdate, btnClear;
        private System.Windows.Forms.DataGridView dgvService;
    }
}

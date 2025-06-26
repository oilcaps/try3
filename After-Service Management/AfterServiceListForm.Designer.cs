namespace AfterServiceApp
{
    partial class AfterServiceListForm
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
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvServiceList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer:";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.Location = new System.Drawing.Point(136, 17);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(121, 23);
            this.cmbCustomer.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(30, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type:";
            // 
            // cmbType
            // 
            this.cmbType.Items.AddRange(new object[] {
            "Return",
            "Repair",
            "Feedback"});
            this.cmbType.Location = new System.Drawing.Point(136, 57);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 23);
            this.cmbType.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(30, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Status:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Items.AddRange(new object[] {
            "Pending",
            "Processing",
            "Completed"});
            this.cmbStatus.Location = new System.Drawing.Point(136, 97);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 23);
            this.cmbStatus.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(320, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(320, 57);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvServiceList
            // 
            this.dgvServiceList.AllowUserToAddRows = false;
            this.dgvServiceList.AllowUserToDeleteRows = false;
            this.dgvServiceList.ColumnHeadersHeight = 29;
            this.dgvServiceList.Location = new System.Drawing.Point(30, 150);
            this.dgvServiceList.Name = "dgvServiceList";
            this.dgvServiceList.ReadOnly = true;
            this.dgvServiceList.RowHeadersWidth = 51;
            this.dgvServiceList.Size = new System.Drawing.Size(600, 300);
            this.dgvServiceList.TabIndex = 8;
            // 
            // AfterServiceListForm
            // 
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvServiceList);
            this.Name = "AfterServiceListForm";
            this.Text = "After-Service Records";
            this.Load += new System.EventHandler(this.AfterServiceListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceList)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label label1, label2, label3;
        private System.Windows.Forms.ComboBox cmbCustomer, cmbType, cmbStatus;
        private System.Windows.Forms.Button btnSearch, btnRefresh;
        private System.Windows.Forms.DataGridView dgvServiceList;
    }
}

namespace Inventory { 
    partial class InboundRecordForm
    {
        private System.ComponentModel.IContainer components = null;

        // UI 控制項宣告
        private System.Windows.Forms.DataGridView dgvInbound;
        private System.Windows.Forms.TextBox txtInboundRecordID;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.DateTimePicker dtpInboundDate;
        private System.Windows.Forms.Label lblInboundRecordID;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblSupplierID;
        private System.Windows.Forms.Label lblInboundDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;

        /// <summary>
        /// 釋放資源
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgvInbound = new System.Windows.Forms.DataGridView();
            this.txtInboundRecordID = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.dtpInboundDate = new System.Windows.Forms.DateTimePicker();
            this.lblInboundRecordID = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblSupplierID = new System.Windows.Forms.Label();
            this.lblInboundDate = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInbound)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInbound
            // 
            this.dgvInbound.AllowUserToAddRows = false;
            this.dgvInbound.AllowUserToDeleteRows = false;
            this.dgvInbound.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInbound.Location = new System.Drawing.Point(12, 12);
            this.dgvInbound.MultiSelect = false;
            this.dgvInbound.Name = "dgvInbound";
            this.dgvInbound.ReadOnly = true;
            this.dgvInbound.RowHeadersWidth = 51;
            this.dgvInbound.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInbound.Size = new System.Drawing.Size(600, 200);
            this.dgvInbound.TabIndex = 0;
            this.dgvInbound.SelectionChanged += new System.EventHandler(this.dgvInbound_SelectionChanged);
            // 
            // txtInboundRecordID
            // 
            this.txtInboundRecordID.Location = new System.Drawing.Point(172, 229);
            this.txtInboundRecordID.Name = "txtInboundRecordID";
            this.txtInboundRecordID.ReadOnly = true;
            this.txtInboundRecordID.Size = new System.Drawing.Size(150, 25);
            this.txtInboundRecordID.TabIndex = 1;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(172, 260);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(150, 25);
            this.txtProductID.TabIndex = 2;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(172, 290);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(150, 25);
            this.txtQuantity.TabIndex = 3;
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Location = new System.Drawing.Point(172, 350);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Size = new System.Drawing.Size(150, 25);
            this.txtSupplierID.TabIndex = 5;
            // 
            // dtpInboundDate
            // 
            this.dtpInboundDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInboundDate.Location = new System.Drawing.Point(172, 319);
            this.dtpInboundDate.Name = "dtpInboundDate";
            this.dtpInboundDate.Size = new System.Drawing.Size(150, 25);
            this.dtpInboundDate.TabIndex = 4;
            // 
            // lblInboundRecordID
            // 
            this.lblInboundRecordID.AutoSize = true;
            this.lblInboundRecordID.Location = new System.Drawing.Point(15, 233);
            this.lblInboundRecordID.Name = "lblInboundRecordID";
            this.lblInboundRecordID.Size = new System.Drawing.Size(143, 15);
            this.lblInboundRecordID.TabIndex = 6;
            this.lblInboundRecordID.Text = "Inbound Record ID";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(15, 263);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(87, 15);
            this.lblProductID.TabIndex = 7;
            this.lblProductID.Text = "Product ID";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(15, 293);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(71, 15);
            this.lblQuantity.TabIndex = 8;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.Location = new System.Drawing.Point(15, 353);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(95, 15);
            this.lblSupplierID.TabIndex = 10;
            this.lblSupplierID.Text = "Supplier ID";
            // 
            // lblInboundDate
            // 
            this.lblInboundDate.AutoSize = true;
            this.lblInboundDate.Location = new System.Drawing.Point(15, 323);
            this.lblInboundDate.Name = "lblInboundDate";
            this.lblInboundDate.Size = new System.Drawing.Size(103, 15);
            this.lblInboundDate.TabIndex = 9;
            this.lblInboundDate.Text = "Inbound Date";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(376, 230);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 30);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(376, 278);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 30);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(376, 338);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 30);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // InboundRecordForm
            // 
            this.ClientSize = new System.Drawing.Size(624, 390);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblSupplierID);
            this.Controls.Add(this.lblInboundDate);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.lblInboundRecordID);
            this.Controls.Add(this.dtpInboundDate);
            this.Controls.Add(this.txtSupplierID);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.txtInboundRecordID);
            this.Controls.Add(this.dgvInbound);
            this.Name = "InboundRecordForm";
            this.Text = "Inbound Record Management";
            this.Load += new System.EventHandler(this.InboundRecordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInbound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

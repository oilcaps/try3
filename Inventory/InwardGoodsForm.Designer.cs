namespace InventoryApp
{
    partial class InwardGoodsForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvInboundRecords;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.DateTimePicker dtpInboundDate;
        private System.Windows.Forms.TextBox txtReference;
        private System.Windows.Forms.TextBox txtInboundRecordID;
        private System.Windows.Forms.Label lblInboundRecordID;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblInboundDate;
        private System.Windows.Forms.Label lblReference;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;

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
            this.dgvInboundRecords = new System.Windows.Forms.DataGridView();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.dtpInboundDate = new System.Windows.Forms.DateTimePicker();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.txtInboundRecordID = new System.Windows.Forms.TextBox();
            this.lblInboundRecordID = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblInboundDate = new System.Windows.Forms.Label();
            this.lblReference = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInboundRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInboundRecords
            // 
            this.dgvInboundRecords.AllowUserToAddRows = false;
            this.dgvInboundRecords.AllowUserToDeleteRows = false;
            this.dgvInboundRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInboundRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInboundRecords.Location = new System.Drawing.Point(12, 12);
            this.dgvInboundRecords.MultiSelect = false;
            this.dgvInboundRecords.Name = "dgvInboundRecords";
            this.dgvInboundRecords.ReadOnly = true;
            this.dgvInboundRecords.RowHeadersWidth = 51;
            this.dgvInboundRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInboundRecords.Size = new System.Drawing.Size(760, 250);
            this.dgvInboundRecords.TabIndex = 0;
            this.dgvInboundRecords.SelectionChanged += new System.EventHandler(this.dgvInboundRecords_SelectionChanged);
            // 
            // cmbProduct
            // 
            this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(161, 308);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(150, 23);
            this.cmbProduct.TabIndex = 4;
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(161, 348);
            this.numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(150, 25);
            this.numQuantity.TabIndex = 6;
            this.numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dtpInboundDate
            // 
            this.dtpInboundDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInboundDate.Location = new System.Drawing.Point(459, 273);
            this.dtpInboundDate.Name = "dtpInboundDate";
            this.dtpInboundDate.Size = new System.Drawing.Size(150, 25);
            this.dtpInboundDate.TabIndex = 8;
            this.dtpInboundDate.ValueChanged += new System.EventHandler(this.dtpInboundDate_ValueChanged);
            // 
            // txtReference
            // 
            this.txtReference.Location = new System.Drawing.Point(459, 312);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(150, 25);
            this.txtReference.TabIndex = 10;
            // 
            // txtInboundRecordID
            // 
            this.txtInboundRecordID.Location = new System.Drawing.Point(161, 277);
            this.txtInboundRecordID.Name = "txtInboundRecordID";
            this.txtInboundRecordID.ReadOnly = true;
            this.txtInboundRecordID.Size = new System.Drawing.Size(150, 25);
            this.txtInboundRecordID.TabIndex = 2;
            // 
            // lblInboundRecordID
            // 
            this.lblInboundRecordID.AutoSize = true;
            this.lblInboundRecordID.Location = new System.Drawing.Point(12, 280);
            this.lblInboundRecordID.Name = "lblInboundRecordID";
            this.lblInboundRecordID.Size = new System.Drawing.Size(143, 15);
            this.lblInboundRecordID.TabIndex = 1;
            this.lblInboundRecordID.Text = "Inbound Record ID";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(12, 315);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(63, 15);
            this.lblProduct.TabIndex = 3;
            this.lblProduct.Text = "Product";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(12, 350);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(71, 15);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblInboundDate
            // 
            this.lblInboundDate.AutoSize = true;
            this.lblInboundDate.Location = new System.Drawing.Point(350, 280);
            this.lblInboundDate.Name = "lblInboundDate";
            this.lblInboundDate.Size = new System.Drawing.Size(103, 15);
            this.lblInboundDate.TabIndex = 7;
            this.lblInboundDate.Text = "Inbound Date";
            // 
            // lblReference
            // 
            this.lblReference.AutoSize = true;
            this.lblReference.Location = new System.Drawing.Point(350, 315);
            this.lblReference.Name = "lblReference";
            this.lblReference.Size = new System.Drawing.Size(79, 15);
            this.lblReference.TabIndex = 9;
            this.lblReference.Text = "Reference";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(350, 350);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(450, 350);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 30);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(550, 350);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // InwardGoodsForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 401);
            this.Controls.Add(this.dgvInboundRecords);
            this.Controls.Add(this.lblInboundRecordID);
            this.Controls.Add(this.txtInboundRecordID);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.lblInboundDate);
            this.Controls.Add(this.dtpInboundDate);
            this.Controls.Add(this.lblReference);
            this.Controls.Add(this.txtReference);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Name = "InwardGoodsForm";
            this.Text = "Inbound Goods Management";
            this.Load += new System.EventHandler(this.InwardGoodsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInboundRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
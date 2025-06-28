namespace InventoryApp
{
    partial class InventoryViewForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblSearch;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.SuspendLayout();

            // dgvInventory
            this.dgvInventory.Location = new System.Drawing.Point(20, 50);
            this.dgvInventory.Size = new System.Drawing.Size(600, 300);
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // lblSearch
            this.lblSearch.Location = new System.Drawing.Point(20, 15);
            this.lblSearch.Size = new System.Drawing.Size(80, 23);
            this.lblSearch.Text = "Product Name:";

            // txtSearch
            this.txtSearch.Location = new System.Drawing.Point(110, 15);
            this.txtSearch.Size = new System.Drawing.Size(200, 22);

            // btnSearch
            this.btnSearch.Location = new System.Drawing.Point(320, 10);
            this.btnSearch.Size = new System.Drawing.Size(80, 30);
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // btnRefresh
            this.btnRefresh.Location = new System.Drawing.Point(420, 10);
            this.btnRefresh.Size = new System.Drawing.Size(80, 30);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // InventoryViewForm
            this.ClientSize = new System.Drawing.Size(650, 370);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblSearch);
            this.Name = "InventoryViewForm";
            this.Text = "Inventory View";

            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

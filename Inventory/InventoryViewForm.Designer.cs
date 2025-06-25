namespace InventoryApp
{
    partial class InventoryViewForm
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.SuspendLayout();

            // Label
            this.label1.Text = "Search Product:";
            this.label1.Location = new System.Drawing.Point(30, 30);

            // TextBox
            this.txtSearch.Location = new System.Drawing.Point(150, 27);
            this.txtSearch.Size = new System.Drawing.Size(200, 23);

            // Search Button
            this.btnSearch.Text = "Search";
            this.btnSearch.Location = new System.Drawing.Point(370, 26);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // Refresh Button
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Location = new System.Drawing.Point(460, 26);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // DataGridView
            this.dgvInventory.Location = new System.Drawing.Point(30, 70);
            this.dgvInventory.Size = new System.Drawing.Size(600, 300);
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;

            // Form Settings
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvInventory);
            this.Text = "Inventory View";

            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvInventory;
    }
}


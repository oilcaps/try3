using System.Windows.Forms;

namespace InventoryApp
{
    partial class InventoryMainForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnInwardGoods;
        private Button btnInventoryView;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnInwardGoods = new System.Windows.Forms.Button();
            this.btnInventoryView = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.btnInwardGoods.Location = new System.Drawing.Point(50, 30);
            this.btnInwardGoods.Name = "btnInwardGoods";
            this.btnInwardGoods.Size = new System.Drawing.Size(180, 40);
            this.btnInwardGoods.TabIndex = 0;
            this.btnInwardGoods.Text = "Inward Goods";
            this.btnInwardGoods.UseVisualStyleBackColor = true;
            this.btnInwardGoods.Click += new System.EventHandler(this.btnInwardGoods_Click);
  
            this.btnInventoryView.Location = new System.Drawing.Point(50, 90);
            this.btnInventoryView.Name = "btnInventoryView";
            this.btnInventoryView.Size = new System.Drawing.Size(180, 40);
            this.btnInventoryView.TabIndex = 1;
            this.btnInventoryView.Text = "View Inventory";
            this.btnInventoryView.UseVisualStyleBackColor = true;
            this.btnInventoryView.Click += new System.EventHandler(this.btnInventoryView_Click);
 
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.btnInwardGoods);
            this.Controls.Add(this.btnInventoryView);
            this.Name = "InventoryMainForm";
            this.Text = "Inventory Main Menu";
            this.Load += new System.EventHandler(this.InventoryMainForm_Load);
            this.ResumeLayout(false);

        }
    }
}

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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInwardGoods
            // 
            this.btnInwardGoods.Location = new System.Drawing.Point(193, 121);
            this.btnInwardGoods.Name = "btnInwardGoods";
            this.btnInwardGoods.Size = new System.Drawing.Size(180, 40);
            this.btnInwardGoods.TabIndex = 0;
            this.btnInwardGoods.Text = "Inward Goods";
            this.btnInwardGoods.UseVisualStyleBackColor = true;
            this.btnInwardGoods.Click += new System.EventHandler(this.btnInwardGoods_Click);
            // 
            // btnInventoryView
            // 
            this.btnInventoryView.Location = new System.Drawing.Point(193, 206);
            this.btnInventoryView.Name = "btnInventoryView";
            this.btnInventoryView.Size = new System.Drawing.Size(180, 40);
            this.btnInventoryView.TabIndex = 1;
            this.btnInventoryView.Text = "View Inventory";
            this.btnInventoryView.UseVisualStyleBackColor = true;
            this.btnInventoryView.Click += new System.EventHandler(this.btnInventoryView_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(201, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inventory Main Menu";
            // 
            // InventoryMainForm
            // 
            this.ClientSize = new System.Drawing.Size(568, 357);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInwardGoods);
            this.Controls.Add(this.btnInventoryView);
            this.Name = "InventoryMainForm";
            this.Text = "Inventory Main Menu";
            this.Load += new System.EventHandler(this.InventoryMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label label1;
    }
}

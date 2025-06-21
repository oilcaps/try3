using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class InventoryViewForm : Form
    {
        private string connectionString = @"Server=;Database=;Trusted_Connection=True;";

        public InventoryViewForm()
        {
            InitializeComponent();
        }

        private void InventoryViewForm_Load(object sender, EventArgs e)
        {
            LoadInventory();
        }

        private void LoadInventory()
        {
            string sql = @"SELECT p.ProductName, i.Quantity, i.LastUpdated
                           FROM Inventory i
                           JOIN Product p ON i.ProductID = p.ProductID
                           ORDER BY p.ProductName";

            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                conn.Open();
                da.Fill(dt);
            }

            dataGridViewInventory.DataSource = dt;
            dataGridViewInventory.Columns["ProductName"].HeaderText = "Product Name";
            dataGridViewInventory.Columns["Quantity"].HeaderText = "Stock Quantity";
            dataGridViewInventory.Columns["LastUpdated"].HeaderText = "Last Updated";
            dataGridViewInventory.AutoResizeColumns();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadInventory();
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class InventoryViewForm : Form
    {
        private string connectionString = @"YourConnectionStringHere";

        public InventoryViewForm()
        {
            InitializeComponent();
            LoadInventory();
        }

        private void LoadInventory()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var adapter = new SqlDataAdapter(
                    "SELECT p.ProductName, i.Quantity AS StockQty, i.LastUpdated " +
                    "FROM Inventory i INNER JOIN Product p ON i.ProductID = p.ProductID", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvInventory.DataSource = dt;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var adapter = new SqlDataAdapter(
                    "SELECT p.ProductName, i.Quantity AS StockQty, i.LastUpdated " +
                    "FROM Inventory i INNER JOIN Product p ON i.ProductID = p.ProductID " +
                    "WHERE p.ProductName LIKE @keyword", conn);
                adapter.SelectCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvInventory.DataSource = dt;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadInventory();
        }

        private void InventoryViewForm_Load(object sender, EventArgs e)
        {

        }
    }
}

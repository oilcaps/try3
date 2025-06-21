using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class InwardGoodsForm : Form
    {
        private string connectionString = @"Server=;Database=;Trusted_Connection=True;";

        public InwardGoodsForm()
        {
            InitializeComponent();
        }

        private async void InwardGoodsForm_Load(object sender, EventArgs e)
        {
            try
            {
                await Task.Run(() => LoadProducts());
                await Task.Run(() => LoadInwardGoodsData());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection error:\n" + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadProducts()
        {
            string sql = "SELECT ProductID, ProductName FROM Product";
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                conn.Open();
                da.Fill(dt);
            }

            if (cmbProduct.InvokeRequired)
            {
                cmbProduct.Invoke(new Action(() =>
                {
                    cmbProduct.DataSource = dt;
                    cmbProduct.DisplayMember = "ProductName";
                    cmbProduct.ValueMember = "ProductID";
                    cmbProduct.SelectedIndex = -1;
                }));
            }
            else
            {
                cmbProduct.DataSource = dt;
                cmbProduct.DisplayMember = "ProductName";
                cmbProduct.ValueMember = "ProductID";
                cmbProduct.SelectedIndex = -1;
            }
        }

        private void LoadInwardGoodsData()
        {
            string sql = @"
                SELECT ig.InwardID, p.ProductName, ig.Quantity, ig.InwardDate
                FROM InwardGoods ig
                JOIN Product p ON ig.ProductID = p.ProductID
                ORDER BY ig.InwardDate DESC";

            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                conn.Open();
                da.Fill(dt);
            }

            if (dataGridView1.InvokeRequired)
            {
                dataGridView1.Invoke(new Action(() =>
                {
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["InwardID"].Visible = false;
                    dataGridView1.Columns["ProductName"].HeaderText = "Product Name";
                    dataGridView1.Columns["Quantity"].HeaderText = "Quantity";
                    dataGridView1.Columns["InwardDate"].HeaderText = "Date";
                    dataGridView1.AutoResizeColumns();
                }));
            }
            else
            {
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["InwardID"].Visible = false;
                dataGridView1.Columns["ProductName"].HeaderText = "Product Name";
                dataGridView1.Columns["Quantity"].HeaderText = "Quantity";
                dataGridView1.Columns["InwardDate"].HeaderText = "Date";
                dataGridView1.AutoResizeColumns();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedValue == null)
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            if (!int.TryParse(txtQty.Text.Trim(), out int qty) || qty <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            int productId = (int)cmbProduct.SelectedValue;
            DateTime inwardDate = dtpDate.Value.Date;

            try
            {
                AddInwardGoods(productId, qty, inwardDate);
                MessageBox.Show("Record added successfully.");
                LoadInwardGoodsData();
                txtQty.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void AddInwardGoods(int productId, int qty, DateTime inwardDate)
        {
            string sqlInsert = "INSERT INTO InwardGoods (ProductID, Quantity, InwardDate) VALUES (@pid, @qty, @date)";
            string sqlUpdateInventory = "UPDATE Inventory SET Quantity = Quantity + @qty, LastUpdated = GETDATE() WHERE ProductID = @pid";
            string sqlInsertInventory = "INSERT INTO Inventory (ProductID, Quantity, LastUpdated) VALUES (@pid, @qty, GETDATE())";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlTransaction tran = conn.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand(sqlInsert, conn, tran))
                        {
                            cmd.Parameters.AddWithValue("@pid", productId);
                            cmd.Parameters.AddWithValue("@qty", qty);
                            cmd.Parameters.AddWithValue("@date", inwardDate);
                            cmd.ExecuteNonQuery();
                        }

                        using (SqlCommand cmd = new SqlCommand(sqlUpdateInventory, conn, tran))
                        {
                            cmd.Parameters.AddWithValue("@pid", productId);
                            cmd.Parameters.AddWithValue("@qty", qty);
                            int rows = cmd.ExecuteNonQuery();

                            if (rows == 0)
                            {
                                using (SqlCommand cmd2 = new SqlCommand(sqlInsertInventory, conn, tran))
                                {
                                    cmd2.Parameters.AddWithValue("@pid", productId);
                                    cmd2.Parameters.AddWithValue("@qty", qty);
                                    cmd2.ExecuteNonQuery();
                                }
                            }
                        }

                        tran.Commit();
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}

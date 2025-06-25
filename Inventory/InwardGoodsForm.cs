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
        public partial class InwardGoodsForm : Form
        {
            private string connectionString = @"YourConnectionStringHere";

            public InwardGoodsForm()
            {
                InitializeComponent();
                LoadProducts();
                LoadInwardRecords();
            }

            private void LoadProducts()
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    var cmd = new SqlCommand("SELECT ProductID, ProductName FROM Product", conn);
                    var reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    cmbProduct.DataSource = dt;
                    cmbProduct.DisplayMember = "ProductName";
                    cmbProduct.ValueMember = "ProductID";
                }
            }

            private void LoadInwardRecords()
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    var adapter = new SqlDataAdapter("SELECT * FROM InwardGoods", conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvInward.DataSource = dt;
                }
            }

            private void btnAdd_Click(object sender, EventArgs e)
            {
                string productId = cmbProduct.SelectedValue.ToString();
                int quantity = (int)numQuantity.Value;
                DateTime date = dtpDate.Value;
                string reference = txtReference.Text;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        // Insert to InwardGoods
                        var cmd1 = new SqlCommand(
                            "INSERT INTO InwardGoods (ProductID, Quantity, Date, Reference) VALUES (@ProductID, @Quantity, @Date, @Reference)", conn, transaction);
                        cmd1.Parameters.AddWithValue("@ProductID", productId);
                        cmd1.Parameters.AddWithValue("@Quantity", quantity);
                        cmd1.Parameters.AddWithValue("@Date", date);
                        cmd1.Parameters.AddWithValue("@Reference", reference);
                        cmd1.ExecuteNonQuery();

                        // Update Inventory
                        var cmd2 = new SqlCommand(
                            "UPDATE Inventory SET Quantity = Quantity + @Quantity WHERE ProductID = @ProductID", conn, transaction);
                        cmd2.Parameters.AddWithValue("@ProductID", productId);
                        cmd2.Parameters.AddWithValue("@Quantity", quantity);
                        cmd2.ExecuteNonQuery();

                        transaction.Commit();
                        MessageBox.Show("Inward record added.");
                        LoadInwardRecords();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            private void btnClear_Click(object sender, EventArgs e)
            {
                cmbProduct.SelectedIndex = 0;
                numQuantity.Value = 1;
                dtpDate.Value = DateTime.Now;
                txtReference.Clear();
            }
        }
    }
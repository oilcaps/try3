using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AfterServiceApp
{
    public partial class AfterServiceListForm : Form
    {
        private string connectionString = @"YourConnectionStringHere";

        public AfterServiceListForm()
        {
            InitializeComponent();
            LoadCustomers();
            LoadServiceList();
        }

        private void LoadCustomers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT CustomerID, Name FROM Customer", conn);
                var dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                cmbCustomer.DataSource = dt;
                cmbCustomer.DisplayMember = "Name";
                cmbCustomer.ValueMember = "CustomerID";
                cmbCustomer.SelectedIndex = -1;
            }
        }

        private void LoadServiceList()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var adapter = new SqlDataAdapter(
                    "SELECT s.ServiceID, c.Name AS Customer, s.ServiceType, s.Status, e.Name AS Employee, s.SubmissionDate " +
                    "FROM AfterService s " +
                    "INNER JOIN Customer c ON s.CustomerID = c.CustomerID " +
                    "INNER JOIN Employee e ON s.EmployeeID = e.EmployeeID", conn);
                var dt = new DataTable();
                adapter.Fill(dt);
                dgvServiceList.DataSource = dt;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string filterCustomer = cmbCustomer.SelectedIndex != -1 ? cmbCustomer.SelectedValue.ToString() : null;
            string filterType = cmbType.Text != "" ? cmbType.Text : null;
            string filterStatus = cmbStatus.Text != "" ? cmbStatus.Text : null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = "SELECT s.ServiceID, c.Name AS Customer, s.ServiceType, s.Status, e.Name AS Employee, s.SubmissionDate " +
                             "FROM AfterService s " +
                             "INNER JOIN Customer c ON s.CustomerID = c.CustomerID " +
                             "INNER JOIN Employee e ON s.EmployeeID = e.EmployeeID WHERE 1=1 ";

                if (filterCustomer != null) sql += "AND s.CustomerID = @CustomerID ";
                if (filterType != null) sql += "AND s.ServiceType = @Type ";
                if (filterStatus != null) sql += "AND s.Status = @Status ";

                SqlCommand cmd = new SqlCommand(sql, conn);

                if (filterCustomer != null) cmd.Parameters.AddWithValue("@CustomerID", filterCustomer);
                if (filterType != null) cmd.Parameters.AddWithValue("@Type", filterType);
                if (filterStatus != null) cmd.Parameters.AddWithValue("@Status", filterStatus);

                var adapter = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);
                dgvServiceList.DataSource = dt;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cmbCustomer.SelectedIndex = -1;
            cmbType.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            LoadServiceList();
        }
    }
}
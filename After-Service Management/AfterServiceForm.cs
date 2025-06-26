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

namespace AfterServiceApp
{
    public partial class AfterServiceForm : Form
    {
        private string connectionString = @"YourConnectionStringHere";

        public AfterServiceForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            LoadCustomers();
            LoadEmployees();
            LoadServices();
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
            }
        }

        private void LoadEmployees()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT EmployeeID, Name FROM Employee", conn);
                var dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                cmbEmployee.DataSource = dt;
                cmbEmployee.DisplayMember = "Name";
                cmbEmployee.ValueMember = "EmployeeID";
            }
        }

        private void LoadServices()
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
                dgvService.DataSource = dt;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string customerId = cmbCustomer.SelectedValue.ToString();
            string serviceType = cmbType.Text;
            string details = txtDetails.Text;
            string status = cmbStatus.Text;
            string employeeId = cmbEmployee.SelectedValue.ToString();
            DateTime date = DateTime.Now;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand(
                    "INSERT INTO AfterService (CustomerID, ServiceType, Details, Status, SubmissionDate, EmployeeID) " +
                    "VALUES (@CustomerID, @ServiceType, @Details, @Status, @Date, @EmployeeID)", conn);
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                cmd.Parameters.AddWithValue("@ServiceType", serviceType);
                cmd.Parameters.AddWithValue("@Details", details);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@Date", date);
                cmd.Parameters.AddWithValue("@EmployeeID", employeeId);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Service record added.");
            LoadServices();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvService.CurrentRow != null)
            {
                string serviceId = dgvService.CurrentRow.Cells["ServiceID"].Value.ToString();
                string newStatus = cmbStatus.Text;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    var cmd = new SqlCommand(
                        "UPDATE AfterService SET Status = @Status WHERE ServiceID = @ServiceID", conn);
                    cmd.Parameters.AddWithValue("@Status", newStatus);
                    cmd.Parameters.AddWithValue("@ServiceID", serviceId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Status updated.");
                LoadServices();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbType.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            txtDetails.Clear();
        }

        private void AfterServiceForm_Load(object sender, EventArgs e)
        {

        }
    }
}
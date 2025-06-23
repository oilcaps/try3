using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AfterServiceApp
{
    public partial class AfterServiceViewForm : Form
    {
        private DataTable dtServiceRecords;

        public AfterServiceViewForm()
        {
            InitializeComponent();
        }

        private void AfterServiceViewForm_Load(object sender, EventArgs e)
        {
            LoadMockData();
            BindData();
            if (cmbStatusFilter.Items.Count > 0)
            {
                cmbStatusFilter.SelectedIndex = 0;
            }
        
        }

        private void LoadMockData()
        {
            dtServiceRecords = new DataTable();
            dtServiceRecords.Columns.Add("ServiceID", typeof(int));
            dtServiceRecords.Columns.Add("CustomerName", typeof(string));
            dtServiceRecords.Columns.Add("ServiceRequest", typeof(string));
            dtServiceRecords.Columns.Add("Status", typeof(string));
            dtServiceRecords.Columns.Add("RequestDate", typeof(DateTime));

            dtServiceRecords.Rows.Add(1, "1", "error", "waiting", DateTime.Today.AddDays(-5));
            dtServiceRecords.Rows.Add(2, "2", "error", "waiting", DateTime.Today.AddDays(-3));
            dtServiceRecords.Rows.Add(3, "3", "error", "waiting", DateTime.Today.AddDays(-10));
            dtServiceRecords.Rows.Add(4, "4", "error", "waiting", DateTime.Today.AddDays(-1));
            dtServiceRecords.Rows.Add(5, "5", "error", "waiting", DateTime.Today.AddDays(-7));
        }

        private void BindData()
        {
            dataGridView1.DataSource = dtServiceRecords.Copy();
            dataGridView1.Columns["ServiceID"].Visible = false;
            dataGridView1.Columns["CustomerName"].HeaderText = "CustomerName";
            dataGridView1.Columns["ServiceRequest"].HeaderText = "ServiceRequest";
            dataGridView1.Columns["Status"].HeaderText = "Status";
            dataGridView1.Columns["RequestDate"].HeaderText = "RequestDate";
            dataGridView1.AutoResizeColumns();
        }

        private void FilterData()
        {
            string statusFilter = cmbStatusFilter.SelectedItem.ToString();
            string keyword = txtKeyword.Text.Trim();

            DataView dv = new DataView(dtServiceRecords);

            string filter = "";

            if (statusFilter != "all")
                filter = $"Status = '{statusFilter}'";

            if (!string.IsNullOrEmpty(keyword))
            {
                if (!string.IsNullOrEmpty(filter))
                    filter += " AND ";

                filter += $"(CustomerName LIKE '%{keyword}%' OR ServiceRequest LIKE '%{keyword}%')";
            }

            dv.RowFilter = filter;
            dataGridView1.DataSource = dv;
            dataGridView1.AutoResizeColumns();
        }

        private void cmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            FilterData();
        }


        private async Task<int> UpdateCustomerDataToAPI(DataTable dtUpdated)
        {
           
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
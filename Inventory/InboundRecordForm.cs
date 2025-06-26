using PayPal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using InventoryWinForms.Models; // 假設你有放 InboundRecordModel 這個類別
using service; // 你封裝 API 呼叫的服務

namespace Inventory
{
    public partial class InboundRecordForm : Form
    {
        private readonly APIService apiService = new APIService("http://localhost:5000/");

        public InboundRecordForm()
        {
            InitializeComponent();
        }

        private async void InboundRecordForm_Load(object sender, EventArgs e)
        {
            await LoadInboundRecords();
        }

        private async System.Threading.Tasks.Task LoadInboundRecords()
        {
            var list = await apiService.GetAsync<List<InboundRecordModel>>("/api/InboundRecord/GetAll");
            dgvInbound.DataSource = list;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var model = new InboundRecordModel
            {
                ProductID = int.Parse(txtProductID.Text),
                Quantity = int.Parse(txtQuantity.Text),
                InboundDate = dtpInboundDate.Value,
                SupplierID = int.Parse(txtSupplierID.Text)
            };

            var response = await apiService.PostAsync("/api/InboundRecord/Add", model);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Add Success");
                await LoadInboundRecords();
            }
            else
            {
                MessageBox.Show("Add Failed");
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            var model = new InboundRecordModel
            {
                InboundRecordID = int.Parse(txtInboundRecordID.Text),
                ProductID = int.Parse(txtProductID.Text),
                Quantity = int.Parse(txtQuantity.Text),
                InboundDate = dtpInboundDate.Value,
                SupplierID = int.Parse(txtSupplierID.Text)
            };

            var response = await apiService.PutAsync("/api/InboundRecord/Update", model);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Update Success");
                await LoadInboundRecords();
            }
            else
            {
                MessageBox.Show("Update Failed");
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtInboundRecordID.Text);
            var response = await apiService.DeleteAsync($"/api/InboundRecord/Delete/{id}");
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Delete Success");
                await LoadInboundRecords();
            }
            else
            {
                MessageBox.Show("Delete Failed");
            }
        }

        private void dgvInbound_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInbound.CurrentRow != null)
            {
                txtInboundRecordID.Text = dgvInbound.CurrentRow.Cells["InboundRecordID"].Value.ToString();
                txtProductID.Text = dgvInbound.CurrentRow.Cells["ProductID"].Value.ToString();
                txtQuantity.Text = dgvInbound.CurrentRow.Cells["Quantity"].Value.ToString();
                dtpInboundDate.Value = Convert.ToDateTime(dgvInbound.CurrentRow.Cells["InboundDate"].Value);
                txtSupplierID.Text = dgvInbound.CurrentRow.Cells["SupplierID"].Value.ToString();
            }
        }
    }

    public class InboundRecordModel
    {
        public int InboundRecordID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public DateTime InboundDate { get; set; }
        public int SupplierID { get; set; }
    }
}
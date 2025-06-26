using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class InwardGoodsForm : Form
    {
        private HttpClient _httpClient;
        private List<ProductModel> _products;
        private List<InboundRecordModel> _inboundRecords;

        public InwardGoodsForm()
        {
            InitializeComponent();

            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:5000/"); // Your API base address
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private async void InwardGoodsForm_Load(object sender, EventArgs e)
        {
            await LoadProductsAsync();
            await LoadInboundRecordsAsync();
        }

        private async Task LoadProductsAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("api/Product/GetAll");
                response.EnsureSuccessStatusCode();

                string json = await response.Content.ReadAsStringAsync();
                _products = JsonConvert.DeserializeObject<List<ProductModel>>(json);

                cmbProduct.DataSource = _products;
                cmbProduct.DisplayMember = "ProductName";
                cmbProduct.ValueMember = "ProductID";
                cmbProduct.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load products: " + ex.Message);
            }
        }

        private async Task LoadInboundRecordsAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("api/InboundRecord/GetAll");
                response.EnsureSuccessStatusCode();

                string json = await response.Content.ReadAsStringAsync();
                _inboundRecords = JsonConvert.DeserializeObject<List<InboundRecordModel>>(json);

                dgvInboundRecords.DataSource = null;
                dgvInboundRecords.DataSource = _inboundRecords;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load inbound records: " + ex.Message);
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedItem == null)
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            if (numQuantity.Value <= 0)
            {
                MessageBox.Show("Quantity must be greater than zero.");
                return;
            }

            var newRecord = new InboundRecordModel
            {
                ProductID = (int)cmbProduct.SelectedValue,
                Quantity = (int)numQuantity.Value,
                InboundDate = dtpInboundDate.Value,
                ReferenceNo = txtReference.Text.Trim()
            };

            try
            {
                string json = JsonConvert.SerializeObject(newRecord);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync("api/InboundRecord/Add", content);
                response.EnsureSuccessStatusCode();

                MessageBox.Show("Inbound record added successfully.");
                await LoadInboundRecordsAsync();
                ClearInputs();
            }
            catch (HttpRequestException httpEx)
            {
                MessageBox.Show("Request error: " + httpEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add failed: " + ex.Message);
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtInboundRecordID.Text, out int id))
            {
                MessageBox.Show("Please select a valid record to update.");
                return;
            }

            if (cmbProduct.SelectedItem == null)
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            if (numQuantity.Value <= 0)
            {
                MessageBox.Show("Quantity must be greater than zero.");
                return;
            }

            var updatedRecord = new InboundRecordModel
            {
                InboundRecordID = id,
                ProductID = (int)cmbProduct.SelectedValue,
                Quantity = (int)numQuantity.Value,
                InboundDate = dtpInboundDate.Value,
                ReferenceNo = txtReference.Text.Trim()
            };

            try
            {
                string json = JsonConvert.SerializeObject(updatedRecord);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PutAsync($"api/InboundRecord/Update/{id}", content);
                response.EnsureSuccessStatusCode();

                MessageBox.Show("Inbound record updated successfully.");
                await LoadInboundRecordsAsync();
                ClearInputs();
            }
            catch (HttpRequestException httpEx)
            {
                MessageBox.Show("Request error: " + httpEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtInboundRecordID.Text, out int id))
            {
                MessageBox.Show("Please select a valid record to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            try
            {
                var response = await _httpClient.DeleteAsync($"api/InboundRecord/Delete/{id}");
                response.EnsureSuccessStatusCode();

                MessageBox.Show("Inbound record deleted successfully.");
                await LoadInboundRecordsAsync();
                ClearInputs();
            }
            catch (HttpRequestException httpEx)
            {
                MessageBox.Show("Request error: " + httpEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed: " + ex.Message);
            }
        }

        private void dgvInboundRecords_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInboundRecords.CurrentRow != null && dgvInboundRecords.CurrentRow.DataBoundItem is InboundRecordModel selected)
            {
                txtInboundRecordID.Text = selected.InboundRecordID.ToString();
                cmbProduct.SelectedValue = selected.ProductID;
                numQuantity.Value = selected.Quantity;
                dtpInboundDate.Value = selected.InboundDate;
                txtReference.Text = selected.ReferenceNo;
            }
            else
            {
                ClearInputs();
            }
        }

        private void ClearInputs()
        {
            txtInboundRecordID.Clear();
            cmbProduct.SelectedIndex = -1;
            numQuantity.Value = 1;
            dtpInboundDate.Value = DateTime.Now;
            txtReference.Clear();
        }
    }

    // Models
    public class ProductModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
    }

    public class InboundRecordModel
    {
        public int InboundRecordID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public DateTime InboundDate { get; set; }
        public string ReferenceNo { get; set; }
    }
}

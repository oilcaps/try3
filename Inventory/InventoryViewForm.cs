using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class InventoryViewForm : Form
    {
        private readonly HttpClient _httpClient;
        private List<InventoryModel> _inventoryList;

        public InventoryViewForm()
        {
            InitializeComponent();

            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:5000/");  
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private async void InventoryViewForm_Load(object sender, EventArgs e)
        {
            await LoadInventoryAsync();
        }

        private async Task LoadInventoryAsync(string keyword = "")
        {
            try
            {
                string url = "api/Inventory/GetAll";

                if (!string.IsNullOrWhiteSpace(keyword))
                {

                    url += $"?search={Uri.EscapeDataString(keyword)}";
                }

                HttpResponseMessage response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string json = await response.Content.ReadAsStringAsync();
                _inventoryList = JsonConvert.DeserializeObject<List<InventoryModel>>(json);

                dgvInventory.DataSource = _inventoryList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load inventory: " + ex.Message);
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            await LoadInventoryAsync(keyword);
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            await LoadInventoryAsync();
        }
    }

    public class InventoryModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}

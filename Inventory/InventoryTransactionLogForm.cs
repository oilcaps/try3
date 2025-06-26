using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory.InventoryTransactionService;


public partial class InventoryTransactionLogForm : Form
{
    private InventoryTransactionService _service;

    public InventoryTransactionLogForm()
    {
        InitializeComponent();
        _service = new InventoryTransactionService();
    }

    private async void InventoryTransactionLogForm_Load(object sender, EventArgs e)
    {

        cmbTransactionType.Items.AddRange(new string[] { "All", "IN", "OUT", "ADJUST", "DAMAGE" });
        cmbTransactionType.SelectedIndex = 0;

 
        dtpFrom.Value = DateTime.Today.AddDays(-30);
        dtpTo.Value = DateTime.Today;

        await LoadDataAsync();
    }

    private async Task LoadDataAsync()
    {
        try
        {
            string typeFilter = cmbTransactionType.SelectedItem.ToString();
            DateTime fromDate = dtpFrom.Value.Date;
            DateTime toDate = dtpTo.Value.Date.AddDays(1).AddSeconds(-1); // 含當日23:59:59

            var list = await _service.GetTransactionsAsync(fromDate, toDate, typeFilter == "All" ? null : typeFilter);
            dgvTransactions.DataSource = list;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Failed to load data: " + ex.Message);
        }
    }

    private async void btnSearch_Click(object sender, EventArgs e)
    {
        await LoadDataAsync();
    }

    private void btnAddNew_Click(object sender, EventArgs e)
    {
        var form = new AddEditTransactionForm();
        if (form.ShowDialog() == DialogResult.OK)
        {
            _ = LoadDataAsync();  // 新增成功後重新載入資料
        }
    }

    private void btnEditSelected_Click(object sender, EventArgs e)
    {
        if (dgvTransactions.CurrentRow == null)
        {
            MessageBox.Show("Please select a record first.");
            return;
        }

        var selected = dgvTransactions.CurrentRow.DataBoundItem as InventoryTransaction;
        if (selected == null)
        {
            MessageBox.Show("Selected data is invalid.");
            return;
        }

        var form = new AddEditTransactionForm(selected);
        if (form.ShowDialog() == DialogResult.OK)
        {
            _ = LoadDataAsync(); // 編輯成功後重新載入資料
        }
    }

    private async void btnDeleteSelected_Click(object sender, EventArgs e)
    {
        if (dgvTransactions.CurrentRow == null)
        {
            MessageBox.Show("Please select a record first.");
            return;
        }

        var selected = dgvTransactions.CurrentRow.DataBoundItem as InventoryTransaction;
        if (selected == null)
        {
            MessageBox.Show("Selected data is invalid.");
            return;
        }

        var confirm = MessageBox.Show("Are you sure to delete this transaction?", "Confirm Delete", MessageBoxButtons.YesNo);
        if (confirm == DialogResult.Yes)
        {
            try
            {
                bool result = await _service.DeleteTransactionAsync(selected.TransactionID);
                if (result)
                {
                    MessageBox.Show("Deleted successfully.");
                    await LoadDataAsync();
                }
                else
                {
                    MessageBox.Show("Delete failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting: " + ex.Message);
            }
        }
    }

    private void btnExportCSV_Click(object sender, EventArgs e)
    {

        if (dgvTransactions.Rows.Count == 0)
        {
            MessageBox.Show("No data to export.");
            return;
        }

        using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV Files|*.csv" })
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    CsvExportHelper.ExportDataGridViewToCSV(dgvTransactions, sfd.FileName);
                    MessageBox.Show("Export completed.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Export failed: " + ex.Message);
                }
            }
        }
    }
}
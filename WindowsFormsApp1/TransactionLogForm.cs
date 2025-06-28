using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class InventoryTransactionLogForm : Form
    {
        public InventoryTransactionLogForm()
        {
            InitializeComponent();
        }

        private void InventoryTransactionLogForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            LoadData();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void btnEditSelected_Click(object sender, EventArgs e)
        {
            if (dgvTransactions.CurrentRow == null)
            {
                MessageBox.Show("Please select a transaction to edit.");
                return;
            }
            MessageBox.Show("");
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {

        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }
    }
}

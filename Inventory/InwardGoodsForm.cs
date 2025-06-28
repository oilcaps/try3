using System;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class InwardGoodsForm : Form
    {
        public InwardGoodsForm()
        {
            InitializeComponent();
        }

        private void InwardGoodsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
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


            MessageBox.Show("Add functionality not implemented.");
            ClearInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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


            MessageBox.Show("Update functionality not implemented.");
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtInboundRecordID.Text, out int id))
            {
                MessageBox.Show("Please select a valid record to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;


            MessageBox.Show("Delete functionality not implemented.");
            ClearInputs();
        }

        private void dgvInboundRecords_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dtpInboundDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ClearInputs()
        {
   
            cmbProduct.SelectedIndex = -1;
            numQuantity.Value = 1;
            dtpInboundDate.Value = DateTime.Now;
            txtReference.Clear();
        }
    }
}
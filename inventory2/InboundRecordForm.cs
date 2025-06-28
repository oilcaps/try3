using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory2
{
    public partial class InboundRecordForm : Form
    {
        public InboundRecordForm()
        {
            InitializeComponent();
        }

        private void InboundRecordForm_Load(object sender, EventArgs e) { }

        private void btnAdd_Click(object sender, EventArgs e) { }

        private void btnUpdate_Click(object sender, EventArgs e) { }

        private void btnDelete_Click(object sender, EventArgs e) { }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtProductID.Clear();
            txtQuantity.Clear();
            dtpDate.Value = DateTime.Now;
            txtSupplierID.Clear();
        }
    }
}

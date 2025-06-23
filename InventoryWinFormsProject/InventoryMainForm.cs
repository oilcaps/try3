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
    public partial class InventoryMainForm : Form
    {
        public InventoryMainForm()
        {
            InitializeComponent();
        }

        private void btnInwardGoods_Click(object sender, EventArgs e)
        {
            InwardGoodsForm form = new InwardGoodsForm();
            form.ShowDialog();
        }

        private void btnInventoryView_Click(object sender, EventArgs e)
        {
            InventoryViewForm form = new InventoryViewForm();
            form.ShowDialog();
        }

        private void InventoryMainForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AfterServiceApp
{
    public partial class AfterServiceMainForm : Form
    {
        public AfterServiceMainForm()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            AfterServiceViewForm viewForm = new AfterServiceViewForm();
            viewForm.ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            AfterServiceStatusReportForm reportForm = new AfterServiceStatusReportForm();
            reportForm.ShowDialog();
        }

        private void AfterServiceMainForm_Load(object sender, EventArgs e)
        {

        }
    }
}

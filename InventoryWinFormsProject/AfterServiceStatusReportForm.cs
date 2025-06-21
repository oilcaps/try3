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
    public partial class AfterServiceStatusReportForm : Form
    {
        private DataTable serviceRecordsTable;

        public AfterServiceStatusReportForm()
        {
            InitializeComponent();
        }

        private void AfterServiceStatusReportForm_Load(object sender, EventArgs e)
        {
            LoadSampleData();
            GenerateStatusReport();
        }

        private void LoadSampleData()
        {
            serviceRecordsTable = new DataTable();
            serviceRecordsTable.Columns.Add("ServiceID", typeof(int));
            serviceRecordsTable.Columns.Add("Status", typeof(string));


            serviceRecordsTable.Rows.Add(1, "Pending");
            serviceRecordsTable.Rows.Add(2, "In Progress");
            serviceRecordsTable.Rows.Add(3, "Completed");
            serviceRecordsTable.Rows.Add(4, "Pending");
            serviceRecordsTable.Rows.Add(5, "Completed");
            serviceRecordsTable.Rows.Add(6, "In Progress");
            serviceRecordsTable.Rows.Add(7, "Completed");
        }

        private void GenerateStatusReport()
        {
            var groupedStatus = serviceRecordsTable.AsEnumerable()
                .GroupBy(row => row.Field<string>("Status"))
                .Select(g => new
                {
                    Status = g.Key,
                    Count = g.Count()
                })
                .ToList();

            DataTable reportTable = new DataTable();
            reportTable.Columns.Add("Status");
            reportTable.Columns.Add("Count", typeof(int));

            foreach (var item in groupedStatus)
            {
                reportTable.Rows.Add(item.Status, item.Count);
            }

            dataGridViewReport.DataSource = reportTable;
            dataGridViewReport.Columns[0].HeaderText = "Service Status";
            dataGridViewReport.Columns[1].HeaderText = "Number of Cases";
            dataGridViewReport.AutoResizeColumns();
        }
    }
}
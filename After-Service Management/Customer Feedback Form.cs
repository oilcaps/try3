using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace YourNamespace
{
    public partial class CustomerFeedbackForm : Form
    {
        // 請自行修改成你的資料庫連線字串
        private string connectionString = @"Server=YOUR_SERVER;Database=YOUR_DB;Trusted_Connection=True;";

        public CustomerFeedbackForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string feedbackType = "Other";

            if (radioProductIssue.Checked) feedbackType = "Product Issue";
            else if (radioServiceFeedback.Checked) feedbackType = "Service Feedback";

            string comments = txtComments.Text.Trim();
            DateTime submissionDate = DateTime.Now;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter your name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(comments))
            {
                MessageBox.Show("Please enter your comments.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtComments.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = @"INSERT INTO Feedback (Name, Email, FeedbackType, Comments, SubmissionDate) 
                                   VALUES (@Name, @Email, @FeedbackType, @Comments, @SubmissionDate)";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@FeedbackType", feedbackType);
                        cmd.Parameters.AddWithValue("@Comments", comments);
                        cmd.Parameters.AddWithValue("@SubmissionDate", submissionDate);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Thank you for your feedback!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving feedback: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtName.Clear();
            txtEmail.Clear();
            radioProductIssue.Checked = false;
            radioServiceFeedback.Checked = false;
            radioOther.Checked = true;
            txtComments.Clear();
        }
    }
}
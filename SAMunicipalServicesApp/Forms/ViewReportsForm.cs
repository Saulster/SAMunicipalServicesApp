using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROG7312ST10202241.Data_Storage; 

namespace PROG7312ST10202241.Forms
{
    public partial class ViewReportsForm : Form
    {
        private ResourceManager resourceManager;
        private List<IssueReport> issueReports;

        public ViewReportsForm(List<IssueReport> issueReports)
        {
            InitializeComponent();
            this.issueReports = issueReports ?? new List<IssueReport>();
            resourceManager = new ResourceManager("PROG7312ST10202241.Properties.Strings", typeof(Form1).Assembly);
            ApplyLocalization();
            PopulateDataGrid(ServiceRequestManager.ReportedIssues);
            //dataGridView1.CellClick += dataGridView1_CellContentClick;
        }


        private void ApplyLocalization()
        {
            this.Text = resourceManager.GetString("ViewReportsTitle");
        }
        public void ChangeLanguage(string cultureName)
        {
            CultureInfo culture = new CultureInfo(cultureName);
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
            ApplyLocalization();
        }
        // Method to populate the DataGridView with the issue reports
        private void PopulateDataGrid(List<IssueReport> issueReports)
        {
            // Set up DataGridView columns
            dataGridView1.Columns.Clear(); // Clear existing columns if any
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Request ID";
            dataGridView1.Columns[1].Name = "Location";
            dataGridView1.Columns[2].Name = "Category";
            dataGridView1.Columns[3].Name = "Description";
            dataGridView1.Columns[4].Name = "Submission Date";

            // Add a button column to view files
            DataGridViewButtonColumn viewFilesButton = new DataGridViewButtonColumn
            {
                Text = "View Files",
                UseColumnTextForButtonValue = true,
                Name = "ViewFiles"
            };
            dataGridView1.Columns.Add(viewFilesButton);

            // Populate rows with issue report data
            foreach (var report in issueReports)
            {
                dataGridView1.Rows.Add(report.RequestID, report.Location, report.Category, report.Description, report.ReportDate.ToString("yyyy-MM-dd HH:mm"));
            }

            //auto-resize the columns for better display
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Attach event for button clicks
            //dataGridView1.CellClick += dataGridView1_CellContentClick;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["ViewFiles"].Index && e.RowIndex >= 0)
            {
                // Get RequestID from the selected row
                if (int.TryParse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), out int requestId))
                {
                    var selectedReport = ServiceRequestManager.ReportedIssues.FirstOrDefault(report => report.RequestID == requestId);

                    if (selectedReport != null && selectedReport.AttachedFiles.Any())
                    {
                        ViewFilesForm viewFilesForm = new ViewFilesForm(selectedReport.AttachedFiles);
                        viewFilesForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("No files are attached to this report.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Request ID.");
                }
            }
        }
    }
}

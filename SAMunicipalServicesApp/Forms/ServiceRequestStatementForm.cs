using PROG7312ST10202241.Data_Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Windows.Forms;

namespace PROG7312ST10202241.Forms
{
    public partial class ServiceRequestStatementForm : Form
    {
        private ResourceManager resourceManager;
        private ServiceRequestBST serviceRequestTree;

        public ServiceRequestStatementForm()
        {
            InitializeComponent();
            resourceManager = new ResourceManager("PROG7312ST10202241.Properties.Strings", typeof(ServiceRequestStatementForm).Assembly);
            ApplyLocalization();
            LoadServiceRequests();
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            LoadServiceRequests(); // Refresh the data whenever the form is activated
        }

        private void ApplyLocalization()
        {
            lblSearchByID.Text = resourceManager.GetString("lblSearchId");
            //lblNewStatus.Text = resourceManager.GetString("lblNewStatus");
            btnSearch.Text = resourceManager.GetString("btnSearch");
            closeBtn.Text = resourceManager.GetString("BackToMainMenuBtn");
        }

        private void LoadServiceRequests()
        {
            dataGridViewRequests.DataSource = null;

            ServiceRequestManager.LoadData(); // Ensure the latest data is loaded

            serviceRequestTree = new ServiceRequestBST();
            foreach (var serviceRequest in ServiceRequestManager.ServiceRequests)
            {
                serviceRequestTree.Insert(serviceRequest);
            }

            var requests = serviceRequestTree.InOrderTraversal();
            dataGridViewRequests.DataSource = requests.Select(r => new
            {
                r.RequestId,
                r.Location,
                r.Category,
                r.Description,
                r.Status,
                r.SubmittedDate
            }).ToList(); // Ensures that all required fields are displayed.
        }

        // Search for a service request by ID
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearchId.Text, out int id))
            {
                var request = serviceRequestTree.Search(id);
                if (request != null)
                {
                    MessageBox.Show($"Request ID: {request.RequestId}\nLocation: {request.Location}\nCategory: {request.Category}\nStatus: {request.Status}",
                        "Service Request Found");
                }
                else
                {
                    MessageBox.Show($"Service Request with ID {id} not found.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric ID.", "Input Error");
            }
        }



        private void ServiceRequestStatementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}

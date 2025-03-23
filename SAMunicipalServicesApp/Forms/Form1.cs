using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace PROG7312ST10202241.Forms
{
    public partial class Form1 : Form
    {
        private ResourceManager resourceManager;

        public Form1()
        {
            InitializeComponent();
            resourceManager = new ResourceManager("PROG7312ST10202241.Properties.Strings", typeof(Form1).Assembly);
            ApplyLocalization();
            InitializeLanguageComboBox();
        }

        private void InitializeLanguageComboBox()
        {
            // Create ComboBox items
            var englishItem = new ComboBoxItem
            {
                Content = "English",
                Tag = "en"
            };
            var afrikaansItem = new ComboBoxItem
            {
                Content = "Afrikaans",
                Tag = "af"
            };
            var xhosaItem = new ComboBoxItem
            {
                Content = "IsiXhosa",
                Tag = "xh"
            };

            // Add items to the ComboBox
            languageCBox.Items.Add(englishItem);
            languageCBox.Items.Add(afrikaansItem);
            languageCBox.Items.Add(xhosaItem);

            // Set default selected item
            languageCBox.SelectedItem = englishItem; // or afrikaansItem or xhosaItem
        }

        public void ChangeLanguage(string cultureName)
        {
            CultureInfo culture = new CultureInfo(cultureName);
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;

            ApplyLocalization();
        }

        private void ApplyLocalization()
        {
            this.Text = resourceManager.GetString("Form1Title");
            ReportIssuesLbl.Text = resourceManager.GetString("ReportIssuesBtn");
            LocalEventsAndAnnouncementsLbl.Text = resourceManager.GetString("LocalEventsAndAnnouncements");
            ServiceRequestStatusLbl.Text = resourceManager.GetString("ServiceRequestStatusBtn");
            btnEmployeeLogin.Text = resourceManager.GetString("btnEmployeeLogin");
        }

        private void ReportIssuesBtn_Click(object sender, EventArgs e)
        {
            ReportIssuesForm form = new ReportIssuesForm();
            form.Show();
            this.Hide();
        }

        private void LocalEventsAndAnnouncements_Click(object sender, EventArgs e)
        {
            LocalEventsAndAccouncementsForm form = new LocalEventsAndAccouncementsForm();
            form.Show();
            this.Hide();
        }

        private void ServiceRequestStatusBtn_Click(object sender, EventArgs e)
        {
            ServiceRequestBST tree = new ServiceRequestBST();
            ServiceRequestStatementForm form = new ServiceRequestStatementForm();
            form.Show();
            this.Hide();
        }

        private void Form1_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ReportIssuesPBox_Click_1(object sender, EventArgs e)
        {
            ReportIssuesForm form = new ReportIssuesForm();
            form.Show();
            this.Hide();
        }

        private void LocalEventsAndAnnouncementsPBox_Click_1(object sender, EventArgs e)
        {
            LocalEventsAndAccouncementsForm form = new LocalEventsAndAccouncementsForm();
            form.Show();
            this.Hide();
        }

        private void ServiceRequestStatusPBox_Click_1(object sender, EventArgs e)
        {
            ServiceRequestBST tree = new ServiceRequestBST();
            ServiceRequestStatementForm form = new ServiceRequestStatementForm();
            form.Show();
            this.Hide();
        }

        private void ReportIssuesLbl_Click_1(object sender, EventArgs e)
        {
            ReportIssuesForm form = new ReportIssuesForm();
            form.Show();
            this.Hide();
        }

        private void LocalEventsAndAnnouncementsLbl_Click_1(object sender, EventArgs e)
        {
            LocalEventsAndAccouncementsForm form = new LocalEventsAndAccouncementsForm();
            form.Show();
            this.Hide();
        }

        private void ServiceRequestStatusLbl_Click_1(object sender, EventArgs e)
        {
            ServiceRequestBST tree = new ServiceRequestBST();
            ServiceRequestStatementForm form = new ServiceRequestStatementForm();
            form.Show();
            this.Hide();
        }

        private void languageCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = languageCBox.SelectedItem as ComboBoxItem;
            if (selectedItem != null)
            {
                ChangeLanguage(selectedItem.Tag.ToString());
            }
        }

        private void btnEmployeeLogin_Click(object sender, EventArgs e)
        {
            EmployeeLoginForm form = new EmployeeLoginForm();
            form.Show();
            this.Hide();
        }
    }

    public class ComboBoxItem
    {
        public string Content { get; set; }
        public string Tag { get; set; }

        public override string ToString()
        {
            return Content;
        }
    }
}

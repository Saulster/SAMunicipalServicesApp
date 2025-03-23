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
using System.Windows.Forms;

namespace PROG7312ST10202241.Forms
{
    public partial class EmployeeLoginForm : Form
    {
        private const string EmployeeUsername = "admin"; // Example username
        private const string EmployeePassword = "password123"; // Example password
        private ResourceManager resourceManager;

        public EmployeeLoginForm()
        {
            InitializeComponent();
            resourceManager = new ResourceManager("PROG7312ST10202241.Properties.Strings", typeof(EmployeeLoginForm).Assembly);
            ApplyLocalization();
        }

        private void ApplyLocalization()
        {
            lblUsername.Text = resourceManager.GetString("lblUsername");
            lblPassword.Text = resourceManager.GetString("lblPassword");
            lblWelcome.Text = resourceManager.GetString("lblWelcome");
            lblEmployeeLogin.Text = resourceManager.GetString("lblEmployeeLogin");
            btnLogin.Text = resourceManager.GetString("btnLogin");
            btnCancel.Text = resourceManager.GetString("btnCancel");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Validate employee credentials
            if (txtUsername.Text == EmployeeUsername && txtPassword.Text == EmployeePassword)
            {
                MessageBox.Show(resourceManager.GetString("LoginSuccessMessage"), resourceManager.GetString("LoginSuccessTitle"));

                // Navigate to ServiceRequestGraphForm
                ServiceRequestGraphForm graphForm = new ServiceRequestGraphForm();
                graphForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(resourceManager.GetString("LoginFailureMessage"), resourceManager.GetString("LoginFailureTitle"));
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Return to main menu or close
            Form1 mainMenu = new Form1();
            mainMenu.Show();
            this.Close();
        }

        private void EmployeeLoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

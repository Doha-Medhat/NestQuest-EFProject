using NestQuest.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NestQuest
{
    public partial class Login : Form
    {
        private RealEstateContext _context;
        public Login()
        {
            InitializeComponent();
            _context = new RealEstateContext();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            string email = tx_email.Text.Trim();
            string password = tx_email.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your email and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var user = _context.Users.FirstOrDefault(u => u.Email == email && u.Password == password);

            if (user == null)
            {
                MessageBox.Show("Invalid email or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Welcome, {user.FullName}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Redirect user to the appropriate form based on role
            this.Hide();
            if (user.Role == "Owner")
            {
                OwnerDashboard ownerDashboard = new OwnerDashboard(user);
                ownerDashboard.Show();
            }
            else if (user.Role == "Client")
            {
                ClientDashboard clientDashboard = new ClientDashboard(user);
                clientDashboard.Show();
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register registerForm = new Register();
            registerForm.Show();
        }
    }
}

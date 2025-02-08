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
    public partial class Register : Form
    {
        private RealEstateContext _context;
        public Register()
        {
            InitializeComponent();
            _context = new RealEstateContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fullName = txb_fullname.Text.Trim();
            string email = txb_email.Text.Trim();
            string password = txb_Pass.Text;
            string confirmPassword = txb_confirm.Text;
            // Owner or Client
            string role = cmb_role.SelectedItem?.ToString();


            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_context.Users.Any(u => u.Email == email))
            {
                MessageBox.Show("This email is already registered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User newUser = new User
            {
                FullName = fullName,
                Email = email,
                Password = password,
                Role = role
            };

            _context.Users.Add(newUser);
            _context.SaveChanges();

            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void tn_clear_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }
    }
}

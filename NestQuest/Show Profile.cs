using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NestQuest
{
    public partial class Show_Profile : Form
    {
        private int _userId;
        private RealEstateContext _context = new RealEstateContext();
        public Show_Profile(int userId)
        {
            InitializeComponent();
            _userId = userId;
            LoadUserProfile();
        }

        private void LoadUserProfile()
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == _userId);
            if (user != null)
            {
                textBox2.Text = user.FullName;
                textBox5.Text = user.Email;
                //  Owner or Client
                textBox3.Text = user.Role; 

            }
           
            else
            {
                MessageBox.Show("User not found!");
                this.Close();
            }
            textBox2.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox3.ReadOnly = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(" Are U Sure", "Ok", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Login loginForm = new Login();
                loginForm.Show();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Edit_Profile editForm = new Edit_Profile(_userId);
            editForm.Show();
            this.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Show_Profile_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label5.Text == "Owner")
            {
                OwnerDashboard ownerForm = new OwnerDashboard(_userId);
                ownerForm.Show();
            }
            else  
            {
                ClientDashboard clientForm = new ClientDashboard(_userId);
                clientForm.Show();
            }
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

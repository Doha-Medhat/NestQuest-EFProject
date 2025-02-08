using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
using static System.Windows.Forms.MonthCalendar;

namespace NestQuest
{
    public partial class OwnerDashboard : Form
    {
        private User _currentUser;
        private RealEstateContext _context = new RealEstateContext();
        private int _ownerId;
        public OwnerDashboard(User User)
        {
            _currentUser = User;
        }
        public OwnerDashboard(int ownerId )
        {
            InitializeComponent();
            _ownerId = ownerId;
            LoadProperties();
            
        }

        private void LoadProperties()
        {
            var properties = _context.Properties
                .Where(p => p.ownerId == _ownerId)
                .Select(p => new
                {

                    p.Title,
                    p.Description,
                    p.Price,
                    p.Area,
                    p.Location,
                    p.IsAvailable,
                    p.CreatedAt
                })
                .ToList();

            dataGridView1.DataSource = properties;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Show_Profile showProfileForm = new Show_Profile(_ownerId);
            showProfileForm.Show();
        }

        private void OwnerDashboard_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbtitle.Text) ||
              string.IsNullOrWhiteSpace(txbdes.Text) ||
              string.IsNullOrWhiteSpace(txbprice.Text) ||
              string.IsNullOrWhiteSpace(txbarea.Text) ||
              string.IsNullOrWhiteSpace(txbloca.Text))
            {
                MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newProperty = new Model.Properties
            {
                Title = txbtitle.Text,
                Description = txbdes.Text,
                Price = decimal.Parse(txbprice.Text),
                Area = txbarea.Text,
                Location = txbloca.Text,
                IsAvailable = comboBox1.SelectedItem.ToString() == "Yes",
                CreatedAt = DateTime.Now,
                ownerId = _ownerId
            };
            _context.Properties.Add(newProperty);
            _context.SaveChanges();
            MessageBox.Show("Property added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadProperties();
            ClearFields();
        }

        private void ClearFields()
        {
            txbtitle.Clear();
            txbdes.Clear();
            txbprice.Clear();
            txbarea.Clear();
            txbloca.Clear();
            comboBox1.SelectedIndex = -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Edit_Profile editProfileForm = new Edit_Profile(_ownerId);
            editProfileForm.Show();
        }
    }
}

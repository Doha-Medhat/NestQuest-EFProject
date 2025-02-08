using Microsoft.EntityFrameworkCore;
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
    public partial class Edit_Profile : Form
    {
        private int currentUserId;
        public Edit_Profile(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Edit_Profile_Load(object sender, EventArgs e)
        {
            LoadUserProfile();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SetFieldsEditable(true);
             
        }
        private void LoadUserProfile()
        {
            using (var context = new RealEstateContext())
            {


                var user = context.Users.Find(currentUserId);
                if (user != null)
                {
                    textBox1.Text = user.FullName;
                    textBox2.Text = user.Email;
                    textBox3.Text = user.Password;



                    SetFieldsEditable(false);
                }
                else
                {
                    MessageBox.Show("Error: User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }

            }
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            using (var context = new RealEstateContext())
            {
                var user = context.Users.Find(currentUserId);
                if (user != null)
                {
                    
                    user.FullName = textBox1.Text;
                    user.Email = textBox2.Text;
                    user.Password = textBox3.Text;
                   

                    try
                    {
                        context.SaveChanges();
                        MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SetFieldsEditable(false);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating profile: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void SetFieldsEditable(bool isEditable)
        {
            textBox1.ReadOnly = !isEditable;
            textBox2.ReadOnly = !isEditable;
            textBox3.ReadOnly = !isEditable;
            
            btnsave.Enabled = isEditable;
        }
    }
}

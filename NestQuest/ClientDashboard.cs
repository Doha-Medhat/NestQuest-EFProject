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
    public partial class ClientDashboard : Form
    {
        private User _currentUser;
        public ClientDashboard(User User)
        {
            _currentUser = User;
        }
        public ClientDashboard(int _userId)
        {
            InitializeComponent();
        }

        private void ClientDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Main : Form
    {
        private string userRole;

        public Main(string role)
        {
            InitializeComponent();
            userRole = role;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (userRole == "admin")
            {
                AdminFunctionsPanel.Visible = true;
            }
            else
            {
                AdminFunctionsPanel.Visible = false;
            }
        }
    }
}

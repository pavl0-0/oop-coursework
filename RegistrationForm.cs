using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace CourseWork
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            var manager = new UserMananger();
            string login = NameRegText.Text;
            string password = PasswordRegText.Text;

            if (manager.Register(login, password))
            {
                MessageBox.Show("Реєстрація успішна!");
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Такий користувач вже існує.");
            }
            Main main = new Main("user");
            main.Show();
            this.Hide();
        }
    }
}

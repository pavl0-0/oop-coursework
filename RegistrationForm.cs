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
using System.Security.Policy;

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
            string fullName = FullNameRegText.Text;


            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Заповніть усі поля.");
                return;
            }

            if (password != RepeatPasswordText.Text)
            {
                MessageBox.Show("Паролі не співпадають.");
                return;
            }

            if (manager.Register(login, password, fullName))
            {
                MessageBox.Show("Реєстрація успішна!");

                string role = (login == "admin" && manager.Login(login, password) == "admin") ? "admin" : "user";

                Main main = new Main(role);
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Користувач з таким логіном вже існує.");
            }
        }
    }
}

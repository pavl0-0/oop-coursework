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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var manager = new UserMananger();
            string login = NameLogText.Text;
            string password = PasswordLogText.Text;

            string role = manager.Login(login, password);

            if (role != null)
            {
                MessageBox.Show("Вхід виконано!");
                Main main = new Main(role);

                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Невірний логін або пароль.");
            }
        }

        private void RegLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registerForm = new RegistrationForm();
            registerForm.Show();
            this.Hide();
        }

        private void NameLogText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

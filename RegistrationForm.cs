using System;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class RegistrationForm : Form
    {
        private UserMananger userManager;

        public RegistrationForm()
        {
            InitializeComponent();
            userManager = new UserMananger();
            this.FormClosing += RegistrationForm_FormClosing;
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            string username = NameRegText.Text;
            string password = PasswordRegText.Text;
            string repeatPassword = RepeatPasswordText.Text;
            string fullName = FullNameRegText.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(repeatPassword) || string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show("Будь ласка, заповніть усі поля.", "Помилка реєстрації", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != repeatPassword)
            {
                MessageBox.Show("Паролі не співпадають.", "Помилка реєстрації", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (userManager.Register(username, password, fullName))
            {
                MessageBox.Show("Реєстрація успішна!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CurrentUser.Username = username;
                CurrentUser.Role = userManager.Login(username, password);
                CurrentUser.FullName = fullName;

                Main mainForm = new Main(CurrentUser.Role);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Користувач з таким іменем вже існує або дані недійсні.", "Помилка реєстрації", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Ви впевнені, що хочете вийти з програми?", "Підтвердження виходу", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else if (e.CloseReason == CloseReason.WindowsShutDown)
            {
                Application.Exit();
            }
        }

        private void LogLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogInForm logForm = new LogInForm();
            logForm.Show();
            this.Hide();
        }
    }
}
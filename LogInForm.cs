using System;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class LogInForm : Form
    {
        private UserMananger userManager;
        private UniversitiesManager _universitiesManager;


        public LogInForm(UniversitiesManager universitiesManager)
        {
            InitializeComponent();
            _universitiesManager = universitiesManager;
            userManager = new UserMananger(_universitiesManager);
            this.FormClosing += LogInForm_FormClosing;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = NameLogText.Text;
            string password = PasswordLogText.Text;

            string role = userManager.Login(username, password);

            if (!string.IsNullOrEmpty(role))
            {
                CurrentUser.Username = username;
                CurrentUser.Role = role;
                var user = userManager.LoadUsers().Find(u => u.user == username);
                CurrentUser.FullName = user?.fullName;


                Main mainForm = new Main(CurrentUser.Role, _universitiesManager);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неправильне ім'я користувача або пароль.", "Помилка входу", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm(_universitiesManager);
            registrationForm.Show();
            this.Hide();
        }

        private void LogInForm_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
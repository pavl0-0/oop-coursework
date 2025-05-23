using System;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Applicants_Handbook : Form
    {

        public Applicants_Handbook()
        {
            InitializeComponent();
            this.FormClosing += Applicants_Handbook_FormClosing;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void RegistrationMainButton_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            this.Hide();
        }

        private void LogInMainButton_Click(object sender, EventArgs e)
        {
            LogInForm loginForm = new LogInForm();
            loginForm.Show();
            this.Hide();
        }

        private void Applicants_Handbook_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.IsExitingProgram)
            {
                e.Cancel = false;
                return;
            }

            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Ви впевнені, що хочете вийти з програми?", "Підтвердження виходу", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Program.ExitApplication(); 
                }
            }
        }
    }
}
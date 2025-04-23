using System.Xml.Linq;

namespace CourseWork
{
    public partial class Applicants_Handbook : Form
    {
        public Applicants_Handbook()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegistrationMainButton_Click(object sender, EventArgs e)
        {
            RegistrationForm regForm = new RegistrationForm();
            regForm.Show();
            this.Hide();
        }

        private void LogInMainButton_Click(object sender, EventArgs e)
        {
            LogInForm logForm = new LogInForm();
            logForm.Show();
            this.Hide();
        }
    }
}

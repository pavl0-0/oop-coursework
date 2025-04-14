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

        private void button1_Click(object sender, EventArgs e)
        {
            string applicantName = textBox1.Text;
            label1.Text = applicantName;
        }
    }
}

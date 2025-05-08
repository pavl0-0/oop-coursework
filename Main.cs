using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CourseWork
{
    public partial class Main : Form
    {
        private string userRole;

        public Main()
        {
            InitializeComponent();
        }

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

        private void AddAdminButton_Click(object sender, EventArgs e)
        {
            Admin adminAdd = new Admin();
            adminAdd.Show();
            this.Hide();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string jsonContent = File.ReadAllText("universities_database.json");
            var universities = JsonConvert.DeserializeObject<List<Universities>>(jsonContent);

            string searchName = nameAdminBox.Text.Trim().ToLower();
            string searchAddress = AddressAdminBox.Text.Trim().ToLower();
            string searchSpecialty = SpecialtyAdminBox.Text.Trim();
            string searchMinMark = MinMarkAdminBox.Text.Trim();
            string searchMaxMark = MaxMarkAdminBox.Text.Trim();
            string searchMoney = MoneyAdminBox.Text.Trim();
            string searchForm = FormComboBox.Text.Trim().ToLower();

            decimal specialtyValue;
            decimal minMarkValue = 0;
            decimal maxMarkValue = 0;
            decimal moneyValue = 0;

            bool isSpecialtyValid = decimal.TryParse(searchSpecialty, out specialtyValue);
            bool isMinMarkValid = decimal.TryParse(searchMinMark, out minMarkValue);
            bool isMaxMarkValid = decimal.TryParse(searchMaxMark, out maxMarkValue);
            bool isMoneyValid = decimal.TryParse(searchMoney, out moneyValue);

            var filteredUniversities = universities.Where(u =>
                (string.IsNullOrEmpty(searchName) || u.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(searchSpecialty) || (isSpecialtyValid && u.Specialties == specialtyValue)) &&
                (string.IsNullOrEmpty(searchAddress) || u.Address.Equals(searchAddress, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(searchMinMark) || (isMinMarkValid && u.MinMark >= minMarkValue)) &&
                (string.IsNullOrEmpty(searchMaxMark) || (isMaxMarkValid && u.MaxMark <= maxMarkValue)) &&
                (string.IsNullOrEmpty(searchMoney) || (isMoneyValid && u.Money <= moneyValue)) &&
                (string.IsNullOrEmpty(searchForm) || u.LearnForm.Equals(searchForm, StringComparison.OrdinalIgnoreCase))
            ).ToList();

            flowLayoutPanel1.Controls.Clear();

            if (filteredUniversities.Count > 0)
            {
                foreach (var university in filteredUniversities)
                {
                    Panel panel = CreateNewPanel();
                    UpdatePanelWithUniversityData(panel, university);
                    flowLayoutPanel1.Controls.Add(panel);
                }
            }
            else
            {
                MessageBox.Show("Нічого не знайдено.");
            }
        }



        private Panel CreateNewPanel()
        {
            var panel = new Panel();
            panel.Size = new Size(700, 220);

            var labelName = new Label { Name = "NameUniv", AutoSize = true, Location = new Point(10, 10) };
            var labelAddress = new Label { Name = "Address", AutoSize = true, Location = new Point(10, 40) };
            var labelSpecialty = new Label { Name = "Specialty", AutoSize = true, Location = new Point(10, 70) };
            var labelMinMark = new Label { Name = "MinMark", AutoSize = true, Location = new Point(10, 100) };
            var labelMaxMark = new Label { Name = "MaxMark", AutoSize = true, Location = new Point(10, 130) };
            var labelForm = new Label { Name = "LearnForm", AutoSize = true, Location = new Point(10, 160) };
            var labelTuitionFee = new Label { Name = "Money", AutoSize = true, Location = new Point(10, 190) };

            panel.Controls.Add(labelName);
            panel.Controls.Add(labelAddress);
            panel.Controls.Add(labelSpecialty);
            panel.Controls.Add(labelMinMark);
            panel.Controls.Add(labelMaxMark);
            panel.Controls.Add(labelForm);
            panel.Controls.Add(labelTuitionFee);

            return panel;
        }

        private void UpdatePanelWithUniversityData(Panel panel, Universities university)
        {
            if (panel.Controls["NameUniv"] is Label name)
                name.Text = $"Назва ВНЗ: {university.Name}";

            if (panel.Controls["Address"] is Label address)
                address.Text = $"Адреса: {university.Address}";

            if (panel.Controls["Specialty"] is Label specialty)
                specialty.Text = $"Спеціальність: {university.Specialties}";

            if (panel.Controls["MinMark"] is Label minMark)
                minMark.Text = $"Мінімальний конкурс: {university.MinMark}";

            if (panel.Controls["MaxMark"] is Label maxMark)
                maxMark.Text = $"Максимальний конкурс: {university.MaxMark}";

            if (panel.Controls["LearnForm"] is Label form)
                form.Text = $"Форма навчання: {university.LearnForm}";

            if (panel.Controls["Money"] is Label money)
                money.Text = $"Вартість навчання: {university.Money} грн.";
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChangeAdminButton_Click(object sender, EventArgs e)
        {
            Admin adminAdd = new Admin();
            adminAdd.Show();
            this.Hide();
        }
    }
}
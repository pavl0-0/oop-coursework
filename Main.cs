using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CourseWork
{
    public partial class Main : Form
    {
        private string userRole;
        private UniversitiesManager _universitiesManager;
        private UserMananger _userMananger;
        private bool isNavigating = false;

        public Main(string role)
        {
            InitializeComponent();
            userRole = role;
            _universitiesManager = new UniversitiesManager();
            LoadUniqueCitiesToComboBox();
            _userMananger = new UserMananger();
            this.FormClosing += Main_FormClosing;
        }

        private void LoadUniqueCitiesToComboBox()
        {
            var uniqueCities = _universitiesManager.GetUniqueCities();

            CityMainComboBox.Items.Clear();
            CityMainComboBox.Items.AddRange(uniqueCities.ToArray());
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

            labelCurrentUser.Text = $"Вітаємо, {CurrentUser.FullName}!";
        }

        private void AddAdminButton_Click(object sender, EventArgs e)
        {
            Admin adminAdd = new Admin();
            adminAdd.Show();
            isNavigating = true;
            this.Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchName = NameMainBox.Text.Trim();
            string searchAddress = AddressMainBox.Text.Trim();
            string searchSpecialty = SpecialtyMainBox.Text.Trim();
            string searchMinMark = MinMarkMainBox.Text.Trim();
            string searchMaxMark = MaxMarkMainBox.Text.Trim();
            string searchMinMoney = MinMoneyMainBox.Text.Trim();
            string searchMaxMoney = MaxMoneyMainBox.Text.Trim();
            string searchForm = FormComboBox.Text.Trim();
            string searchCity = CityMainComboBox.Text.Trim();

            var filteredUniversities = _universitiesManager.SearchUniversities(
                searchName, searchAddress, searchSpecialty, searchMinMark, searchMaxMark,
                searchMinMoney, searchMaxMoney, searchForm, searchCity
            );

            DisplayUniversities(filteredUniversities, true);
        }

        private Panel CreateNewPanel()
        {
            var panel = new Panel();
            panel.Size = new Size(700, 250);

            var labelName = new Label { Name = "NameUniv", AutoSize = true, Location = new Point(10, 10) };
            var labelCity = new Label { Name = "City", AutoSize = true, Location = new Point(10, 40) };
            var labelAddress = new Label { Name = "Address", AutoSize = true, Location = new Point(10, 70) };
            var labelSpecialty = new Label { Name = "Specialty", AutoSize = true, Location = new Point(10, 100) };
            var labelMinMark = new Label { Name = "MinMark", AutoSize = true, Location = new Point(10, 130) };
            var labelMaxMark = new Label { Name = "MaxMark", AutoSize = true, Location = new Point(10, 160) };
            var labelForm = new Label { Name = "LearnForm", AutoSize = true, Location = new Point(10, 190) };
            var labelTuitionFee = new Label { Name = "Money", AutoSize = true, Location = new Point(10, 220) };

            var detailsButton = new Button
            {
                Text = "Детальніше",
                Location = new Point(500, 150),
                Size = new Size(100, 30)
            };

            var saveButton = new Button
            {
                Text = "Зберегти",
                Location = new Point(500, 190),
                Size = new Size(100, 30),
                Name = "SaveButton"
            };


            panel.Controls.AddRange(new Control[]
            {
                labelName, labelCity, labelAddress, labelSpecialty, labelMinMark,
                labelMaxMark, labelForm, labelTuitionFee, detailsButton, saveButton
            });

            return panel;
        }

        private void DisplayUniversities(List<Universities> universities, bool showSaveButton)
        {
            flowLayoutPanel1.Controls.Clear();

            if (universities.Count > 0)
            {
                foreach (var university in universities)
                {
                    Panel panel = CreateNewPanel();
                    UpdatePanelWithUniversityData(panel, university, showSaveButton);
                    flowLayoutPanel1.Controls.Add(panel);
                }
            }
            else
            {
                MessageBox.Show("Нічого не знайдено.");
            }
        }

        private void UpdatePanelWithUniversityData(Panel panel, Universities university, bool showSaveButton)
        {
            if (panel.Controls["NameUniv"] is Label name)
                name.Text = $"Назва ВНЗ: {university.Name}";

            if (panel.Controls["City"] is Label city)
                city.Text = $"Місто: {university.City}";

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

            Button detailsButton = panel.Controls.OfType<Button>().FirstOrDefault(b => b.Text == "Детальніше");
            Button saveButton = panel.Controls.OfType<Button>().FirstOrDefault(b => b.Name == "SaveButton"); 

            if (detailsButton != null)
            {
                detailsButton.Click += (s, e) =>
                {
                    Info infoForm = new Info(university);
                    infoForm.ShowDialog();
                };
            }

            if (saveButton != null)
            {
                saveButton.Tag = university;
                saveButton.Click += SaveButton_Click;
                saveButton.Visible = showSaveButton;
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void ChangeAdminButton_Click(object sender, EventArgs e)
        {
            Admin adminAdd = new Admin();
            adminAdd.Show();
            isNavigating = true;
            this.Close();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isNavigating || Program.IsExitingProgram)
            {
                e.Cancel = false;
                return;
            }

            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Ви впевнені, що хочете вийти з програми?", "Підтвердження виходу", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Program.ExitApplication();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else if (e.CloseReason == CloseReason.WindowsShutDown)
            {
                Program.ExitApplication();
            }
        }

        private void buttonEditProfile_Click(object sender, EventArgs e)
        {
            EditProfileForm editForm = new EditProfileForm();
            editForm.ShowDialog();
            labelCurrentUser.Text = $"Вітаємо, {CurrentUser.FullName}!";
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете вийти з облікового запису?", "Підтвердження виходу", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                CurrentUser.Clear();
                Applicants_Handbook applicantsHandbook = new Applicants_Handbook();
                applicantsHandbook.Show();
                isNavigating = true;
                this.Close();
            }
        }

        private void ViewSavedButton_Click(object sender, EventArgs e)
        {
            string currentUsername = CurrentUser.Username;
            if (string.IsNullOrEmpty(currentUsername))
            {
                MessageBox.Show("Будь ласка, увійдіть в систему, щоб переглянути збережені університети.");
                return;
            }

            SavedUniversitiesForm savedForm = new SavedUniversitiesForm(currentUsername);
            savedForm.ShowDialog();
            flowLayoutPanel1.Controls.Clear();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton?.Tag is Universities universityToSave)
            {
                string currentUsername = CurrentUser.Username;

                if (string.IsNullOrEmpty(currentUsername))
                {
                    MessageBox.Show("Будь ласка, увійдіть в систему, щоб зберегти.");
                    return;
                }

                try
                {
                    _userMananger.AddSavedUniversity(currentUsername, universityToSave.Id);
                    MessageBox.Show($"Університет '{universityToSave.Name}' успішно збережено!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не вдалося зберегти університет: {ex.Message}");
                }
            }
        }
    }
}
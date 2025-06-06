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

        public Main(string role, UniversitiesManager universitiesManager)
        {
            InitializeComponent();
            userRole = role;
            _universitiesManager = universitiesManager;
            _userMananger = new UserMananger(_universitiesManager);
            this.FormClosing += Main_FormClosing;
        }

        private void SetupAutoComplete()
        {
            var names = _universitiesManager.GetAllNames();
            SetAutoComplete(NameMainBox, names);

            var cities = _universitiesManager.GetUniqueCities();
            SetAutoComplete(CityMainTextBox, cities);

            var addresses = _universitiesManager.GetAllAddresses();
            SetAutoComplete(AddressMainBox, addresses);

            var specialties = _universitiesManager.GetAllSpecialties();
            SetAutoComplete(SpecialtyMainBox, specialties);
        }

        private void SetAutoComplete(TextBox box, IEnumerable<string> items)
        {
            var autoSource = new AutoCompleteStringCollection();
            autoSource.AddRange(items.Where(i => !string.IsNullOrWhiteSpace(i)).Distinct().ToArray());

            box.AutoCompleteCustomSource = autoSource;
            box.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            box.AutoCompleteSource = AutoCompleteSource.CustomSource;
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
            SetupAutoComplete();
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
            string cityFilter = CityMainTextBox.Text;
            string learnFormFilter = FormComboBox.SelectedItem?.ToString();

            string nameFilter = NameMainBox.Text;
            string addressFilter = AddressMainBox.Text;

            int? Specialties = null;
            if (int.TryParse(SpecialtyMainBox.Text, out int sp)) Specialties = sp;

            decimal? minMark = null;
            if (decimal.TryParse(MinMarkMainBox.Text, out decimal mkMin)) minMark = mkMin;

            decimal? maxMark = null;
            if (decimal.TryParse(MaxMarkMainBox.Text, out decimal mkMax)) maxMark = mkMax;

            decimal? minMoney = null;
            if (decimal.TryParse(MinMoneyMainBox.Text, out decimal mnMin)) minMoney = mnMin;

            decimal? maxMoney = null;
            if (decimal.TryParse(MaxMoneyMainBox.Text, out decimal mnMax)) maxMoney = mnMax;

            List<Universities> filteredUniversities = _universitiesManager.SearchUniversities(
                name: nameFilter,
                address: addressFilter,
                specialty: Specialties?.ToString(),
                minMark: minMark?.ToString(),
                maxMark: maxMark?.ToString(),
                minMoney: minMoney?.ToString(),
                maxMoney: maxMoney?.ToString(),
                form: learnFormFilter,
                city: cityFilter
            );

            flowLayoutPanel1.Controls.Clear();
            DisplayUniversities(filteredUniversities);
        }

        private Panel CreateNewPanel()
        {
            var panel = new Panel();
            panel.Size = new Size(700, 250);

            var labelName = new Label { Name = "labelName", AutoSize = true, Location = new Point(10, 10) };
            var labelCity = new Label { Name = "labelCity", AutoSize = true, Location = new Point(10, 40) };
            var labelAddress = new Label { Name = "labelAddress", AutoSize = true, Location = new Point(10, 70) };
            var labelSpecialty = new Label { Name = "labelSpecialties", AutoSize = true, Location = new Point(10, 100) };
            var labelMinMark = new Label { Name = "labelMinMark", AutoSize = true, Location = new Point(10, 130) };
            var labelMaxMark = new Label { Name = "labelMaxMark", AutoSize = true, Location = new Point(10, 160) };
            var labelForm = new Label { Name = "labelLearnForm", AutoSize = true, Location = new Point(10, 190) };
            var labelTuitionFee = new Label { Name = "labelMoney", AutoSize = true, Location = new Point(10, 220) };

            var detailsButton = new Button
            {
                Text = "Детальніше",
                Location = new Point(500, 150),
                Size = new Size(100, 30),
                Name = "DetailsButton"
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

        private void UpdateUniversityPanelWithData(Panel panel, Universities university)
        {
            Label nameLabel = panel.Controls.OfType<Label>().FirstOrDefault(l => l.Name == "labelName");
            Label cityLabel = panel.Controls.OfType<Label>().FirstOrDefault(l => l.Name == "labelCity");
            Label addressLabel = panel.Controls.OfType<Label>().FirstOrDefault(l => l.Name == "labelAddress");
            Label specialtiesLabel = panel.Controls.OfType<Label>().FirstOrDefault(l => l.Name == "labelSpecialties");
            Label minMarkLabel = panel.Controls.OfType<Label>().FirstOrDefault(l => l.Name == "labelMinMark");
            Label maxMarkLabel = panel.Controls.OfType<Label>().FirstOrDefault(l => l.Name == "labelMaxMark");
            Label learnFormLabel = panel.Controls.OfType<Label>().FirstOrDefault(l => l.Name == "labelLearnForm");
            Label moneyLabel = panel.Controls.OfType<Label>().FirstOrDefault(l => l.Name == "labelMoney");
            Button detailsButton = panel.Controls.OfType<Button>().FirstOrDefault(b => b.Name == "DetailsButton");
            Button saveButton = panel.Controls.OfType<Button>().FirstOrDefault(b => b.Name == "SaveButton");

            if (nameLabel != null)
            {
                nameLabel.Text = $"Назва: {university.Basic?.Name ?? "N/A"}";
            }
            if (cityLabel != null)
            {
                cityLabel.Text = $"Місто: {university.Basic?.City ?? "N/A"}";
            }
            if (addressLabel != null)
            {
                addressLabel.Text = $"Адреса: {university.Basic?.Address ?? "N/A"}";
            }
            if (specialtiesLabel != null)
            {
                specialtiesLabel.Text = $"Спеціальності: {university.Basic?.Specialties.ToString() ?? "N/A"}";
            }
            if (minMarkLabel != null)
            {
                minMarkLabel.Text = $"Мін. бал: {university.Stats?.MinMark.ToString() ?? "N/A"}";
            }
            if (maxMarkLabel != null)
            {
                maxMarkLabel.Text = $"Макс. бал: {university.Stats?.MaxMark.ToString() ?? "N/A"}";
            }
            if (learnFormLabel != null)
            {
                learnFormLabel.Text = $"Форма навчання: {university.Basic?.LearnForm ?? "N/A"}";
            }
            if (moneyLabel != null)
            {
                moneyLabel.Text = $"Вартість: {university.Stats?.Money.ToString("C") ?? "N/A"}";
            }

            if (detailsButton != null)
            {
                detailsButton.Tag = university;
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
            }
        }

        private void DisplayUniversities(List<Universities> universitiesToDisplay)
        {
            foreach (var university in universitiesToDisplay)
            {
                Panel universityPanel = CreateNewPanel();
                UpdateUniversityPanelWithData(universityPanel, university);
                flowLayoutPanel1.Controls.Add(universityPanel);
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
            EditProfileForm editForm = new EditProfileForm(_universitiesManager);
            editForm.ShowDialog();
            labelCurrentUser.Text = $"Вітаємо, {CurrentUser.FullName}!";
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете вийти з облікового запису?", "Підтвердження виходу", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                CurrentUser.Clear();
                Applicants_Handbook applicantsHandbook = new Applicants_Handbook(_universitiesManager);
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

            SavedUniversitiesForm savedForm = new SavedUniversitiesForm(currentUsername, _universitiesManager);
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
                    MessageBox.Show($"Університет '{universityToSave.Basic?.Name}' успішно збережено!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не вдалося зберегти університет: {ex.Message}");
                }
            }
        }
    }
}
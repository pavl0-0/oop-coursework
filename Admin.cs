using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            AdminEditPanel.Visible = false; 
            AdminEditButton.Visible = false;
        }

        private void SaveAdminButton_Click(object sender, EventArgs e)
        {
            var manager = new UniversitiesMananger();
            var universities = manager.LoadUniversities();

            if (!decimal.TryParse(MinMarkAdminBox.Text, out decimal minMark) ||
                !decimal.TryParse(MaxMarkAdminBox.Text, out decimal maxMark) ||
                minMark < 100 || minMark > 200 || maxMark < 100 || maxMark > 200)
            {
                MessageBox.Show("Введіть мінімальне і максимальне значення в межах від 100 до 200 балів");
                return;
            }

            string form = FormComboBox.SelectedItem?.ToString() ?? "";
            if (string.IsNullOrWhiteSpace(form))
            {
                MessageBox.Show("Оберіть форму навчання");
                return;
            }

            if (!decimal.TryParse(MoneyAdminBox.Text, out decimal money) || money < 0)
            {
                MessageBox.Show("Введіть коректну суму грошей за навчання");
                return;
            }
            decimal.TryParse(MinMarkAdminBox.Text, out decimal specialty);

            var newUniversity = new Universities
            {
                Name = nameAdminBox.Text,
                Address = AddressAdminBox.Text,
                Specialties = specialty,
                LearnForm = form,
                MinMark = minMark,
                MaxMark = maxMark,
                Money = money
            };

            universities.Add(newUniversity);
            manager.SaveUniversities(universities);

            MessageBox.Show("Університет успішно збережено!");

        }

        private void ClearButtonAdmin_Click(object sender, EventArgs e)
        {
            nameAdminBox.Text = "";
            AddressAdminBox.Text = "";
            SpecialtyAdminBox.Text = "";
            FormComboBox.SelectedIndex = -1;
            MinMarkAdminBox.Text = "";
            MaxMarkAdminBox.Text = "";
            MoneyAdminBox.Text = "";
        }

        private void ExitAdminButton_Click(object sender, EventArgs e)
        {
            Main main = new Main("admin");
            main.Show();
            this.Hide();
        }

        private void SearchButtonAdmin_Click(object sender, EventArgs e)
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

            MessageBox.Show($"Знайдено університетів: {filteredUniversities.Count}");

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
            panel.Size = new Size(700, 250);

            var labelName = new Label { Name = "NameUniv", AutoSize = true, Location = new Point(10, 10) };
            var labelAddress = new Label { Name = "Address", AutoSize = true, Location = new Point(10, 40) };
            var labelSpecialty = new Label { Name = "Specialty", AutoSize = true, Location = new Point(10, 70) };
            var labelMinMark = new Label { Name = "MinMark", AutoSize = true, Location = new Point(10, 100) };
            var labelMaxMark = new Label { Name = "MaxMark", AutoSize = true, Location = new Point(10, 130) };
            var labelForm = new Label { Name = "LearnForm", AutoSize = true, Location = new Point(10, 160) };
            var labelTuitionFee = new Label { Name = "Money", AutoSize = true, Location = new Point(10, 190) };

            var editButton = new Button
            {
                Text = "Редагувати",
                Location = new Point(500, 30),
                Size = new Size(100, 30)
            };

            var deleteButton = new Button
            {
                Text = "Видалити",
                Location = new Point(500, 70),
                Size = new Size(100, 30)
            };

            panel.Controls.AddRange(new Control[]
            {
                labelName, labelAddress, labelSpecialty, labelMinMark,
                labelMaxMark, labelForm, labelTuitionFee, editButton, deleteButton
            });

            return panel;
        }

        private void DeleteUniversity(Universities university)
        {
            string jsonPath = "universities_database.json";
            var universities = JsonConvert.DeserializeObject<List<Universities>>(File.ReadAllText(jsonPath));

            universities = universities
                .Where(u => !(u.Name == university.Name && u.Address == university.Address))
                .ToList();

            File.WriteAllText(jsonPath, JsonConvert.SerializeObject(universities, Formatting.Indented));
            MessageBox.Show("Університет успішно видалено.");
        }

        private Universities universityBeingEdited;

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

            foreach (Control control in panel.Controls)
            {
                if (control is Button button)
                {
                    if (button.Text == "Редагувати")
                    {
                        button.Click += (s, e) =>
                        {
                            AdminPanel.Visible = false;
                            AdminPanelButton.Visible = false;
                            AdminEditPanel.Visible = true;
                            AdminEditButton.Visible = true;
                            universityBeingEdited = university;

                            nameEditAdminBox.Text = university.Name;
                            AddressEditAdminBox.Text = university.Address;
                            SpecialtyEditAdminBox.Text = university.Specialties.ToString();
                            MinMarkEditAdminBox.Text = university.MinMark.ToString();
                            MaxMarkEditAdminBox.Text = university.MaxMark.ToString();
                            MoneyEditAdminBox.Text = university.Money.ToString();
                            FormEditComboBox.Text = university.LearnForm;
                        };
                    }
                    else if (button.Text == "Видалити")
                    {
                        button.Click += (s, e) =>
                        {
                            var result = MessageBox.Show("Ви впевнені, що хочете видалити університет?", "Підтвердження", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                DeleteUniversity(university);
                                SearchButtonAdmin_Click(null, null);
                            }
                        };
                    }
                }
            }
        }

        private void SaveEdit_Click(object sender, EventArgs e)
        {
            string jsonPath = "universities_database.json";
            var universities = JsonConvert.DeserializeObject<List<Universities>>(File.ReadAllText(jsonPath));

            var target = universities.FirstOrDefault(u =>
                u.Name == universityBeingEdited.Name &&
                u.Address == universityBeingEdited.Address);

            if (target != null)
            {
                if (!string.IsNullOrEmpty(nameEditAdminBox.Text) && nameEditAdminBox.Text != universityBeingEdited.Name)
                    target.Name = nameEditAdminBox.Text;

                if (!string.IsNullOrEmpty(AddressEditAdminBox.Text) && AddressEditAdminBox.Text != universityBeingEdited.Address)
                    target.Address = AddressEditAdminBox.Text;

                if (decimal.TryParse(SpecialtyEditAdminBox.Text, out decimal specialty) && specialty != universityBeingEdited.Specialties)
                    target.Specialties = specialty;

                if (decimal.TryParse(MinMarkEditAdminBox.Text, out decimal minMark) && minMark != universityBeingEdited.MinMark)
                    target.MinMark = minMark;

                if (decimal.TryParse(MaxMarkEditAdminBox.Text, out decimal maxMark) && maxMark != universityBeingEdited.MaxMark)
                    target.MaxMark = maxMark;

                if (decimal.TryParse(MoneyEditAdminBox.Text, out decimal money) && money != universityBeingEdited.Money)
                    target.Money = money;

                if (!string.IsNullOrEmpty(FormEditComboBox.Text) && FormEditComboBox.Text != universityBeingEdited.LearnForm)
                    target.LearnForm = FormEditComboBox.Text;

                File.WriteAllText(jsonPath, JsonConvert.SerializeObject(universities, Formatting.Indented));
                MessageBox.Show("Дані успішно оновлено.");

                nameEditAdminBox.Text = "";
                AddressEditAdminBox.Text = "";
                SpecialtyEditAdminBox.Text = "";
                FormEditComboBox.SelectedIndex = -1;
                MinMarkEditAdminBox.Text = "";
                MaxMarkEditAdminBox.Text = "";
                MoneyEditAdminBox.Text = "";

                nameAdminBox.Text = "";
                AddressAdminBox.Text = "";
                SpecialtyAdminBox.Text = "";
                FormComboBox.SelectedIndex = -1;
                MinMarkAdminBox.Text = "";
                MaxMarkAdminBox.Text = "";
                MoneyAdminBox.Text = "";
            }

            AdminEditPanel.Visible = false;
            AdminPanel.Visible = true;
            SearchButtonAdmin_Click(null, null);
        }

        private void CleanEdit_Click(object sender, EventArgs e)
        {
            nameEditAdminBox.Text = "";
            AddressEditAdminBox.Text = "";
            SpecialtyEditAdminBox.Text = "";
            FormEditComboBox.SelectedIndex = -1;
            MinMarkEditAdminBox.Text = "";
            MaxMarkEditAdminBox.Text = "";
            MoneyEditAdminBox.Text = "";
        }

        private void ExitEdit_Click(object sender, EventArgs e)
        {
            AdminEditButton.Visible = false;
            AdminEditPanel.Visible = false;
            AdminPanel.Visible = true;
            AdminPanelButton.Visible = true;
        }
    }
}
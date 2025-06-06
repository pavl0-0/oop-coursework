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
using System.IO;

namespace CourseWork
{
    public partial class Admin : Form
    {
        private UniversitiesManager _universitiesManager;
        private Universities universityBeingEdited;
        private string _photoPathForNewUniversity;
        private bool isNavigating = false;

        public Admin()
        {
            InitializeComponent();
            _universitiesManager = new UniversitiesManager();
            AdminEditPanel.Visible = false;
            AdminEditButton.Visible = false;
            this.FormClosing += Admin_FormClosing;
        }

        private void SetupAutoComplete()
        {
            var names = _universitiesManager.GetAllNames();
            SetAutoComplete(new[] { nameAdminBox, nameEditAdminBox }, names);

            var cities = _universitiesManager.GetUniqueCities();
            SetAutoComplete(new[] { AdminCityTextBox, EditCityTextBox}, cities);

            var addresses = _universitiesManager.GetAllAddresses();
            SetAutoComplete(new[] { AddressAdminBox, AddressEditAdminBox}, addresses);

            var specialties = _universitiesManager.GetAllSpecialties();
            SetAutoComplete(new[] { SpecialtyAdminBox, SpecialtyEditAdminBox}, specialties);
        }

        private void SetAutoComplete(IEnumerable<TextBox> boxes, IEnumerable<string> items)
        {
            var autoSource = new AutoCompleteStringCollection();
            autoSource.AddRange(items.Where(i => !string.IsNullOrWhiteSpace(i)).Distinct().ToArray());

            foreach (var box in boxes)
            {
                box.AutoCompleteCustomSource = autoSource;
                box.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                box.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        }

        private void SaveAdminButton_Click(object sender, EventArgs e)
        {
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

            int specialty;
            if (!int.TryParse(SpecialtyAdminBox.Text, out specialty))
            {
                specialty = 0;
            }

            var newUniversity = new Universities
            {
                Basic = new UniversityBasic
                {
                    Name = nameAdminBox.Text,
                    City = AdminCityTextBox.Text,
                    Address = AddressAdminBox.Text,
                    Specialties = specialty,
                    LearnForm = form
                },
                Stats = new UniversityStats
                {
                    MinMark = minMark,
                    MaxMark = maxMark,
                    Money = money
                },
                Details = new UniversityDetails
                {
                    UniversityNameFull = FullNameAdmintextBox.Text,
                    AddressFull = FullAddressAdmintextBox.Text,
                    SpecialtiesFull = FullSpecialtiesAdmintextBox.Text,
                    MarksFull = FullMarksAdmintextBox.Text,
                    LearnFormFull = FullFormAdmintextBox.Text,
                    MoneyFull = FullMoneyAdmintextBox.Text,
                    DescriptionFull = DescriptionAdmintextBox.Text,
                    PhotoPath = _photoPathForNewUniversity
                }
            };

            _universitiesManager.AddUniversity(newUniversity);

            MessageBox.Show("Університет успішно збережено!");
            ClearButtonAdmin_Click(sender, e);
            SetupAutoComplete();
        }

        private void ClearButtonAdmin_Click(object sender, EventArgs e)
        {
            nameAdminBox.Text = "";
            AdminCityTextBox.Text = "";
            AddressAdminBox.Text = "";
            SpecialtyAdminBox.Text = "";
            FormComboBox.SelectedIndex = -1;
            MinMarkAdminBox.Text = "";
            MaxMarkAdminBox.Text = "";
            MinMoneyAdminBox.Text = "";
            MaxMoneyAdminBox.Text = "";
            MoneyAdminBox.Text = "";
            FullNameAdmintextBox.Text = "";
            FullAddressAdmintextBox.Text = "";
            FullSpecialtiesAdmintextBox.Text = "";
            FullMarksAdmintextBox.Text = "";
            FullFormAdmintextBox.Text = "";
            FullMoneyAdmintextBox.Text = "";
            DescriptionAdmintextBox.Text = "";
            FotoUnivAdminpictureBox.Image = null;
            _photoPathForNewUniversity = null;
            SetupAutoComplete();
        }

        private void ExitAdminButton_Click(object sender, EventArgs e)
        {
            Main main = new Main("admin", _universitiesManager);
            main.Show();
            isNavigating = true;
            this.Close();
            SetupAutoComplete();
        }

        private void SearchButtonAdmin_Click(object sender, EventArgs e)
        {
            string searchName = nameAdminBox.Text.Trim();
            string searchAddress = AddressAdminBox.Text.Trim();
            string searchSpecialty = SpecialtyAdminBox.Text.Trim();
            string searchMinMark = MinMarkAdminBox.Text.Trim();
            string searchMaxMark = MaxMarkAdminBox.Text.Trim();
            string searchMinMoney = MinMoneyAdminBox.Text.Trim();
            string searchMaxMoney = MaxMoneyAdminBox.Text.Trim();
            string searchForm = FormComboBox.Text.Trim();
            string searchCity = AdminCityTextBox.Text.Trim();

            var filteredUniversities = _universitiesManager.SearchUniversities(
                searchName, searchAddress, searchSpecialty, searchMinMark, searchMaxMark,
                searchMinMoney, searchMaxMoney, searchForm, searchCity
            );

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
            var labelCity = new Label { Name = "City", AutoSize = true, Location = new Point(10, 40) };
            var labelAddress = new Label { Name = "Address", AutoSize = true, Location = new Point(10, 70) };
            var labelSpecialty = new Label { Name = "Specialty", AutoSize = true, Location = new Point(10, 100) };
            var labelMinMark = new Label { Name = "MinMark", AutoSize = true, Location = new Point(10, 130) };
            var labelMaxMark = new Label { Name = "MaxMark", AutoSize = true, Location = new Point(10, 160) };
            var labelForm = new Label { Name = "LearnForm", AutoSize = true, Location = new Point(10, 190) };
            var labelTuitionFee = new Label { Name = "Money", AutoSize = true, Location = new Point(10, 220) };

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
                labelName, labelCity, labelAddress, labelSpecialty, labelMinMark,
                labelMaxMark, labelForm, labelTuitionFee, editButton, deleteButton
            });

            return panel;
        }

        private void UpdatePanelWithUniversityData(Panel panel, Universities university)
        {
            if (panel.Controls["NameUniv"] is Label name)
                name.Text = $"Назва ВНЗ: {university.Basic.Name}";

            if (panel.Controls["City"] is Label city)
                city.Text = $"Місто: {university.Basic.City}";

            if (panel.Controls["Address"] is Label address)
                address.Text = $"Адреса: {university.Basic.Address}";

            if (panel.Controls["Specialty"] is Label specialty)
                specialty.Text = $"Спеціальність: {university.Basic.Specialties}";

            if (panel.Controls["MinMark"] is Label minMark)
                minMark.Text = $"Мінімальний конкурс: {university.Stats.MinMark}";

            if (panel.Controls["MaxMark"] is Label maxMark)
                maxMark.Text = $"Максимальний конкурс: {university.Stats.MaxMark}";

            if (panel.Controls["LearnForm"] is Label form)
                form.Text = $"Форма навчання: {university.Basic.LearnForm}";

            if (panel.Controls["Money"] is Label money)
                money.Text = $"Вартість навчання: {university.Stats.Money} грн.";

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

                            nameEditAdminBox.Text = university.Basic.Name;
                            AddressEditAdminBox.Text = university.Basic.Address;
                            SpecialtyEditAdminBox.Text = university.Basic.Specialties.ToString();
                            MinMarkEditAdminBox.Text = university.Stats.MinMark.ToString();
                            MaxMarkEditAdminBox.Text = university.Stats.MaxMark.ToString();
                            EditCityTextBox.Text = university.Basic.City;
                            MoneyEditAdminBox.Text = university.Stats.Money.ToString();
                            FormEditComboBox.Text = university.Basic.LearnForm;
                            FullNameEdittextBox.Text = university.Details.UniversityNameFull;
                            FullAddressEdittextBox.Text = university.Details.AddressFull;
                            FullSpecialtiesEdittextBox.Text = university.Details.SpecialtiesFull;
                            FullMarksEdittextBox.Text = university.Details.MarksFull;
                            FullFormEdittextBox.Text = university.Details.LearnFormFull;
                            FullMoneyEdittextBox.Text = university.Details.MoneyFull;
                            DescriptionEdittextBox.Text = university.Details.DescriptionFull;
                            if (!string.IsNullOrEmpty(university.Details.PhotoPath) && File.Exists(university.Details.PhotoPath))
                            {
                                FotoUnivEditpictureBox.Image = Image.FromFile(university.Details.PhotoPath);
                            }
                            else
                            {
                                FotoUnivEditpictureBox.Image = null;
                            }
                        };
                    }
                    else if (button.Text == "Видалити")
                    {
                        button.Click += (s, e) =>
                        {
                            var result = MessageBox.Show("Ви впевнені, що хочете видалити університет?", "Підтвердження", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                _universitiesManager.DeleteUniversity(university.Id);
                                SearchButtonAdmin_Click(null, null);
                            }
                        };
                    }
                }
            }
        }

        private void SaveEdit_Click(object sender, EventArgs e)
        {
            if (universityBeingEdited == null)
            {
                MessageBox.Show("Не вибрано університет для редагування.");
                return;
            }

            if (!decimal.TryParse(MinMarkEditAdminBox.Text, out decimal minMark) ||
                !decimal.TryParse(MaxMarkEditAdminBox.Text, out decimal maxMark) ||
                minMark < 100 || minMark > 200 || maxMark < 100 || maxMark > 200)
            {
                MessageBox.Show("Введіть мінімальне і максимальне значення в межах від 100 до 200 балів");
                return;
            }

            if (!decimal.TryParse(MoneyEditAdminBox.Text, out decimal money) || money < 0)
            {
                MessageBox.Show("Введіть коректну суму грошей за навчання");
                return;
            }
            int specialty;
            if (!int.TryParse(SpecialtyEditAdminBox.Text, out specialty))
            {
                specialty = 0;
            }

            var updatedUniversityData = new Universities
            {
                Id = universityBeingEdited.Id,
                Basic = new UniversityBasic
                {
                    Id = universityBeingEdited.Basic.Id,
                    Name = nameEditAdminBox.Text,
                    City = EditCityTextBox.Text,
                    Address = AddressEditAdminBox.Text,
                    Specialties = specialty,
                    LearnForm = FormEditComboBox.Text
                },
                Stats = new UniversityStats
                {
                    Id = universityBeingEdited.Stats.Id,
                    MinMark = minMark,
                    MaxMark = maxMark,
                    Money = money
                },
                Details = new UniversityDetails
                {
                    Id = universityBeingEdited.Details.Id,
                    UniversityNameFull = FullNameEdittextBox.Text,
                    AddressFull = FullAddressEdittextBox.Text,
                    SpecialtiesFull = FullSpecialtiesEdittextBox.Text,
                    MarksFull = FullMarksEdittextBox.Text,
                    LearnFormFull = FullFormEdittextBox.Text,
                    MoneyFull = FullMoneyEdittextBox.Text,
                    DescriptionFull = DescriptionEdittextBox.Text,
                    PhotoPath = universityBeingEdited.Details.PhotoPath
                }
            };

            _universitiesManager.UpdateUniversity(updatedUniversityData);
            MessageBox.Show("Дані успішно оновлено.");

            CleanEdit_Click(sender, e);
            AdminEditButton.Visible = false;
            AdminEditPanel.Visible = false;
            AdminPanel.Visible = true;
            AdminPanelButton.Visible = true;
            SearchButtonAdmin_Click(null, null);
            SetupAutoComplete();
        }

        private void CleanEdit_Click(object sender, EventArgs e)
        {
            nameEditAdminBox.Text = "";
            EditCityTextBox.Text = "";
            AddressEditAdminBox.Text = "";
            SpecialtyEditAdminBox.Text = "";
            FormEditComboBox.SelectedIndex = -1;
            MinMarkEditAdminBox.Text = "";
            MaxMarkEditAdminBox.Text = "";
            MoneyEditAdminBox.Text = "";
            FullNameEdittextBox.Text = "";
            FullAddressEdittextBox.Text = "";
            FullSpecialtiesEdittextBox.Text = "";
            FullMarksEdittextBox.Text = "";
            FullFormEdittextBox.Text = "";
            FullMoneyEdittextBox.Text = "";
            DescriptionEdittextBox.Text = "";
            FotoUnivEditpictureBox.Image = null;
            SetupAutoComplete();
        }

        private void ExitEdit_Click(object sender, EventArgs e)
        {
            AdminEditButton.Visible = false;
            AdminEditPanel.Visible = false;
            AdminPanel.Visible = true;
            AdminPanelButton.Visible = true;
            SetupAutoComplete();
        }

        private void FotoUnivAdminpictureBox_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Оберіть зображення університету";
                openFileDialog.Filter = "Зображення (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        FotoUnivAdminpictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        FotoUnivAdminpictureBox.Image = Image.FromFile(openFileDialog.FileName);
                        _photoPathForNewUniversity = openFileDialog.FileName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Не вдалося завантажити зображення: " + ex.Message);
                    }
                }
            }
        }

        private void FotoUnivEditpictureBox_Click(object sender, EventArgs e)
        {
            if (universityBeingEdited == null)
            {
                MessageBox.Show("Університет не вибрано або не ініціалізовано.");
                return;
            }

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Оберіть зображення університету";
                openFileDialog.Filter = "Зображення (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        FotoUnivEditpictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        FotoUnivEditpictureBox.Image = Image.FromFile(openFileDialog.FileName);
                        universityBeingEdited.Details.PhotoPath = openFileDialog.FileName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Не вдалося завантажити зображення: " + ex.Message);
                    }
                }
            }
        }
        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
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

        private void buttonEditProfileAdmin_Click(object sender, EventArgs e)
        {
            EditProfileForm editForm = new EditProfileForm(_universitiesManager);
            editForm.ShowDialog();
            labelCurrentUserAdmin.Text = $"Вітаємо, {CurrentUser.FullName}!";
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            labelCurrentUserAdmin.Text = $"Вітаємо, {CurrentUser.FullName}!";
            SetupAutoComplete();
        }

        private void buttonLogoutAdmin_Click(object sender, EventArgs e)
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
    }
}
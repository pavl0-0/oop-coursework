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

            LoadUniqueCitiesToComboBox();
            this.FormClosing += Admin_FormClosing;
        }

        private void LoadUniqueCitiesToComboBox()
        {
            var uniqueCities = _universitiesManager.GetUniqueCities();

            AdminCityComboBox.Items.Clear();
            AdminCityComboBox.Items.AddRange(uniqueCities.ToArray());
            EditCityComboBox.Items.Clear();
            EditCityComboBox.Items.AddRange(uniqueCities.ToArray());
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

            string city = AdminCityComboBox.Text.Trim();
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
                Name = nameAdminBox.Text,
                City = city,
                Address = AddressAdminBox.Text,
                Specialties = specialty,
                LearnForm = form,
                MinMark = minMark,
                MaxMark = maxMark,
                Money = money,
                UniversityNameFull = FullNameAdmintextBox.Text,
                AddressFull = FullAddressAdmintextBox.Text,
                SpecialtiesFull = FullSpecialtiesAdmintextBox.Text,
                MarksFull = FullMarksAdmintextBox.Text,
                LearnFormFull = FullFormAdmintextBox.Text,
                MoneyFull = FullMoneyAdmintextBox.Text,
                DescriptionFull = DescriptionAdmintextBox.Text,
                PhotoPath = _photoPathForNewUniversity
            };

            _universitiesManager.AddUniversity(newUniversity);

            MessageBox.Show("Університет успішно збережено!");
            ClearButtonAdmin_Click(sender, e);
            LoadUniqueCitiesToComboBox();
        }

        private void ClearButtonAdmin_Click(object sender, EventArgs e)
        {
            nameAdminBox.Text = "";
            AdminCityComboBox.SelectedIndex = -1;
            AdminCityComboBox.Text = "";
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
        }

        private void ExitAdminButton_Click(object sender, EventArgs e)
        {
            Main main = new Main("admin");
            main.Show();
            isNavigating = true;
            this.Close();
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
            string searchCity = AdminCityComboBox.Text.Trim();

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
                            EditCityComboBox.Text = university.City;
                            MoneyEditAdminBox.Text = university.Money.ToString();
                            FormEditComboBox.Text = university.LearnForm;
                            FullNameEdittextBox.Text = university.UniversityNameFull;
                            FullAddressEdittextBox.Text = university.AddressFull;
                            FullSpecialtiesEdittextBox.Text = university.SpecialtiesFull;
                            FullMarksEdittextBox.Text = university.MarksFull;
                            FullFormEdittextBox.Text = university.LearnFormFull;
                            FullMoneyEdittextBox.Text = university.MoneyFull;
                            DescriptionEdittextBox.Text = university.DescriptionFull;
                            if (!string.IsNullOrEmpty(university.PhotoPath) && File.Exists(university.PhotoPath))
                            {
                                FotoUnivEditpictureBox.Image = Image.FromFile(university.PhotoPath);
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
                                _universitiesManager.DeleteUniversity(university.Name, university.Address);
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
                Name = nameEditAdminBox.Text,
                City = EditCityComboBox.Text,
                Address = AddressEditAdminBox.Text,
                Specialties = specialty,
                LearnForm = FormEditComboBox.Text,
                MinMark = minMark,
                MaxMark = maxMark,
                Money = money,
                UniversityNameFull = FullNameEdittextBox.Text,
                AddressFull = FullAddressEdittextBox.Text,
                SpecialtiesFull = FullSpecialtiesEdittextBox.Text,
                MarksFull = FullMarksEdittextBox.Text,
                LearnFormFull = FullFormEdittextBox.Text,
                MoneyFull = FullMoneyEdittextBox.Text,
                DescriptionFull = DescriptionEdittextBox.Text,
                PhotoPath = universityBeingEdited.PhotoPath
            };

            _universitiesManager.UpdateUniversity(updatedUniversityData);
            MessageBox.Show("Дані успішно оновлено.");

            CleanEdit_Click(sender, e);
            AdminEditButton.Visible = false;
            AdminEditPanel.Visible = false;
            AdminPanel.Visible = true;
            AdminPanelButton.Visible = true;
            SearchButtonAdmin_Click(null, null);
            LoadUniqueCitiesToComboBox();
        }

        private void CleanEdit_Click(object sender, EventArgs e)
        {
            nameEditAdminBox.Text = "";
            EditCityComboBox.SelectedIndex = -1;
            EditCityComboBox.Text = "";
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
        }

        private void ExitEdit_Click(object sender, EventArgs e)
        {
            AdminEditButton.Visible = false;
            AdminEditPanel.Visible = false;
            AdminPanel.Visible = true;
            AdminPanelButton.Visible = true;
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
                        universityBeingEdited.PhotoPath = openFileDialog.FileName;
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
            EditProfileForm editForm = new EditProfileForm();
            editForm.ShowDialog();
            labelCurrentUserAdmin.Text = $"Вітаємо, {CurrentUser.FullName}!";
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            labelCurrentUserAdmin.Text = $"Вітаємо, {CurrentUser.FullName}!";
        }

        private void buttonLogoutAdmin_Click(object sender, EventArgs e)
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
    }
}
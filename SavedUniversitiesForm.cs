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
    public partial class SavedUniversitiesForm : Form
    {
        private string _username;
        private UniversitiesManager _universitiesManager;
        private UserMananger _userMananger;

        public SavedUniversitiesForm(string username, UniversitiesManager universitiesManager)
        {
            InitializeComponent();
            _username = username;
            _universitiesManager = new UniversitiesManager();
            _userMananger = new UserMananger(_universitiesManager);

            this.Text = $"Збережені університети для {_username}";
            this.AutoScroll = true;

            LoadSavedUniversities();
        }

        private void LoadSavedUniversities()
        {
            flowLayoutPanelSaved.Controls.Clear();

            List<Universities> savedUniversitiesToDisplay = _userMananger.GetSavedUniversities(_username);

            if (savedUniversitiesToDisplay != null && savedUniversitiesToDisplay.Any())
            {
                foreach (var university in savedUniversitiesToDisplay)
                {
                    Panel panel = CreateSavedUniversityPanel();
                    UpdateSavedPanelWithUniversityData(panel, university);
                    flowLayoutPanelSaved.Controls.Add(panel);
                }
            }
            else
            {
                MessageBox.Show("У вас немає збережених університетів.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private Panel CreateSavedUniversityPanel()
        {
            var panel = new Panel();
            panel.Size = new Size(700, 250);
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Margin = new Padding(5);

            var labelName = new Label { Name = "NameUniv", AutoSize = true, Location = new Point(10, 10), Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold) };
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
                Location = new Point(500, 100),
                Size = new Size(100, 30)
            };

            var deleteButton = new Button
            {
                Text = "Видалити",
                Location = new Point(500, 150),
                Size = new Size(100, 30),
                Name = "DeleteButton"
            };

            var pictureBox = new PictureBox
            {
                Name = "UniversityPicture",
                Location = new Point(610, 10),
                Size = new Size(80, 80),
                SizeMode = PictureBoxSizeMode.Zoom,
                BorderStyle = BorderStyle.FixedSingle
            };

            panel.Controls.AddRange(new Control[]
            {
                labelName, labelCity, labelAddress, labelSpecialty, labelMinMark,
                labelMaxMark, labelForm, labelTuitionFee, detailsButton, deleteButton, pictureBox
            });

            return panel;
        }

        private void UpdateSavedPanelWithUniversityData(Panel panel, Universities university)
        {
            if (panel.Controls["NameUniv"] is Label name)
                name.Text = $"Назва ВНЗ: {university.Basic?.Name ?? "N/A"}";

            if (panel.Controls["City"] is Label city)
                city.Text = $"Місто: {university.Basic?.City ?? "N/A"}";

            if (panel.Controls["Address"] is Label address)
                address.Text = $"Адреса: {university.Basic?.Address ?? "N/A"}";

            if (panel.Controls["Specialty"] is Label specialty)
                specialty.Text = $"Спеціальність: {university.Basic?.Specialties.ToString() ?? "N/A"}";

            if (panel.Controls["MinMark"] is Label minMark)
                minMark.Text = $"Мінімальний конкурс: {university.Stats?.MinMark.ToString() ?? "N/A"}";

            if (panel.Controls["MaxMark"] is Label maxMark)
                maxMark.Text = $"Максимальний конкурс: {university.Stats?.MaxMark.ToString() ?? "N/A"}";

            if (panel.Controls["LearnForm"] is Label form)
                form.Text = $"Форма навчання: {university.Basic?.LearnForm ?? "N/A"}";

            if (panel.Controls["Money"] is Label money)
                money.Text = $"Вартість навчання: {university.Stats?.Money.ToString("C") ?? "N/A"} грн.";

            if (panel.Controls["UniversityPicture"] is PictureBox pictureBox)
            {
                if (university.Details != null && !string.IsNullOrEmpty(university.Details.PhotoPath) && File.Exists(university.Details.PhotoPath))
                {
                    try
                    {
                        pictureBox.Image = Image.FromFile(university.Details.PhotoPath);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error loading image for {university.Basic?.Name ?? university.Id}: {ex.Message}");
                        pictureBox.Image = null;
                    }
                }
                else
                {
                    pictureBox.Image = null;
                }
            }

            Button detailsButton = panel.Controls.OfType<Button>().FirstOrDefault(b => b.Text == "Детальніше");
            Button deleteButton = panel.Controls.OfType<Button>().FirstOrDefault(b => b.Name == "DeleteButton");

            if (detailsButton != null)
            {
                detailsButton.Tag = university;
                detailsButton.Click += (s, e) =>
                {
                    Info infoForm = new Info(university);
                    infoForm.ShowDialog();
                };
            }

            if (deleteButton != null)
            {
                deleteButton.Tag = university;
                deleteButton.Click += DeleteSavedButton_Click;
            }
        }

        private void DeleteSavedButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton?.Tag is Universities universityToDelete)
            {
                var result = MessageBox.Show($"Ви впевнені, що хочете видалити '{universityToDelete.Basic?.Name ?? universityToDelete.Id}' зі збережених?", "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        _userMananger.RemoveSavedUniversity(_username, universityToDelete.Id);
                        MessageBox.Show($"Університет '{universityToDelete.Basic?.Name ?? universityToDelete.Id}' видалено зі збережених.");
                        LoadSavedUniversities();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Помилка при видаленні університету: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ExportAllButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Текстові файли (*.txt)|*.txt",
                Title = "Зберегти всі збережені університети в текстовий файл",
                FileName = $"SavedUniversities_{_username}.txt"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    List<Universities> savedUniversities = _userMananger.GetSavedUniversities(_username);

                    if (savedUniversities == null || !savedUniversities.Any())
                    {
                        MessageBox.Show("Немає університетів для експорту.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        foreach (var university in savedUniversities)
                        {
                            writer.WriteLine("===============================================");
                            writer.WriteLine($"Назва ВНЗ: {university.Basic?.Name ?? "N/A"}");
                            writer.WriteLine($"Місто: {university.Basic?.City ?? "N/A"}");
                            writer.WriteLine($"Адреса: {university.Basic?.Address ?? "N/A"}");
                            writer.WriteLine($"Спеціальність: {university.Basic?.Specialties.ToString() ?? "N/A"}");
                            writer.WriteLine($"Мінімальний конкурс: {university.Stats?.MinMark.ToString() ?? "N/A"}");
                            writer.WriteLine($"Максимальний конкурс: {university.Stats?.MaxMark.ToString() ?? "N/A"}");
                            writer.WriteLine($"Форма навчання: {university.Basic?.LearnForm ?? "N/A"}");
                            writer.WriteLine($"Вартість навчання: {university.Stats?.Money.ToString("C") ?? "N/A"} грн.");
                            writer.WriteLine();
                        }
                    }

                    MessageBox.Show($"Дані університетів успішно збережено у файл:\n{saveFileDialog.FileName}", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при збереженні файлу: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
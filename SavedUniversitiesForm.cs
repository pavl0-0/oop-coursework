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

        public SavedUniversitiesForm(string username)
        {
            InitializeComponent();
            _username = username;
            _universitiesManager = new UniversitiesManager();
            _userMananger = new UserMananger();

            this.Text = $"Збережені університети для {_username}"; 
            this.AutoScroll = true;

            LoadSavedUniversities();
        }

        private void LoadSavedUniversities()
        {
            flowLayoutPanelSaved.Controls.Clear();

            var savedUniversitiesList = _userMananger.GetSavedUniversities(_username);

            if (savedUniversitiesList != null && savedUniversitiesList.Any())
            {
                foreach (var university in savedUniversitiesList)
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

            if (panel.Controls["UniversityPicture"] is PictureBox pictureBox)
            {
                if (!string.IsNullOrEmpty(university.PhotoPath) && File.Exists(university.PhotoPath))
                {
                    try
                    {
                        pictureBox.Image = Image.FromFile(university.PhotoPath);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error loading image for {university.Name}: {ex.Message}");
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
                var result = MessageBox.Show($"Ви впевнені, що хочете видалити '{universityToDelete.Id}' зі збережених?", "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        _userMananger.RemoveSavedUniversity(_username, universityToDelete.Id); 
                        MessageBox.Show($"Університет '{universityToDelete.Id}' видалено зі збережених.");
                        LoadSavedUniversities();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Помилка при видаленні університету: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
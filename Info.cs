using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Info : Form
    {
        private Universities _university;

        public Info(Universities university)
        {
            InitializeComponent();
            _university = university;
        }

        private void Info_Load(object sender, EventArgs e)
        {
            if (_university != null && _university.Details != null)
            {
                labelNameFull.Text = $"Повна назва: {_university.Details.UniversityNameFull ?? "N/A"}";
                labelAddressFull.Text = $"Повна адреса: {_university.Details.AddressFull ?? "N/A"}";
                labelSpecialtiesFull.Text = $"Повні спеціальності: {_university.Details.SpecialtiesFull ?? "N/A"}";
                labelMarksFull.Text = $"Повні бали ЗНО: {_university.Details.MarksFull ?? "N/A"}";
                labelLearnFormFull.Text = $"Повна форма навчання: {_university.Details.LearnFormFull ?? "N/A"}";
                labelMoneyFull.Text = $"Повна вартість (рік): {_university.Details.MoneyFull ?? "N/A"}";
                textBoxDescriptionFull.Text = _university.Details.DescriptionFull ?? "N/A";

                if (!string.IsNullOrEmpty(_university.Details.PhotoPath) && File.Exists(_university.Details.PhotoPath))
                {
                    try
                    {
                        pictureBoxUniversity.Image = Image.FromFile(_university.Details.PhotoPath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Не вдалося завантажити зображення: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        pictureBoxUniversity.Image = null;
                    }
                }
                else
                {
                    pictureBoxUniversity.Image = null;
                }

                AdjustFormAndTextBoxSize();
            }
            else if (_university != null)
            {
                MessageBox.Show("Детальні дані для цього університету відсутні.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelNameFull.Text = "Повна назва: Відсутня";
                labelAddressFull.Text = "Повна адреса: Відсутня";
                textBoxDescriptionFull.Text = "Опис відсутній.";
                pictureBoxUniversity.Image = null;
                AdjustFormAndTextBoxSize();
            }
        }

        private void AdjustFormAndTextBoxSize()
        {
            int textBoxWidth = textBoxDescriptionFull.Width;

            TextFormatFlags flags = TextFormatFlags.WordBreak | TextFormatFlags.TextBoxControl;
            Size textSize = TextRenderer.MeasureText(textBoxDescriptionFull.Text, textBoxDescriptionFull.Font, new Size(textBoxWidth, 0), flags);

            int minTextBoxHeight = 200;

            int newTextBoxHeight = Math.Max(minTextBoxHeight, textSize.Height + 10);

            textBoxDescriptionFull.Height = newTextBoxHeight;

            int bottomMargin = 20;
            int newFormHeight = textBoxDescriptionFull.Location.Y + newTextBoxHeight + bottomMargin;

            this.ClientSize = new Size(this.ClientSize.Width, newFormHeight);
        }
    }
}
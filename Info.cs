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
            if (_university != null)
            {
                labelNameFull.Text = $"Повна назва: {_university.UniversityNameFull}";
                labelAddressFull.Text = $"Повна адреса: {_university.AddressFull}";
                labelSpecialtiesFull.Text = $"Повні спеціальності: {_university.SpecialtiesFull}";
                labelMarksFull.Text = $"Повні бали ЗНО: {_university.MarksFull}";
                labelLearnFormFull.Text = $"Повна форма навчання: {_university.LearnFormFull}";
                labelMoneyFull.Text = $"Повна вартість (рік): {_university.MoneyFull}";
                textBoxDescriptionFull.Text = _university.DescriptionFull;

                if (!string.IsNullOrEmpty(_university.PhotoPath) && File.Exists(_university.PhotoPath))
                {
                    try
                    {
                        pictureBoxUniversity.Image = Image.FromFile(_university.PhotoPath);
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
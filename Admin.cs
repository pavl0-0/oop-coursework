using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        private void SaveAdminButton_Click(object sender, EventArgs e)
        {
            var manager = new UniversitiesMananger();
            var universities = manager.LoadUniversities();

            double minMark = double.Parse(MinMarkAdminBox.Text);
            double maxMark = double.Parse(MaxMarkAdminBox.Text);
            string form = FormComboBox.SelectedItem.ToString();

            var newUniversity = new Universities
            {
                Name = nameAdminBox.Text,
                Address = AddressAdminBox.Text,
                Specialties = SpecialtyAdminBox.Text,
                LearnForm = FormComboBox.Text,

                MinDayMark = 0,
                MaxDayMark = 0,
                MinCorrespondenceMark = 0,
                MaxCorrespondenceMark = 0,
                MinEveningMark = 0,
                MaxEveningMark = 0,
            };

            switch (form)
            {
                case "Денна":
                    newUniversity.MinDayMark = minMark;
                    newUniversity.MaxDayMark = maxMark;
                    break;
                case "Заочна":
                    newUniversity.MinCorrespondenceMark = minMark;
                    newUniversity.MaxCorrespondenceMark = maxMark;
                    break;
                case "Вечірня":
                    newUniversity.MinEveningMark = minMark;
                    newUniversity.MaxEveningMark = maxMark;
                    break;
                default:
                    MessageBox.Show("Оберіть форму навчання.");
                    return;
            }

            universities.Add(newUniversity);
            manager.SaveUniversities(universities);

            MessageBox.Show("Університет успішно збережено!");

        }
    }
}

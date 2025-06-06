// EditProfileForm.cs
using System;
using System.Linq;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class EditProfileForm : Form
    {
        private UserMananger userManager;
        private UniversitiesManager _universitiesManager;

        public EditProfileForm(UniversitiesManager universitiesManager)
        {
            InitializeComponent();
            _universitiesManager = universitiesManager;
            userManager = new UserMananger(_universitiesManager);
            this.FormClosing += EditProfileForm_FormClosing;
        }

        private void EditProfileForm_Load(object sender, EventArgs e)
        {
            labelUsername.Text = $"Користувач: {CurrentUser.Username}";
            textBoxFullName.Text = CurrentUser.FullName;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string oldPassword = textBoxOldPassword.Text;
            string newPassword = textBoxNewPassword.Text;
            string repeatNewPassword = textBoxRepeatNewPassword.Text;
            string newFullName = textBoxFullName.Text;

            if (userManager.Login(CurrentUser.Username, oldPassword) == null)
            {
                MessageBox.Show("Невірний старий пароль.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newFullName != CurrentUser.FullName)
            {
                var users = userManager.LoadUsers();
                var userToUpdate = users.FirstOrDefault(u => u.user == CurrentUser.Username);
                if (userToUpdate != null)
                {
                    userToUpdate.fullName = newFullName;
                    userManager.SaveUsers(users);
                    CurrentUser.FullName = newFullName; 
                    MessageBox.Show("Повне ім'я успішно оновлено.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (!string.IsNullOrWhiteSpace(newPassword))
            {
                if (newPassword != repeatNewPassword)
                {
                    MessageBox.Show("Новий пароль та його повторення не співпадають.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var users = userManager.LoadUsers();
                var userToUpdate = users.FirstOrDefault(u => u.user == CurrentUser.Username);
                if (userToUpdate != null)
                {
                    userToUpdate.password = userManager.HashPassword(newPassword); 
                    userManager.SaveUsers(users);
                    MessageBox.Show("Пароль успішно змінено.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            this.Close(); 
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditProfileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Ви впевнені, що хочете закрити редагування профілю?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true; 
                }
            }
        }
    }
}
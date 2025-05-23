// EditProfileForm.Designer.cs
namespace CourseWork
{
    partial class EditProfileForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelUsername = new Label();
            labelFullName = new Label();
            textBoxFullName = new TextBox();
            labelOldPassword = new Label();
            textBoxOldPassword = new TextBox();
            labelNewPassword = new Label();
            textBoxNewPassword = new TextBox();
            labelRepeatNewPassword = new Label();
            textBoxRepeatNewPassword = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelUsername.ForeColor = Color.DarkSlateBlue;
            labelUsername.Location = new Point(30, 30);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(246, 28);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "Користувач: [Username]";
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Location = new Point(30, 80);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(87, 20);
            labelFullName.TabIndex = 1;
            labelFullName.Text = "Повне ім'я:";
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(221, 77);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(229, 27);
            textBoxFullName.TabIndex = 2;
            // 
            // labelOldPassword
            // 
            labelOldPassword.AutoSize = true;
            labelOldPassword.Location = new Point(30, 130);
            labelOldPassword.Name = "labelOldPassword";
            labelOldPassword.Size = new Size(117, 20);
            labelOldPassword.TabIndex = 3;
            labelOldPassword.Text = "Старий пароль:";
            // 
            // textBoxOldPassword
            // 
            textBoxOldPassword.Location = new Point(221, 127);
            textBoxOldPassword.Name = "textBoxOldPassword";
            textBoxOldPassword.PasswordChar = '*';
            textBoxOldPassword.Size = new Size(229, 27);
            textBoxOldPassword.TabIndex = 4;
            // 
            // labelNewPassword
            // 
            labelNewPassword.AutoSize = true;
            labelNewPassword.Location = new Point(30, 180);
            labelNewPassword.Name = "labelNewPassword";
            labelNewPassword.Size = new Size(113, 20);
            labelNewPassword.TabIndex = 5;
            labelNewPassword.Text = "Новий пароль:";
            // 
            // textBoxNewPassword
            // 
            textBoxNewPassword.Location = new Point(221, 177);
            textBoxNewPassword.Name = "textBoxNewPassword";
            textBoxNewPassword.PasswordChar = '*';
            textBoxNewPassword.Size = new Size(229, 27);
            textBoxNewPassword.TabIndex = 6;
            // 
            // labelRepeatNewPassword
            // 
            labelRepeatNewPassword.AutoSize = true;
            labelRepeatNewPassword.Location = new Point(30, 230);
            labelRepeatNewPassword.Name = "labelRepeatNewPassword";
            labelRepeatNewPassword.Size = new Size(185, 20);
            labelRepeatNewPassword.TabIndex = 7;
            labelRepeatNewPassword.Text = "Повторіть новий пароль:";
            // 
            // textBoxRepeatNewPassword
            // 
            textBoxRepeatNewPassword.Location = new Point(221, 227);
            textBoxRepeatNewPassword.Name = "textBoxRepeatNewPassword";
            textBoxRepeatNewPassword.PasswordChar = '*';
            textBoxRepeatNewPassword.Size = new Size(229, 27);
            textBoxRepeatNewPassword.TabIndex = 8;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.ForestGreen;
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonSave.ForeColor = Color.White;
            buttonSave.Location = new Point(200, 280);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(120, 35);
            buttonSave.TabIndex = 9;
            buttonSave.Text = "Зберегти";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.IndianRed;
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(330, 280);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(120, 35);
            buttonCancel.TabIndex = 10;
            buttonCancel.Text = "Скасувати";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // EditProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(487, 350);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxRepeatNewPassword);
            Controls.Add(labelRepeatNewPassword);
            Controls.Add(textBoxNewPassword);
            Controls.Add(labelNewPassword);
            Controls.Add(textBoxOldPassword);
            Controls.Add(labelOldPassword);
            Controls.Add(textBoxFullName);
            Controls.Add(labelFullName);
            Controls.Add(labelUsername);
            Name = "EditProfileForm";
            Text = "Редагування профілю";
            Load += EditProfileForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Label labelOldPassword;
        private System.Windows.Forms.TextBox textBoxOldPassword;
        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Label labelRepeatNewPassword;
        private System.Windows.Forms.TextBox textBoxRepeatNewPassword;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}
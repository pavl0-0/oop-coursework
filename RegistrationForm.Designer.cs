namespace CourseWork
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NameRegText = new TextBox();
            PasswordRegText = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            RegistrationButton = new Button();
            RepeatPasswordLabel = new Label();
            RepeatPasswordText = new TextBox();
            label5 = new Label();
            FullNameRegText = new TextBox();
            LogLabel = new LinkLabel();
            SuspendLayout();
            // 
            // NameRegText
            // 
            NameRegText.Font = new Font("Segoe UI", 10.5F);
            NameRegText.Location = new Point(367, 185);
            NameRegText.Name = "NameRegText";
            NameRegText.Size = new Size(216, 31);
            NameRegText.TabIndex = 0;
            // 
            // PasswordRegText
            // 
            PasswordRegText.Font = new Font("Segoe UI", 10.5F);
            PasswordRegText.Location = new Point(367, 228);
            PasswordRegText.Name = "PasswordRegText";
            PasswordRegText.PasswordChar = '●';
            PasswordRegText.Size = new Size(216, 31);
            PasswordRegText.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.ForeColor = Color.DarkSlateBlue;
            label1.Location = new Point(300, 60);
            label1.Name = "label1";
            label1.Size = new Size(243, 54);
            label1.TabIndex = 2;
            label1.Text = "Реєстрація ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(194, 186);
            label2.Name = "label2";
            label2.Size = new Size(125, 25);
            label2.TabIndex = 3;
            label2.Text = "Введіть логін";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(194, 229);
            label3.Name = "label3";
            label3.Size = new Size(144, 25);
            label3.TabIndex = 4;
            label3.Text = "Введіть пароль";
            // 
            // RegistrationButton
            // 
            RegistrationButton.BackColor = Color.SeaGreen;
            RegistrationButton.FlatAppearance.BorderSize = 0;
            RegistrationButton.FlatStyle = FlatStyle.Flat;
            RegistrationButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            RegistrationButton.ForeColor = Color.White;
            RegistrationButton.Location = new Point(292, 360);
            RegistrationButton.Name = "RegistrationButton";
            RegistrationButton.Size = new Size(228, 60);
            RegistrationButton.TabIndex = 5;
            RegistrationButton.Text = "Зареєструватися";
            RegistrationButton.UseVisualStyleBackColor = false;
            RegistrationButton.Click += RegistrationButton_Click;
            // 
            // RepeatPasswordLabel
            // 
            RepeatPasswordLabel.AutoSize = true;
            RepeatPasswordLabel.Font = new Font("Segoe UI", 11F);
            RepeatPasswordLabel.ForeColor = Color.DimGray;
            RepeatPasswordLabel.Location = new Point(194, 272);
            RepeatPasswordLabel.Name = "RepeatPasswordLabel";
            RepeatPasswordLabel.Size = new Size(168, 25);
            RepeatPasswordLabel.TabIndex = 6;
            RepeatPasswordLabel.Text = "Повторіть пароль";
            // 
            // RepeatPasswordText
            // 
            RepeatPasswordText.Font = new Font("Segoe UI", 10.5F);
            RepeatPasswordText.Location = new Point(367, 271);
            RepeatPasswordText.Name = "RepeatPasswordText";
            RepeatPasswordText.PasswordChar = '●';
            RepeatPasswordText.Size = new Size(216, 31);
            RepeatPasswordText.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(194, 143);
            label5.Name = "label5";
            label5.Size = new Size(113, 25);
            label5.TabIndex = 8;
            label5.Text = "Введіть ім'я";
            // 
            // FullNameRegText
            // 
            FullNameRegText.Font = new Font("Segoe UI", 10.5F);
            FullNameRegText.Location = new Point(367, 142);
            FullNameRegText.Name = "FullNameRegText";
            FullNameRegText.Size = new Size(216, 31);
            FullNameRegText.TabIndex = 9;
            // 
            // LogLabel
            // 
            LogLabel.AutoSize = true;
            LogLabel.Font = new Font("Segoe UI", 9.5F);
            LogLabel.LinkColor = Color.SteelBlue;
            LogLabel.Location = new Point(326, 423);
            LogLabel.Name = "LogLabel";
            LogLabel.Size = new Size(161, 21);
            LogLabel.TabIndex = 10;
            LogLabel.TabStop = true;
            LogLabel.Text = "Вже є акаунт? Увійди";
            LogLabel.LinkClicked += LogLabel_LinkClicked;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(800, 470);
            Controls.Add(LogLabel);
            Controls.Add(FullNameRegText);
            Controls.Add(label5);
            Controls.Add(RepeatPasswordText);
            Controls.Add(RepeatPasswordLabel);
            Controls.Add(RegistrationButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordRegText);
            Controls.Add(NameRegText);
            Name = "RegistrationForm";
            Text = "Довідник Абітурієнта - Реєстрація";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameRegText;
        private TextBox PasswordRegText;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button RegistrationButton;
        private Label RepeatPasswordLabel;
        private TextBox RepeatPasswordText;
        private Label label5;
        private TextBox FullNameRegText;
        private LinkLabel LogLabel;
    }
}
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
            SuspendLayout();
            // 
            // NameRegText
            // 
            NameRegText.Location = new Point(367, 185);
            NameRegText.Name = "NameRegText";
            NameRegText.Size = new Size(216, 27);
            NameRegText.TabIndex = 0;
            // 
            // PasswordRegText
            // 
            PasswordRegText.Location = new Point(367, 228);
            PasswordRegText.Name = "PasswordRegText";
            PasswordRegText.Size = new Size(216, 27);
            PasswordRegText.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(357, 94);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 2;
            label1.Text = "Реєстрація ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(218, 188);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 3;
            label2.Text = "Введіть логін";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 231);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 4;
            label3.Text = "Введіть пароль";
            // 
            // RegistrationButton
            // 
            RegistrationButton.Location = new Point(292, 330);
            RegistrationButton.Name = "RegistrationButton";
            RegistrationButton.Size = new Size(216, 27);
            RegistrationButton.TabIndex = 5;
            RegistrationButton.Text = "Зареєструватися";
            RegistrationButton.UseVisualStyleBackColor = true;
            RegistrationButton.Click += RegistrationButton_Click;
            // 
            // RepeatPasswordLabel
            // 
            RepeatPasswordLabel.AutoSize = true;
            RepeatPasswordLabel.Location = new Point(218, 274);
            RepeatPasswordLabel.Name = "RepeatPasswordLabel";
            RepeatPasswordLabel.Size = new Size(134, 20);
            RepeatPasswordLabel.TabIndex = 6;
            RepeatPasswordLabel.Text = "Повторіть пароль";
            // 
            // RepeatPasswordText
            // 
            RepeatPasswordText.Location = new Point(367, 271);
            RepeatPasswordText.Name = "RepeatPasswordText";
            RepeatPasswordText.Size = new Size(216, 27);
            RepeatPasswordText.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(218, 145);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 8;
            label5.Text = "Введіть ім'я";
            // 
            // FullNameRegText
            // 
            FullNameRegText.Location = new Point(367, 142);
            FullNameRegText.Name = "FullNameRegText";
            FullNameRegText.Size = new Size(216, 27);
            FullNameRegText.TabIndex = 9;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Text = "Реєстрація нового користувача";
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
    }
}
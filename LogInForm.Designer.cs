namespace CourseWork
{
    partial class LogInForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            NameLogText = new TextBox();
            PasswordLogText = new TextBox();
            RegLabel = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(382, 119);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 0;
            label1.Text = "Вхід";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(228, 165);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 1;
            label2.Text = "Ім'я";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(228, 210);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 2;
            label3.Text = "Пароль";
            // 
            // button1
            // 
            button1.Location = new Point(325, 258);
            button1.Name = "button1";
            button1.Size = new Size(150, 50);
            button1.TabIndex = 3;
            button1.Text = "Увійти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // NameLogText
            // 
            NameLogText.Location = new Point(306, 162);
            NameLogText.Name = "NameLogText";
            NameLogText.Size = new Size(188, 27);
            NameLogText.TabIndex = 4;
            NameLogText.TextChanged += NameLogText_TextChanged;
            // 
            // PasswordLogText
            // 
            PasswordLogText.Location = new Point(306, 207);
            PasswordLogText.Name = "PasswordLogText";
            PasswordLogText.Size = new Size(188, 27);
            PasswordLogText.TabIndex = 5;
            // 
            // RegLabel
            // 
            RegLabel.AutoSize = true;
            RegLabel.Location = new Point(272, 311);
            RegLabel.Name = "RegLabel";
            RegLabel.Size = new Size(256, 20);
            RegLabel.TabIndex = 6;
            RegLabel.TabStop = true;
            RegLabel.Text = "Ще не маєш акаунта? Зареєструйся";
            RegLabel.LinkClicked += RegLabel_LinkClicked;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RegLabel);
            Controls.Add(PasswordLogText);
            Controls.Add(NameLogText);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LogInForm";
            Text = "LogInForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox NameLogText;
        private TextBox PasswordLogText;
        private LinkLabel RegLabel;
    }
}
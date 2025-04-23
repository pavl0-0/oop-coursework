namespace CourseWork
{
    partial class Admin
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
            nameAdminBox = new TextBox();
            SpecialtyAdminBox = new TextBox();
            MaxMarkAdminBox = new TextBox();
            MinMarkAdminBox = new TextBox();
            FormComboBox = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SaveAdminButton = new Button();
            button1 = new Button();
            button2 = new Button();
            label6 = new Label();
            AddressAdminBox = new TextBox();
            SuspendLayout();
            // 
            // nameAdminBox
            // 
            nameAdminBox.Location = new Point(159, 114);
            nameAdminBox.Name = "nameAdminBox";
            nameAdminBox.Size = new Size(470, 27);
            nameAdminBox.TabIndex = 20;
            // 
            // SpecialtyAdminBox
            // 
            SpecialtyAdminBox.Location = new Point(182, 222);
            SpecialtyAdminBox.Name = "SpecialtyAdminBox";
            SpecialtyAdminBox.Size = new Size(447, 27);
            SpecialtyAdminBox.TabIndex = 19;
            // 
            // MaxMarkAdminBox
            // 
            MaxMarkAdminBox.Location = new Point(534, 293);
            MaxMarkAdminBox.Name = "MaxMarkAdminBox";
            MaxMarkAdminBox.Size = new Size(93, 27);
            MaxMarkAdminBox.TabIndex = 18;
            // 
            // MinMarkAdminBox
            // 
            MinMarkAdminBox.Location = new Point(236, 293);
            MinMarkAdminBox.Name = "MinMarkAdminBox";
            MinMarkAdminBox.Size = new Size(93, 27);
            MinMarkAdminBox.TabIndex = 17;
            // 
            // FormComboBox
            // 
            FormComboBox.FormattingEnabled = true;
            FormComboBox.Items.AddRange(new object[] { "Денна", "Заочна", "Вечірня" });
            FormComboBox.Location = new Point(224, 351);
            FormComboBox.Name = "FormComboBox";
            FormComboBox.Size = new Size(242, 28);
            FormComboBox.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 354);
            label5.Name = "label5";
            label5.Size = new Size(131, 20);
            label5.TabIndex = 15;
            label5.Text = "Форма навчання:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(351, 296);
            label4.Name = "label4";
            label4.Size = new Size(177, 20);
            label4.TabIndex = 14;
            label4.Text = "Максимальний конкурс:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 296);
            label3.Name = "label3";
            label3.Size = new Size(163, 20);
            label3.TabIndex = 13;
            label3.Text = "Мінімальний конкурс:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 229);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 12;
            label2.Text = "Спеціальність:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 117);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 11;
            label1.Text = "Назва ВНЗ:";
            // 
            // SaveAdminButton
            // 
            SaveAdminButton.Location = new Point(67, 422);
            SaveAdminButton.Name = "SaveAdminButton";
            SaveAdminButton.Size = new Size(213, 61);
            SaveAdminButton.TabIndex = 21;
            SaveAdminButton.Text = "Зберегти дані";
            SaveAdminButton.UseVisualStyleBackColor = true;
            SaveAdminButton.Click += SaveAdminButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(378, 422);
            button1.Name = "button1";
            button1.Size = new Size(213, 61);
            button1.TabIndex = 22;
            button1.Text = "Очистити поля";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(666, 422);
            button2.Name = "button2";
            button2.Size = new Size(213, 61);
            button2.TabIndex = 23;
            button2.Text = "Вийти";
            button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(67, 171);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 24;
            label6.Text = "Адреса ВНЗ:";
            // 
            // AddressAdminBox
            // 
            AddressAdminBox.Location = new Point(167, 164);
            AddressAdminBox.Name = "AddressAdminBox";
            AddressAdminBox.Size = new Size(462, 27);
            AddressAdminBox.TabIndex = 25;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 580);
            Controls.Add(AddressAdminBox);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(SaveAdminButton);
            Controls.Add(nameAdminBox);
            Controls.Add(SpecialtyAdminBox);
            Controls.Add(MaxMarkAdminBox);
            Controls.Add(MinMarkAdminBox);
            Controls.Add(FormComboBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Admin";
            Text = "Admin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox nameAdminBox;
        private TextBox SpecialtyAdminBox;
        private TextBox MaxMarkAdminBox;
        private TextBox MinMarkAdminBox;
        private ComboBox FormComboBox;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button SaveAdminButton;
        private Button button1;
        private Button button2;
        private Label label6;
        private TextBox AddressAdminBox;
    }
}
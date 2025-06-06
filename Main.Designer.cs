namespace CourseWork
{
    partial class Main
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
            AdminFunctionsPanel = new Panel();
            AddAdminButton = new Button();
            SearchButton = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            MainPanel = new Panel();
            CityMainTextBox = new TextBox();
            label24 = new Label();
            label7 = new Label();
            label1 = new Label();
            label19 = new Label();
            label2 = new Label();
            label20 = new Label();
            label3 = new Label();
            label4 = new Label();
            MaxMoneyMainBox = new TextBox();
            label5 = new Label();
            MinMoneyMainBox = new TextBox();
            FormComboBox = new ComboBox();
            AddressMainBox = new TextBox();
            MinMarkMainBox = new TextBox();
            MaxMarkMainBox = new TextBox();
            NameMainBox = new TextBox();
            SpecialtyMainBox = new TextBox();
            labelCurrentUser = new Label();
            buttonEditProfile = new Button();
            buttonLogout = new Button();
            buttonSaved = new Button();
            AdminFunctionsPanel.SuspendLayout();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // AdminFunctionsPanel
            // 
            AdminFunctionsPanel.Controls.Add(AddAdminButton);
            AdminFunctionsPanel.Location = new Point(12, 534);
            AdminFunctionsPanel.Name = "AdminFunctionsPanel";
            AdminFunctionsPanel.Size = new Size(250, 50);
            AdminFunctionsPanel.TabIndex = 0;
            // 
            // AddAdminButton
            // 
            AddAdminButton.BackColor = Color.SteelBlue;
            AddAdminButton.FlatAppearance.BorderSize = 0;
            AddAdminButton.FlatStyle = FlatStyle.Flat;
            AddAdminButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            AddAdminButton.ForeColor = Color.White;
            AddAdminButton.Location = new Point(0, 0);
            AddAdminButton.Name = "AddAdminButton";
            AddAdminButton.Size = new Size(250, 50);
            AddAdminButton.TabIndex = 0;
            AddAdminButton.Text = "Функції адміністратора";
            AddAdminButton.UseVisualStyleBackColor = false;
            AddAdminButton.Click += AddAdminButton_Click;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.ForestGreen;
            SearchButton.FlatAppearance.BorderSize = 0;
            SearchButton.FlatStyle = FlatStyle.Flat;
            SearchButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            SearchButton.ForeColor = Color.White;
            SearchButton.Location = new Point(12, 478);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(250, 50);
            SearchButton.TabIndex = 1;
            SearchButton.Text = "Пошук";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Location = new Point(329, 93);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(669, 554);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(CityMainTextBox);
            MainPanel.Controls.Add(label24);
            MainPanel.Controls.Add(label7);
            MainPanel.Controls.Add(label1);
            MainPanel.Controls.Add(label19);
            MainPanel.Controls.Add(label2);
            MainPanel.Controls.Add(label20);
            MainPanel.Controls.Add(label3);
            MainPanel.Controls.Add(label4);
            MainPanel.Controls.Add(MaxMoneyMainBox);
            MainPanel.Controls.Add(label5);
            MainPanel.Controls.Add(MinMoneyMainBox);
            MainPanel.Controls.Add(FormComboBox);
            MainPanel.Controls.Add(AddressMainBox);
            MainPanel.Controls.Add(MinMarkMainBox);
            MainPanel.Controls.Add(MaxMarkMainBox);
            MainPanel.Controls.Add(NameMainBox);
            MainPanel.Controls.Add(SpecialtyMainBox);
            MainPanel.Location = new Point(12, 114);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(311, 358);
            MainPanel.TabIndex = 3;
            // 
            // CityMainTextBox
            // 
            CityMainTextBox.Location = new Point(183, 314);
            CityMainTextBox.Name = "CityMainTextBox";
            CityMainTextBox.Size = new Size(125, 27);
            CityMainTextBox.TabIndex = 25;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(3, 317);
            label24.Name = "label24";
            label24.Size = new Size(48, 20);
            label24.TabIndex = 23;
            label24.Text = "Місто";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 284);
            label7.Name = "label7";
            label7.Size = new Size(107, 20);
            label7.TabIndex = 22;
            label7.Text = "Макс. вартість";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 49);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "Назва";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(3, 251);
            label19.Name = "label19";
            label19.Size = new Size(98, 20);
            label19.TabIndex = 21;
            label19.Text = "Мін. вартість";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 82);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 1;
            label2.Text = "Спеціальність";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(3, 218);
            label20.Name = "label20";
            label20.Size = new Size(128, 20);
            label20.TabIndex = 20;
            label20.Text = "Форма навчання";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 118);
            label3.Name = "label3";
            label3.Size = new Size(122, 20);
            label3.TabIndex = 2;
            label3.Text = "Мін. конкур. бал";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 151);
            label4.Name = "label4";
            label4.Size = new Size(131, 20);
            label4.TabIndex = 3;
            label4.Text = "Макс. конкур. бал";
            // 
            // MaxMoneyMainBox
            // 
            MaxMoneyMainBox.Location = new Point(183, 281);
            MaxMoneyMainBox.Name = "MaxMoneyMainBox";
            MaxMoneyMainBox.Size = new Size(125, 27);
            MaxMoneyMainBox.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 184);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 4;
            label5.Text = "Адреса";
            // 
            // MinMoneyMainBox
            // 
            MinMoneyMainBox.Location = new Point(183, 248);
            MinMoneyMainBox.Name = "MinMoneyMainBox";
            MinMoneyMainBox.Size = new Size(125, 27);
            MinMoneyMainBox.TabIndex = 17;
            // 
            // FormComboBox
            // 
            FormComboBox.FormattingEnabled = true;
            FormComboBox.Items.AddRange(new object[] { "Денна", "Заочна", "Вечірня" });
            FormComboBox.Location = new Point(183, 215);
            FormComboBox.Name = "FormComboBox";
            FormComboBox.Size = new Size(125, 28);
            FormComboBox.TabIndex = 16;
            // 
            // AddressMainBox
            // 
            AddressMainBox.Location = new Point(183, 181);
            AddressMainBox.Name = "AddressMainBox";
            AddressMainBox.Size = new Size(125, 27);
            AddressMainBox.TabIndex = 14;
            // 
            // MinMarkMainBox
            // 
            MinMarkMainBox.Location = new Point(183, 115);
            MinMarkMainBox.Name = "MinMarkMainBox";
            MinMarkMainBox.Size = new Size(125, 27);
            MinMarkMainBox.TabIndex = 13;
            // 
            // MaxMarkMainBox
            // 
            MaxMarkMainBox.Location = new Point(183, 148);
            MaxMarkMainBox.Name = "MaxMarkMainBox";
            MaxMarkMainBox.Size = new Size(125, 27);
            MaxMarkMainBox.TabIndex = 12;
            // 
            // NameMainBox
            // 
            NameMainBox.Location = new Point(183, 46);
            NameMainBox.Name = "NameMainBox";
            NameMainBox.Size = new Size(125, 27);
            NameMainBox.TabIndex = 10;
            // 
            // SpecialtyMainBox
            // 
            SpecialtyMainBox.Location = new Point(183, 79);
            SpecialtyMainBox.Name = "SpecialtyMainBox";
            SpecialtyMainBox.Size = new Size(125, 27);
            SpecialtyMainBox.TabIndex = 11;
            // 
            // labelCurrentUser
            // 
            labelCurrentUser.AutoSize = true;
            labelCurrentUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelCurrentUser.Location = new Point(12, 9);
            labelCurrentUser.Name = "labelCurrentUser";
            labelCurrentUser.Size = new Size(90, 23);
            labelCurrentUser.TabIndex = 4;
            labelCurrentUser.Text = "Вітаємо, !";
            // 
            // buttonEditProfile
            // 
            buttonEditProfile.BackColor = Color.SteelBlue;
            buttonEditProfile.FlatAppearance.BorderSize = 0;
            buttonEditProfile.FlatStyle = FlatStyle.Flat;
            buttonEditProfile.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonEditProfile.ForeColor = Color.White;
            buttonEditProfile.Location = new Point(12, 35);
            buttonEditProfile.Name = "buttonEditProfile";
            buttonEditProfile.Size = new Size(140, 35);
            buttonEditProfile.TabIndex = 5;
            buttonEditProfile.Text = "Редагувати профіль";
            buttonEditProfile.UseVisualStyleBackColor = false;
            buttonEditProfile.Click += buttonEditProfile_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.IndianRed;
            buttonLogout.FlatAppearance.BorderSize = 0;
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonLogout.ForeColor = Color.White;
            buttonLogout.Location = new Point(158, 35);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(104, 35);
            buttonLogout.TabIndex = 6;
            buttonLogout.Text = "Вийти";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // buttonSaved
            // 
            buttonSaved.BackColor = Color.SteelBlue;
            buttonSaved.FlatAppearance.BorderSize = 0;
            buttonSaved.FlatStyle = FlatStyle.Flat;
            buttonSaved.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonSaved.ForeColor = Color.White;
            buttonSaved.Location = new Point(12, 73);
            buttonSaved.Name = "buttonSaved";
            buttonSaved.Size = new Size(250, 35);
            buttonSaved.TabIndex = 7;
            buttonSaved.Text = "Збережені університети";
            buttonSaved.UseVisualStyleBackColor = false;
            buttonSaved.Click += ViewSavedButton_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(1010, 659);
            Controls.Add(buttonSaved);
            Controls.Add(buttonLogout);
            Controls.Add(buttonEditProfile);
            Controls.Add(labelCurrentUser);
            Controls.Add(MainPanel);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(SearchButton);
            Controls.Add(AdminFunctionsPanel);
            Name = "Main";
            Text = "Довідник Абітурієнта";
            FormClosing += Main_FormClosing;
            Load += Main_Load;
            AdminFunctionsPanel.ResumeLayout(false);
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel AdminFunctionsPanel;
        private Button AddAdminButton;
        private Button SearchButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel MainPanel;
        private Label label1;
        private Label label19;
        private Label label2;
        private Label label20;
        private Label label3;
        private Label label4;
        private TextBox MaxMoneyMainBox;
        private Label label5;
        private TextBox MinMoneyMainBox;
        private ComboBox FormComboBox;
        private TextBox AddressMainBox;
        private TextBox MinMarkMainBox;
        private TextBox MaxMarkMainBox;
        private TextBox NameMainBox;
        private TextBox SpecialtyMainBox;
        private Label label24;
        private Label label7;
        private Label labelCurrentUser;
        private Button buttonEditProfile;
        private Button buttonLogout;
        private Button buttonSaved;
        private TextBox CityMainTextBox;
    }
}
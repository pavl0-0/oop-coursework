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
            CityMainComboBox = new ComboBox();
            label24 = new Label();
            label7 = new Label();
            label1 = new Label();
            label19 = new Label();
            label2 = new Label();
            label20 = new Label();
            label3 = new Label();
            label21 = new Label();
            label4 = new Label();
            MaxMoneyMainBox = new TextBox();
            label5 = new Label();
            MinMoneyMainBox = new TextBox();
            FormComboBox = new ComboBox();
            label22 = new Label();
            AddressMainBox = new TextBox();
            MinMarkMainBox = new TextBox();
            label6 = new Label();
            MaxMarkMainBox = new TextBox();
            NameMainBox = new TextBox();
            SpecialtyMainBox = new TextBox();
            AdminFunctionsPanel.SuspendLayout();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // AdminFunctionsPanel
            // 
            AdminFunctionsPanel.Controls.Add(AddAdminButton);
            AdminFunctionsPanel.Location = new Point(396, 480);
            AdminFunctionsPanel.Name = "AdminFunctionsPanel";
            AdminFunctionsPanel.Size = new Size(236, 86);
            AdminFunctionsPanel.TabIndex = 10;
            // 
            // AddAdminButton
            // 
            AddAdminButton.Location = new Point(10, 10);
            AddAdminButton.Name = "AddAdminButton";
            AddAdminButton.Size = new Size(218, 67);
            AddAdminButton.TabIndex = 0;
            AddAdminButton.Text = "Перейти в адмінську панель";
            AddAdminButton.UseVisualStyleBackColor = true;
            AddAdminButton.Click += AddAdminButton_Click;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(139, 490);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(218, 67);
            SearchButton.TabIndex = 11;
            SearchButton.Text = "Пошук";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(139, 596);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(560, 284);
            flowLayoutPanel1.TabIndex = 43;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(CityMainComboBox);
            MainPanel.Controls.Add(label24);
            MainPanel.Controls.Add(label7);
            MainPanel.Controls.Add(label1);
            MainPanel.Controls.Add(label19);
            MainPanel.Controls.Add(label2);
            MainPanel.Controls.Add(label20);
            MainPanel.Controls.Add(label3);
            MainPanel.Controls.Add(label21);
            MainPanel.Controls.Add(label4);
            MainPanel.Controls.Add(MaxMoneyMainBox);
            MainPanel.Controls.Add(label5);
            MainPanel.Controls.Add(MinMoneyMainBox);
            MainPanel.Controls.Add(FormComboBox);
            MainPanel.Controls.Add(label22);
            MainPanel.Controls.Add(AddressMainBox);
            MainPanel.Controls.Add(MinMarkMainBox);
            MainPanel.Controls.Add(label6);
            MainPanel.Controls.Add(MaxMarkMainBox);
            MainPanel.Controls.Add(NameMainBox);
            MainPanel.Controls.Add(SpecialtyMainBox);
            MainPanel.Location = new Point(139, 56);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(622, 409);
            MainPanel.TabIndex = 47;
            // 
            // CityMainComboBox
            // 
            CityMainComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CityMainComboBox.FormattingEnabled = true;
            CityMainComboBox.Items.AddRange(new object[] { "Денна", "Заочна", "Вечірня" });
            CityMainComboBox.Location = new Point(135, 71);
            CityMainComboBox.Name = "CityMainComboBox";
            CityMainComboBox.Size = new Size(242, 28);
            CityMainComboBox.TabIndex = 56;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(32, 74);
            label24.Name = "label24";
            label24.Size = new Size(51, 20);
            label24.TabIndex = 55;
            label24.Text = "Місто:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(562, 370);
            label7.Name = "label7";
            label7.Size = new Size(36, 20);
            label7.TabIndex = 54;
            label7.Text = "грн.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 18);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 11;
            label1.Text = "Назва ВНЗ:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(410, 370);
            label19.Name = "label19";
            label19.Size = new Size(36, 20);
            label19.TabIndex = 53;
            label19.Text = "грн.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 191);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 12;
            label2.Text = "Спеціальність:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(448, 369);
            label20.Name = "label20";
            label20.Size = new Size(29, 20);
            label20.TabIndex = 52;
            label20.Text = "до:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 258);
            label3.Name = "label3";
            label3.Size = new Size(163, 20);
            label3.TabIndex = 13;
            label3.Text = "Мінімальний конкурс:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(296, 369);
            label21.Name = "label21";
            label21.Size = new Size(32, 20);
            label21.TabIndex = 51;
            label21.Text = "від:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(316, 258);
            label4.Name = "label4";
            label4.Size = new Size(177, 20);
            label4.TabIndex = 14;
            label4.Text = "Максимальний конкурс:";
            // 
            // MaxMoneyMainBox
            // 
            MaxMoneyMainBox.Location = new Point(483, 366);
            MaxMoneyMainBox.Name = "MaxMoneyMainBox";
            MaxMoneyMainBox.Size = new Size(70, 27);
            MaxMoneyMainBox.TabIndex = 50;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 313);
            label5.Name = "label5";
            label5.Size = new Size(131, 20);
            label5.TabIndex = 15;
            label5.Text = "Форма навчання:";
            // 
            // MinMoneyMainBox
            // 
            MinMoneyMainBox.Location = new Point(334, 366);
            MinMoneyMainBox.Name = "MinMoneyMainBox";
            MinMoneyMainBox.Size = new Size(70, 27);
            MinMoneyMainBox.TabIndex = 49;
            // 
            // FormComboBox
            // 
            FormComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FormComboBox.FormattingEnabled = true;
            FormComboBox.Items.AddRange(new object[] { "Денна", "Заочна", "Вечірня" });
            FormComboBox.Location = new Point(187, 310);
            FormComboBox.Name = "FormComboBox";
            FormComboBox.Size = new Size(242, 28);
            FormComboBox.TabIndex = 16;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(32, 369);
            label22.Name = "label22";
            label22.Size = new Size(258, 20);
            label22.TabIndex = 48;
            label22.Text = "Вартість навчання за рік (контракт):";
            // 
            // AddressMainBox
            // 
            AddressMainBox.Location = new Point(132, 133);
            AddressMainBox.Name = "AddressMainBox";
            AddressMainBox.Size = new Size(462, 27);
            AddressMainBox.TabIndex = 25;
            // 
            // MinMarkMainBox
            // 
            MinMarkMainBox.Location = new Point(201, 255);
            MinMarkMainBox.Name = "MinMarkMainBox";
            MinMarkMainBox.Size = new Size(93, 27);
            MinMarkMainBox.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 136);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 24;
            label6.Text = "Адреса ВНЗ:";
            // 
            // MaxMarkMainBox
            // 
            MaxMarkMainBox.Location = new Point(499, 255);
            MaxMarkMainBox.Name = "MaxMarkMainBox";
            MaxMarkMainBox.Size = new Size(93, 27);
            MaxMarkMainBox.TabIndex = 18;
            // 
            // NameMainBox
            // 
            NameMainBox.Location = new Point(121, 15);
            NameMainBox.Name = "NameMainBox";
            NameMainBox.Size = new Size(470, 27);
            NameMainBox.TabIndex = 20;
            // 
            // SpecialtyMainBox
            // 
            SpecialtyMainBox.Location = new Point(147, 188);
            SpecialtyMainBox.Name = "SpecialtyMainBox";
            SpecialtyMainBox.Size = new Size(447, 27);
            SpecialtyMainBox.TabIndex = 19;
            // 
            // Main
            // 
            ClientSize = new Size(1179, 1055);
            Controls.Add(MainPanel);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(SearchButton);
            Controls.Add(AdminFunctionsPanel);
            Name = "Main";
            Load += Main_Load;
            AdminFunctionsPanel.ResumeLayout(false);
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel AdminFunctionsPanel;
        private Button AddAdminButton;
        private Button SearchButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label14;
        private Label Money;
        private Label LearnForm;
        private Label MaxMark;
        private Label MinMark;
        private Label Specialty;
        private Label Address;
        private Label NameUniv;
        private Panel MainPanel;
        private ComboBox CityMainComboBox;
        private Label label24;
        private Label label7;
        private Label label1;
        private Label label19;
        private Label label2;
        private Label label20;
        private Label label3;
        private Label label21;
        private Label label4;
        private TextBox MaxMoneyMainBox;
        private Label label5;
        private TextBox MinMoneyMainBox;
        private ComboBox FormComboBox;
        private Label label22;
        private TextBox AddressMainBox;
        private TextBox MinMarkMainBox;
        private Label label6;
        private TextBox MaxMarkMainBox;
        private TextBox NameMainBox;
        private TextBox SpecialtyMainBox;
    }
}
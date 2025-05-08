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
            MoneyAdminBox = new TextBox();
            label7 = new Label();
            AddressAdminBox = new TextBox();
            label6 = new Label();
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            AdminFunctionsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // AdminFunctionsPanel
            // 
            AdminFunctionsPanel.Controls.Add(AddAdminButton);
            AdminFunctionsPanel.Location = new Point(393, 414);
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
            SearchButton.Location = new Point(139, 424);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(218, 67);
            SearchButton.TabIndex = 11;
            SearchButton.Text = "Пошук";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // MoneyAdminBox
            // 
            MoneyAdminBox.Location = new Point(403, 373);
            MoneyAdminBox.Name = "MoneyAdminBox";
            MoneyAdminBox.Size = new Size(298, 27);
            MoneyAdminBox.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(139, 375);
            label7.Name = "label7";
            label7.Size = new Size(258, 20);
            label7.TabIndex = 40;
            label7.Text = "Вартість навчання за рік (контракт):";
            // 
            // AddressAdminBox
            // 
            AddressAdminBox.Location = new Point(239, 136);
            AddressAdminBox.Name = "AddressAdminBox";
            AddressAdminBox.Size = new Size(462, 27);
            AddressAdminBox.TabIndex = 39;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(139, 139);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 38;
            label6.Text = "Адреса ВНЗ:";
            // 
            // nameAdminBox
            // 
            nameAdminBox.Location = new Point(231, 77);
            nameAdminBox.Name = "nameAdminBox";
            nameAdminBox.Size = new Size(470, 27);
            nameAdminBox.TabIndex = 37;
            // 
            // SpecialtyAdminBox
            // 
            SpecialtyAdminBox.Location = new Point(254, 195);
            SpecialtyAdminBox.Name = "SpecialtyAdminBox";
            SpecialtyAdminBox.Size = new Size(447, 27);
            SpecialtyAdminBox.TabIndex = 36;
            // 
            // MaxMarkAdminBox
            // 
            MaxMarkAdminBox.Location = new Point(606, 254);
            MaxMarkAdminBox.Name = "MaxMarkAdminBox";
            MaxMarkAdminBox.Size = new Size(93, 27);
            MaxMarkAdminBox.TabIndex = 35;
            // 
            // MinMarkAdminBox
            // 
            MinMarkAdminBox.Location = new Point(308, 254);
            MinMarkAdminBox.Name = "MinMarkAdminBox";
            MinMarkAdminBox.Size = new Size(93, 27);
            MinMarkAdminBox.TabIndex = 34;
            // 
            // FormComboBox
            // 
            FormComboBox.FormattingEnabled = true;
            FormComboBox.Items.AddRange(new object[] { "Денна", "Заочна", "Вечірня" });
            FormComboBox.Location = new Point(294, 313);
            FormComboBox.Name = "FormComboBox";
            FormComboBox.Size = new Size(242, 28);
            FormComboBox.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(139, 316);
            label5.Name = "label5";
            label5.Size = new Size(131, 20);
            label5.TabIndex = 32;
            label5.Text = "Форма навчання:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(423, 257);
            label4.Name = "label4";
            label4.Size = new Size(177, 20);
            label4.TabIndex = 31;
            label4.Text = "Максимальний конкурс:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(139, 257);
            label3.Name = "label3";
            label3.Size = new Size(163, 20);
            label3.TabIndex = 30;
            label3.Text = "Мінімальний конкурс:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 198);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 29;
            label2.Text = "Спеціальність:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 80);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 28;
            label1.Text = "Назва ВНЗ:";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(139, 522);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(560, 284);
            flowLayoutPanel1.TabIndex = 43;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // Main
            // 
            ClientSize = new Size(1179, 1055);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(MoneyAdminBox);
            Controls.Add(label7);
            Controls.Add(AddressAdminBox);
            Controls.Add(label6);
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
            Controls.Add(SearchButton);
            Controls.Add(AdminFunctionsPanel);
            Name = "Main";
            Load += Main_Load;
            AdminFunctionsPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel AdminFunctionsPanel;
        private Button AddAdminButton;
        private Button SearchButton;
        private TextBox MoneyAdminBox;
        private Label label7;
        private TextBox AddressAdminBox;
        private Label label6;
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
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label Money;
        private Label LearnForm;
        private Label MaxMark;
        private Label MinMark;
        private Label Specialty;
        private Label Address;
        private Label NameUniv;
    }
}
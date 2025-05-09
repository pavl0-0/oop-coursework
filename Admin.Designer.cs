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
            ClearButtonAdmin = new Button();
            ExitAdminButton = new Button();
            label6 = new Label();
            AddressAdminBox = new TextBox();
            AdminPanelButton = new Panel();
            SearchButtonAdmin = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            AdminEditButton = new Panel();
            ExitEdit = new Button();
            CleanEdit = new Button();
            SaveEdit = new Button();
            AdminPanel = new Panel();
            MoneyAdminBox = new TextBox();
            label15 = new Label();
            AdminCityComboBox = new ComboBox();
            label24 = new Label();
            label7 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            MaxMoneyAdminBox = new TextBox();
            MinMoneyAdminBox = new TextBox();
            label22 = new Label();
            AdminEditPanel = new Panel();
            EditCityComboBox = new ComboBox();
            label23 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            MoneyEditAdminBox = new TextBox();
            label12 = new Label();
            label13 = new Label();
            FormEditComboBox = new ComboBox();
            AddressEditAdminBox = new TextBox();
            MinMarkEditAdminBox = new TextBox();
            label14 = new Label();
            MaxMarkEditAdminBox = new TextBox();
            nameEditAdminBox = new TextBox();
            SpecialtyEditAdminBox = new TextBox();
            AdminPanelButton.SuspendLayout();
            AdminEditButton.SuspendLayout();
            AdminPanel.SuspendLayout();
            AdminEditPanel.SuspendLayout();
            SuspendLayout();
            // 
            // nameAdminBox
            // 
            nameAdminBox.Location = new Point(121, 15);
            nameAdminBox.Name = "nameAdminBox";
            nameAdminBox.Size = new Size(470, 27);
            nameAdminBox.TabIndex = 20;
            // 
            // SpecialtyAdminBox
            // 
            SpecialtyAdminBox.Location = new Point(147, 188);
            SpecialtyAdminBox.Name = "SpecialtyAdminBox";
            SpecialtyAdminBox.Size = new Size(447, 27);
            SpecialtyAdminBox.TabIndex = 19;
            // 
            // MaxMarkAdminBox
            // 
            MaxMarkAdminBox.Location = new Point(499, 255);
            MaxMarkAdminBox.Name = "MaxMarkAdminBox";
            MaxMarkAdminBox.Size = new Size(93, 27);
            MaxMarkAdminBox.TabIndex = 18;
            // 
            // MinMarkAdminBox
            // 
            MinMarkAdminBox.Location = new Point(201, 255);
            MinMarkAdminBox.Name = "MinMarkAdminBox";
            MinMarkAdminBox.Size = new Size(93, 27);
            MinMarkAdminBox.TabIndex = 17;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 313);
            label5.Name = "label5";
            label5.Size = new Size(131, 20);
            label5.TabIndex = 15;
            label5.Text = "Форма навчання:";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 258);
            label3.Name = "label3";
            label3.Size = new Size(163, 20);
            label3.TabIndex = 13;
            label3.Text = "Мінімальний конкурс:";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 18);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 11;
            label1.Text = "Назва ВНЗ:";
            // 
            // SaveAdminButton
            // 
            SaveAdminButton.Location = new Point(299, 13);
            SaveAdminButton.Name = "SaveAdminButton";
            SaveAdminButton.Size = new Size(213, 61);
            SaveAdminButton.TabIndex = 21;
            SaveAdminButton.Text = "Зберегти дані";
            SaveAdminButton.UseVisualStyleBackColor = true;
            SaveAdminButton.Click += SaveAdminButton_Click;
            // 
            // ClearButtonAdmin
            // 
            ClearButtonAdmin.Location = new Point(569, 13);
            ClearButtonAdmin.Name = "ClearButtonAdmin";
            ClearButtonAdmin.Size = new Size(213, 61);
            ClearButtonAdmin.TabIndex = 22;
            ClearButtonAdmin.Text = "Очистити поля";
            ClearButtonAdmin.UseVisualStyleBackColor = true;
            ClearButtonAdmin.Click += ClearButtonAdmin_Click;
            // 
            // ExitAdminButton
            // 
            ExitAdminButton.Location = new Point(839, 13);
            ExitAdminButton.Name = "ExitAdminButton";
            ExitAdminButton.Size = new Size(213, 61);
            ExitAdminButton.TabIndex = 23;
            ExitAdminButton.Text = "Вийти";
            ExitAdminButton.UseVisualStyleBackColor = true;
            ExitAdminButton.Click += ExitAdminButton_Click;
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
            // AddressAdminBox
            // 
            AddressAdminBox.Location = new Point(132, 133);
            AddressAdminBox.Name = "AddressAdminBox";
            AddressAdminBox.Size = new Size(462, 27);
            AddressAdminBox.TabIndex = 25;
            // 
            // AdminPanelButton
            // 
            AdminPanelButton.Controls.Add(SearchButtonAdmin);
            AdminPanelButton.Controls.Add(ExitAdminButton);
            AdminPanelButton.Controls.Add(ClearButtonAdmin);
            AdminPanelButton.Controls.Add(SaveAdminButton);
            AdminPanelButton.Location = new Point(54, 544);
            AdminPanelButton.Name = "AdminPanelButton";
            AdminPanelButton.Size = new Size(1081, 88);
            AdminPanelButton.TabIndex = 28;
            // 
            // SearchButtonAdmin
            // 
            SearchButtonAdmin.Location = new Point(29, 13);
            SearchButtonAdmin.Name = "SearchButtonAdmin";
            SearchButtonAdmin.Size = new Size(213, 61);
            SearchButtonAdmin.TabIndex = 29;
            SearchButtonAdmin.Text = "Пошук";
            SearchButtonAdmin.UseVisualStyleBackColor = true;
            SearchButtonAdmin.Click += SearchButtonAdmin_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(54, 638);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(745, 219);
            flowLayoutPanel1.TabIndex = 44;
            flowLayoutPanel1.WrapContents = false;
            // 
            // AdminEditButton
            // 
            AdminEditButton.Controls.Add(ExitEdit);
            AdminEditButton.Controls.Add(CleanEdit);
            AdminEditButton.Controls.Add(SaveEdit);
            AdminEditButton.Location = new Point(54, 545);
            AdminEditButton.Name = "AdminEditButton";
            AdminEditButton.Size = new Size(882, 87);
            AdminEditButton.TabIndex = 45;
            // 
            // ExitEdit
            // 
            ExitEdit.Location = new Point(640, 13);
            ExitEdit.Name = "ExitEdit";
            ExitEdit.Size = new Size(213, 61);
            ExitEdit.TabIndex = 23;
            ExitEdit.Text = "Вийти";
            ExitEdit.UseVisualStyleBackColor = true;
            ExitEdit.Click += ExitEdit_Click;
            // 
            // CleanEdit
            // 
            CleanEdit.Location = new Point(335, 13);
            CleanEdit.Name = "CleanEdit";
            CleanEdit.Size = new Size(213, 61);
            CleanEdit.TabIndex = 22;
            CleanEdit.Text = "Очистити поля";
            CleanEdit.UseVisualStyleBackColor = true;
            CleanEdit.Click += CleanEdit_Click;
            // 
            // SaveEdit
            // 
            SaveEdit.Location = new Point(30, 13);
            SaveEdit.Name = "SaveEdit";
            SaveEdit.Size = new Size(213, 61);
            SaveEdit.TabIndex = 21;
            SaveEdit.Text = "Зберегти дані";
            SaveEdit.UseVisualStyleBackColor = true;
            SaveEdit.Click += SaveEdit_Click;
            // 
            // AdminPanel
            // 
            AdminPanel.Controls.Add(MoneyAdminBox);
            AdminPanel.Controls.Add(label15);
            AdminPanel.Controls.Add(AdminCityComboBox);
            AdminPanel.Controls.Add(label24);
            AdminPanel.Controls.Add(label7);
            AdminPanel.Controls.Add(label1);
            AdminPanel.Controls.Add(label19);
            AdminPanel.Controls.Add(label2);
            AdminPanel.Controls.Add(label20);
            AdminPanel.Controls.Add(label3);
            AdminPanel.Controls.Add(label21);
            AdminPanel.Controls.Add(label4);
            AdminPanel.Controls.Add(MaxMoneyAdminBox);
            AdminPanel.Controls.Add(label5);
            AdminPanel.Controls.Add(MinMoneyAdminBox);
            AdminPanel.Controls.Add(FormComboBox);
            AdminPanel.Controls.Add(label22);
            AdminPanel.Controls.Add(AddressAdminBox);
            AdminPanel.Controls.Add(MinMarkAdminBox);
            AdminPanel.Controls.Add(label6);
            AdminPanel.Controls.Add(MaxMarkAdminBox);
            AdminPanel.Controls.Add(nameAdminBox);
            AdminPanel.Controls.Add(SpecialtyAdminBox);
            AdminPanel.Location = new Point(54, 42);
            AdminPanel.Name = "AdminPanel";
            AdminPanel.Size = new Size(622, 463);
            AdminPanel.TabIndex = 46;
            // 
            // MoneyAdminBox
            // 
            MoneyAdminBox.Location = new Point(296, 422);
            MoneyAdminBox.Name = "MoneyAdminBox";
            MoneyAdminBox.Size = new Size(150, 27);
            MoneyAdminBox.TabIndex = 58;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(32, 425);
            label15.Name = "label15";
            label15.Size = new Size(258, 20);
            label15.TabIndex = 57;
            label15.Text = "Вартість навчання за рік (контракт):";
            // 
            // AdminCityComboBox
            // 
            AdminCityComboBox.FormattingEnabled = true;
            AdminCityComboBox.Items.AddRange(new object[] { "Денна", "Заочна", "Вечірня" });
            AdminCityComboBox.Location = new Point(121, 71);
            AdminCityComboBox.Name = "AdminCityComboBox";
            AdminCityComboBox.Size = new Size(242, 28);
            AdminCityComboBox.TabIndex = 56;
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
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(410, 370);
            label19.Name = "label19";
            label19.Size = new Size(36, 20);
            label19.TabIndex = 53;
            label19.Text = "грн.";
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
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(296, 369);
            label21.Name = "label21";
            label21.Size = new Size(32, 20);
            label21.TabIndex = 51;
            label21.Text = "від:";
            // 
            // MaxMoneyAdminBox
            // 
            MaxMoneyAdminBox.Location = new Point(483, 366);
            MaxMoneyAdminBox.Name = "MaxMoneyAdminBox";
            MaxMoneyAdminBox.Size = new Size(70, 27);
            MaxMoneyAdminBox.TabIndex = 50;
            // 
            // MinMoneyAdminBox
            // 
            MinMoneyAdminBox.Location = new Point(334, 366);
            MinMoneyAdminBox.Name = "MinMoneyAdminBox";
            MinMoneyAdminBox.Size = new Size(70, 27);
            MinMoneyAdminBox.TabIndex = 49;
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
            // AdminEditPanel
            // 
            AdminEditPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AdminEditPanel.Controls.Add(EditCityComboBox);
            AdminEditPanel.Controls.Add(label23);
            AdminEditPanel.Controls.Add(label8);
            AdminEditPanel.Controls.Add(label9);
            AdminEditPanel.Controls.Add(label10);
            AdminEditPanel.Controls.Add(label11);
            AdminEditPanel.Controls.Add(MoneyEditAdminBox);
            AdminEditPanel.Controls.Add(label12);
            AdminEditPanel.Controls.Add(label13);
            AdminEditPanel.Controls.Add(FormEditComboBox);
            AdminEditPanel.Controls.Add(AddressEditAdminBox);
            AdminEditPanel.Controls.Add(MinMarkEditAdminBox);
            AdminEditPanel.Controls.Add(label14);
            AdminEditPanel.Controls.Add(MaxMarkEditAdminBox);
            AdminEditPanel.Controls.Add(nameEditAdminBox);
            AdminEditPanel.Controls.Add(SpecialtyEditAdminBox);
            AdminEditPanel.Location = new Point(756, 42);
            AdminEditPanel.Name = "AdminEditPanel";
            AdminEditPanel.Size = new Size(622, 409);
            AdminEditPanel.TabIndex = 47;
            // 
            // EditCityComboBox
            // 
            EditCityComboBox.FormattingEnabled = true;
            EditCityComboBox.Items.AddRange(new object[] { "Денна", "Заочна", "Вечірня" });
            EditCityComboBox.Location = new Point(135, 71);
            EditCityComboBox.Name = "EditCityComboBox";
            EditCityComboBox.Size = new Size(242, 28);
            EditCityComboBox.TabIndex = 34;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(32, 74);
            label23.Name = "label23";
            label23.Size = new Size(51, 20);
            label23.TabIndex = 33;
            label23.Text = "Місто:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 18);
            label8.Name = "label8";
            label8.Size = new Size(86, 20);
            label8.TabIndex = 11;
            label8.Text = "Назва ВНЗ:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(32, 191);
            label9.Name = "label9";
            label9.Size = new Size(109, 20);
            label9.TabIndex = 12;
            label9.Text = "Спеціальність:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(32, 258);
            label10.Name = "label10";
            label10.Size = new Size(163, 20);
            label10.TabIndex = 13;
            label10.Text = "Мінімальний конкурс:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(321, 258);
            label11.Name = "label11";
            label11.Size = new Size(177, 20);
            label11.TabIndex = 14;
            label11.Text = "Максимальний конкурс:";
            // 
            // MoneyEditAdminBox
            // 
            MoneyEditAdminBox.Location = new Point(296, 366);
            MoneyEditAdminBox.Name = "MoneyEditAdminBox";
            MoneyEditAdminBox.Size = new Size(136, 27);
            MoneyEditAdminBox.TabIndex = 27;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(32, 313);
            label12.Name = "label12";
            label12.Size = new Size(131, 20);
            label12.TabIndex = 15;
            label12.Text = "Форма навчання:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(32, 369);
            label13.Name = "label13";
            label13.Size = new Size(258, 20);
            label13.TabIndex = 26;
            label13.Text = "Вартість навчання за рік (контракт):";
            // 
            // FormEditComboBox
            // 
            FormEditComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FormEditComboBox.FormattingEnabled = true;
            FormEditComboBox.Items.AddRange(new object[] { "Денна", "Заочна", "Вечірня" });
            FormEditComboBox.Location = new Point(190, 310);
            FormEditComboBox.Name = "FormEditComboBox";
            FormEditComboBox.Size = new Size(242, 28);
            FormEditComboBox.TabIndex = 16;
            // 
            // AddressEditAdminBox
            // 
            AddressEditAdminBox.Location = new Point(135, 133);
            AddressEditAdminBox.Name = "AddressEditAdminBox";
            AddressEditAdminBox.Size = new Size(462, 27);
            AddressEditAdminBox.TabIndex = 25;
            // 
            // MinMarkEditAdminBox
            // 
            MinMarkEditAdminBox.Location = new Point(201, 255);
            MinMarkEditAdminBox.Name = "MinMarkEditAdminBox";
            MinMarkEditAdminBox.Size = new Size(93, 27);
            MinMarkEditAdminBox.TabIndex = 17;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(32, 136);
            label14.Name = "label14";
            label14.Size = new Size(94, 20);
            label14.TabIndex = 24;
            label14.Text = "Адреса ВНЗ:";
            // 
            // MaxMarkEditAdminBox
            // 
            MaxMarkEditAdminBox.Location = new Point(504, 255);
            MaxMarkEditAdminBox.Name = "MaxMarkEditAdminBox";
            MaxMarkEditAdminBox.Size = new Size(93, 27);
            MaxMarkEditAdminBox.TabIndex = 18;
            // 
            // nameEditAdminBox
            // 
            nameEditAdminBox.Location = new Point(124, 15);
            nameEditAdminBox.Name = "nameEditAdminBox";
            nameEditAdminBox.Size = new Size(470, 27);
            nameEditAdminBox.TabIndex = 20;
            // 
            // SpecialtyEditAdminBox
            // 
            SpecialtyEditAdminBox.Location = new Point(150, 188);
            SpecialtyEditAdminBox.Name = "SpecialtyEditAdminBox";
            SpecialtyEditAdminBox.Size = new Size(447, 27);
            SpecialtyEditAdminBox.TabIndex = 19;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1537, 869);
            Controls.Add(AdminEditPanel);
            Controls.Add(AdminEditButton);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(AdminPanelButton);
            Controls.Add(AdminPanel);
            Name = "Admin";
            Text = "Admin";
            AdminPanelButton.ResumeLayout(false);
            AdminEditButton.ResumeLayout(false);
            AdminPanel.ResumeLayout(false);
            AdminPanel.PerformLayout();
            AdminEditPanel.ResumeLayout(false);
            AdminEditPanel.PerformLayout();
            ResumeLayout(false);
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
        private Button ClearButtonAdmin;
        private Button ExitAdminButton;
        private Label label6;
        private TextBox AddressAdminBox;
        private Panel AdminPanelButton;
        private Button SearchButtonAdmin;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel AdminEditButton;
        private Button ExitEdit;
        private Button CleanEdit;
        private Button SaveEdit;
        private Panel AdminPanel;
        private Panel AdminEditPanel;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox MoneyEditAdminBox;
        private Label label12;
        private Label label13;
        private ComboBox FormEditComboBox;
        private TextBox AddressEditAdminBox;
        private TextBox MinMarkEditAdminBox;
        private Label label14;
        private TextBox MaxMarkEditAdminBox;
        private TextBox nameEditAdminBox;
        private TextBox SpecialtyEditAdminBox;
        private Label label7;
        private Label label19;
        private Label label20;
        private Label label21;
        private TextBox MaxMoneyAdminBox;
        private TextBox MinMoneyAdminBox;
        private Label label22;
        private ComboBox EditCityComboBox;
        private Label label23;
        private ComboBox AdminCityComboBox;
        private Label label24;
        private Label label15;
        private TextBox MoneyAdminBox;
    }
}
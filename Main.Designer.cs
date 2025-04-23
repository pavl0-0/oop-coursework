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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            AdminFunctionsPanel = new Panel();
            DeleteAdminButton = new Button();
            ChangeAdminButton = new Button();
            AddAdminButton = new Button();
            SearchButton = new Button();
            AdminFunctionsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 116);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 0;
            label1.Text = "Назва ВНЗ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 175);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 1;
            label2.Text = "Спеціальність:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(108, 239);
            label3.Name = "label3";
            label3.Size = new Size(163, 20);
            label3.TabIndex = 2;
            label3.Text = "Мінімальний конкурс:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(394, 239);
            label4.Name = "label4";
            label4.Size = new Size(177, 20);
            label4.TabIndex = 3;
            label4.Text = "Максимальний конкурс:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(108, 307);
            label5.Name = "label5";
            label5.Size = new Size(131, 20);
            label5.TabIndex = 4;
            label5.Text = "Форма навчання:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Денна", "Заочна", "Вечірня" });
            comboBox1.Location = new Point(265, 304);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 28);
            comboBox1.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(277, 236);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(93, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(577, 236);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(93, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(223, 172);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(447, 27);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(200, 113);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(470, 27);
            textBox4.TabIndex = 9;
            // 
            // AdminFunctionsPanel
            // 
            AdminFunctionsPanel.Controls.Add(DeleteAdminButton);
            AdminFunctionsPanel.Controls.Add(ChangeAdminButton);
            AdminFunctionsPanel.Controls.Add(AddAdminButton);
            AdminFunctionsPanel.Location = new Point(767, 80);
            AdminFunctionsPanel.Name = "AdminFunctionsPanel";
            AdminFunctionsPanel.Size = new Size(270, 366);
            AdminFunctionsPanel.TabIndex = 10;
            // 
            // DeleteAdminButton
            // 
            DeleteAdminButton.Location = new Point(35, 270);
            DeleteAdminButton.Name = "DeleteAdminButton";
            DeleteAdminButton.Size = new Size(200, 65);
            DeleteAdminButton.TabIndex = 2;
            DeleteAdminButton.Text = "Видалити дані про ВНЗ";
            DeleteAdminButton.UseVisualStyleBackColor = true;
            // 
            // ChangeAdminButton
            // 
            ChangeAdminButton.Location = new Point(35, 151);
            ChangeAdminButton.Name = "ChangeAdminButton";
            ChangeAdminButton.Size = new Size(200, 65);
            ChangeAdminButton.TabIndex = 1;
            ChangeAdminButton.Text = "Змінити дані про ВНЗ";
            ChangeAdminButton.UseVisualStyleBackColor = true;
            // 
            // AddAdminButton
            // 
            AddAdminButton.Location = new Point(35, 27);
            AddAdminButton.Name = "AddAdminButton";
            AddAdminButton.Size = new Size(200, 65);
            AddAdminButton.TabIndex = 0;
            AddAdminButton.Text = "Додати дані про ВНЗ";
            AddAdminButton.UseVisualStyleBackColor = true;
            AddAdminButton.Click += AddAdminButton_Click;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(108, 359);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(218, 67);
            SearchButton.TabIndex = 11;
            SearchButton.Text = "Пошук";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // Main
            // 
            ClientSize = new Size(1179, 500);
            Controls.Add(SearchButton);
            Controls.Add(AdminFunctionsPanel);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Main";
            Load += Main_Load;
            AdminFunctionsPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Panel AdminFunctionsPanel;
        private Button DeleteAdminButton;
        private Button ChangeAdminButton;
        private Button AddAdminButton;
        private Button SearchButton;
    }
}
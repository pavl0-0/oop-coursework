namespace CourseWork
{
    partial class Applicants_Handbook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Applicants_Handbook));
            RegistrationMainButton = new Button();
            LogInMainButton = new Button();
            mainTitleLabel = new Label();
            SuspendLayout();
            // 
            // RegistrationMainButton
            // 
            RegistrationMainButton.BackColor = Color.SteelBlue;
            RegistrationMainButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(RegistrationMainButton, "RegistrationMainButton");
            RegistrationMainButton.ForeColor = Color.White;
            RegistrationMainButton.Name = "RegistrationMainButton";
            RegistrationMainButton.UseVisualStyleBackColor = false;
            RegistrationMainButton.Click += RegistrationMainButton_Click;
            // 
            // LogInMainButton
            // 
            LogInMainButton.BackColor = Color.ForestGreen;
            LogInMainButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(LogInMainButton, "LogInMainButton");
            LogInMainButton.ForeColor = Color.White;
            LogInMainButton.Name = "LogInMainButton";
            LogInMainButton.UseVisualStyleBackColor = false;
            LogInMainButton.Click += LogInMainButton_Click;
            // 
            // mainTitleLabel
            // 
            resources.ApplyResources(mainTitleLabel, "mainTitleLabel");
            mainTitleLabel.ForeColor = Color.DarkSlateBlue;
            mainTitleLabel.Name = "mainTitleLabel";
            // 
            // Applicants_Handbook
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            Controls.Add(mainTitleLabel);
            Controls.Add(LogInMainButton);
            Controls.Add(RegistrationMainButton);
            Name = "Applicants_Handbook";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RegistrationMainButton;
        private Button LogInMainButton;
        private Label mainTitleLabel;
    }
}
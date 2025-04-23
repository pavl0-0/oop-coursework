namespace CourseWork
{
    partial class Applicants_Handbook
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Applicants_Handbook));
            RegistrationMainButton = new Button();
            LogInMainButton = new Button();
            SuspendLayout();
            // 
            // RegistrationMainButton
            // 
            resources.ApplyResources(RegistrationMainButton, "RegistrationMainButton");
            RegistrationMainButton.Name = "RegistrationMainButton";
            RegistrationMainButton.UseVisualStyleBackColor = true;
            RegistrationMainButton.Click += RegistrationMainButton_Click;
            // 
            // LogInMainButton
            // 
            resources.ApplyResources(LogInMainButton, "LogInMainButton");
            LogInMainButton.Name = "LogInMainButton";
            LogInMainButton.UseVisualStyleBackColor = true;
            LogInMainButton.Click += LogInMainButton_Click;
            // 
            // Applicants_Handbook
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(LogInMainButton);
            Controls.Add(RegistrationMainButton);
            Name = "Applicants_Handbook";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button RegistrationMainButton;
        private Button LogInMainButton;
    }
}

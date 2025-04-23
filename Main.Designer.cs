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
            button1 = new Button();
            AdminFunctionsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // AdminFunctionsPanel
            // 
            AdminFunctionsPanel.Controls.Add(button1);
            AdminFunctionsPanel.Location = new Point(121, 128);
            AdminFunctionsPanel.Name = "AdminFunctionsPanel";
            AdminFunctionsPanel.Size = new Size(326, 152);
            AdminFunctionsPanel.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(69, 49);
            button1.Name = "button1";
            button1.Size = new Size(202, 66);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            ClientSize = new Size(517, 385);
            Controls.Add(AdminFunctionsPanel);
            Name = "Main";
            Load += Main_Load;
            AdminFunctionsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel AdminFunctionsPanel;
        private Button button1;
    }
}
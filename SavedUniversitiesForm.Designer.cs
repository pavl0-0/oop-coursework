namespace CourseWork
{
    partial class SavedUniversitiesForm
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
            DeleteSavedButton = new Button();
            flowLayoutPanelSaved = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // DeleteSavedButton
            // 
            DeleteSavedButton.Location = new Point(269, 96);
            DeleteSavedButton.Name = "DeleteSavedButton";
            DeleteSavedButton.Size = new Size(148, 51);
            DeleteSavedButton.TabIndex = 0;
            DeleteSavedButton.Text = "button1";
            DeleteSavedButton.UseVisualStyleBackColor = true;
            DeleteSavedButton.Click += DeleteSavedButton_Click;
            // 
            // flowLayoutPanelSaved
            // 
            flowLayoutPanelSaved.AutoScroll = true;
            flowLayoutPanelSaved.Dock = DockStyle.Fill;
            flowLayoutPanelSaved.Location = new Point(0, 0);
            flowLayoutPanelSaved.Name = "flowLayoutPanelSaved";
            flowLayoutPanelSaved.Size = new Size(800, 450);
            flowLayoutPanelSaved.TabIndex = 0;
            // 
            // SavedUniversitiesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanelSaved);
            Controls.Add(DeleteSavedButton);
            Name = "SavedUniversitiesForm";
            Text = "SavedUniversitiesForm";
            ResumeLayout(false);
        }

        #endregion

        private Button DeleteSavedButton;
        private FlowLayoutPanel flowLayoutPanelSaved;
    }
}
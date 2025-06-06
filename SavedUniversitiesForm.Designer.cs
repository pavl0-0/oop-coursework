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
            flowLayoutPanelSaved = new FlowLayoutPanel();
            ExportAllButton = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanelSaved
            // 
            flowLayoutPanelSaved.AutoScroll = true;
            flowLayoutPanelSaved.Location = new Point(1, 71);
            flowLayoutPanelSaved.Name = "flowLayoutPanelSaved";
            flowLayoutPanelSaved.Size = new Size(800, 450);
            flowLayoutPanelSaved.TabIndex = 0;
            // 
            // ExportAllButton
            // 
            ExportAllButton.Location = new Point(12, 12);
            ExportAllButton.Name = "ExportAllButton";
            ExportAllButton.Size = new Size(204, 53);
            ExportAllButton.TabIndex = 1;
            ExportAllButton.Text = "Експортувати";
            ExportAllButton.UseVisualStyleBackColor = true;
            ExportAllButton.Click += ExportAllButton_Click;
            // 
            // SavedUniversitiesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 519);
            Controls.Add(ExportAllButton);
            Controls.Add(flowLayoutPanelSaved);
            Name = "SavedUniversitiesForm";
            Text = "SavedUniversitiesForm";
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanelSaved;
        private Button ExportAllButton;
    }
}
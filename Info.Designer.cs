namespace CourseWork
{
    partial class Info
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelNameFull = new Label();
            labelAddressFull = new Label();
            labelSpecialtiesFull = new Label();
            labelMarksFull = new Label();
            labelLearnFormFull = new Label();
            labelMoneyFull = new Label();
            textBoxDescriptionFull = new TextBox();
            pictureBoxUniversity = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUniversity).BeginInit();
            SuspendLayout();
            // 
            // labelNameFull
            // 
            labelNameFull.AutoSize = true;
            labelNameFull.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelNameFull.Location = new Point(20, 20);
            labelNameFull.Name = "labelNameFull";
            labelNameFull.Size = new Size(141, 28);
            labelNameFull.TabIndex = 0;
            labelNameFull.Text = "Повна назва:";
            // 
            // labelAddressFull
            // 
            labelAddressFull.AutoSize = true;
            labelAddressFull.Location = new Point(20, 60);
            labelAddressFull.Name = "labelAddressFull";
            labelAddressFull.Size = new Size(109, 20);
            labelAddressFull.TabIndex = 1;
            labelAddressFull.Text = "Повна адреса:";
            // 
            // labelSpecialtiesFull
            // 
            labelSpecialtiesFull.AutoSize = true;
            labelSpecialtiesFull.Location = new Point(20, 100);
            labelSpecialtiesFull.Name = "labelSpecialtiesFull";
            labelSpecialtiesFull.Size = new Size(153, 20);
            labelSpecialtiesFull.TabIndex = 2;
            labelSpecialtiesFull.Text = "Повні спеціальності:";
            // 
            // labelMarksFull
            // 
            labelMarksFull.AutoSize = true;
            labelMarksFull.Location = new Point(20, 140);
            labelMarksFull.Name = "labelMarksFull";
            labelMarksFull.Size = new Size(125, 20);
            labelMarksFull.TabIndex = 3;
            labelMarksFull.Text = "Повні бали ЗНО:";
            // 
            // labelLearnFormFull
            // 
            labelLearnFormFull.AutoSize = true;
            labelLearnFormFull.Location = new Point(20, 180);
            labelLearnFormFull.Name = "labelLearnFormFull";
            labelLearnFormFull.Size = new Size(179, 20);
            labelLearnFormFull.TabIndex = 4;
            labelLearnFormFull.Text = "Повна форма навчання:";
            // 
            // labelMoneyFull
            // 
            labelMoneyFull.AutoSize = true;
            labelMoneyFull.Location = new Point(20, 220);
            labelMoneyFull.Name = "labelMoneyFull";
            labelMoneyFull.Size = new Size(151, 20);
            labelMoneyFull.TabIndex = 5;
            labelMoneyFull.Text = "Повна вартість (рік):";
            // 
            // textBoxDescriptionFull
            // 
            textBoxDescriptionFull.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDescriptionFull.Location = new Point(20, 260);
            textBoxDescriptionFull.Multiline = true;
            textBoxDescriptionFull.Name = "textBoxDescriptionFull";
            textBoxDescriptionFull.ReadOnly = true;
            textBoxDescriptionFull.ScrollBars = ScrollBars.Vertical;
            textBoxDescriptionFull.Size = new Size(1442, 220);
            textBoxDescriptionFull.TabIndex = 6;
            textBoxDescriptionFull.Text = "Повний опис...";
            // 
            // pictureBoxUniversity
            // 
            pictureBoxUniversity.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxUniversity.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxUniversity.Location = new Point(1162, 20);
            pictureBoxUniversity.Name = "pictureBoxUniversity";
            pictureBoxUniversity.Size = new Size(300, 200);
            pictureBoxUniversity.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxUniversity.TabIndex = 7;
            pictureBoxUniversity.TabStop = false;
            // 
            // Info
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 500);
            Controls.Add(pictureBoxUniversity);
            Controls.Add(textBoxDescriptionFull);
            Controls.Add(labelMoneyFull);
            Controls.Add(labelLearnFormFull);
            Controls.Add(labelMarksFull);
            Controls.Add(labelSpecialtiesFull);
            Controls.Add(labelAddressFull);
            Controls.Add(labelNameFull);
            Name = "Info";
            Text = "Деталі університету";
            Load += Info_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxUniversity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label labelNameFull;
        private System.Windows.Forms.Label labelAddressFull;
        private System.Windows.Forms.Label labelSpecialtiesFull;
        private System.Windows.Forms.Label labelMarksFull;
        private System.Windows.Forms.Label labelLearnFormFull;
        private System.Windows.Forms.Label labelMoneyFull;
        private System.Windows.Forms.TextBox textBoxDescriptionFull;
        private System.Windows.Forms.PictureBox pictureBoxUniversity;
    }
}
namespace CourseWork
{
    partial class Info
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(275, 144);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 10;
            label1.Text = "Назва ВНЗ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(275, 203);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 11;
            label2.Text = "Спеціальність:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(275, 267);
            label3.Name = "label3";
            label3.Size = new Size(163, 20);
            label3.TabIndex = 12;
            label3.Text = "Мінімальний конкурс:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(561, 267);
            label4.Name = "label4";
            label4.Size = new Size(177, 20);
            label4.TabIndex = 13;
            label4.Text = "Максимальний конкурс:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(275, 335);
            label5.Name = "label5";
            label5.Size = new Size(131, 20);
            label5.TabIndex = 14;
            label5.Text = "Форма навчання:";
            // 
            // Info
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 563);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Info";
            Text = "Info";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
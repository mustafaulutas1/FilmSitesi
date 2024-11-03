namespace FinalOdevi.Formlar
{
    partial class DegerlendirmeYapFormu
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
            degerlendirmeYapButton = new Button();
            label2 = new Label();
            puan_textbox = new TextBox();
            degerlendirme_textbox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 96);
            label1.Name = "label1";
            label1.Size = new Size(240, 32);
            label1.TabIndex = 0;
            label1.Text = "Değerlendirme Puanı";
            // 
            // degerlendirmeYapButton
            // 
            degerlendirmeYapButton.Location = new Point(463, 334);
            degerlendirmeYapButton.Name = "degerlendirmeYapButton";
            degerlendirmeYapButton.Size = new Size(288, 46);
            degerlendirmeYapButton.TabIndex = 1;
            degerlendirmeYapButton.Text = "Değerlendirme Yap";
            degerlendirmeYapButton.UseVisualStyleBackColor = true;
            degerlendirmeYapButton.Click += degerlendirmeYapButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 170);
            label2.Name = "label2";
            label2.Size = new Size(174, 32);
            label2.TabIndex = 2;
            label2.Text = "Değerlendirme";
            // 
            // puan_textbox
            // 
            puan_textbox.Location = new Point(463, 89);
            puan_textbox.Name = "puan_textbox";
            puan_textbox.Size = new Size(288, 39);
            puan_textbox.TabIndex = 3;
            // 
            // degerlendirme_textbox
            // 
            degerlendirme_textbox.Location = new Point(463, 170);
            degerlendirme_textbox.Multiline = true;
            degerlendirme_textbox.Name = "degerlendirme_textbox";
            degerlendirme_textbox.Size = new Size(288, 78);
            degerlendirme_textbox.TabIndex = 4;
            degerlendirme_textbox.TextChanged += textBox2_TextChanged;
            // 
            // DegerlendirmeYapFormu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(degerlendirme_textbox);
            Controls.Add(puan_textbox);
            Controls.Add(label2);
            Controls.Add(degerlendirmeYapButton);
            Controls.Add(label1);
            Name = "DegerlendirmeYapFormu";
            Text = "Değerlendirme Yap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button degerlendirmeYapButton;
        private Label label2;
        private TextBox puan_textbox;
        private TextBox degerlendirme_textbox;
    }
}
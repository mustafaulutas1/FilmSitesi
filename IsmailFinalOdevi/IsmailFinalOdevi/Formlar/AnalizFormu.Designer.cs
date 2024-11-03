namespace FinalOdevi.Formlar
{
    partial class AnalizFormu
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
            enCokDegerlendirilenFilmLabel = new Label();
            enYuksekPuanliFilmLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 92);
            label1.Name = "label1";
            label1.Size = new Size(331, 32);
            label1.TabIndex = 0;
            label1.Text = "En Çok Değerlendirilen Film : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 184);
            label2.Name = "label2";
            label2.Size = new Size(264, 32);
            label2.TabIndex = 1;
            label2.Text = "En Yüksek Puanlı Film : ";
            // 
            // enCokDegerlendirilenFilmLabel
            // 
            enCokDegerlendirilenFilmLabel.AutoSize = true;
            enCokDegerlendirilenFilmLabel.Location = new Point(473, 92);
            enCokDegerlendirilenFilmLabel.Name = "enCokDegerlendirilenFilmLabel";
            enCokDegerlendirilenFilmLabel.Size = new Size(0, 32);
            enCokDegerlendirilenFilmLabel.TabIndex = 2;
            // 
            // enYuksekPuanliFilmLabel
            // 
            enYuksekPuanliFilmLabel.AutoSize = true;
            enYuksekPuanliFilmLabel.Location = new Point(473, 184);
            enYuksekPuanliFilmLabel.Name = "enYuksekPuanliFilmLabel";
            enYuksekPuanliFilmLabel.Size = new Size(0, 32);
            enYuksekPuanliFilmLabel.TabIndex = 3;
            // 
            // AnalizFormu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 554);
            Controls.Add(enYuksekPuanliFilmLabel);
            Controls.Add(enCokDegerlendirilenFilmLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AnalizFormu";
            Text = "Film Analizi - Film Kitaplığı";
            Load += AnalizFormu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label enCokDegerlendirilenFilmLabel;
        private Label enYuksekPuanliFilmLabel;
    }
}
namespace FinalOdevi
{
    partial class GirisFormu
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
            label1 = new Label();
            label2 = new Label();
            kullaniciAdiTextBox = new TextBox();
            sifreTextBox = new TextBox();
            button_girisYap = new Button();
            button_kayitOl = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(295, 196);
            label1.Name = "label1";
            label1.Size = new Size(145, 32);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(715, 196);
            label2.Name = "label2";
            label2.Size = new Size(62, 32);
            label2.TabIndex = 1;
            label2.Text = "Şifre";
            // 
            // kullaniciAdiTextBox
            // 
            kullaniciAdiTextBox.Location = new Point(295, 258);
            kullaniciAdiTextBox.Name = "kullaniciAdiTextBox";
            kullaniciAdiTextBox.Size = new Size(200, 39);
            kullaniciAdiTextBox.TabIndex = 2;
            // 
            // sifreTextBox
            // 
            sifreTextBox.Location = new Point(715, 258);
            sifreTextBox.Name = "sifreTextBox";
            sifreTextBox.Size = new Size(200, 39);
            sifreTextBox.TabIndex = 3;
            sifreTextBox.UseSystemPasswordChar = true;
            // 
            // button_girisYap
            // 
            button_girisYap.Location = new Point(765, 438);
            button_girisYap.Name = "button_girisYap";
            button_girisYap.Size = new Size(150, 46);
            button_girisYap.TabIndex = 4;
            button_girisYap.Text = "Giriş Yap";
            button_girisYap.UseVisualStyleBackColor = true;
            button_girisYap.Click += button_girisYap_Click;
            // 
            // button_kayitOl
            // 
            button_kayitOl.Location = new Point(573, 438);
            button_kayitOl.Name = "button_kayitOl";
            button_kayitOl.Size = new Size(150, 46);
            button_kayitOl.TabIndex = 5;
            button_kayitOl.Text = "Kayıt Ol";
            button_kayitOl.UseVisualStyleBackColor = true;
            button_kayitOl.Click += button_kayitOl_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(295, 74);
            label3.Name = "label3";
            label3.Size = new Size(104, 32);
            label3.TabIndex = 6;
            label3.Text = "Giriş Yap";
            // 
            // GirisFormu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 614);
            Controls.Add(label3);
            Controls.Add(button_kayitOl);
            Controls.Add(button_girisYap);
            Controls.Add(sifreTextBox);
            Controls.Add(kullaniciAdiTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GirisFormu";
            Text = "Giriş Yap - Film Kütüphanesi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox kullaniciAdiTextBox;
        private TextBox sifreTextBox;
        private Button button_girisYap;
        private Button button_kayitOl;
        private Label label3;
    }
}

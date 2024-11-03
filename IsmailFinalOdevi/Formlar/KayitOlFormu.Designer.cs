namespace FinalOdevi.Formlar
{
    partial class KayitOlFormu
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
            adsoyadTextbox = new TextBox();
            tcTextbox = new TextBox();
            dogumTarihiTextbox = new DateTimePicker();
            normalUyelikRadio = new RadioButton();
            premiumUyelikRadio = new RadioButton();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            erkekRadio = new RadioButton();
            kadinRadio = new RadioButton();
            label7 = new Label();
            label8 = new Label();
            kullaniciAdi_textbox = new TextBox();
            sifreTextbox = new TextBox();
            SuspendLayout();
            // 
            // adsoyadTextbox
            // 
            adsoyadTextbox.Location = new Point(151, 212);
            adsoyadTextbox.Name = "adsoyadTextbox";
            adsoyadTextbox.Size = new Size(200, 39);
            adsoyadTextbox.TabIndex = 0;
            // 
            // tcTextbox
            // 
            tcTextbox.Location = new Point(541, 212);
            tcTextbox.Name = "tcTextbox";
            tcTextbox.Size = new Size(200, 39);
            tcTextbox.TabIndex = 1;
            // 
            // dogumTarihiTextbox
            // 
            dogumTarihiTextbox.Format = DateTimePickerFormat.Short;
            dogumTarihiTextbox.Location = new Point(875, 210);
            dogumTarihiTextbox.Name = "dogumTarihiTextbox";
            dogumTarihiTextbox.Size = new Size(200, 39);
            dogumTarihiTextbox.TabIndex = 2;
            // 
            // normalUyelikRadio
            // 
            normalUyelikRadio.AutoSize = true;
            normalUyelikRadio.Location = new Point(151, 356);
            normalUyelikRadio.Name = "normalUyelikRadio";
            normalUyelikRadio.Size = new Size(196, 36);
            normalUyelikRadio.TabIndex = 3;
            normalUyelikRadio.TabStop = true;
            normalUyelikRadio.Text = "Normal Üyelik";
            normalUyelikRadio.UseVisualStyleBackColor = true;
            // 
            // premiumUyelikRadio
            // 
            premiumUyelikRadio.AutoSize = true;
            premiumUyelikRadio.Location = new Point(151, 416);
            premiumUyelikRadio.Name = "premiumUyelikRadio";
            premiumUyelikRadio.Size = new Size(213, 36);
            premiumUyelikRadio.TabIndex = 4;
            premiumUyelikRadio.TabStop = true;
            premiumUyelikRadio.Text = "Premium Üyelik";
            premiumUyelikRadio.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(925, 558);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 6;
            button1.Text = "Kayıt Ol";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 46);
            label1.Name = "label1";
            label1.Size = new Size(97, 32);
            label1.TabIndex = 7;
            label1.Text = "Kayıt Ol";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 168);
            label2.Name = "label2";
            label2.Size = new Size(115, 32);
            label2.TabIndex = 8;
            label2.Text = "Ad Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(541, 168);
            label3.Name = "label3";
            label3.Size = new Size(158, 32);
            label3.TabIndex = 9;
            label3.Text = "T.C Kimlik No";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(875, 168);
            label4.Name = "label4";
            label4.Size = new Size(157, 32);
            label4.TabIndex = 10;
            label4.Text = "Doğum Tarihi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(151, 310);
            label5.Name = "label5";
            label5.Size = new Size(125, 32);
            label5.TabIndex = 11;
            label5.Text = "Üyelik Tipi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(541, 310);
            label6.Name = "label6";
            label6.Size = new Size(98, 32);
            label6.TabIndex = 12;
            label6.Text = "Cinsiyet";
            // 
            // erkekRadio
            // 
            erkekRadio.AutoSize = true;
            erkekRadio.Location = new Point(541, 356);
            erkekRadio.Name = "erkekRadio";
            erkekRadio.Size = new Size(102, 36);
            erkekRadio.TabIndex = 13;
            erkekRadio.TabStop = true;
            erkekRadio.Text = "Erkek";
            erkekRadio.UseVisualStyleBackColor = true;
            // 
            // kadinRadio
            // 
            kadinRadio.AutoSize = true;
            kadinRadio.Location = new Point(541, 416);
            kadinRadio.Name = "kadinRadio";
            kadinRadio.Size = new Size(105, 36);
            kadinRadio.TabIndex = 14;
            kadinRadio.TabStop = true;
            kadinRadio.Text = "Kadın";
            kadinRadio.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(875, 310);
            label7.Name = "label7";
            label7.Size = new Size(145, 32);
            label7.TabIndex = 15;
            label7.Text = "Kullanıcı Adı";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(151, 500);
            label8.Name = "label8";
            label8.Size = new Size(62, 32);
            label8.TabIndex = 16;
            label8.Text = "Şifre";
            // 
            // kullaniciAdi_textbox
            // 
            kullaniciAdi_textbox.Location = new Point(875, 368);
            kullaniciAdi_textbox.Name = "kullaniciAdi_textbox";
            kullaniciAdi_textbox.Size = new Size(200, 39);
            kullaniciAdi_textbox.TabIndex = 17;
            // 
            // sifreTextbox
            // 
            sifreTextbox.Location = new Point(151, 565);
            sifreTextbox.Name = "sifreTextbox";
            sifreTextbox.Size = new Size(200, 39);
            sifreTextbox.TabIndex = 18;
            // 
            // KayitOlFormu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1320, 732);
            Controls.Add(sifreTextbox);
            Controls.Add(kullaniciAdi_textbox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(kadinRadio);
            Controls.Add(erkekRadio);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(premiumUyelikRadio);
            Controls.Add(normalUyelikRadio);
            Controls.Add(dogumTarihiTextbox);
            Controls.Add(tcTextbox);
            Controls.Add(adsoyadTextbox);
            Name = "KayitOlFormu";
            Text = "Kayıt Ol - Film Kütüphanesi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox adsoyadTextbox;
        private TextBox tcTextbox;
        private DateTimePicker dogumTarihiTextbox;
        private RadioButton normalUyelikRadio;
        private RadioButton premiumUyelikRadio;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private RadioButton erkekRadio;
        private RadioButton kadinRadio;
        private Label label7;
        private Label label8;
        private TextBox kullaniciAdi_textbox;
        private TextBox sifreTextbox;
    }
}
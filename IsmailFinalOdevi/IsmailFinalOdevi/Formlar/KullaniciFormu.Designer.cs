namespace FinalOdevi.Formlar
{
    partial class KullaniciFormu
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
            components = new System.ComponentModel.Container();
            filmListesi_datagrid = new DataGridView();
            filmId = new DataGridViewTextBoxColumn();
            filmAdi = new DataGridViewTextBoxColumn();
            tur = new DataGridViewTextBoxColumn();
            yayinYili = new DataGridViewTextBoxColumn();
            degerlendirmePuani = new DataGridViewTextBoxColumn();
            yonetmen = new DataGridViewTextBoxColumn();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            ara_btn = new Button();
            ara_textbox = new TextBox();
            label9 = new Label();
            label8 = new Label();
            button1 = new Button();
            degerlendirmeYap_button = new Button();
            izlemeyeEkle_button = new Button();
            detay_button = new Button();
            tabPage2 = new TabPage();
            listedenKaldir_button = new Button();
            izlendiIsaretle_button = new Button();
            izlemeListesi_datagrid = new DataGridView();
            i_id = new DataGridViewTextBoxColumn();
            i_filmAdi = new DataGridViewTextBoxColumn();
            i_izlendiMi = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            uyelikUcreti_label = new Label();
            label7 = new Label();
            uyelikTipiLabel = new Label();
            label6 = new Label();
            kadin_radio = new RadioButton();
            erkek_radio = new RadioButton();
            sifre_textbox = new TextBox();
            kullaniciAdi_textbox = new TextBox();
            adsoyad_textbox = new TextBox();
            tc_textbox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            notifyIcon1 = new NotifyIcon(components);
            ((System.ComponentModel.ISupportInitialize)filmListesi_datagrid).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)izlemeListesi_datagrid).BeginInit();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // filmListesi_datagrid
            // 
            filmListesi_datagrid.AllowUserToAddRows = false;
            filmListesi_datagrid.AllowUserToDeleteRows = false;
            filmListesi_datagrid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            filmListesi_datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            filmListesi_datagrid.Columns.AddRange(new DataGridViewColumn[] { filmId, filmAdi, tur, yayinYili, degerlendirmePuani, yonetmen });
            filmListesi_datagrid.Location = new Point(8, 58);
            filmListesi_datagrid.Name = "filmListesi_datagrid";
            filmListesi_datagrid.ReadOnly = true;
            filmListesi_datagrid.RowHeadersWidth = 82;
            filmListesi_datagrid.Size = new Size(1492, 514);
            filmListesi_datagrid.TabIndex = 0;
            filmListesi_datagrid.CellContentClick += filmListesi_datagrid_CellContentClick;
            // 
            // filmId
            // 
            filmId.HeaderText = "ID";
            filmId.MinimumWidth = 10;
            filmId.Name = "filmId";
            filmId.ReadOnly = true;
            filmId.Visible = false;
            filmId.Width = 200;
            // 
            // filmAdi
            // 
            filmAdi.HeaderText = "Film Adı";
            filmAdi.MinimumWidth = 10;
            filmAdi.Name = "filmAdi";
            filmAdi.ReadOnly = true;
            filmAdi.Width = 200;
            // 
            // tur
            // 
            tur.HeaderText = "Tür";
            tur.MinimumWidth = 10;
            tur.Name = "tur";
            tur.ReadOnly = true;
            tur.Width = 200;
            // 
            // yayinYili
            // 
            yayinYili.HeaderText = "Yayın Yılı";
            yayinYili.MinimumWidth = 10;
            yayinYili.Name = "yayinYili";
            yayinYili.ReadOnly = true;
            yayinYili.Width = 200;
            // 
            // degerlendirmePuani
            // 
            degerlendirmePuani.HeaderText = "Değerlendirme Puanı";
            degerlendirmePuani.MinimumWidth = 10;
            degerlendirmePuani.Name = "degerlendirmePuani";
            degerlendirmePuani.ReadOnly = true;
            degerlendirmePuani.Width = 200;
            // 
            // yonetmen
            // 
            yonetmen.HeaderText = "Yönetmen";
            yonetmen.MinimumWidth = 10;
            yonetmen.Name = "yonetmen";
            yonetmen.ReadOnly = true;
            yonetmen.Width = 200;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1520, 840);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(ara_btn);
            tabPage1.Controls.Add(ara_textbox);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(degerlendirmeYap_button);
            tabPage1.Controls.Add(izlemeyeEkle_button);
            tabPage1.Controls.Add(detay_button);
            tabPage1.Controls.Add(filmListesi_datagrid);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1504, 786);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Anasayfa";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // ara_btn
            // 
            ara_btn.Location = new Point(351, 6);
            ara_btn.Name = "ara_btn";
            ara_btn.Size = new Size(150, 46);
            ara_btn.TabIndex = 9;
            ara_btn.Text = "Ara";
            ara_btn.UseVisualStyleBackColor = true;
            ara_btn.Click += ara_btn_Click;
            // 
            // ara_textbox
            // 
            ara_textbox.Location = new Point(113, 10);
            ara_textbox.Name = "ara_textbox";
            ara_textbox.Size = new Size(200, 39);
            ara_textbox.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(25, 13);
            label9.Name = "label9";
            label9.Size = new Size(49, 32);
            label9.TabIndex = 7;
            label9.Text = "Ara";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1187, 13);
            label8.Name = "label8";
            label8.Size = new Size(232, 32);
            label8.TabIndex = 6;
            label8.Text = "İzleme Listesine Ekle";
            // 
            // button1
            // 
            button1.Location = new Point(35, 668);
            button1.Name = "button1";
            button1.Size = new Size(216, 46);
            button1.TabIndex = 5;
            button1.Text = "Film Analizi Yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // degerlendirmeYap_button
            // 
            degerlendirmeYap_button.Location = new Point(1203, 668);
            degerlendirmeYap_button.Name = "degerlendirmeYap_button";
            degerlendirmeYap_button.Size = new Size(246, 46);
            degerlendirmeYap_button.TabIndex = 4;
            degerlendirmeYap_button.Text = "Değerlendirme Yap";
            degerlendirmeYap_button.UseVisualStyleBackColor = true;
            degerlendirmeYap_button.Click += degerlendirmeYap_button_Click;
            // 
            // izlemeyeEkle_button
            // 
            izlemeyeEkle_button.Location = new Point(1438, 6);
            izlemeyeEkle_button.Name = "izlemeyeEkle_button";
            izlemeyeEkle_button.Size = new Size(60, 46);
            izlemeyeEkle_button.TabIndex = 2;
            izlemeyeEkle_button.Text = "+";
            izlemeyeEkle_button.UseVisualStyleBackColor = true;
            izlemeyeEkle_button.Click += izlemeyeEkle_button_Click;
            // 
            // detay_button
            // 
            detay_button.Location = new Point(915, 668);
            detay_button.Name = "detay_button";
            detay_button.Size = new Size(230, 46);
            detay_button.TabIndex = 1;
            detay_button.Text = "Detayı Göster";
            detay_button.UseVisualStyleBackColor = true;
            detay_button.Click += detay_button_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(listedenKaldir_button);
            tabPage2.Controls.Add(izlendiIsaretle_button);
            tabPage2.Controls.Add(izlemeListesi_datagrid);
            tabPage2.Location = new Point(8, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1504, 786);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "İzleme Listem";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // listedenKaldir_button
            // 
            listedenKaldir_button.Location = new Point(947, 694);
            listedenKaldir_button.Name = "listedenKaldir_button";
            listedenKaldir_button.Size = new Size(220, 46);
            listedenKaldir_button.TabIndex = 2;
            listedenKaldir_button.Text = "Listeden Kaldır";
            listedenKaldir_button.UseVisualStyleBackColor = true;
            listedenKaldir_button.Click += listedenKaldir_button_Click;
            // 
            // izlendiIsaretle_button
            // 
            izlendiIsaretle_button.Location = new Point(1205, 694);
            izlendiIsaretle_button.Name = "izlendiIsaretle_button";
            izlendiIsaretle_button.Size = new Size(276, 46);
            izlendiIsaretle_button.TabIndex = 1;
            izlendiIsaretle_button.Text = "İzlendi Olarak İşaretle";
            izlendiIsaretle_button.UseVisualStyleBackColor = true;
            izlendiIsaretle_button.Click += izlendiIsaretle_button_Click;
            // 
            // izlemeListesi_datagrid
            // 
            izlemeListesi_datagrid.AllowUserToAddRows = false;
            izlemeListesi_datagrid.AllowUserToDeleteRows = false;
            izlemeListesi_datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            izlemeListesi_datagrid.Columns.AddRange(new DataGridViewColumn[] { i_id, i_filmAdi, i_izlendiMi });
            izlemeListesi_datagrid.Location = new Point(6, 6);
            izlemeListesi_datagrid.Name = "izlemeListesi_datagrid";
            izlemeListesi_datagrid.ReadOnly = true;
            izlemeListesi_datagrid.RowHeadersWidth = 82;
            izlemeListesi_datagrid.Size = new Size(1492, 570);
            izlemeListesi_datagrid.TabIndex = 0;
            // 
            // i_id
            // 
            i_id.HeaderText = "id";
            i_id.MinimumWidth = 10;
            i_id.Name = "i_id";
            i_id.ReadOnly = true;
            i_id.Visible = false;
            i_id.Width = 200;
            // 
            // i_filmAdi
            // 
            i_filmAdi.HeaderText = "Film Adı";
            i_filmAdi.MinimumWidth = 10;
            i_filmAdi.Name = "i_filmAdi";
            i_filmAdi.ReadOnly = true;
            i_filmAdi.Width = 200;
            // 
            // i_izlendiMi
            // 
            i_izlendiMi.HeaderText = "İzlendi Mi";
            i_izlendiMi.MinimumWidth = 10;
            i_izlendiMi.Name = "i_izlendiMi";
            i_izlendiMi.ReadOnly = true;
            i_izlendiMi.Width = 200;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(uyelikUcreti_label);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(uyelikTipiLabel);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(kadin_radio);
            tabPage3.Controls.Add(erkek_radio);
            tabPage3.Controls.Add(sifre_textbox);
            tabPage3.Controls.Add(kullaniciAdi_textbox);
            tabPage3.Controls.Add(adsoyad_textbox);
            tabPage3.Controls.Add(tc_textbox);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(label1);
            tabPage3.Controls.Add(button2);
            tabPage3.Location = new Point(8, 46);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1504, 786);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Ayarlar";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // uyelikUcreti_label
            // 
            uyelikUcreti_label.AutoSize = true;
            uyelikUcreti_label.Location = new Point(895, 322);
            uyelikUcreti_label.Name = "uyelikUcreti_label";
            uyelikUcreti_label.Size = new Size(78, 32);
            uyelikUcreti_label.TabIndex = 16;
            uyelikUcreti_label.Text = "label8";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(633, 322);
            label7.Name = "label7";
            label7.Size = new Size(198, 32);
            label7.TabIndex = 15;
            label7.Text = "Üyelik Ücretiniz : ";
            // 
            // uyelikTipiLabel
            // 
            uyelikTipiLabel.AutoSize = true;
            uyelikTipiLabel.Location = new Point(375, 322);
            uyelikTipiLabel.Name = "uyelikTipiLabel";
            uyelikTipiLabel.Size = new Size(78, 32);
            uyelikTipiLabel.TabIndex = 13;
            uyelikTipiLabel.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(129, 322);
            label6.Name = "label6";
            label6.Size = new Size(168, 32);
            label6.TabIndex = 12;
            label6.Text = "Üyelik Tipiniz :";
            // 
            // kadin_radio
            // 
            kadin_radio.AutoSize = true;
            kadin_radio.Location = new Point(1179, 258);
            kadin_radio.Name = "kadin_radio";
            kadin_radio.Size = new Size(105, 36);
            kadin_radio.TabIndex = 11;
            kadin_radio.TabStop = true;
            kadin_radio.Text = "Kadın";
            kadin_radio.UseVisualStyleBackColor = true;
            // 
            // erkek_radio
            // 
            erkek_radio.AutoSize = true;
            erkek_radio.Location = new Point(1179, 185);
            erkek_radio.Name = "erkek_radio";
            erkek_radio.Size = new Size(102, 36);
            erkek_radio.TabIndex = 10;
            erkek_radio.TabStop = true;
            erkek_radio.Text = "Erkek";
            erkek_radio.UseVisualStyleBackColor = true;
            // 
            // sifre_textbox
            // 
            sifre_textbox.Location = new Point(895, 182);
            sifre_textbox.Name = "sifre_textbox";
            sifre_textbox.Size = new Size(200, 39);
            sifre_textbox.TabIndex = 9;
            // 
            // kullaniciAdi_textbox
            // 
            kullaniciAdi_textbox.Location = new Point(633, 182);
            kullaniciAdi_textbox.Name = "kullaniciAdi_textbox";
            kullaniciAdi_textbox.Size = new Size(200, 39);
            kullaniciAdi_textbox.TabIndex = 8;
            // 
            // adsoyad_textbox
            // 
            adsoyad_textbox.Location = new Point(375, 182);
            adsoyad_textbox.Name = "adsoyad_textbox";
            adsoyad_textbox.Size = new Size(200, 39);
            adsoyad_textbox.TabIndex = 7;
            // 
            // tc_textbox
            // 
            tc_textbox.Enabled = false;
            tc_textbox.Location = new Point(129, 182);
            tc_textbox.Name = "tc_textbox";
            tc_textbox.Size = new Size(200, 39);
            tc_textbox.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(129, 104);
            label5.Name = "label5";
            label5.Size = new Size(119, 32);
            label5.TabIndex = 5;
            label5.Text = "T.C Kimlik";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1179, 104);
            label4.Name = "label4";
            label4.Size = new Size(135, 32);
            label4.TabIndex = 4;
            label4.Text = "Cinsiyetiniz";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(895, 104);
            label3.Name = "label3";
            label3.Size = new Size(93, 32);
            label3.TabIndex = 3;
            label3.Text = "Şifreniz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(633, 104);
            label2.Name = "label2";
            label2.Size = new Size(176, 32);
            label2.TabIndex = 2;
            label2.Text = "Kullanıcı Adınız";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(375, 104);
            label1.Name = "label1";
            label1.Size = new Size(189, 32);
            label1.TabIndex = 1;
            label1.Text = "Adınız Soyadınız";
            // 
            // button2
            // 
            button2.Location = new Point(1255, 664);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 0;
            button2.Text = "Kaydet";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // KullaniciFormu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1520, 840);
            Controls.Add(tabControl1);
            Name = "KullaniciFormu";
            Text = "Film Kütüphanesi";
            Load += KullaniciFormu_Load;
            ((System.ComponentModel.ISupportInitialize)filmListesi_datagrid).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)izlemeListesi_datagrid).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView filmListesi_datagrid;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button detay_button;
        private Button izlemeyeEkle_button;
        private Button degerlendirmeYap_button;
        private Button button1;
        private TabPage tabPage3;
        private Button listedenKaldir_button;
        private Button izlendiIsaretle_button;
        private DataGridView izlemeListesi_datagrid;
        private Button button2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label uyelikTipiLabel;
        private Label label6;
        private RadioButton kadin_radio;
        private RadioButton erkek_radio;
        private TextBox sifre_textbox;
        private TextBox kullaniciAdi_textbox;
        private TextBox adsoyad_textbox;
        private TextBox tc_textbox;
        private Label label5;
        private Label uyelikUcreti_label;
        private Label label7;
        private DataGridViewTextBoxColumn filmId;
        private DataGridViewTextBoxColumn filmAdi;
        private DataGridViewTextBoxColumn tur;
        private DataGridViewTextBoxColumn yayinYili;
        private DataGridViewTextBoxColumn degerlendirmePuani;
        private DataGridViewTextBoxColumn yonetmen;
        private DataGridViewTextBoxColumn i_id;
        private DataGridViewTextBoxColumn i_filmAdi;
        private DataGridViewTextBoxColumn i_izlendiMi;
        private Button ara_btn;
        private TextBox ara_textbox;
        private Label label9;
        private Label label8;
        private NotifyIcon notifyIcon1;
    }
}
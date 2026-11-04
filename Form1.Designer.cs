namespace EvcilHayvanBakimSistemi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbMusteriBilgileri = new System.Windows.Forms.GroupBox();
            this.txtGunSayisi = new System.Windows.Forms.TextBox();
            this.txtHayvanYasi = new System.Windows.Forms.TextBox();
            this.txtHayvanAdi = new System.Windows.Forms.TextBox();
            this.txtMusteriAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbHizmetler = new System.Windows.Forms.GroupBox();
            this.chkBesleme = new System.Windows.Forms.CheckBox();
            this.chkTirnak = new System.Windows.Forms.CheckBox();
            this.chkYikama = new System.Windows.Forms.CheckBox();
            this.cmbHayvanTuru = new System.Windows.Forms.ComboBox();
            this.gbSonuc = new System.Windows.Forms.GroupBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnYardim = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblHayvanTuruBaslik = new System.Windows.Forms.Label();
            this.gbMusteriBilgileri.SuspendLayout();
            this.gbHizmetler.SuspendLayout();
            this.gbSonuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMusteriBilgileri
            // 
            this.gbMusteriBilgileri.Controls.Add(this.txtGunSayisi);
            this.gbMusteriBilgileri.Controls.Add(this.txtHayvanYasi);
            this.gbMusteriBilgileri.Controls.Add(this.txtHayvanAdi);
            this.gbMusteriBilgileri.Controls.Add(this.txtMusteriAdi);
            this.gbMusteriBilgileri.Controls.Add(this.label4);
            this.gbMusteriBilgileri.Controls.Add(this.label3);
            this.gbMusteriBilgileri.Controls.Add(this.label2);
            this.gbMusteriBilgileri.Controls.Add(this.label1);
            this.gbMusteriBilgileri.Location = new System.Drawing.Point(12, 12);
            this.gbMusteriBilgileri.Name = "gbMusteriBilgileri";
            this.gbMusteriBilgileri.Size = new System.Drawing.Size(245, 254);
            this.gbMusteriBilgileri.TabIndex = 0;
            this.gbMusteriBilgileri.TabStop = false;
            this.gbMusteriBilgileri.Text = "Müşteri ve Evcil Hayvan Bilgileri";
            // 
            // txtGunSayisi
            // 
            this.txtGunSayisi.Location = new System.Drawing.Point(114, 202);
            this.txtGunSayisi.Name = "txtGunSayisi";
            this.txtGunSayisi.Size = new System.Drawing.Size(108, 26);
            this.txtGunSayisi.TabIndex = 7;
            // 
            // txtHayvanYasi
            // 
            this.txtHayvanYasi.Location = new System.Drawing.Point(114, 157);
            this.txtHayvanYasi.Name = "txtHayvanYasi";
            this.txtHayvanYasi.Size = new System.Drawing.Size(108, 26);
            this.txtHayvanYasi.TabIndex = 6;
            // 
            // txtHayvanAdi
            // 
            this.txtHayvanAdi.Location = new System.Drawing.Point(114, 106);
            this.txtHayvanAdi.Name = "txtHayvanAdi";
            this.txtHayvanAdi.Size = new System.Drawing.Size(108, 26);
            this.txtHayvanAdi.TabIndex = 5;
            // 
            // txtMusteriAdi
            // 
            this.txtMusteriAdi.Location = new System.Drawing.Point(114, 54);
            this.txtMusteriAdi.Name = "txtMusteriAdi";
            this.txtMusteriAdi.Size = new System.Drawing.Size(108, 26);
            this.txtMusteriAdi.TabIndex = 4;
            this.txtMusteriAdi.TextChanged += new System.EventHandler(this.txtMusteriAdi_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gün Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hayvan Yaşı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hayvan Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Adı";
            // 
            // gbHizmetler
            // 
            this.gbHizmetler.Controls.Add(this.lblHayvanTuruBaslik);
            this.gbHizmetler.Controls.Add(this.chkBesleme);
            this.gbHizmetler.Controls.Add(this.chkTirnak);
            this.gbHizmetler.Controls.Add(this.chkYikama);
            this.gbHizmetler.Controls.Add(this.cmbHayvanTuru);
            this.gbHizmetler.Location = new System.Drawing.Point(263, 12);
            this.gbHizmetler.Name = "gbHizmetler";
            this.gbHizmetler.Size = new System.Drawing.Size(191, 254);
            this.gbHizmetler.TabIndex = 1;
            this.gbHizmetler.TabStop = false;
            this.gbHizmetler.Text = "Hizmet Seçenekleri";
            // 
            // chkBesleme
            // 
            this.chkBesleme.AutoSize = true;
            this.chkBesleme.Location = new System.Drawing.Point(11, 201);
            this.chkBesleme.Name = "chkBesleme";
            this.chkBesleme.Size = new System.Drawing.Size(133, 24);
            this.chkBesleme.TabIndex = 3;
            this.chkBesleme.Text = "Özel Besleme";
            this.chkBesleme.UseVisualStyleBackColor = true;
            // 
            // chkTirnak
            // 
            this.chkTirnak.AutoSize = true;
            this.chkTirnak.Location = new System.Drawing.Point(11, 155);
            this.chkTirnak.Name = "chkTirnak";
            this.chkTirnak.Size = new System.Drawing.Size(128, 24);
            this.chkTirnak.TabIndex = 2;
            this.chkTirnak.Text = "Tırnak Kesimi";
            this.chkTirnak.UseVisualStyleBackColor = true;
            // 
            // chkYikama
            // 
            this.chkYikama.AutoSize = true;
            this.chkYikama.Location = new System.Drawing.Point(11, 112);
            this.chkYikama.Name = "chkYikama";
            this.chkYikama.Size = new System.Drawing.Size(88, 24);
            this.chkYikama.TabIndex = 1;
            this.chkYikama.Text = "Yıkama";
            this.chkYikama.UseVisualStyleBackColor = true;
            // 
            // cmbHayvanTuru
            // 
            this.cmbHayvanTuru.FormattingEnabled = true;
            this.cmbHayvanTuru.Items.AddRange(new object[] {
            "\"Köpek\"",
            "\"Kedi\"",
            "\"Kuş\"",
            "\"Kemirgen\""});
            this.cmbHayvanTuru.Location = new System.Drawing.Point(6, 68);
            this.cmbHayvanTuru.Name = "cmbHayvanTuru";
            this.cmbHayvanTuru.Size = new System.Drawing.Size(121, 28);
            this.cmbHayvanTuru.TabIndex = 0;
            // 
            // gbSonuc
            // 
            this.gbSonuc.Controls.Add(this.lblSonuc);
            this.gbSonuc.Controls.Add(this.btnCikis);
            this.gbSonuc.Controls.Add(this.btnYardim);
            this.gbSonuc.Controls.Add(this.btnTemizle);
            this.gbSonuc.Controls.Add(this.btnHesapla);
            this.gbSonuc.Location = new System.Drawing.Point(460, 12);
            this.gbSonuc.Name = "gbSonuc";
            this.gbSonuc.Size = new System.Drawing.Size(338, 373);
            this.gbSonuc.TabIndex = 2;
            this.gbSonuc.TabStop = false;
            this.gbSonuc.Text = "Hesaplama ve İşlemler";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(6, 205);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(232, 20);
            this.lblSonuc.TabIndex = 4;
            this.lblSonuc.Text = "Sonuç Burada Görünecektir";
            this.lblSonuc.Click += new System.EventHandler(this.lblSonuc_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(107, 169);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(128, 33);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnYardim
            // 
            this.btnYardim.Location = new System.Drawing.Point(107, 127);
            this.btnYardim.Name = "btnYardim";
            this.btnYardim.Size = new System.Drawing.Size(128, 36);
            this.btnYardim.TabIndex = 2;
            this.btnYardim.Text = "Yardım";
            this.btnYardim.UseVisualStyleBackColor = true;
            this.btnYardim.Click += new System.EventHandler(this.btnYardim_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(107, 86);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(128, 35);
            this.btnTemizle.TabIndex = 1;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(107, 42);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(128, 38);
            this.btnHesapla.TabIndex = 0;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click_1);
            // 
            // lblHayvanTuruBaslik
            // 
            this.lblHayvanTuruBaslik.AutoSize = true;
            this.lblHayvanTuruBaslik.Location = new System.Drawing.Point(7, 45);
            this.lblHayvanTuruBaslik.Name = "lblHayvanTuruBaslik";
            this.lblHayvanTuruBaslik.Size = new System.Drawing.Size(153, 20);
            this.lblHayvanTuruBaslik.TabIndex = 4;
            this.lblHayvanTuruBaslik.Text = "Hayvan Türü Seçiniz";
            this.lblHayvanTuruBaslik.Click += new System.EventHandler(this.lblHayvanTuruBaslik_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbSonuc);
            this.Controls.Add(this.gbHizmetler);
            this.Controls.Add(this.gbMusteriBilgileri);
            this.Name = "Form1";
            this.Text = "Evcil Hayvan Bakım Ücreti Hesaplama Sistemi";
            this.gbMusteriBilgileri.ResumeLayout(false);
            this.gbMusteriBilgileri.PerformLayout();
            this.gbHizmetler.ResumeLayout(false);
            this.gbHizmetler.PerformLayout();
            this.gbSonuc.ResumeLayout(false);
            this.gbSonuc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMusteriBilgileri;
        private System.Windows.Forms.TextBox txtGunSayisi;
        private System.Windows.Forms.TextBox txtHayvanYasi;
        private System.Windows.Forms.TextBox txtHayvanAdi;
        private System.Windows.Forms.TextBox txtMusteriAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbHizmetler;
        private System.Windows.Forms.GroupBox gbSonuc;
        private System.Windows.Forms.CheckBox chkBesleme;
        private System.Windows.Forms.CheckBox chkTirnak;
        private System.Windows.Forms.CheckBox chkYikama;
        private System.Windows.Forms.ComboBox cmbHayvanTuru;
        private System.Windows.Forms.Button btnYardim;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label lblHayvanTuruBaslik;
    }
}


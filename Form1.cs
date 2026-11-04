using System;
using System.Windows.Forms;
using System.Linq;

namespace EvcilHayvanBakimSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            // Giriş Kontrolleri (Kriter 6)
            // txtGunSayisi kullandığın için burayı ona göre güncelledim
            if (string.IsNullOrWhiteSpace(txtMusteriAdi.Text) ||
                string.IsNullOrWhiteSpace(txtHayvanAdi.Text) ||
                !int.TryParse(txtGunSayisi.Text, out int gun))
            {
                MessageBox.Show("Lütfen tüm alanları eksiksiz doldurun ve Gün Sayısı kısmına sayı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (gun <= 0)
            {
                MessageBox.Show("Gün sayısı 0'dan büyük olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Baz Fiyat Belirleme (Switch Yapısı)
            double bazFiyat = 0;
            // ComboBox'tan seçilen değeri alıyoruz
            string tur = cmbHayvanTuru.SelectedItem?.ToString();

            switch (tur)
            {
                case "Köpek": bazFiyat = 200; break;
                case "Kedi": bazFiyat = 150; break;
                case "Kuş": bazFiyat = 100; break;
                case "Kemirgen": bazFiyat = 80; break;
                default:
                    MessageBox.Show("Lütfen listeden bir hayvan türü seçiniz!");
                    return;
            }

            // Ek Hizmetler
            double ekUcret = 0;
            if (chkYikama.Checked) ekUcret += 50;
            if (chkTirnak.Checked) ekUcret += 30;
            if (chkBesleme.Checked) ekUcret += 40;

            // Yaş Kontrolü (Eğer kutu boş değilse ve 1'den küçükse +30 TL)
            if (int.TryParse(txtHayvanYasi.Text, out int yas) && yas < 1)
            {
                ekUcret += 30;
            }

            // Toplam Hesaplama
            double toplam = (bazFiyat + ekUcret) * gun;

            // Sonucu Label'a yazdır
            lblSonuc.Text = "Sonuç: " + txtHayvanAdi.Text + " için toplam tutar: " + toplam.ToString("N2") + " TL";
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            // Tüm alanları temizle
            txtMusteriAdi.Clear();
            txtHayvanAdi.Clear();
            txtHayvanYasi.Clear();
            txtGunSayisi.Clear(); // Senin isimlendirmene göre güncellendi
            cmbHayvanTuru.SelectedIndex = -1;
            chkYikama.Checked = false;
            chkTirnak.Checked = false;
            chkBesleme.Checked = false;
            lblSonuc.Text = "Sonuç Burada Görünecektir";
        }

        private void btnYardim_Click(object sender, EventArgs e)
        {
            string yardimMesaji = "--- EVCİL HAYVAN BAKIM ÜCRETİ ---\n\n" +
                        "Günlük Bakım Ücreti: 100 TL\n\n" +
                        "--- TÜR FARKLARI ---\n" +
                        "Kedi: 50 TL\n" +
                        "Köpek: 100 TL\n" +
                        "Kuş: 20 TL\n" +
                        "Kemirgen: 25 TL\n\n" +
                        "--- EK HİZMETLER ---\n" +
                        "Yıkama: 50 TL | Tırnak Kesimi: 30 TL | Özel Besleme: 40 TL\n\n" +
                        "Not: Yaş kısmına sadece tam sayı (örn: 5) veya ay/gün ifadesi (örn: 3 ay) giriniz. Negatif değerler kabul edilmez.";

            MessageBox.Show(yardimMesaji, "Yardım ve Fiyat Listesi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHesapla_Click_1(object sender, EventArgs e)
        {
            // 1. ADIM: TEK TEK BOŞLUK KONTROLÜ (İmleci eksik olana odaklar)
            if (string.IsNullOrWhiteSpace(txtMusteriAdi.Text)) { MessageBox.Show("Lütfen müşteri adını girin!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtMusteriAdi.Focus(); return; }
            if (string.IsNullOrWhiteSpace(txtHayvanAdi.Text)) { MessageBox.Show("Lütfen hayvan adını girin!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtHayvanAdi.Focus(); return; }
            if (string.IsNullOrWhiteSpace(txtHayvanYasi.Text)) { MessageBox.Show("Lütfen hayvan yaşını girin!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtHayvanYasi.Focus(); return; }
            if (string.IsNullOrWhiteSpace(txtGunSayisi.Text)) { MessageBox.Show("Lütfen gün sayısını girin!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtGunSayisi.Focus(); return; }
            if (string.IsNullOrWhiteSpace(cmbHayvanTuru.Text)) { MessageBox.Show("Lütfen bir hayvan türü seçin!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning); cmbHayvanTuru.Focus(); return; }

            // 2. GÜN SAYISI KONTROLÜ
            if (!int.TryParse(txtGunSayisi.Text, out int gunSayisi) || gunSayisi < 0)
            {
                MessageBox.Show("Lütfen gün sayısı kısmına geçerli, pozitif bir tam sayı giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGunSayisi.Focus();
                return;
            }

            // 3. KATI YAŞ VE FORMAT KONTROLÜ
            string yasMetni = txtHayvanYasi.Text.ToLower().Trim();
            int yasSayi = 0;

            if (yasMetni.Contains("-"))
            {
                MessageBox.Show("Yaş değeri negatif olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHayvanYasi.Focus();
                return;
            }

            bool isYavru = yasMetni.EndsWith("ay") || yasMetni.EndsWith("gün");

            if (isYavru)
            {
                string rakamlar = new string(yasMetni.Where(char.IsDigit).ToArray());
                if (string.IsNullOrEmpty(rakamlar))
                {
                    MessageBox.Show("Lütfen geçerli bir sayı ile birlikte ay/gün ifadesi giriniz! (Örn: 3 ay)", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtHayvanYasi.Focus();
                    return;
                }
                yasSayi = int.Parse(rakamlar);
            }
            else
            {
                if (!int.TryParse(yasMetni, out yasSayi))
                {
                    MessageBox.Show("Yaş sadece tam sayı veya 'ay/gün' ifadesi içermelidir (Örn: 5 veya 3 ay).", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtHayvanYasi.Focus();
                    return;
                }
            }

            // 4. HESAPLAMA VE TÜR FARKLARI
            double gunlukBirimUcret = 100;
            double turFarki = 0;
            string secilenTur = cmbHayvanTuru.Text.Replace("\"", "").Trim();

            switch (secilenTur)
            {
                case "Kedi": turFarki = 50; break;
                case "Köpek": turFarki = 100; break;
                case "Kuş": turFarki = 20; break;
                case "Tavşan": turFarki = 30; break;
                case "Kemirgen": turFarki = 25; break;
                default: turFarki = 0; break;
            }

            double toplam = (gunSayisi * gunlukBirimUcret) + turFarki;

            // 5. FİŞ DETAYI OLUŞTURMA
            string fisDetayi = "--- FİŞ DETAYI ---\n";
            fisDetayi += "Müşteri: " + txtMusteriAdi.Text + "\n";
            fisDetayi += "Hayvan: " + txtHayvanAdi.Text + "\n";
            fisDetayi += "Günlük Bakım: ₺100,00 x " + gunSayisi + "\n";

            if (turFarki > 0)
                fisDetayi += "Tür Farkı (" + secilenTur + "): ₺" + turFarki.ToString("N2") + "\n";

            if (chkYikama.Checked) { toplam += 50; fisDetayi += "Yıkama: 50 TL\n"; }
            if (chkTirnak.Checked) { toplam += 30; fisDetayi += "Tırnak Kesimi: 30 TL\n"; }
            if (chkBesleme.Checked) { toplam += 40; fisDetayi += "Özel Besleme: 40 TL\n"; }

            if (isYavru || yasSayi < 1)
            {
                toplam += 30;
                fisDetayi += "Yavru Bakım Farkı: 30 TL\n";
            }

            lblSonuc.Text = fisDetayi + "---------------------\nToplam Tutar: ₺" + toplam.ToString("N2");
        }

        private void txtMusteriAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSonuc_Click(object sender, EventArgs e)
        {

        }

        private void lblHayvanTuruBaslik_Click(object sender, EventArgs e)
        {

        }
    }
}
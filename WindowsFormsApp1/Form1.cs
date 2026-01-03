using System;
using System.Drawing; // Renkler için
using System.IO;      // Dosya işlemleri için
using System.Windows.Forms;

namespace Virüs_Antivirüs

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // --- YARDIMCI METOD: LOG YAZDIRMA ---
        private void LogYaz(string mesaj)
        {
            string zaman = DateTime.Now.ToLongTimeString();
            lstLog.Items.Add($"[{zaman}] {mesaj}");
            lstLog.SelectedIndex = lstLog.Items.Count - 1; // Otomatik aşağı kaydır
        }

        // --- 1. KLASÖR SEÇME İŞLEMİ ---
        private void btnSec_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtYol.Text = fbd.SelectedPath;
                    LogYaz("Hedef klasör seçildi: " + fbd.SelectedPath);
                }
            }
        }

        // --- 2. VİRÜS SİMÜLASYONU (DOSYALARI GİZLE) ---
        private void btnVirus_Click(object sender, EventArgs e)
        {
            string yol = txtYol.Text;

            // Klasör seçili mi kontrol et
            if (string.IsNullOrEmpty(yol) || !Directory.Exists(yol))
            {
                MessageBox.Show("Lütfen önce geçerli bir klasör seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LogYaz("--- SALDIRI BAŞLATILIYOR ---");

            try
            {
                string[] dosyalar = Directory.GetFiles(yol);
                int sayac = 0;

                foreach (var dosya in dosyalar)
                {
                    FileAttributes ozellikler = File.GetAttributes(dosya);

                    // Dosya zaten gizli değilse gizle
                    if ((ozellikler & FileAttributes.Hidden) != FileAttributes.Hidden)
                    {
                        File.SetAttributes(dosya, ozellikler | FileAttributes.Hidden);
                        LogYaz($"KRİTİK: {Path.GetFileName(dosya)} dosyasına erişim engellendi (Gizlendi).");
                        sayac++;
                    }
                }

                if (sayac > 0)
                    MessageBox.Show($"{sayac} dosya üzerinde anomali oluşturuldu!", "Virüs Aktif", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    LogYaz("Gizlenecek dosya bulunamadı.");
            }
            catch (Exception ex)
            {
                LogYaz("Hata: " + ex.Message);
            }
        }

        // --- 3. ANTİVİRÜS (TARAMA VE KURTARMA) ---
        private void btnAntivirus_Click(object sender, EventArgs e)
        {
            string yol = txtYol.Text;

            if (string.IsNullOrEmpty(yol) || !Directory.Exists(yol))
            {
                MessageBox.Show("Lütfen önce taranacak klasörü seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LogYaz("--- SİSTEM TARANIYOR (Heuristik Analiz) ---");

            try
            {
                string[] dosyalar = Directory.GetFiles(yol);
                int tehditSayisi = 0;

                foreach (var dosya in dosyalar)
                {
                    FileAttributes ozellikler = File.GetAttributes(dosya);

                    // Eğer dosya GİZLİ ise, bu bir tehdit olabilir (Normal dosyalar gizli olmaz)
                    if ((ozellikler & FileAttributes.Hidden) == FileAttributes.Hidden)
                    {
                        // Gizliliği Kaldır
                        File.SetAttributes(dosya, ozellikler & ~FileAttributes.Hidden);
                        LogYaz($"TESPİT: {Path.GetFileName(dosya)} üzerindeki gizlilik kaldırıldı.");
                        tehditSayisi++;
                    }
                    else
                    {
                        // LogYaz($"TEMİZ: {Path.GetFileName(dosya)}"); // İstersen açabilirsin
                    }
                }

                if (tehditSayisi > 0)
                {
                    LogYaz($"TARAMA TAMAMLANDI: {tehditSayisi} tehdit temizlendi.");
                    MessageBox.Show("Sistem temizlendi! Dosyalarınız geri getirildi.", "Güvenli", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    LogYaz("Sistem temiz. Tehdit bulunamadı.");
                    MessageBox.Show("Tehdit bulunamadı.", "Temiz", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                LogYaz("Hata: " + ex.Message);
            }
        }

        // --- 4. STEGANOGRAFİ (RESİM İÇİNE GÖMME - BONUS) ---
        private void btnStego_Click(object sender, EventArgs e)
        {
            LogYaz("Steganografi işlemi başlatıldı...");

            // 1. Resim Seç
            OpenFileDialog ofdResim = new OpenFileDialog();
            ofdResim.Filter = "Resim Dosyaları|*.jpg;*.png";
            ofdResim.Title = "1. Taşıyıcı Resmi Seçin";
            if (ofdResim.ShowDialog() != DialogResult.OK) return;

            // 2. EXE Seç
            OpenFileDialog ofdExe = new OpenFileDialog();
            ofdExe.Filter = "Uygulama|*.exe";
            ofdExe.Title = "2. Gizlenecek Virüsü (EXE) Seçin";
            if (ofdExe.ShowDialog() != DialogResult.OK) return;

            // 3. Kaydet
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Resim Dosyası|*.jpg";
            sfd.Title = "3. Yeni 'Truva Atı' Resmini Kaydet";
            if (sfd.ShowDialog() != DialogResult.OK) return;

            try
            {
                byte[] resimBytes = File.ReadAllBytes(ofdResim.FileName);
                byte[] exeBytes = File.ReadAllBytes(ofdExe.FileName);

                using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create))
                {
                    fs.Write(resimBytes, 0, resimBytes.Length);
                    // İsteğe bağlı ayraç (Virüs imzası gibi düşünülebilir)
                    // byte[] ayrac = System.Text.Encoding.ASCII.GetBytes("VIRUS_BASLANGICI");
                    // fs.Write(ayrac, 0, ayrac.Length);
                    fs.Write(exeBytes, 0, exeBytes.Length);
                }

                LogYaz($"BAŞARILI: {Path.GetFileName(ofdExe.FileName)} dosyası, resmin içine gömüldü.");
                MessageBox.Show("İşlem tamam! Oluşan resim normal çalışır ama içinde kod saklıdır.", "Steganografi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                LogYaz("Steganografi Hatası: " + ex.Message);
            }
        }
    }
}
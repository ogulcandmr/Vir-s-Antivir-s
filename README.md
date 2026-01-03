# 🛡️ Virüs & Antivirüs Simülasyonu ve Steganografi Aracı

Bu proje, **Siber Güvenlik** dersi kapsamında, zararlı yazılımların çalışma mantığını (saldırı) ve savunma sistemlerinin bu tehditleri nasıl bertaraf ettiğini (savunma) simüle etmek amacıyla geliştirilmiş bir **C# Windows Forms** uygulamasıdır.

Proje, veriye zarar vermeden sadece **erişilebilirliğini (Availability)** hedef alan bir simülasyon içerir ve eğitim amaçlıdır.

## 🚀 Özellikler

Proje üç ana modülden oluşur:

### 1. Virüs Simülasyon Modülü (Saldırı)
- Seçilen hedef klasördeki tüm dosyaları tarar.
- Dosyaların özniteliklerini (File Attributes) değiştirerek **"Gizli" (Hidden)** hale getirir.
- Bu işlem, dosyaları silmez ancak son kullanıcı için görünmez hale getirerek bir fidye yazılımı (ransomware) paniği simüle eder.

### 2. Antivirüs Modülü (Savunma & İyileştirme)
- Hedef klasörü analiz eder.
- **Heuristik (Davranışsal) Analiz:** Normal şartlarda gizli olmaması gereken dosyaların gizli olduğunu bir "anomali" olarak tespit eder.
- Tespit edilen dosyaların gizlilik özniteliklerini kaldırarak sistemi eski haline getirir.

### 3. Steganografi Modülü (Veri Gizleme)
- Bir çalıştırılabilir dosyanın (.exe), masum bir resim dosyasının (.jpg) içine nasıl gizlenebileceğini gösterir.
- **Binary Copy** yöntemi ile resim dosyasının hex kodlarının sonuna exe dosyasının kodlarını ekler.
- Sonuçta oluşan resim normal şekilde açılırken, içerisinde gizli veri barındırır.

---

## 🛠️ Kullanılan Teknolojiler ve Yöntemler

- **Dil:** C# (.NET Framework)
- **Arayüz:** Windows Forms (WinForms)
- **Kütüphaneler:** `System.IO`, `System.Drawing`
- **Teknikler:**
  - `FileAttributes.Hidden`: Dosya gizleme işlemi için.
  - `Bitwise Operations`: Özniteliklerin üzerine yazmak yerine, mevcut özelliklere ekleme/çıkarma yapmak için (`|` ve `& ~` operatörleri).
  - `FileStream`: Dosyaların binary (ikili) modda okunup birleştirilmesi için.

---

## 💻 Kurulum ve Kullanım

1. Projeyi Visual Studio ile açın (`Virüs_Antivirüs.sln`).
2. **Başlat (Start)** butonuna basarak uygulamayı çalıştırın.
3. Masaüstünde test amaçlı bir klasör oluşturun (Örn: `TestKlasor`) ve içine dosyalar atın.
4. Uygulamadan bu klasörü seçin.
5. **Kırmızı Buton:** Dosyaları gizler (Virüs Simülasyonu).
6. **Yeşil Buton:** Dosyaları kurtarır (Antivirüs Simülasyonu).

---

## ⚠️ Yasal Uyarı (Disclaimer)

Bu yazılım tamamen **eğitim ve öğrenim** amaçlı geliştirilmiştir. İçerisindeki kodlar, sistem dosyalarına kalıcı zarar vermez. Steganografi ve dosya manipülasyonu tekniklerinin kötü amaçlı kullanımı yasaktır ve geliştirici bundan sorumlu tutulamaz.

---

**Geliştirici:** [Adın Soyadın]  
**Ders:** [Dersin Adı]  
**Tarih:** 2025

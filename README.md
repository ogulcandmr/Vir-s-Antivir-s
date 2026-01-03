Proje, gerçek sistemlere zarar vermeden yalnızca erişilebilirlik (Availability) kavramı üzerinden ilerler ve tamamen eğitim amaçlıdır.

⸻

🎯 Projenin Amacı
	•	Zararlı yazılımların kullanıcı üzerinde oluşturduğu etkiyi göstermek
	•	Antivirüs yazılımlarının temel mantığını kavratmak
	•	Dosya gizleme ve veri saklama tekniklerini (steganografi) tanıtmak

⸻

🔧 Modüller ve İşlevler

🔴 1. Virüs Simülasyonu (Saldırı Senaryosu)
	•	Kullanıcının seçtiği klasördeki dosyaları tarar.
	•	Dosyaların özniteliklerini değiştirerek gizli (Hidden) hale getirir.
	•	Dosyalar silinmez; yalnızca görünmez yapılarak bir fidye yazılımı (ransomware) hissi oluşturulur.

⸻

🟢 2. Antivirüs Modülü (Savunma & Kurtarma)
	•	Aynı klasörü analiz eder.
	•	Davranışsal (heuristik) analiz kullanarak normalde gizli olmaması gereken dosyaları tespit eder.
	•	Gizli hale getirilmiş dosyaların özniteliklerini temizleyerek eski hâline döndürür.

⸻

🖼️ 3. Steganografi Modülü (Veri Gizleme)
	•	Bir .exe dosyasının, bir .jpg resim dosyasının içine nasıl gizlenebileceğini gösterir.
	•	Binary (ikili) kopyalama yöntemi kullanılır.
	•	Ortaya çıkan resim normal şekilde açılabilir, ancak içinde gizli bir dosya barındırır.

⸻

🧪 Kullanılan Teknolojiler
	•	Programlama Dili: C# (.NET Framework)
	•	Arayüz: Windows Forms
	•	Kütüphaneler:
	•	System.IO
	•	System.Drawing

Kullanılan Teknikler
	•	FileAttributes.Hidden ile dosya gizleme
	•	Bit düzeyinde işlemler (| ve & ~) ile öznitelik yönetimi
	•	FileStream ile binary dosya okuma ve birleştirme

⸻

▶️ Çalıştırma ve Test
	1.	Projeyi Visual Studio’da açın (Virüs_Antivirüs.sln)
	2.	Uygulamayı çalıştırın
	3.	Masaüstünde test için bir klasör oluşturun
	4.	Klasörü uygulama üzerinden seçin
	5.	Kırmızı Buton: Dosyaları gizler (Virüs simülasyonu)
	6.	Yeşil Buton: Dosyaları geri getirir (Antivirüs)

⸻

⚠️ Yasal ve Etik Uyarı

Bu proje yalnızca akademik ve öğretici amaçlarla hazırlanmıştır.
Kodlar gerçek zararlı yazılım değildir ve kalıcı hasar oluşturmaz.
Steganografi ve dosya manipülasyonu tekniklerinin kötüye kullanımı hukuka aykırıdır. Tüm sorumluluk kullanıcıya aittir.

⸻

👤 Geliştirici

Oğulcan Demir
Ders:  NTP

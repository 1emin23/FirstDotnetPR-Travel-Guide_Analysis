# İlk .NET Windows Forms Projem 🚀

Bu depo, benim geliştirdiğim **ilk .NET Windows Forms** uygulamasıdır. Proje, **Murat Yücedağ C# Eğitimi** kapsamında öğrenilen bilgilerin pratiğe dökülmesi amacıyla geliştirilmiştir.

Veritabanı operasyonları ve mimari tasarım aşamasında **Entity Framework - DB First (Önce Veritabanı)** yaklaşımı tercih edilmiştir. Proje geliştirilirken özellikle LINQ sorguları ile veritabanından veri okuma, filtreleme ve istatistiksel verileri (en yüksek fiyat, ortalama kapasite vb.) formatlayarak arayüze yansıtma konularında ciddi bir temel atılmıştır.

## 🛠️ Kullanılan Teknolojiler

Her ne kadar repoda kocaman bir C# ibaresi yer alsa da perde arkasında kullanılan yapılar şunlardır: 

* **C#**

* **.NET Framework (Windows Forms)**

* **Entity Framework (DB First Approach)**

* **LINQ (Language Integrated Query)**

* **MS SQL Server**

## 💻 Kodu Çalıştırma Adımları

Projeyi kendi ortamınızda incelemek ve test etmek isterseniz aşağıdaki adımları izleyebilirsiniz:

1. **Projeyi Klonlayın:**

   ```
   git clone https://github.com/KULLANICI_ADIN/REPO_ADIN.git
   
   ```

   benden örnek vermek gerekirse: 
   ```
   https://github.com/1emin23/FirstDotnetPR-Travel-Guide_Analysis.git   
   ```

2. **Visual Studio ile Açın:**
   Klonladığınız klasördeki `.sln` (Solution) dosyasına çift tıklayarak projeyi Visual Studio'da açın.

3. **Connection String (Bağlantı) Ayarı:**
   Proje **DB First** ile geliştirildiği için, SQL bağlantı cümlenizi kendi yerel veritabanınıza göre güncellemeniz gerekmektedir. `App.config` dosyasına gidin ve `<connectionStrings>` etiketi altındaki veritabanı yolunu kendi SQL Server isminize göre düzenleyin.

4. **Projeyi Derleyin ve Çalıştırın:**
   Visual Studio'nun üst menüsünden `Start` (Başlat) butonuna veya klavyeden `F5` tuşuna basarak projeyi ayağa kaldırabilirsiniz.

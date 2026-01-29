# 🚀 Kişisel Portfolyo Projesi (Bootcamp Case #1)

Bu proje, **M&Y Yazılım Eğitim Akademi Danışmanlık** bünyesinde düzenlenen ve **Murat Yücedağ** tarafından verilen **.Net Core Full Stack Bootcamp** eğitiminin 1. Case çalışması olarak geliştirilmiştir.

Proje, veritabanı tabanlı, yönetim paneli bulunan ve tamamen dinamik bir kişisel portfolyo (özgeçmiş) web sitesidir.

##  Proje Hakkında

Bu proje, bir yazılım geliştiricinin veya profesyonelin kendisini tanıtabileceği, yeteneklerini, deneyimlerini ve projelerini sergileyebileceği dinamik bir web uygulamasıdır. Ziyaretçiler site üzerinden portfolyo sahibinin bilgilerine ulaşabilirken, site sahibi **Admin Paneli** üzerinden tüm içerikleri (yazılar, resimler, istatistikler vb.) kod bilgisine ihtiyaç duymadan güncelleyebilir.

###  Amaç
Bootcamp sürecinde öğrenilen **ASP.NET Core MVC**, **Entity Framework Core (Code First)** ve **N-Tier Architecture (veya MVC katmanlı yapı)** temellerini pekiştirmek ve gerçek hayat senaryosuna uygun bir CRUD (Create, Read, Update, Delete) uygulaması geliştirmektir.

##  Kullanılan Teknolojiler ve Araçlar

* **Backend:** C#, ASP.NET Core MVC
* **Veritabanı:** MS SQL Server
* **ORM:** Entity Framework Core (Code First Yaklaşımı)
* **Frontend (Public):** HTML5, CSS3, Bootstrap, JavaScript (Template Entegrasyonu)
* **Frontend (Admin):** Admin Template, Razor Views
* **Tasarım Deseni:** MVC (Model-View-Controller)
* **Diğer:** ViewComponents, Migrations

##  Özellikler ve Modüller

Proje iki ana bölümden oluşmaktadır: **Kullanıcı Arayüzü (UI)** ve **Yönetim Paneli (Admin Area)**.

###  Kullanıcı Arayüzü (Vitrin)
* **Ana Sayfa:** Karşılama ekranı ve özet bilgiler.
* **Hakkımda:** Kişisel bilgiler ve biyografi.
* **Yetenekler (Skills):** Yüzdelik dilimlerle teknik yetkinliklerin gösterimi.
* **Hizmetler:** Sunulan hizmetlerin listelenmesi.
* **Deneyimler:** İş ve eğitim geçmişinin zaman çizelgesi.
* **Portfolyo:** Tamamlanan projelerin görsellerle listelenmesi.
* **Referanslar (Testimonials):** Müşteri veya iş arkadaşlarının yorumları.
* **İletişim:** Ziyaretçilerin mesaj gönderebileceği iletişim formu.

###  Yönetim Paneli (Admin Dashboard)
Admin paneli üzerinden aşağıdaki modüller için Ekleme, Silme, Güncelleme ve Listeleme (CRUD) işlemleri yapılabilmektedir:
* **Kategori Yönetimi**
* **Hakkımda Yazısı Düzenleme**
* **Deneyim Ekleme/Düzenleme**
* **Yetenek Ekleme/Düzenleme**
* **Hizmet Yönetimi**
* **Portfolyo Projeleri Yönetimi**
* **Referans Yönetimi**
* **İstatistik Yönetimi**
* **Sosyal Medya Hesapları Yönetimi**
* **Gelen Mesajları Okuma ve Yönetme**

##  Kurulum (Nasıl Çalıştırılır?)

Projeyi yerel makinenizde çalıştırmak için aşağıdaki adımları izleyebilirsiniz:

1.  **Repoyu Klonlayın:**
    ```bash
    git clone [https://github.com/nullablege/portfolip-project-case1.git](https://github.com/nullablege/portfolip-project-case1.git)
    ```
2.  **Projeyi Açın:**
    `ResumeProjectDemoNight.sln` dosyasını Visual Studio ile açın.
3.  **Veritabanı Bağlantısını Yapılandırın:**
    `appsettings.json` dosyasındaki `ConnectionStrings` bölümünü kendi SQL Server bilgilerinize göre güncelleyin.
4.  **Migrationları Uygulayın (Veritabanını Oluşturun):**
    Visual Studio'da **Package Manager Console**'u açın ve şu komutu çalıştırın:
    ```powershell
    update-database
    ```
5.  **Projeyi Başlatın:**
    `Ctrl + F5` veya `F5` tuşuna basarak projeyi tarayıcıda çalıştırın.

##  Ekran Görüntüleri
<img width="1918" height="910" alt="Screenshot_11" src="https://github.com/user-attachments/assets/235e6fa4-8eb4-499d-a31f-ea127858b88b" />
<img width="1911" height="893" alt="Screenshot_10" src="https://github.com/user-attachments/assets/d9feaca1-f0e4-44ea-83ca-e228aefb338f" />
<img width="1912" height="898" alt="Screenshot_9" src="https://github.com/user-attachments/assets/d891c54d-b9e3-4903-af5d-81a66771fa22" />
<img width="1905" height="907" alt="Screenshot_8" src="https://github.com/user-attachments/assets/bc624e25-459a-4496-bff4-2bc8898dbb75" />
<img width="1907" height="903" alt="Screenshot_7" src="https://github.com/user-attachments/assets/a82d3a6f-ed21-4167-8722-4d0c43154f1a" />
<img width="1909" height="902" alt="Screenshot_6" src="https://github.com/user-attachments/assets/cad6c803-c98d-430e-92b2-fb731939e97b" />
<img width="1915" height="899" alt="Screenshot_5" src="https://github.com/user-attachments/assets/da650458-7633-49ef-bd06-ee30ecc30d52" />
<img width="1913" height="895" alt="Screenshot_4" src="https://github.com/user-attachments/assets/43a2bed9-73a2-4088-a2df-65695cb72456" />
<img width="1907" height="901" alt="Screenshot_3" src="https://github.com/user-attachments/assets/10e2d2ec-ac88-4ae3-bf10-739221878d1b" />
<img width="1918" height="910" alt="Screenshot_2" src="https://github.com/user-attachments/assets/374c4115-4acf-450d-9211-b7761ec4d862" />
<img width="1908" height="909" alt="Screenshot_12" src="https://github.com/user-attachments/assets/e117aff1-a4d2-4414-a2d2-c887f2bf77d9" />
<img width="1900" height="912" alt="Screenshot_15" src="https://github.com/user-attachments/assets/c898f734-cf2b-42c3-a49e-9020a04008ea" />
<img width="1906" height="915" alt="Screenshot_14" src="https://github.com/user-attachments/assets/9e7e5ca5-ed6d-4328-9cf5-40be82142f8d" />
<img width="1894" height="912" alt="Screenshot_13" src="https://github.com/user-attachments/assets/c158c179-2a16-4810-8586-62a457efbc3d" />
<img width="1899" height="910" alt="Screenshot_18" src="https://github.com/user-attachments/assets/26a25413-2ed8-4368-9a96-c2fdf1660ac3" />
<img width="1907" height="914" alt="Screenshot_17" src="https://github.com/user-attachments/assets/f2854f45-d36d-4700-b956-efe96f589797" />
<img width="1903" height="914" alt="Screenshot_16" src="https://github.com/user-attachments/assets/15e7741b-c59d-4371-b3de-2fa4a776e75b" />
---



##  Eğitim & Teşekkür

Bu proje, **M&Y Yazılım Eğitim Akademi Danışmanlık** tarafından sağlanan eğitim kapsamında geliştirilmiştir. Değerli katkıları ve öğretileri için **Murat Yücedağ** hocama teşekkür ederim.

---
*License: MIT*

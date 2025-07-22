# MyHotelApiProject

# 🏨 ASP.NET Core Otel Rezervasyon Sistemi

Bu proje, [Murat Yücedağ](https://www.udemy.com/user/murat-yucedag/) hocanın Udemy’deki **“ASP.NET Core API - RapidAPI ve API Consume”** eğitimi temel alınarak geliştirilmiştir. Proje, gerçek dünyaya uygun olarak **n katmanlı mimari (N-Tier Architecture)** ile yapılandırılmış ve hem kullanıcı hem de yönetici (admin) taraflı işlevler içermektedir. Projenin genelinde kendim oluşturmuş oldugum web api projesi ve rapid apiden cekmiş oldugum apiler user interface tarafında consume edilmiştir.

## 🚀 Kullanılan Teknolojiler

- ASP.NET Core Web API
- RapidAPI entegrasyonu (Booking.com benzeri servislerden veri çekme)
- ASP.NET Core MVC UI
- N-Tier Architecture (UI, Business, DataAccess, Entity)
- AutoMapper
- Identity (Kullanıcı Kimlik Yönetimi)
- JSON Web Token (JWT) ile authentication
- Fluent Validation
- Role-based Authorization
- Admin & Kullanıcı panelleri

---

## 🌐 Proje Özellikleri

### 🧑‍💼 Kullanıcı Tarafı (UI)

- ✅ **Ana Sayfa**: 
  - Kullanıcılar şehir, giriş/çıkış tarihi, kişi sayısı ve çocuk yasına göre **otel araması** yapabilir.
  - Otellerin detaylarını görüntüleyebilir.
  - Odaları inceleyerek **rezervasyon** oluşturabilir.

- 📨 **İletişim Sayfası**:
  - Kullanıcılar, iletişim formu aracılığıyla mesaj gönderebilir.
  - **Mail bültenine abone** olarak güncel gelişmelerden haberdar olabilir.

---

### 🛠️ Admin Paneli

#### 📊 Dashboard
- Toplam kullanıcı, rezervasyon, otel, personel vb. genel istatistikleri gösterir.

#### 🗓️ Rezervasyon Yönetimi
- Tüm rezervasyonları görüntüleme
- Yeni rezervasyon ekleme
- Güncelleme & Silme (CRUD)

#### 👨‍🔧 Personel Yönetimi
- Personel listeleme, ekleme, güncelleme, silme (CRUD)

#### 🏨 Otel & Oda Yönetimi
- Referanslar
- Hizmetler
- Hakkımızda
- Odalar
- Misafirler
- Tüm bu bölümlerde CRUD işlemleri yapılabilir.

#### 💬 Mesaj Yönetimi
- Anasayfada kullanıcıların gönderdiği mesajları listeleme
- Kullanıcılara yeni mesaj gönderme
- Giden mesajları görüntüleme

#### 📧 Mail Yönetimi
- Kullanıcılara sistem üzerinden **mail gönderimi** yapılabilir.

#### 📁 Resim & Dosya Yönetimi
- Otel görselleri ve diğer dosyalar yüklenip yönetilebilir.

#### 👤 Kullanıcı & Rol İşlemleri
- Kullanıcıları listeleme, düzenleme (CRUD)
- Otel lokasyonlarını yönetme
- Roller üzerinde CRUD işlemleri
- Kayıtlı kullanıcılara roller atama (Rol Atama Sayfası)

#### ⚙️ Ayarlar
- Admin kullanıcı kendi **profil bilgilerini güncelleyebilir.**

---

## 🧱 Katmanlar
- HotelProject.WebAPI --> REST API (Backend)
- HotelProject.WebUI --> MVC UI (Frontend)
- HotelProject.BusinessLayer --> İş kuralları ve servisler
- HotelProject.DataAccessLayer --> Entity Framework + Repository
- HotelProject.EntityLayer --> Model / DTO tanımları

---
## 📺 Tanıtım Videoları

[![Videoyu YouTube'da İzle](https://img.youtube.com/vi/KOpKjR-4YSE/0.jpg)](https://youtu.be/KOpKjR-4YSE)

[![Videoyu YouTube'da İzle](https://img.youtube.com/vi/WjbMV0M_Rkc/0.jpg)](https://youtu.be/WjbMV0M_Rkc)

## 📷 Ekran Görüntüleri
<img width="1919" height="1079" alt="Screenshot 2025-07-22 165603" src="https://github.com/user-attachments/assets/cb528001-45ea-40d3-a73d-87afcc6b6e9a" />
<img width="1917" height="1074" alt="Screenshot 2025-07-22 165611" src="https://github.com/user-attachments/assets/e4c531bc-5ad7-4896-8d55-2428da997509" />
<img width="1919" height="1079" alt="Screenshot 2025-07-22 165618" src="https://github.com/user-attachments/assets/d4e41e5e-751b-4509-9060-022709c10d5c" />
<img width="1914" height="1079" alt="Screenshot 2025-07-22 165629" src="https://github.com/user-attachments/assets/737031d0-af3f-4477-990f-86c56e27a89c" />
<img width="1919" height="1079" alt="Screenshot 2025-07-22 165638" src="https://github.com/user-attachments/assets/cb4533d8-ea89-4ce3-8616-cccb2b5bb823" />
<img width="1919" height="1079" alt="Screenshot 2025-07-22 165645" src="https://github.com/user-attachments/assets/2536cae6-eab9-423f-8f32-15b5492d496f" />
<img width="1919" height="1079" alt="Screenshot 2025-07-22 165654" src="https://github.com/user-attachments/assets/e34d2cdc-4aac-4e5c-98e0-ab6d9bdbd66d" />
<img width="1916" height="1077" alt="Screenshot 2025-07-22 165712" src="https://github.com/user-attachments/assets/6ad94bc9-68e7-4397-882a-58aa10aa7c90" />
<img width="1915" height="1074" alt="Screenshot 2025-07-22 165726" src="https://github.com/user-attachments/assets/cd230fca-29ae-402f-8734-06e80cb66a6c" />
<img width="1919" height="1079" alt="Screenshot 2025-07-22 165733" src="https://github.com/user-attachments/assets/a535be00-a3e0-43bd-a27d-9922d7f239cd" />
<img width="1916" height="1076" alt="Screenshot 2025-07-22 165747" src="https://github.com/user-attachments/assets/9c0848a0-a933-4e94-a330-0f3b52b97cb1" />
<img width="1916" height="1073" alt="Screenshot 2025-07-22 165754" src="https://github.com/user-attachments/assets/ddaab0ac-6a39-4bbd-addc-d62a2c9c67dc" />
<img width="1919" height="1079" alt="Screenshot 2025-07-22 165801" src="https://github.com/user-attachments/assets/f493edce-5f34-4de8-bbed-72e8420d282c" />





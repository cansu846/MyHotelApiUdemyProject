# MyHotelApiProject

# 🏨 ASP.NET Core Otel Rezervasyon Sistemi

Bu proje, [Murat Yücedağ](https://www.udemy.com/user/murat-yucedag/) hocanın Udemy’deki **“ASP.NET Core API - RapidAPI ve API Consume”** eğitimi temel alınarak geliştirilmiştir. Proje, gerçek dünyaya uygun olarak **n katmanlı mimari (N-Tier Architecture)** ile yapılandırılmış ve hem kullanıcı hem de yönetici (admin) taraflı işlevler içermektedir.

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

## 📷 Ekran Görüntüleri

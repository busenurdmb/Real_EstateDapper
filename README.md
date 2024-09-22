# Dapper ile Real Estate Yönetim Sistemi ve Kaggle dataset ile Admin Paneli
M&Y Yazılım Eğitim Akademi Danışmanlık bünyesinde Dapper öğrenmek için yapılan 10. Projedir.

# Dapper Nedir?
- 🗃️ Dapper: Dapper, hafif ve hızlı bir ORM (Object-Relational Mapper) kütüphanesidir. Veritabanı sorgularını hızlı bir şekilde işleyebilmek için ADO.NET üzerine inşa edilmiştir 
ve SQL sorgularına tam kontrol imkanı sunar. Performansı yüksek, kullanımı kolay olan bu kütüphane, özellikle büyük projelerde SQL sorgularını doğrudan yazmak isteyen geliştiriciler için idealdir. 
Hem küçük hem de büyük ölçekli projelerde etkili bir performans sağlar.
- 🌍 Kaggle Dataset: Kaggle, veri bilimciler için geniş veri setleri sağlayan bir platformdur.
-  Bu projede film verilerini yönetmek için Kaggle'dan indirilen bir dataset kullanıldı.
- Film verileri, admin panelinde gösterilmek üzere SQL Server'a yüklendi ve Dapper ile işlendi.

# Proje Kapsamı: Emlak İlan ve Film Yönetim Sistemi
Bu proje, iki ana bileşenden oluşmaktadır:

- 🏠 Emlak Yönetim Sistemi: Dapper ile SQL Server üzerinde emlak ilanlarını yönetme, listeleme ve filtreleme işlemleri yapılır.
- 📹 Admin Paneli Film Yönetimi: Kaggle'dan indirilen "Movie Dataset" kullanılarak film verileri admin panelinde listelenir ve filtrelenir.
- 16 adet istatistik verisi çekilmiştir.
  

# Temel Prensipler ve Avantajlar
- ➡️ Hafif Yapı: Dapper, minimal bir ORM yapısıdır ve SQL sorgularını hızla çalıştırır. Diğer ORM'lere göre daha az bellek tüketir.
- ➡️ Veritabanı Performansı: Minimum ek yük ile sorgu çalıştırır ve veritabanı performansını artırır.
- ➡️ Esnek SQL Desteği: SQL sorgularını manuel olarak yazmanıza olanak tanır ve sorgular üzerinde tam kontrol sağlar.
- ➡️ Basit Kullanım: Karmaşık ORM yapıları olmadan, basit kodlama ile hızlı sorgular yapılabilir.
- ➡️ Çoklu Veritabanı Desteği: MySQL, SQL Server, PostgreSQL gibi farklı veritabanları ile uyumlu çalışır.
  
  # 🏡 Proje Örneği: Real Estate Yönetim Sistemi
Emlak ilanlarını listelemek, filtrelemek ve detaylarını görüntülemek üzerine kurulmuş bu sistemde,kullanıcılar şehir,
teklif türü (satılık/kiralık) ve kategori (daire, villa vb.) gibi parametrelerle ilanlarıfiltreleyebilir ve detaylarına ulaşabilirler. 
Dapper ile SQL sorguları hızlı ve verimli bir şekilde işlenir.

# Sürecin Adımları:
- ⌨️  İlan Listeleme:  Kullanıcı, şehir, teklif türü ve kategori seçimlerini yaparak ilanları filtreleyebilir.
-  Dapper ile bu seçimlere uygun SQL sorgusu çalıştırılır ve sonuçlar listelenir.
- 🧑‍💻 Veri Filtreleme ve SQL Sorgusu:  Filtreleme parametreleri kullanılarak dinamik SQL sorgusu oluşturulur ve
-  Dapper aracılığıyla veritabanından sonuçlar çekilir..
- ❓ İlan Detaylarına Gitme: Kullanıcı bir ilanı seçtiğinde, detay sayfasına yönlendirilir ve
- daha fazla bilgi alabilir.
- 📜 Verilerin Gösterimi: Filtrelenen veriler, kullanıcıya sade bir arayüzle sunulur. Mobil ve masaüstü cihazlarla uyumludur.

# 🎬 Admin Panelinde Film Verileri Yönetimi (Kaggle Movie Dataset ile)
Admin panelinde, Kaggle'dan indirilen film dataset'i kullanılarak bir Film Yönetim Sistemi oluşturuldu.
Admin panelinde filmler listelenir ve çeşitli filtreleme işlemleri gerçekleştirilir.

# Proje Süreci:
- ⬇️ Kaggle Movie Dataset İndirildi: Örneğin, "IMDb Movies Dataset" kullanılarak film adları, türleri, IMDB puanları gibi veriler çekildi.
- 🗃️Dataset SQL Server'a Yüklendi: Film verileri SQL Server'a yüklendi ve Dapper ile bu veriler üzerinde işlemler yapıldı.
- 📜 Admin Panelinde Listeleme ve Filtreleme: Admin paneli üzerinden filmler listelendi ve admin, film ismine  göre filtreleme işlemleri yapabildi.
- 🖥️ Film Düzenleme ve Silme: Admin, listedeki filmler üzerinde düzenleme ve silme işlemleri yapabildi.



# Öne Çıkan Özellikler:
- 🗃️ Hızlı Veri İşleme: Dapper ile SQL sorgularının hızlı işlenmesi sağlanır.
- 🏙️ Esnek Filtreleme: Kullanıcılar farklı parametrelerle ilanları filtreleyebilir (şehir, teklif türü, kategori).
- 📊 Detay Sayfası: İlanların detayları görüntülenebilir.
- 🌍 Kolay Entegrasyon: Diğer bulut veya veri sağlayıcılarıyla entegrasyon için esnek altyapı.


# 🛠️ Kullanılan Teknolojiler:
- 🎆 .NET Core 6.0: Web uygulamasının temel çerçevesi.
- 🗃️ Dapper: ORM olarak veri erişim katmanında kullanıldı.
- 🎨 HTML/CSS/Bootstrap: Kullanıcı arayüzü tasarımı.
- 🖥️ SQL Server: İlan verilerinin saklandığı veritabanı.
- 🖊️Rich Text Editör
- 📃Pagination
- 🗂️Kaggle Dataset

Bu proje, Dapper'ın hızlı ve esnek yapısını kullanarak emlak verilerini işlemek ve yönetmek için ideal bir yapı sunmaktadır.




   ![d](https://github.com/busenurdmb/Real_EstateDapper/blob/master/Real_EstateDapper/wwwroot/Proje/vbrealestate.png)
#emlak
   ![d](https://github.com/busenurdmb/Real_EstateDapper/blob/master/Real_EstateDapper/wwwroot/Proje/carausel.jpeg)
   ![d](https://github.com/busenurdmb/Real_EstateDapper/blob/master/Real_EstateDapper/wwwroot/Proje/defaultproperty.jpeg)
   ![d](https://github.com/busenurdmb/Real_EstateDapper/blob/master/Real_EstateDapper/wwwroot/Proje/about.jpeg)
   ![d](https://github.com/busenurdmb/Real_EstateDapper/blob/master/Real_EstateDapper/wwwroot/Proje/testimonialfooter.jpeg)
   ![d](https://github.com/busenurdmb/Real_EstateDapper/blob/master/Real_EstateDapper/wwwroot/Proje/filterlayout.jpeg)
   ![d](https://github.com/busenurdmb/Real_EstateDapper/blob/master/Real_EstateDapper/wwwroot/Proje/create.jpeg)
  ![d](https://github.com/busenurdmb/Real_EstateDapper/blob/master/Real_EstateDapper/wwwroot/Proje/detaillayout.jpeg)
   ![d](https://github.com/busenurdmb/Real_EstateDapper/blob/master/Real_EstateDapper/wwwroot/Proje/update.jpeg)
   ![d](https://github.com/busenurdmb/Real_EstateDapper/blob/master/Real_EstateDapper/wwwroot/Proje/properylistt.jpeg)
   
  #kaggle
   ![d](https://github.com/busenurdmb/Real_EstateDapper/blob/master/Real_EstateDapper/wwwroot/Proje/mlist.jpeg)
   ![d](https://github.com/busenurdmb/Real_EstateDapper/blob/master/Real_EstateDapper/wwwroot/Proje/filter.jpeg)
   ![d](https://github.com/busenurdmb/Real_EstateDapper/blob/master/Real_EstateDapper/wwwroot/Proje/mdetail.jpeg)
   ![d](https://github.com/busenurdmb/Real_EstateDapper/blob/master/Real_EstateDapper/wwwroot/Proje/ist.jpeg)

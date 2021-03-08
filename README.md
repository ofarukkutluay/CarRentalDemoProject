## CarRentalDemoProject

#### Aynı Projeyi geliştiriyoruz,
-------------------------------------------------------------------------------------------------------------------------------------------
### Engin Demiroğ Kamp Kurs 15. Gün Ödev 1

#### Yapılanlar;
* JWT ile ilgili ufak hatalar giderildi.
* Cache, Transaction ve Performance aspectleri yazıldı.
* Loglama için Log4Net paketi yardımı ile LogAspect yazıldı.
* Dosyaya xml formatında loglanması için FileLogger yazıldı.
* LogAspect projenin tümünde çalışması sağlandı.

#### Ödev içeriği;
* Cache, Transaction ve Performance aspectlerini ekleyiniz.

-------------------------------------------------------------------------------------------------------------------------------------------
### Engin Demiroğ Kamp Kurs 14. Gün Ödev 2

#### Yapılanlar;
* "User" nesnesi ve karşılık gelen Users tablosundaki özellikler güncellendi.
  * Password özelliği çıkarıldı.
  * PasswordHash, PasswordSalt ve Status özellikleri eklendi.
* "User" nesnesi artık her katmanda kullanılacığı için Core katmanına taşındı.
* Yetkilendirme için Entity'ler ve karşılığı tablolar oluşturuldu.
  * OperationClaims --> Id,Name
  * UserOperationClaims --> Id,UserId,OperationClaimId
* WebApi içindeki konfigurasyon dosyasına "TokenOption" öğeleri eklendi.
* Core katmanında Utilities içinde Security klasörü oluşturuldu. 
  * Security içine Encryption klasörü ile SecurityKeyHelper ve SigningCredentialsHelper class'ları yazıldı.
  * Security içine Hashing klasörü ile HashingHelper class'ı yazıldı.
  * Security içine JWT klasörü ile JwtHelper yazıldı ve yardımcı AccessToken, ITokenHelper, TokenOption class' ları yazıldı.
* Business katmanında AuthManager yazıldı.
* Entities katmanında AuthManager ın ihtiyaç duyacağı UserForLoginDTO ve UserForRegisterDTO entitiy leri oluşturuldu.
* WebAPI de AuthController "login" ve "register" yazıldı ve Autofac de ihtiyaç duyacağı instancelar oluşturuldu.
* Sadece Business katmanında kullanılacağı için BusinessAspect klasörü Business oluşturuldu.
  * İçinde SecurityOperation yazıldı.
  * Yardımcı IoC, Core katmanı içinde Utilities altında ServiceTool yazıldı.
* Business katmanında CarManager içinde SecurityOperation AOP uygulandı.
* Postmanda test edildi


#### Ödev içeriği;
* RentACar projenize JWT entegrasyonu yapınız.

-------------------------------------------------------------------------------------------------------------------------------------------
### Engin Demiroğ Kamp Kurs 13. Gün Ödev 1

#### Yapılanlar;
* "CarImage" nesnesi oluşturuldu.
* CarImages tablosu Id,CarId,ImagePath ve Date kolonları ile oluşturuldu.
* Core katmanında Utilities içerisinde FileHelper oluşturuldu.
* Api üzerinde resimleri ekleme ve silme yapacak operasyon yazıldı.
* Resimlerin ekleme kuralları yazıldı. Aşağıdaki gibidir,
  * Resimler GUID isimlendirme ile dosyalanacak
  * Bir arabanın en fazla 5 Resmi olabilir
  * Eğer bir arabaya ait resim yoksa default resim yansıyacak
  * Resim ekleme tarihi o günün tarihi olarak sistem atayacak.

#### Ödev içeriği;
Artık araştırma yapıp, yeni işlemleri projeye ekleyebilmemiz gerekiyor.

RentACar projenizde;

* CarImages (Araba Resimleri) tablosu oluşturunuz. (Id,CarId,ImagePath,Date) Bir arabanın birden fazla resmi olabilir.
* Api üzerinden arabaya resim ekleyecek sistemi yazınız.
* Resimler projeniz içerisinde bir klasörde tutulacaktır. Resimler yüklendiği isimle değil, kendi vereceğiniz GUID ile dosyalanacaktır.
* Resim silme, güncelleme yetenekleri ekleyiniz.
* Bir arabanın en fazla 5 resmi olabilir.
* Resmin eklendiği tarih sistem tarafından atanacaktır.
* Bir arabaya ait resimleri listeleme imkanı oluşturunuz. (Liste)
* Eğer bir arabaya ait resim yoksa, default bir resim gösteriniz. Bu resim şirket logonuz olabilir. (Tek elemanlı liste)

-------------------------------------------------------------------------------------------------------------------------------------
### Engin Demiroğ Kamp Kurs 12. Gün Ödev 1-2-3

#### Yapılanlar;
* Autofac desteği eklenerek WebApi katmanında düzenlemeler yapıldı.
* FluentValidation desteği eklendi.
* AOP desteği eklendi.
* ValidationAspect ile daha önce yazılmış Validasyon kuralları düzenlendi.

#### Ödev içeriği;
* Autofac desteği ekleyiniz.
* FluentValidation desteği ekleyiniz.
* AOP desteği ekleyiniz.
* ValidationAspect ekleyiniz.

-------------------------------------------------------------------------------------------------------------------------------------
### Engin Demiroğ Kamp Kurs 11. Gün Ödev 1

#### Yapılanlar;
* WebAPI  katmanı oluşturuldu.
* Business katmanındaki tüm servislerin Api karşılığı yazıldı.
* Postman ile test edildi.

#### Ödev içeriği;
* WebAPI katmanını kurunuz.
* Business katmanındaki tüm servislerin Api karşılığını yazınız.
* Postman'de test ediniz.

-------------------------------------------------------------------------------------------------------------------------------------
### Engin Demiroğ Kamp Kurs 10. Gün Ödev 4

#### Yapılanlar;
* Aşağıdaki tablolar ve Entity nesneleri oluşturuldu,
  * Users-->Id,FirstName,LastName,Email,Password
  * Customers-->UserId,CompanyName
  * Rentals-->Id, CarId, CustomerId, RentDate(Kiralama Tarihi), ReturnDate(Teslim Tarihi)
* Bu tabloların EntitiyFramework ile Crud operasyonları yazıldı.
* Arabanaın kiralanabilmesi için Add operasyonuna aracın teslim edilmesi gerekliliği If-Else yapısı ile kodlandı.

#### Ödev içeriği;
* Kullanıcılar tablosu oluşturunuz. Users-->Id,FirstName,LastName,Email,Password
* Müşteriler tablosu oluşturunuz. Customers-->UserId,CompanyName
  * _Not : Kullanıcılar ve müşteriler ilişkilidir._
* Arabanın kiralanma bilgisini tutan tablo oluşturunuz. Rentals-->Id, CarId, CustomerId, RentDate(Kiralama Tarihi), ReturnDate(Teslim Tarihi). Araba teslim edilmemişse ReturnDate null'dır.
* Projenizde bu entity'leri oluşturunuz.
* CRUD operasyonlarını yazınız.
* Yeni müşteriler ekleyiniz.
* Arabayı kiralama imkanını kodlayınız. Rental-->Add
* Arabanın kiralanabilmesi için arabanın teslim edilmesi gerekmektedir.

--------------------------------------------------------------------------------------------------------------------------------------
### Engin Demiroğ Kamp Kurs 9. Gün Ödev 1

#### Yapılanlar;
* Core katmanı oluşturuldu.
* IEntity, IDto, IEntityRepository interfaceleri ile kurallar oluşturuldu.
* Core da EfEntityRepositoryBase oluşturularak DataAccess katmanındaki CRUD operasyonları nesnelleştirildi.
* "CarDetailsDTO" nesnesi oluşturuldu.
  * EfCarDal içinde CarDetailDTO nesnesi kullanılarak GetCarDetails operasyonunu join olarak yazıldı

#### Ödev içeriği;
_**Not :** İsteyenler Northwind projesindeki Core katmanını da ekleyebilir ama pekiştirmek için yeniden yazmanızı öneririm. Bu şekilde yapmak isteyenler CarRental/Solution Explorer Sağ Tık / Add /Existing Project/ Northwind içindeki Core klasöründe Core.csproj dosyasını ekleyebilirler. Bu şekilde yapanlar aşağıdaki 3. adımdan devam edebilirler._

- Önerim aşağıdaki gibi yeniden yapmanızdır,
  - CarRental Projenizde Core katmanı oluşturunuz.
  - IEntity, IDto, IEntityRepository, EfEntityRepositoryBase dosyalarınızı 9. gün dersindeki gibi oluşturup ekleyiniz.
  - Car, Brand, Color sınıflarınız için tüm CRUD operasyonlarını hazır hale getiriniz.
  - Console'da Tüm CRUD operasyonlarınızı Car, Brand, Model nesneleriniz için test ediniz. GetAll, GetById, Insert, Update, Delete.
  - Arabaları şu bilgiler olacak şekilde listeleyiniz. CarName, BrandName, ColorName, DailyPrice. (İpucu : IDto oluşturup 3 tabloya join yazınız)
  - Kodlarınızı Github hesabınızda paylaşıp link veriniz.

---------------------------------------------------------------------------------------------------------------------------------------
### Engin Demiroğ Kamp Kurs 8. Gün Ödev 1

#### Yapılanlar;
* "Brand" nesnesi Id, Name alanları ile olıuşturuldu.
*  "Color" nesenesi Id, Name alanları ile oluşturuldu.
*  Sql Server da Local de "Cars","Brands" ve "Colors" tabloları oluşturuldu.
*  IEntitiyRepository generic altyapı ile CRUD operasyonları kuralları yazıldı.
*  Tüm nesneler için Entitiy Framework altyapısı kuruldu.
*  "CarManager" da GetCarsByBrandId , GetCarsByColorId servisleri yazıldı.
*  If-else yapısı ile Add operasyonunda aşağıdaki kurallar getirildi,
   *  Araba ismi minimum 2 karakter olmalıdır
   *  Araba günlük fiyatı 0'dan büyük olmalıdır.

#### Ödev İçeriği;
Araba Kiralama projemiz üzerinde çalışmaya devam edeceğiz.
 * Car nesnesine ek olarak;
   * Brand ve Color nesneleri ekleyiniz(Entity)
    - Brand-->Id,Name
    - Color-->Id,Name
 * Sql Server tarafında yeni bir veritabanı kurunuz. Cars,Brands,Colors tablolarını oluşturunuz. (Araştırma)
 * Sisteme Generic IEntityRepository altyapısı yazınız.
 * Car, Brand ve Color nesneleri için Entity Framework altyapısını yazınız.
 * GetCarsByBrandId , GetCarsByColorId servislerini yazınız.
 * Sisteme yeni araba eklendiğinde aşağıdaki kuralları çalıştırınız.
   * Araba ismi minimum 2 karakter olmalıdır
   * Araba günlük fiyatı 0'dan büyük olmalıdır.
Ödevinize ait github linkini paylaşınız.

----------------------------------------------------------------------------------------------------------------------------------
### Engin Demiroğ Kamp Kurs 7. Gün Ödev 2

#### Yapılanlar;
* ReCapProject ismi CarRentalDemoProject olarak oluşturuldu.
* Entities, DataAccess, Business ve Console katmanlarını oluşturuldu.
* "Car" nesensi Id, BrandId, ColorId, ModelYear, DailyPrice, Description alanları ile oluşturuldu. 
* InMemory formatta GetById, GetAll, Add, Update, Delete oprasyonlarını yazıldı.

Console da test edildi...


#### Ödev İçeriği;
- Kampımızla beraber paralelde geliştireceğimiz bir projemiz daha olacak. Araba kiralama sistemi yazıyoruz.
- Yepyeni bir proje oluşturunuz. Adı ReCapProject olacak. (Tekrar ve geliştirme projesi)
- Entities, DataAccess, Business ve Console katmanlarını oluşturunuz.
- Bir araba nesnesi oluşturunuz. "Car"
  - Özellik olarak : Id, BrandId, ColorId, ModelYear, DailyPrice, Description alanlarını ekleyiniz. (Brand = Marka)
- InMemory formatta GetById, GetAll, Add, Update, Delete oprasyonlarını yazınız.

Consolda test ediniz.

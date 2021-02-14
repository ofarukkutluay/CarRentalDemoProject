# CarRentalDemoProject

Aynı Projeyi geliştiriyoruz,
-------------------------------------------------------------------------------------------------------------------------------------
Engin Demiroğ Kamp Kurs 10. Gün Ödev4

Ödev içeriği;

CarRental projenizde;

Kullanıcılar tablosu oluşturunuz. Users-->Id,FirstName,LastName,Email,Password
Müşteriler tablosu oluşturunuz. Customers-->UserId,CompanyName
*****Kullanıcılar ve müşteriler ilişkilidir.
Arabanın kiralanma bilgisini tutan tablo oluşturunuz. Rentals-->Id, CarId, CustomerId, RentDate(Kiralama Tarihi), ReturnDate(Teslim Tarihi). Araba teslim edilmemişse ReturnDate null'dır.
Projenizde bu entity'leri oluşturunuz.
CRUD operasyonlarını yazınız.
Yeni müşteriler ekleyiniz.
Arabayı kiralama imkanını kodlayınız. Rental-->Add
Arabanın kiralanabilmesi için arabanın teslim edilmesi gerekmektedir.


--------------------------------------------------------------------------------------------------------------------------------------

Engin Demiroğ Kamp Kurs 9. Gün Ödev1

Ödev içeriği;

Not : İsteyenler Northwind projesindeki Core katmanını da ekleyebilir ama pekiştirmek için yeniden yazmanızı öneririm. Bu şekilde yapmak isteyenler CarRental/Solution Explorer Sağ Tık / Add /Existing Project/ Northwind içindeki Core klasöründe Core.csproj dosyasını ekleyebilirler. Bu şekilde yapanlar aşağıdaki 3. adımdan devam edebilirler.

Önerim aşağıdaki gibi yeniden yapmanızdır.

CarRental Projenizde Core katmanı oluşturunuz.
IEntity, IDto, IEntityRepository, EfEntityRepositoryBase dosyalarınızı 9. gün dersindeki gibi oluşturup ekleyiniz.
Car, Brand, Color sınıflarınız için tüm CRUD operasyonlarını hazır hale getiriniz.
Console'da Tüm CRUD operasyonlarınızı Car, Brand, Model nesneleriniz için test ediniz. GetAll, GetById, Insert, Update, Delete.
Arabaları şu bilgiler olacak şekilde listeleyiniz. CarName, BrandName, ColorName, DailyPrice. (İpucu : IDto oluşturup 3 tabloya join yazınız)
Kodlarınızı Github hesabınızda paylaşıp link veriniz.
Başkalarının kodlarını inceleyiniz. Beğenirseniz yıldız veriniz.

---------------------------------------------------------------------------------------------------------------------------------------


Engin Demiroğ Kamp kurs 8. Gün Ödev 1

Ödev İçeriği;

Araba Kiralama projemiz üzerinde çalışmaya devam edeceğiz.

Car nesnesine ek olarak;

Brand ve Color nesneleri ekleyiniz(Entity)
Brand-->Id,Name

Color-->Id,Name

Sql Server tarafında yeni bir veritabanı kurunuz. Cars,Brands,Colors tablolarını oluşturunuz. (Araştırma)

Sisteme Generic IEntityRepository altyapısı yazınız.

Car, Brand ve Color nesneleri için Entity Framework altyapısını yazınız.

GetCarsByBrandId , GetCarsByColorId servislerini yazınız.

Sisteme yeni araba eklendiğinde aşağıdaki kuralları çalıştırınız.

Araba ismi minimum 2 karakter olmalıdır

Araba günlük fiyatı 0'dan büyük olmalıdır.

Ödevinize ait github linkini paylaşınız.


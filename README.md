## Dapper ORM hakkında gerekli bilgileri ve açıklamarı diğer repomda paylaşmıştım bu linkden okuyabilirsiniz  : https://github.com/MBatuhanZanlier/RealEstate_Dapper_Api

## Dapper ORM ile geliştirdiğim Emlak ilan yayınlama websitesi 
 Bu proje eğitim aldığım MY yazılım Akedemi eğitim programında ki 10 nuncu projem. 
## Projenin  özellikleri 
Bu proje mini bir proje olup .Net Core 8.0 ile  *Dapper ORM*  kullanalarak geliştirilmiştir. Admin panelinde CRUD işlemler uygulanmıştır. UI kısmında ise ilanın öne çıkanları,ilan aramaları,tüm ilanları paganetion(sayfalama) ile listelenmiştir. 
## Kullanılan Teknolojiler 
1. Dapper ORM
2. .NET CORE 8.0
3. MSSQL
4. X.PAGEDLİST
## X.PagedList Kütüpahenin avantajları nelerdir? 
X.PagedList kütüphanesi, ASP.NET MVC ve ASP.NET Core projelerinde veritabanındaki büyük veri setlerini sayfalayarak göstermek için kullanılan güçlü bir araçtır. Bu kütüphane, sayfalama (pagination) işlemlerini kolaylaştırır ve birkaç önemli fayda sağlar.   
- Veritabanı Optimizasyonu: Büyük veri setlerinde verilerin tamamını almak yerine, sadece mevcut sayfada gösterilmesi gereken kısmı çekebilirsiniz. Bu, performansı büyük ölçüde iyileştirir.
- Daha Az Bellek Kullanımı:Bellek Yönetimi: Veritabanından yalnızca o sayfaya ait veriler çekildiğinden, büyük veri setlerinde bellekte daha az yer kaplar. Bu, özellik sınırlı kaynaklara sahip makinelerde önemli bir avantajdır.
- X.PagedList kütüphanesi, verilerinizi sayfalayarak kullanıcıya gösterirken performansı artırır, bellek kullanımını azaltır, kolayca sayfalama kontrolleri eklemenizi sağlar ve geliştiriciye iş yükü azaltır. Bu kütüphane özellikle büyük veri setlerini yönetirken son derece kullanışlıdır.
## Dapper ile PagedList Nasıl Yapılır. 
1.Öncelikle veritabanınızda dönecek olan model veya Dto sınıfını oluşturun.  
![Ekran Görüntüsü (221)](https://github.com/user-attachments/assets/a29537f6-9960-45e2-8604-dd763741991c)
2.IPropertyService interface içine metodumuzun imzasını atın. 
![Ekran Görüntüsü (223)](https://github.com/user-attachments/assets/f959b61a-9aad-4713-8008-75f2a574456c)
Burda list türünü IpagedList almamımın sebebi biz sayfalama yapacağımız için ıpagedList döndürdük çünkü kendisinin iki tane parametre alıyor. 
Yani kısacası döndürülen verinin sayfalama (pagination) yapılmış bir liste olduğunu gösterir. Yani, veritabanından çekilen veriler bir sayfa olarak döndürülür.
IPagedList: Sayfalama bilgilerini (sayfa numarası, toplam sayfa sayısı, toplam kayıt sayısı vb.) içerir. 
3.İmzansını attığımız methodun İçini dolduralım.
![Ekran Görüntüsü (225)](https://github.com/user-attachments/assets/c449f904-1c2b-4eeb-8ddc-ff83aadb82b9)
4.Methodumuzu Cotrollerda çağıralım.
![Ekran Görüntüsü (226)](https://github.com/user-attachments/assets/89af6168-f04b-4f42-bab4-80277d0aada1)
(int page=1,int pagesize=6)= Sayfamızda  page=1 olan 1. sayafada başlayıp ve pagesize=6 olan paremetlersi sayfada kaçar det veri tutacağını belirler örnekdekinde her 1 sayfada 6 adet veri listelendikden sonra diğer sayfaya geçiyor olmasıdır.
5.Listeleme yapacağımız Indexin içine views açalım.  
6.Veri Listeleme ve sayfalandırma.
![Ekran Görüntüsü (228)](https://github.com/user-attachments/assets/e4573bbb-6691-4c4d-9cea-6bee67ccbaf5) 
@using X.PagedList;
@using X.PagedList.Mvc.Core; 
NuGet paketlerine ait isim alanlarını (namespace) dahil etmek için kullanılır. Bu sayede sayfalama (pagination) işlemi ile ilgili fonksiyonlar ve yardımcı sınıflar (helper methods) kolayca kullanılabilir.  
@model IPagedList<ResultPagedWithProperty Methodumuz IPagedList türünde döndürdüğümüz için burdada aynı türü döndürüyoruz. 
Benim Templatdeki sayfalandırma buttonları bu şekilde olduğu için bu şekilde yaptım resimde ileri geri buttonlarının açıklamarı mevcuttur.  
for ile birer birer arttırdım modelden gelen kaç adet sayfa varsa for içinde okadar dönecektir.
![Ekran Görüntüsü (229)](https://github.com/user-attachments/assets/87a5bfb7-d4c2-49e9-b8ab-4a1ce5570ae7)
Resimde görüldüğü gibi  1. sayfamda toplamda 6 adet veri listeledim toplamda 8 adet verim var idi o yüzden geri kalan diğer verileri 2.ci sayfamda listelemiş oldu. 
![Ekran Görüntüsü (230)](https://github.com/user-attachments/assets/6d62dd1e-995c-4b2f-8bef-f8826a3669a4)
Ellimden geldiğince X.pagedlist kütüpahesinin nasıl kullanıldığı anlatmış oldum. 
## Projem ile ilgili görseller 
### İlan arama
![Ekran Görüntüsü (209)](https://github.com/user-attachments/assets/c3a263d3-e381-44e2-8324-21cbb7359171)
### Hizmetler ve Öne çıkan İlanlar
![Ekran Görüntüsü (219)](https://github.com/user-attachments/assets/fc4d6ef4-9e97-4f5b-a2f6-68dec7f0b12e)
### Son Eklenen 5 İlanlar 
![Ekran Görüntüsü (211)](https://github.com/user-attachments/assets/0d8d1022-58f7-4814-a04f-ba96ad64c46b)
###  İslatistik ve Referanslar
![Ekran Görüntüsü (212)](https://github.com/user-attachments/assets/56d311c6-a6e3-4725-88c4-b6ad77ff890f)
### Footer
![Ekran Görüntüsü (213)](https://github.com/user-attachments/assets/b7c7b2b6-7e46-4d7b-b2a4-6b0b612aaa8d)
### Tüm İlanların Listelenmesi 
![Ekran Görüntüsü (214)](https://github.com/user-attachments/assets/7f0bc7ef-5993-4545-83d1-bfd9b830fa61) 
### ilanın detay Sayfası  ve Kategorilerin listelenmesi ve aynı kategoriden kaç adet ilanın olmasının listelenmesi
![Ekran Görüntüsü (218)](https://github.com/user-attachments/assets/766022ad-99af-4d6b-b41b-81f93b8ba584)
### Yotube Enbed linki Listelenmesi ve en son eklenen yeni ilan 
![Ekran Görüntüsü (216)](https://github.com/user-attachments/assets/45a706fd-7578-4158-82e4-27ec8d5afd0d)
## Admin Sayfası 
![Ekran Görüntüsü (205)](https://github.com/user-attachments/assets/005562e6-3094-42da-9da9-f9d1e49638a2)
![Ekran Görüntüsü (207)](https://github.com/user-attachments/assets/d15a9ccc-c60f-48ca-b909-c5e21659e1cd)
![Ekran Görüntüsü (208)](https://github.com/user-attachments/assets/5342b5d5-ee15-42c9-aeff-ef1734c88bc1) 

## MsSQl Tüm tablolar ve ilişkili tablolar 
![Ekran Görüntüsü (220)](https://github.com/user-attachments/assets/d164eee2-8003-4287-9420-baf3825bed81)

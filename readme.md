# Hukuk Bürosu Veritabanı Yönetim Sistemi

**Sena Aksu**   


## Proje Amacı

Bu proje, bir hukuk bürosunun avukat, stajyer, müvekkil ve dosya bilgilerini saklayan bir veritabanı uygulamasıdır. Uygulama, bu bilgileri ekleme, düzenleme, listeleme, arama ve silme işlemlerini gerçekleştirecek şekilde tasarlanmıştır. Windows form uygulaması olarak geliştirilmiş olup, veritabanı kısmında **PostgreSQL**, ara yüz ve kullanıcı işlemlerinde ise **C#** programlama dili kullanılmıştır.

## İş Kuralları

- Sistemdeki her kişi benzersiz bir `id` ile temsil edilir.
- Avukat, stajyer ve müvekkil üzerinde ekleme, arama, güncelleme, listeleme ve silme işlemleri yapılabilir.
- Dosya üzerinde ekleme, listeleme ve silme işlemleri yapılabilir.
- Kişi tablosu `ad`, `soyad`, `cinsiyet`, `tc` ve `dogumTarihi` alanlarını içerir.
- Bir kişinin bir cinsiyeti vardır.
- Avukatların birden fazla müvekkili olabilir; müvekkillerin ise bir avukatı vardır.
- Her müvekkilin bir durumu ve bir ödeme durumu vardır.
- Müvekkiller birden fazla dosyaya sahip olabilir; dosyaların bir müvekkili vardır.
- Her dosyanın bir mahkeme türü, dosya durumu, derecesi ve bulunduğu il vardır.

## İlişkisel Şema

- **tblkisi**: `kisid`, `adsoyad`, `cinsiyetid`, `tc`, `dogumTarihi`, `telefon`, `ePosta`
- **tblavukat**: `sicilNo`
- **tblstajyer**: `baslangicTarihi`, `bitisTarihi`
- **tblmuvekkil**: `mDurumID`, `modemeID`, `avid`
- **tbldosya**: `dosyaNo`, `mahkemeTur`, `ilID`, `dosyaDurumID`, `dosyaDerece`, `muvid`
- **tblmuvekkildurum**: `mDurumID`, `mDurum`
- **tblmuvekkilodeme**: `mOdemeID`, `mOdeme`
- **tbldosyaderece**: `dosyaDereceID`, `dosyaDerece`
- **tbldosyadurum**: `dosyaDurumID`, `dosyaDurum`
- **tblmahkemetur**: `mahkemeTurID`, `mahkemeTur`
- **tblcinsiyet**: `cinsiyetId`, `cinsiyet`
- **tblil**: `ilID`, `ilAdi`
- **tblduyuru**: `duyuruid`, `baslik`, `aciklama`
- **tblhakkimizda**: `hakkimizdaid`, `hakkimizda`
- **tblresim**: `resimid`, `resim`




## Proje Fotoğrafları

Projenin ekran görüntülerini aşağıda görebilirsiniz:

<p>
  <img src="https://github.com/senaksu/Hukuk_Burosu_Otomasyon_Sistemi/blob/main/hukuk%20otomasyon/veritaban%C4%B1%20resim/varlikbagintipoje.png?raw=true" width="300" style="margin-right: 20px;" />
  <img src="https://github.com/senaksu/Hukuk_Burosu_Otomasyon_Sistemi/blob/main/hukuk%20otomasyon/veritaban%C4%B1%20resim/ekran1.png?raw=true" width="300" style="margin-right: 20px;" />
</p>

<p>
  <img src="https://github.com/senaksu/Hukuk_Burosu_Otomasyon_Sistemi/blob/main/hukuk%20otomasyon/veritaban%C4%B1%20resim/ekran2.png?raw=true" width="300" style="margin-right: 20px;" />
  <img src="https://github.com/senaksu/Hukuk_Burosu_Otomasyon_Sistemi/blob/main/hukuk%20otomasyon/veritaban%C4%B1%20resim/ekran3.png?raw=true" width="300" />
</p>

# three-darts-to-the-wind

## Oynanış
> Oyun 3 farklı dart okunun dart tahtasına atılması ve vurulan dart tahtasının 3 ok sonrası yok edilmesini konu almaktadır. Esc tuşu sonrası oyundan çıkabilirsiniz.
## Oyun Görseli
![This is an image](https://i.ibb.co/xjSVzVH/Ekran-G-r-nt-s-33.png)
## Tuşlar
> Oyunda dart oklarının hareketi mouse ile sağlanmaktadır. Space tuşu atış yapmaktadır.
## Benim Geliştirdiğim Kısımlar ve Kodladığım Scriptler
### dur.cs
- Pause modunu birçok oyunda görmüşsünüzdür bu kodda pause modu kullanıldı. Burada Unity’nin zaman ölçeği olan Time.timeScale değişkeni kullanıldı. 
- İlk başta bir varsayılan değeri belirleyip(oyundurumu) bunu false olarak yazdırıldı .
- Void update kısmında oyun çalışırken Esc tuşuna basılınca if , else blokları ile kontrol edilir 
    * Eğer oyun durumu true ise oyunu devam ettir ve oyun durumunu false olarak değiştir. 
    * False ise oyunu durdur ve oyun durumunu true olarak değiştir.    
- Bu bölümde daha çok arayüz üzerinde çalışıldı. Üzerinde çalışılan arayüz kazanımları ;
    * Canvas 
    * Button 
    * Panel

## Ekip Arkadaşlarımın Geliştirdiği Kısımlar ve Kodladığı Scriptler (BETÜL YALÇIN)
### dondur.cs
- yeni bir Time nesnesi ve Inspectordan erişilebilen _move değişkeni oluşturuldu.
- update fonksiyonu içinde yer alan transform.Rotate() sayesinde her fps de dart tahtasının z ekseni üzerinde dönmesi sağlandı.
### vur.cs
- Header Inspector'daki değişkenlerin gruplandırılmasını sağlar.
- Dosyada kullanılacak değişkenler 'Kaynak', 'Değişken' ve 'Atış' olarak 3 e bölündü
- Update fonksiyonunun içinde GetAxis ile mouse hareketi algılama ve Space tusu ile atış sağlandı.
- At() fonksiyonu içinde Instantiate() ile yeni obje oluşturuldu.
- Rigitbody ile objeye fizik eklendi.
- Raycast ile olusturulan objenin dart tahtasıyla teması denetlenir.
- Invoke() ile bekleme suresi sonrası atış sağlandı.
### tahtayikaldir.cs
- 3 atış sonrası dart tahtasının ortadan kaldırılmasını sağlar.
### iliski.cs
- vur.cs ve tahtayikaldir.cs arasındaki ilişkiyi sağlar.
- OnCollisionEnter fonksiyonu nesnelerin birbirine çarpısmasını denetler:
    * eğer iki cisim çarpıştıysa zarar ver ve 3 ten fazla çarpıstıysa tahtayı kaldır.
## Oyun Linki
[Link](https://simmer.io/@betulyalcin/3-darts-to-the-wind)

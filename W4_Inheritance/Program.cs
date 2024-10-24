using W4_Inheritance;

Ogretmen ogretmen = new Ogretmen();
ogretmen.Ad = "Alev";
ogretmen.Soyad = "Bayindirli";
ogretmen.MaasBilgisi = 60000;

ogretmen.Yazdir();  //burada override yaptigim icin basekisideki gibi cagirabilirim metodu

Ogrenci ogrenci = new Ogrenci();
ogrenci.Ad = "Aysel";
ogrenci.Soyad = "Bilmez";
ogrenci.OgrenciNumarasi = 2239126;

ogrenci.OgrenciBilgileriniYazdir(); //burada yeni bir metot olusturdugumuz icin yazdir() kullanamayiz tek basina numara gozukmez

Console.ReadKey();
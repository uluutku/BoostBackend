// Klavyeden kullanıcı tarafından girilen sayının karesini KareAl() metoduna alıp sonucu ekrana yazdıran.
// Geriye değer döndüren ve geriye değer döndürmeyen olarak.

Console.WriteLine("Sayı gir: ");
int girilenSayi = int.Parse(Console.ReadLine());

KareAl();

KareAl2(girilenSayi);

int karesi = KareAl3();
Console.WriteLine("Sonuc: " + karesi);

int sonuc = KareAl4(girilenSayi);
Console.WriteLine("Return: " + sonuc);

void KareAl()  // Tüm işlemler fonksiyon içinde. Global değişkeni kullan.
{
    Console.WriteLine("Sayının karesi: " + (girilenSayi * girilenSayi));
}

static void KareAl2(int gelenSayi) // Fonksiyon içine gönderilen değeri kullanarak fonksiyon içinde işlem yap, geri bir şey dönme. KareAl2(elma) da girsen. KareAl2(int gelenSayi) karşılar, fonksiyon içinde gelenSayi ile o değeri kullanırsın.
{
    Console.WriteLine("Sayının karesi: " + (gelenSayi * gelenSayi));
}

static int KareAl3() // Parametre göndermeden değişkeni burada alıp işi burda yaparak da olur.
{
    Console.WriteLine("Sayı gir: ");
    int girisSayi = int.Parse(Console.ReadLine());

    return girisSayi * girisSayi;
}

static int KareAl4(int gelenSayi) // Fonksiyon içinde int sonuc = KareAl4(girilenSayi); ile gönderlien değeri hesaplayıp sonucu int sonuc = KareAl4(girilenSayi); yani int sonuc = 25 olarak dön.
{
    return gelenSayi * gelenSayi;
}

//geri bir değer dönecekse static int FonksiyonAdi(); olarak oluşturulur, int burda dönecek değerin türü demek.

//eğer oluşan değer int değilse dışarı çıkaramaz, manuel convert edip returnu bu değer yapmak gerekir.

//eğer değer dönmeyecekse static void FonksiyonAdi2(); geri birşey dönmeyeceği için tipi de yok.
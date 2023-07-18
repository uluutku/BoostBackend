using System;

#region SınavSoru

static int adimUzunluguAl() //Kullanıcının adım uzunluğunu alıp değerin uyumluluğunu kontrol eden fonksiyon. 
{
    int adimUzunlugu = 0;
    bool adimVeriGecerliMi = false;

    do
    {
        try
        {
            Console.Write("Ortalama adım uzunluğunu cm cinsinden tam sayı olarak giriniz: ");
            adimUzunlugu = int.Parse(Console.ReadLine());

            if (adimUzunlugu >= 10 && adimUzunlugu <= 150) //Bir insanın olabilecek adım uzunluğunu aralığında mı kontrol etme.
            {
                adimVeriGecerliMi = true; //Döngüden çıkılması için veriyi doğru aldığımızı kaydediyoruz.
            }
            else
            {
                Console.WriteLine("Hatalı giriş! Adım uzunluğu normal aralıkta değil (10-150). Lütfen tekrar giriniz.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Hatalı giriş! Lütfen sadece tam sayı giriniz."); //Değer tam sayı mı kontrol etme.
        }
        catch (OverflowException)
        {
            Console.WriteLine("Hatalı giriş! Girilen sayı çok büyük veya çok küçük."); //Değer istenen sınırlarda mı kontrol etme.
        }
    } while (adimVeriGecerliMi == false); // Veri geçerli kabul edilmediği sürece tekrar alıyoruz.

    return adimUzunlugu;
}//Kullanıcının adım uzunluğunu alıp değerin uyumluluğunu kontrol eden fonksiyon.

static int dakikadakiAdimSayisiAl() //Kullanıcının bir dakikad attığı adım sayısını alıp değerin uyumluluğunu kontrol eden fonksiyon.
{
    int dakikadaAdimSayisi = 0;
    bool dakikadaAdimVeriGecerliMi = false;

    do
    {
        try
        {
            Console.Write("Dakikada koştuğunuz adım sayısını tam sayı olarak giriniz: ");
            dakikadaAdimSayisi = int.Parse(Console.ReadLine());

            if (dakikadaAdimSayisi >= 1 && dakikadaAdimSayisi <= 300)
            {
                dakikadaAdimVeriGecerliMi = true; //Döngüden çıkılması için veriyi doğru aldığımızı kaydediyoruz.
            }
            else
            {
                Console.WriteLine("Hatalı giriş! Adım sayısı geçerli bir aralıkta değil (1-300). Lütfen tekrar giriniz."); //Bir insanın atabileceği adım sayısı aralığında mı kontrol etme.
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Hatalı giriş! Lütfen bir tam sayı giriniz."); //Tam sayı girildiğni kontrol etme.
        }
        catch (OverflowException)
        {
            Console.WriteLine("Hatalı giriş! Girilen sayı çok büyük veya çok küçük."); //İstenen sınırlarda olduğunu kontrol etme.
        }
    } while (dakikadaAdimVeriGecerliMi == false);

    return dakikadaAdimSayisi;
} //Kullanıcının bir dakikada attığı adım sayısını alıp değerin uyumluluğunu kontrol eden fonksiyon.

static int saatAl() //Kullanıcının koştuğu sürenin saat kısmını alıp, değerin uyumluluğunu kontrol eden fonksiyon.
{
    int saat = 0;
    bool saatVeriGecerliMi = false;

    do
    {
        try
        {
            Console.Write("Koşu süresini saat olarak giriniz: ");
            saat = int.Parse(Console.ReadLine());
            saatVeriGecerliMi = true; //Döngüden çıkılması için veriyi doğru aldığımızı kaydediyoruz.
        }
        catch (FormatException)
        {
            Console.WriteLine("Hatalı giriş! Lütfen saat olarak bir tam sayı giriniz.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Hatalı giriş! Girilen saat değeri çok büyük veya çok küçük.");
        }
    } while (saatVeriGecerliMi == false);

    return saat;
}//Kullanıcının koştuğu sürenin saat kısmını alıp, değerin uyumluluğunu kontrol eden fonksiyon.

static int dakikaAl() //Kullanıcının koştuğu sürenin dakika kısmını alıp, değerin uyumluluğunu kontrol eden fonksiyon.
{
    int dakika = 0;
    bool dakikaVeriGecerliMi = false;

    do
    {
        try
        {
            Console.Write("Koşu süresini dakika olarak giriniz: ");
            dakika = int.Parse(Console.ReadLine());

            if (dakika >= 0 && dakika <= 59) // Dakika değeri 0 ile 59 arasında olmalıdır.
            {
                dakikaVeriGecerliMi = true;
            }
            else
            {
                Console.WriteLine("Hatalı giriş! Dakika değeri geçerli bir aralıkta değil (0-59). Lütfen tekrar giriniz.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Hatalı giriş! Lütfen dakika olarak bir tam sayı giriniz.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Hatalı giriş! Girilen dakika değeri çok büyük veya çok küçük.");
        }
    } while (dakikaVeriGecerliMi == false);

    return dakika;
}//Kullanıcının koştuğu sürenin dakika kısmını alıp, değerin uyumluluğunu kontrol eden fonksiyon.

static double kosuMesafesiHesapla(int adimUzunlugu, int dakikadaAdimSayisi, int kosuSuresiSaat, int kosuSuresiDakika)
{
    // Koşu süresini girilen saat ve dakika verilerini kullanarak toplam dakika haline getiriyoruz.
    int toplamDakika = kosuSuresiSaat * 60 + kosuSuresiDakika;

    // Koşunun toplam dakika süresiyle bir dakikadaki adım sayısını kullanarak koşuda atılan toplam adım sayısını buluyoruz.
    double toplamAdimSayisi = toplamDakika * dakikadaAdimSayisi;

    // Koşu boyunca toplam atılan adım sayısı ile adım uzunluğunu kullanarak toplam mesafeyi (CM) cinsinden bulup 100 e bölerek Metre cinsine ceviriyoruz.
    double toplamMesafe = toplamAdimSayisi * adimUzunlugu / 100.0;

    return toplamMesafe;
} //Girilen verileri kullanarak mesafe hesaplayan fonksiyon.


Console.WriteLine("Hoşgeldiniz, istenilen değerleri girerek koşu mesafenizi metre cinsinden hesaplayabilirsiniz."); //Kullanıcıyı karşılama.
Console.WriteLine();

int adimUzunlugu = adimUzunluguAl(); // Kullanıcıdan adım uzunluğu değerini alma.
int dakikadaAdimSayisi = dakikadakiAdimSayisiAl(); // Kullanıcıdan bir dakikada attığı adım sayısı değerini alma.
int kosuSuresiSaat = saatAl(); // Kullanıcıdan koşu süresinin saat bölümünü alma.
int kosuSuresiDakika = dakikaAl(); // Kullanıcıdan koşu süresinin dakika bölümünü alma.

double hesaplananMesafe = kosuMesafesiHesapla(adimUzunlugu, dakikadaAdimSayisi, kosuSuresiSaat, kosuSuresiDakika); //Alınan değerleri hesaplama fonksiyonuna gönderme ve sonucu alma.
Console.WriteLine();
Console.WriteLine($"Hesaplanan koşu mesafeniz: {hesaplananMesafe} metre."); //Kullanıcıya sonucu veriyoruz.
Console.WriteLine();
Console.WriteLine("Hesaplama programı sonlandı."); //Programın kapandığını bildiriyoruz.

#endregion

#region EkSoru
Console.WriteLine();
Console.WriteLine("*********");
Console.WriteLine();
Console.WriteLine("Merhaba, Tur süreleri kayıt ve sıralama için 5 turunuzdan ilkini girin: "); //Kullanıcı karışlama
Console.WriteLine();

double[] turSureleri = new double[5]; // Tur süreleri için 5 elemanlı bir dizi oluşturma

for (int tur = 0; tur < 5; tur++) // Her turun süresini kullanıcıdan alma
{
    double turSuresi = TurSureAl(tur + 1);
    turSureleri[tur] = turSuresi;
}


Array.Sort(turSureleri); // Tur süreleri sıralama(en hızlıdan yavaşa)

Console.WriteLine();
Console.WriteLine("Koşu Süreleri (en hızlıdan yavaşa doğru sıralı):"); // Her bir elemanı gezerek sonuçları ekrana yazdırma
foreach (double turSure in turSureleri)
{
    Console.WriteLine($"{turSure} saniye");

}



static double TurSureAl(int turNo)  //Kullanıcıdan tur sürelerini alan fonsiyon.
{
    double turSuresi = 0;

    try
    {

        Console.Write($"{turNo}. Tur Süresini Girin (saniye cinsinden): ");
        string girilenSure = Console.ReadLine();


        turSuresi = double.Parse(girilenSure);


        if (turSuresi <= 0) // Girilen değerin 0 veya negatif olup olmadığını kontrol ediyoruz
        {
            Console.WriteLine("Tur süresi negatif olamaz. Lütfen tekrar girin: ");
            return TurSureAl(turNo); // Tekrar giriş yapılması için fonksiyonu tekrar çağırıyoruz
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Hatalı giriş! Geçerli bir sayı giriniz.");
        return TurSureAl(turNo); // Tekrar giriş yapılması için fonksiyonu tekrar çağırıyoruz
    }
    catch (OverflowException)
    {
        Console.WriteLine("Hatalı giriş! Geçerli bir sayı giriniz.");
        return TurSureAl(turNo); // Tekrar giriş yapılması için fonksiyonu tekrar çağırıyoruz
    }

    return turSuresi;
}


#endregion
//SORU: Bir X sayısı tek ise 3 ile çarpılıp 1 ekleniyor.Çift ise 2'ye bölünüyor.İşlem X sayısı 1 olana kadar devam ediyor. Bu işlemin kaç adım sürdüğünü, işlemler sırasında X sayısının aldığı maksimum değeri, X sayısının hangi sayıdan sonra hep çift olarak 1'e ulaştığını(Çift maksimum) bulan ve ekrana yazan algoritma

//1.Adım: Başla
//2.Adım: sayi, sayac, maxSayi, ciftMaxSayi tanımla.
//3.Adım: Kullanıcıdan sayi değerini al.
//4.Adım: sayac = 0, maxSayi = 0, ciftMaxSayi = 0 olsun.
//5.Adım: Eğer, sayi != 1 ise 6.Adım'a git.
//     Aksi halde, Ekrana Yaz("Sayıyı 1 girdiniz.") ve 14.Adım'a git.
//6.Adım: Eğer, sayi >= 2 ise,
//     sayac = sayac + 1 olsun. 7.Adım'a git.
//     Aksi halde, 11.Adım'a git.
//7.Adım: Eğer, sayi % 2 == 1 ise,
//     sayi = (sayi * 3) + 1 olsun.
//     sayac = sayac + 1 olsun.
//     ciftMaxSayi = 0 olsun. 8.Adım'a git.
//     Aksi halde, 8.Adım'a git.
//8.Adım: Eğer, ciftMaxSayi < sayi ise,
//     ciftMaxSayi = sayi olsun ve 9.Adım'a git.
//     Aksi halde, 9.Adım'a git.
//9.Adım: Eğer, maxSayi < sayi ise,
//     maxSayi = sayi olsun ve 10.Adım'a git.
//     Aksi halde, 10.Adım'a git.
//10.Adım: sayi = sayi / 2 olsun ve 6.Adım'a git.
//11.Adım: Ekrana Yaz("Bu işlemler sırasında ulaşılan maksimum sayı: ", maxSayi)
//12.Adım: Ekrana Yaz("Bu işlemler sırasında çift olarak 1'e ulaşılan maksimum sayı: ", ciftMaxSayi)
//13.Adım: Ekrana Yaz("Bu işlemlerin bitmesi için yapılan işlem adım sayısı: ", sayac)
//14.Adım: Bitir



int x = 0, sayac = 0, MaxX = 0, CiftMaxX = 0;

Console.Write("X sayısını girin: ");
x = int.Parse(Console.ReadLine());

if (x == 1)
{
    Console.WriteLine("Sayıyı 1 girdiniz.");
}

else
{

    while (x != 1)
    {
        if (x % 2 == 1)
        {
            x = x * 3 + 1;
        }
        else 
        {
            x = x / 2;
        }

        sayac++;

        if (x > MaxX)
        {
            MaxX = x;
        }

        if (x % 2 == 0 && x > CiftMaxX)
        {
            CiftMaxX = x;
        }
    }
}

Console.WriteLine("İşlem adım sayısı: " + sayac);
Console.WriteLine("X sayısının aldığı maksimum değer: " + MaxX);
Console.WriteLine("X sayısı çift olarak 1'e ulaştıktan sonra aldığı en büyük değer: " + CiftMaxX);
Console.ReadLine();

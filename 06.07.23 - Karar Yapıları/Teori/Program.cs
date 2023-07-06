


#region Kullanıcıdan alınan suyun sıcaklığı bilgisine göre suyun hangi fazda olduğunu ekrana yaz
/* 

Console.WriteLine("Suyun sıcaklığını girin: ");
double suSicakligi = double.Parse(Console.ReadLine());

if (suSicakligi < 0)
    Console.WriteLine("Su katı haldedir.");
else if (suSicakligi == 0)
    Console.WriteLine("Su katı ve sıvı haldedir.");
else if (suSicakligi > 0 && suSicakligi < 100)
    Console.WriteLine("Su sıvı haldedir.");
else if (suSicakligi == 100)
    Console.WriteLine("Su sıvı ve buhar halindedir.");
else
    Console.WriteLine("Su buhar halindedir.");
*/

#endregion

#region Kullanıcıdan alınan bir sayının faktöriyel hesabını yapan uygulama
/*
Console.WriteLine("Lütfen faktöriyeli alınacak sayıyı girin: ");
double sayi = double.Parse(Console.ReadLine());

double faktoriyel = 1;
int sayac = 0;

if (sayi == 0)
{
    Console.WriteLine("Sonuç = 1 dir.");
}

else
{
    while (sayac < sayi)
    {
        sayac++;
        faktoriyel = sayac * faktoriyel;
    }
    Console.WriteLine("Sonuç: " + faktoriyel);
}
*/
#endregion

#region Goto ile faktoriyel (hocanın cozumu)
/* 
 
sayiAl:
Console.WriteLine("Lütfen sayı gir: ");
int sayi = int.Parse(Console.ReadLine());

int faktoriyel = 1, sayac = 1;

if (sayi == 0)
{
    faktoriyel = 1;
    goto ekranaYaz;

}

else if (sayi < 0)
{
    goto negatifSayi;
}

kontrol: if (sayi > sayac)
{
    sayac++;
    faktoriyel *= sayac;
    goto kontrol;
}

goto ekranaYaz;

ekranaYaz: Console.WriteLine($"Girilen sayı: {sayi} Faktoriyeli: {faktoriyel}");
    goto bitir;
negatifSayi: Console.WriteLine("Negatif sayı girildi.");
    goto sayiAl;
bitir: Console.ReadLine() ; 
*/

#endregion

#region İki sayıdan önce girilen mi sonra girilen mi daha büyük ekrana yazan algoritma
/*
 * 
Console.WriteLine("Lütfen 1. sayıyı girin: ");
double sayi1 = double.Parse(Console.ReadLine());

Console.WriteLine("Lütfen 2. sayıyı girin: ");
double sayi2 = double.Parse(Console.ReadLine());

if (sayi1 > sayi2)
{
    Console.WriteLine("Birinci girilen sayı daha büyüktür.");
}

if (sayi1 < sayi2)
{
    Console.WriteLine("İkinci girilen sayı daha büyüktür.");
}

if (sayi1 == sayi2)
{
    Console.WriteLine("Girilen iki sayı birbirine eşittir.");
}
*/

#endregion

#region Alınan 3 sayıdan en büyüğü
/*

Console.WriteLine("Lütfen 1. sayıyı girin: ");
double sayi1 = double.Parse(Console.ReadLine());

Console.WriteLine("Lütfen 2. sayıyı girin: ");
double sayi2 = double.Parse(Console.ReadLine());

Console.WriteLine("Lütfen 3. sayıyı girin: ");
double sayi3 = double.Parse(Console.ReadLine());



if (sayi1 > sayi2 && sayi1 > sayi3)
{
    Console.WriteLine("Sayı 1 en büyüktür.");
}

if (sayi2 > sayi1 && sayi2 > sayi3)
{
    Console.WriteLine("Sayı 2 en büyüktür.");
}

if (sayi3 > sayi1 && sayi3 > sayi2)
{
    Console.WriteLine("Sayı 3 en büyüktür.");
}

*/
#endregion

#region alınan iki tam sayıdan biri negatif ise toplamlarını ikisi de negatifse carpımlarını ikisi de pozitifse ortalamalarını al 0 girilirse yeniden al
/*

double sonuc;

sayi1Al:  Console.WriteLine("Lütfen 1. sayıyı girin: ");
double sayi1 = double.Parse(Console.ReadLine());

if (sayi1 == 0)
{
    Console.WriteLine("Girilen değer 0 olamaz lütfen tekrar girin.");
    goto sayi1Al;
}

sayi2Al: Console.WriteLine("Lütfen 2. sayıyı girin: ");
double sayi2 = double.Parse(Console.ReadLine());

if (sayi2 == 0)
{
    Console.WriteLine("Girilen değer 0 olamaz lütfen tekrar girin.");
    goto sayi2Al;
}


if ( sayi1 < 0 && sayi2 < 0)
{
    Console.WriteLine("İki sayı da negatiftir.");
    sonuc = sayi1 * sayi2;
}

else if (sayi1 >0 && sayi2 > 0)
{
    Console.WriteLine("İki sayı da pozitiftir.");
    sonuc = (sayi1 + sayi2) / 2;
}

else
{
    Console.WriteLine("Sayılardan biri pozitif biri negatiftir.");
    sonuc = sayi1 + sayi2;
}

Console.WriteLine($"Sonuç: {sonuc}");
*/
#endregion

#region limoanata gazoz cay tercihini C, L veya K ile tercihe göre ekrana bas.
/*

secme: Console.WriteLine("Lütfen istediğiniz içeceği girin (C: Çay, L: Limonata, K: Kola");
string secim = Console.ReadLine();

if (secim == "C" || secim == "c")
{
    Console.WriteLine("Seçim Çay.");
}

else if (secim == "K" || secim == "k")
{
    Console.WriteLine("Seçim Kola.");
}

else if (secim == "L" || secim == "l")
{
    Console.WriteLine("Seçim Limonata.");
}

else
{
    Console.WriteLine("Lütfen harfle C, K veya L tercih edin! ");
    goto secme;
}

*/
#endregion

#region  Limonata Sorusu Switch Case

tercihYap: Console.WriteLine("Lütfen istediğiniz içeceği girin (C: Çay, L: Limonata, K: Kola");
string tercih = Console.ReadLine();

switch (tercih)
{
    case "C":
    case "c":
        Console.WriteLine("İçecek tercihiniz Çay.");
        break;

    case "L":
    case "l":
        Console.WriteLine("İçecek tercihiniz Limonata.");
        break;

    case "K":
    case "k":
        Console.WriteLine("İçecek tercihiniz Kola.");
        break;

    default:
        Console.WriteLine("Lütfen harfle C, K veya L tercih edin! ");
        goto tercihYap;
}

#endregion
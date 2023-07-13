/*
Console.WriteLine("Kullanıcı adı girin: ");
string kullaniciAdi = Console.ReadLine();

Console.WriteLine("Sifre girin: ");
string sifre = Console.ReadLine();

kullaniciAdi = kullaniciAdi.Replace(" ", "");
Console.WriteLine("Düzeltilmiş kullanıcı adı: " + kullaniciAdi);

sifre = sifre.Replace(" ", "");
Console.WriteLine("Düzeltilmiş şifre: " + sifre);

// trim bas ve sondan bosluk
Console.WriteLine("Bana adınızı verin: ");
string ad = Console.ReadLine().Trim();

Console.WriteLine("Bana soyadınızı verin: ");
string soyAd = Console.ReadLine().Trim();

Console.WriteLine(ad + soyAd);

using System;

//index of

Console.WriteLine("ifadeyi girin: ");
string ifade = Console.ReadLine();

Console.WriteLine("Aranacak karakteri girin: ");
char karakter = char.Parse(Console.ReadLine());

int adres = ifade.IndexOf(karakter);
Console.WriteLine($"{karakter} karakteri {adres} sıradadır.");

*/

//replace
/*
using System.Reflection.Metadata;

Console.WriteLine("Adınız: ");
string ad = Console.ReadLine();
Console.WriteLine("Soyadınız: ");
string soyad = Console.ReadLine();
Console.WriteLine("Yaşınız : ");
string yas =  Console.ReadLine();

string metin = "Merhaba, benim adım kullaniciAdi, soyadım kullaniciSoyadi, yaşım kullaniciYasi";

metin = metin.Replace("kullaniciAdi", ad);
metin = metin.Replace("kullaniciSoyadi", soyad);
metin = metin.Replace("kullaniciYasi", yas);

Console.WriteLine(metin);
*/


/*
//concate
Console.WriteLine("Adınız: ");
string ad = Console.ReadLine();
Console.WriteLine("Soyadınız: ");
string soyad = Console.ReadLine();
Console.WriteLine("Yaşınız : ");
string yas = Console.ReadLine();

string mesaj = String.Concat("Benim adım, ", ad, " soyadım, ", soyad, " yaşım, ", yas, " tir.");

Console.WriteLine(mesaj);
*/

//Ödev:
//Girilen kredi kartı numarasının son 4 hanesini gösteren ve diğer rakamlar yerine * işareti koyan programı yazınız. (Kullanıcı son 4 haneyi girecek, gerisine ben * koyup ekrana yazdırıcam.)

tekrar:
Console.Write("Kredi kartı numarasının son 4 hanesini girin: ");
int sonDortHane = int.Parse(Console.ReadLine());

if (sonDortHane >= 1000 && sonDortHane < 10000)
{
    string gizliNumara = string.Concat("**** **** **** ", sonDortHane);
    Console.WriteLine("Gizli kart numarası: " + gizliNumara);
}
else
{
    Console.WriteLine("Lütfen kartınızın son 4 hanesini girip yeniden deneyin.");
    goto tekrar;
}


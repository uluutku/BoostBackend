
#region Dışarıdan alınan iki sayının toplamıyla farkının birbirine bölümünden kalanın sonucunu ekrana yazdırınız.
/*
Console.WriteLine("Lütfen birinci sayıyı girin:");
long sayi1 = long.Parse(Console.ReadLine());

Console.WriteLine("Lütfen ikinci sayıyı girin:");
long sayi2 = long.Parse(Console.ReadLine());

long toplam = sayi1 + sayi2;
long fark = sayi1 - sayi2;
long bolum = toplam % fark;

Console.WriteLine($"Sayıların toplamı: {toplam}");
Console.WriteLine($"Sayıların farkı: {fark}");
Console.WriteLine($"Toplamla farkın bölümünden kalan fark {bolum}");
*/
#endregion

#region Dışarıdan alınan bir sayının 10 eksiğinin 20 fazlasının 2 ye bölümünden kalan kaçtır?
/*

Console.WriteLine("Lütfen bir sayı girin:");
long sayi = long.Parse(Console.ReadLine());

long hesaplama = (sayi - 10 + 20) / 2;

Console.WriteLine($"Sayının 10 eksiğinin 20 fazlasının yarısı {hesaplama} dır.");
*/
#endregion

#region Vize ve Final Sınavlarının %40 ve %60 ını alarak not ortalamasını hesaplayıp ekrana yazmaca
/*

Console.WriteLine("Lütfen vize notunuzu girin:");
int vize = int.Parse(Console.ReadLine());

Console.WriteLine("Lütfen final notunuzu girin:");
int final = int.Parse(Console.ReadLine());

double vizeYuzde, finalYuzde;

vizeYuzde = vize * 0.4;
finalYuzde = final * 0.6;
Console.WriteLine($"Not ortalamanız: {vizeYuzde + finalYuzde}");
*/
#endregion

#region Kullanıcıdan iki sayı alıp eşitse eşit değilse değil yazmaca
/*

Console.WriteLine("Lütfen birinci sayıyı girin:");
long sayi1 = long.Parse(Console.ReadLine());

Console.WriteLine("Lütfen ikinci sayıyı girin:");
long sayi2 = long.Parse(Console.ReadLine());

if (sayi1 != sayi2)
{
    Console.WriteLine("Sayılar eşit değildir."); 
}
else
{
    Console.WriteLine("Sayılar eşittir.");
}
*/

#endregion

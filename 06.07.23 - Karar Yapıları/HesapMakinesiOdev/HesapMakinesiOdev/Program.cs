﻿double sonuc = 0;

islemSec: Console.WriteLine("*****************");
Console.WriteLine("Yapacağınız işlemi girin: \n Toplama = T \n Çıkarma = C \n Çarpma = X \n Bölme = B \n *****************");
char islem = char.Parse(Console.ReadLine());

if (islem != 'T' && islem != 't' && islem != 'C' && islem != 'c' && islem != 'X' && islem != 'x' && islem != 'B' && islem != 'b')
{
    Console.WriteLine("Hatalı işlem seçtiniz lütfen tekrar deneyin.");
    goto islemSec;
}

Console.WriteLine("Lütfen birinci sayıyı girin.");
    double sayi1 = double.Parse(Console.ReadLine());

sayi2Al: Console.WriteLine("Lütfen ikinci sayıyı girin.");
    double sayi2 = double.Parse(Console.ReadLine());

if (islem == 'T' || islem == 't')
{
    sonuc = sayi1 + sayi2;
}

else if (islem == 'C' || islem == 'c')
{
    sonuc = sayi1 - sayi2;
}

else if (islem == 'X' || islem == 'x')
{
    sonuc = sayi1 * sayi2;
}

else if (islem == 'B' || islem == 'b')
{
    if (sayi2 == 0)
    {
        Console.WriteLine("0'a bölme işlemi yapılamaz lütfen Sayı 2'yi tekrar girin.");
        goto sayi2Al;
    }
    sonuc = sayi1 / sayi2;
}

Console.WriteLine("İşlem sonucu: " + sonuc);

Console.WriteLine("Yeni bir işlem yapmak istiyor musunuz? E/H");
char tekrar = char.Parse(Console.ReadLine());

if (tekrar == 'E' || tekrar == 'e')
{
    goto islemSec;
}
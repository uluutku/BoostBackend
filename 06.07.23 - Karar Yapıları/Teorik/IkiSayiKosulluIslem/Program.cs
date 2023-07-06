double sonuc;

sayi1Al: Console.WriteLine("Lütfen 1. sayıyı girin: ");
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


if (sayi1 < 0 && sayi2 < 0)
{
    Console.WriteLine("İki sayı da negatiftir.");
    sonuc = sayi1 * sayi2;
}

else if (sayi1 > 0 && sayi2 > 0)
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
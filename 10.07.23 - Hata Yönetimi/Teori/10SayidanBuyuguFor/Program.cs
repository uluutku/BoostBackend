int sayi;
int enBuyuk = int.MinValue; 
int enKucuk = int.MaxValue;

for (int i = 1; i <= 10; i++)
{
    Console.Write("Sayı {0}: ", i);
    sayi = Convert.ToInt32(Console.ReadLine());

    if (sayi > enBuyuk)
        enBuyuk = sayi;

    if (sayi < enKucuk)
        enKucuk = sayi;
}

Console.WriteLine("En büyük sayı: " + enBuyuk);
Console.WriteLine("En küçük sayı: " + enKucuk);

Console.ReadLine();
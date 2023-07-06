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
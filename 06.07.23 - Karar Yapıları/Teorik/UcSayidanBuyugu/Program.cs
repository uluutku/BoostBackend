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
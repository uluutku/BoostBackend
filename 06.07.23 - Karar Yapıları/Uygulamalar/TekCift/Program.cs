// Klavyeden girilen bir sayının tek çift olduğunu bul

Console.WriteLine("Lütfen bir sayı girin.");
double sayi = Convert.ToDouble(Console.ReadLine());

if (sayi % 2 == 0)
{
    Console.WriteLine("Sayı çifttir.");
}

else
{
    Console.WriteLine("Sayı tektir.");
}

// tekse ekrana iki katını yazim

if (sayi % 2 != 0)
{
    Console.WriteLine((sayi * 2));
}
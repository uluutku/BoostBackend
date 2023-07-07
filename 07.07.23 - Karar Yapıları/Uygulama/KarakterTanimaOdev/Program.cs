tekrar:
Console.WriteLine("*********");
Console.Write("Bir karakter girin: ");
char karakter = char.Parse(Console.ReadLine());
Console.WriteLine();

if (char.IsLetter(karakter))
{
    Console.WriteLine("Girilen karakter bir harftir.");
}

else
{
    if (char.IsDigit(karakter))
    {
        Console.WriteLine("Girilen karakter bir rakamdır.");
    }

    else
    {
        Console.WriteLine("Girilen karakter bir özel karakterdir.");
    }
}

Console.WriteLine();
Console.WriteLine("Yeni bir karakter deneyecek misiniz? E/H ");
string tekrarSecimi = Console.ReadLine().ToLower();

if (tekrarSecimi == "e")
{
    goto tekrar;
}

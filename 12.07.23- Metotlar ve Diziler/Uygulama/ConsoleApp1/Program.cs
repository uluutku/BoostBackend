
Console.WriteLine("Cümle girin:");
string metin = Console.ReadLine();
string aranacak = "hava";
if (metin.Contains(aranacak))
{
    Console.WriteLine($"{metin}, {aranacak} içeriyor.");
}
else
{
    {
        Console.WriteLine($"{metin}, {aranacak} içermiyor.");
    }
}

// 1.2
Console.WriteLine("****************");

if (metin.Contains(" hava "))
{
    Console.WriteLine($"{metin}, hava içeriyor.");
}

else if (metin.Contains(" hava"))
{
    Console.WriteLine($"{metin}, hava içeriyor.");
}

else
{
    {
        Console.WriteLine($"{metin}, hava içermiyor.");
    }
}


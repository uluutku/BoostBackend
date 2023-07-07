Console.WriteLine("Lütfen bir dil seçin: ");
Console.WriteLine("1 - Türkçe");
Console.WriteLine("2 - İngilizce");
Console.WriteLine("3 - Almanca");
Console.WriteLine("4 - Fransızca");

int dilSecimi = int.Parse(Console.ReadLine());

string merhabaKelimesi = default;

switch (dilSecimi)
{
    case 1:
        merhabaKelimesi = "Merhaba";
        break;
    case 2:
        merhabaKelimesi = "Hello";
        break;
    case 3:
        merhabaKelimesi = "Hallo";
        break;
    case 4:
        merhabaKelimesi = "Bonjour";
        break;
    default:
        Console.WriteLine("Geçersiz dil seçimi.");
        break;
}

Console.WriteLine(merhabaKelimesi);

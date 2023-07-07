int begenen = 0;
int begenmeyen = 0;
int kararsiz = 0;
int toplamMusteri = 0;

baslangic:
Console.WriteLine("*****");
Console.WriteLine("Anketi bitirmek ve sonuçları almak için cevaba 'S' yazın.");
Console.WriteLine("*****");

Console.Write("Ürünü beğendiniz mi? (E/H/K) - (S): ");
string cevap = Console.ReadLine();

if (cevap.ToLower() == "s")
    goto sonuclar;

switch (cevap.ToLower())
{
    case "e":
        Console.WriteLine("Beğenildi cevabı kaydedildi.");
        begenen++;
        break;
    case "h":
        Console.WriteLine("Beğenilmedi cevabı kaydedildi.");
        begenmeyen++;
        break;
    case "k":
        Console.WriteLine("Kararsız cevabı kaydedildi.");
        kararsiz++;
        break;
    default:
        Console.WriteLine("Geçersiz bir cevap girdiniz.");
        goto baslangic;
}

toplamMusteri++;
goto baslangic;

sonuclar:
Console.WriteLine();
Console.WriteLine("Sonuçlar:");
Console.WriteLine("Begenen: " + begenen);
Console.WriteLine("Begenmeyen: " + begenmeyen);
Console.WriteLine("Kararsız: " + kararsiz);
Console.WriteLine("Toplam Müşteri: " + toplamMusteri);
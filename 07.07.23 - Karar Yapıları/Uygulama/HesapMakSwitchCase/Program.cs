double sonuc = default;

islemAlma: Console.WriteLine("\n Yapılacak işlemi giriniz: \n + = Toplama \n - = Çıkarma \n * = Çarpma \n / - Bölme");
string islem = Console.ReadLine().ToLower();

if (islem != "+" && islem != "-" && islem != "*" && islem != "/")
{
    Console.WriteLine("Lütfen gerçeli bir işlem girin.");
    goto islemAlma;
}

sayi1Alma: Console.WriteLine("Sayı 1'i giriniz: ");
double sayi1 = double.Parse(Console.ReadLine());

sayi2Alma: Console.WriteLine("Sayı 2'yi giriniz: ");
double sayi2 = double.Parse(Console.ReadLine());

if (islem == "/" && sayi2 == 0)
{
    Console.WriteLine("0 a bölme işlemi yapılamaz. \n Lütfen Sayı 2 için 0 dan farklı bir değer girin.");
    goto sayi2Alma;
}

switch (islem)
{
    case "+":
        sonuc = sayi1 + sayi2;
        break;
    case "-":
        sonuc = sayi1 - sayi2;
        break;
    case "*":
        sonuc = sayi1 * sayi2;
        break;
    case "/":
        sonuc = sayi1 / sayi2;
        break;
    default:
        Console.WriteLine("Lütfen geçerli bir işlem girin.");
        goto islemAlma;

}

Console.WriteLine("İşlem sonucu: " + sonuc);
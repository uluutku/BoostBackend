Console.WriteLine("Lütfen birinci sayıyı girin.");
int sayi1 = int.Parse(Console.ReadLine());

Console.WriteLine("Lütfen ikinci sayıyı girin.");
int sayi2 = int.Parse(Console.ReadLine());

Console.WriteLine("Lütfen üçüncü sayıyı girin.");
int sayi3 = int.Parse(Console.ReadLine());

int enBuyuk = default;
int enKucuk = default;
int ortanca = default;

//En Büyük Bulma
if (sayi1 > sayi2 && sayi1 > sayi3)
    enBuyuk = sayi1;
if (sayi2 > sayi1 && sayi2 > sayi3)
    enBuyuk = sayi2;
if (sayi3 > sayi1 && sayi3 > sayi2)
    enBuyuk = sayi3;

//En Küçük Bulma
if ((sayi1 < sayi2) && (sayi1 < sayi3))
    enKucuk = sayi1;
if ((sayi2 < sayi1) && (sayi2 < sayi3))
    enKucuk = sayi2;
if ((sayi3 < sayi1) && (sayi3 < sayi2))
    enKucuk = sayi3;

//En Ortanca Bulma
if ((sayi1 != enBuyuk) && (sayi1 != enKucuk))
    ortanca = sayi1;
if ((sayi2 != enBuyuk) && (sayi2 != enKucuk))
    ortanca = sayi2;
if ((sayi3 != enBuyuk) && (sayi3 != enKucuk))
    ortanca = sayi3;

//İşlem
int sonuc = (enKucuk + enBuyuk) % ortanca;

//Print
Console.WriteLine("En Büyük Sayı: " + enBuyuk);
Console.WriteLine("En Ortanca Sayı: " + ortanca);
Console.WriteLine("En Küçük Sayı: " + enKucuk);

Console.WriteLine("İşlem Sonucu:" + sonuc);
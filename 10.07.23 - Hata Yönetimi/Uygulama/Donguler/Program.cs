double toplam = 0;
for (int i = 1; i <= 12; i++)
{
    Console.WriteLine(i + " Bilgeadam");
}

Console.WriteLine();
Console.WriteLine("********************");
Console.WriteLine();


// klavyeden kullanıcı tarafından girilen 12 sayının toplamı ve ortalaması 

for  (int i = 1;i <= 12; i++)
{
    Console.WriteLine($"{i}. sayıyı giriniz: ");
    double sayi = double.Parse(Console.ReadLine()); ;
    toplam = toplam + sayi;
}

Console.WriteLine("Girdiğiniz 12 sayının toplamı: " + toplam);
Console.WriteLine("Sayıların ortalaması: " + (toplam / 12.0) );

Console.WriteLine();
Console.WriteLine("********************");
Console.WriteLine();

Console.WriteLine("Virgül test: ");
double virgullu = double.Parse(Console.ReadLine());
double donusturulmus = (virgullu * 1000);
Console.WriteLine(donusturulmus);
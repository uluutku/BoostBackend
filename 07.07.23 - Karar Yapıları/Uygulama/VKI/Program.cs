// Kullanıcıdan boy ve ağırlık alıp VKI hesaplama
// VKI = agırlık / (boy * boy) - metre cinsinden
// VKI 18 - 25 normal, 25 - 30 kilolu, >30 obez, >35 eyvah

baslangic: Console.WriteLine("*******************");

boyAl: Console.WriteLine("Lütfen boyunuzu girin: ");
double boy = double.Parse(Console.ReadLine());

if (boy > 100 && boy < 300)
{
    //boy cm girilmişse metreye cevirme
    boy = boy / 100;
}

if (boy > 0 && boy < 3)
{
    //Boy zaten metre cinsi
}

else
{
    Console.WriteLine("Lütfen boy değerini kontrol edin.");
    goto boyAl;
}

kiloAl: Console.WriteLine("Lütfen kilonuzu girin: ");
double kilo = double.Parse(Console.ReadLine());

if (kilo < 0 || kilo > 700)
{
    Console.WriteLine("Lütfen kilo değerini kontrol edin.");
    goto kiloAl;
}

double vki = kilo / (boy * boy);

Console.WriteLine("VKI değeriniz: " + vki);

if (vki > 18 && vki < 25)
{
    Console.WriteLine("VKI değeriniz normal.");
}

else if (vki >= 25 && vki <= 30)
{
    Console.WriteLine("VKI değeriniz kilolu.");
}

else if (vki > 30 && vki < 35)
{
    Console.WriteLine("VKI değeriniz obez.");
}

else if (vki >= 35)
{
    Console.WriteLine("VKI değeriniz ağır yaşamlar.");
}

else
{
    Console.WriteLine("VKI tanınmadı lütfen girdiğiniz değerleri kontrol edin.");
    goto baslangic;
}

Console.WriteLine("Yeniden başlamak istiyor musunuz? E/H ");
string tekrar = Console.ReadLine();

if (tekrar == "E" || tekrar == "e")
{
    goto baslangic;
}
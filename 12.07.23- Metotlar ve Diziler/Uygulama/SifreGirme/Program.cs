int dogruSifre = 159753;
int girilenSifre;

do
{
    Console.Write("Şifreyi girin: ");
    girilenSifre = int.Parse(Console.ReadLine());

    if (girilenSifre != dogruSifre)
    {
        Console.WriteLine("Yanlış şifre! Tekrar deneyin.");
    }
} while (dogruSifre != girilenSifre);

Console.WriteLine("Şifre doğru.");
string adminKullanici = "utkuulu";
string adminSifre = "159753";

Console.WriteLine("Lütfen Kullanıcı Adınızı Girin: ");
string girilenKullanici = Console.ReadLine();

Console.WriteLine("Lütfen Şifrenizi Girin: ");
string girilenSifre = Console.ReadLine();

if (adminKullanici == girilenKullanici)
{
    if (adminSifre == girilenSifre)
    {
        Console.WriteLine("Giriş başarılı. Hoşgeldiniz beyfendi.");
    }

    else { Console.WriteLine("Şifreniz hatalı."); }
}

else
{
    Console.WriteLine("Hatalı giriş.");
}


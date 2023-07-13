Console.WriteLine("Lütfen Adınızı Giriniz: ");
string girilenAd = Console.ReadLine();



ekranaYaz(girilenAd); // Parametreli çağırılıp bişey girilmezse parametre yerine boş doldurur.
ekranaYaz(); // Parametresiz çağırılırsa defaultu parametre olarak kullanır.


void ekranaYaz(string girilenAd = "Dostum")
{
    Console.WriteLine($"Merhaba {girilenAd}!");
}


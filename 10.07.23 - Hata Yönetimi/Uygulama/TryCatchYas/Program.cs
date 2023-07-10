

yenidenDene:

Console.WriteLine("Kaç yaşın var? :");
try
{
    string input = Console.ReadLine();

    int age = Convert.ToInt32(input);
    if (age < 0 || age > 150)
    {
        Console.WriteLine("Yanlışın olmasın kirve?");
        goto yenidenDene;
    }
    Console.WriteLine("Yaşınız: " + age);
    Console.WriteLine("Bilgi satışa çıkarılıyor.");
}
catch (FormatException)
{
    Console.WriteLine("Hatalı giriş! Sayısal bir değer gir kirve.");
    goto yenidenDene;
}
catch (OverflowException)
{
    Console.WriteLine("Hatalı giriş! Girilen değer sınırların dışında kirve.");
    goto yenidenDene;
}
catch (Exception)
{
    Console.WriteLine("Bir hata oluştu ama bilmiyorum kirve.");
    goto yenidenDene;
}

Console.ReadLine();
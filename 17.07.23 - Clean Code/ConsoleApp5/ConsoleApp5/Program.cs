Console.WriteLine("Çıkış yapmak için Exit yazın.");

while (true)
{
    Console.Write("Bir tamsayı girin: ");
    string input = Console.ReadLine();

    if (input.ToLower() == "exit")
    {
        Console.WriteLine("Program sonlandırıldı.");
        break;
    }

    try
    {
        int sayi = int.Parse(input);
        int carpimSayi = 1;

        while (sayi > 0)
        {
            int hane = sayi % 10;
            sayi /= 10;

            Console.WriteLine($"{hane} x {carpimSayi} = {hane * carpimSayi}");
            carpimSayi *= 10;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Geçerli bir tamsayı giriniz!");
    }
}

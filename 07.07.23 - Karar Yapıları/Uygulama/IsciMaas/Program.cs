// işçilerden bekarlara maaş, evliler %3 ek - 1 cocuk %5 ek - 2 cocuk %10 ek - 3+ cocuk %15 ek

using System.Threading.Channels;

double ekliMaas = default;  


Console.WriteLine("Evli misiniz? E/H");
string evlilik = Console.ReadLine();



if (evlilik == "E" || evlilik == "e")
{
    Console.WriteLine("Maaşınızı girin: ");
    double maas = double.Parse(Console.ReadLine());

    Console.WriteLine("Çocuk sayınızı girin: ");
    double cocuk = double.Parse(Console.ReadLine());

    if (cocuk == 0)
    {
        Console.WriteLine("Evli ve çocuksuz olduğunuzdan %3 ek maaş alırsınız.");
        ekliMaas = maas + (maas * 0.3);
    }

    else if (cocuk == 1)
    {
        Console.WriteLine("1 Çocuğunuz olduğundan %5 ek maaş alırsınız.");
        ekliMaas = maas + (maas * 0.5);
    }

    else if (cocuk == 2)
    {
        Console.WriteLine("1 Çocuğunuz olduğundan %10 ek maaş alırsınız.");
        ekliMaas = maas + (maas * 0.10);
    }

    else if (cocuk >= 3)
    {
        Console.WriteLine("3 veya daha fazla çocuğunuz olduğundan %15 ek maaş alırsınız.");
        ekliMaas = maas + (maas * 0.15);
    }

  Console.WriteLine($"Normal maaşınız {maas}, ekli maaşınız {ekliMaas}, ek maaş miktarınız {ekliMaas - maas}");
}

else
{
    Console.WriteLine("Sizlik bir şey yok.");
}


#region Hoca Cozum
/*
 
Console.WriteLine("Lütfen maaşınızı giriniz");
double maas = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Lütfen Medeni Durumunuzu giriniz: (Bekar ise B'ye Evli ise E'ye basınız)");
char medeniDurum = Convert.ToChar(Console.ReadLine());
if (medeniDurum == 'b' || medeniDurum == 'B')
{
    Console.WriteLine("Maaşınız: " + maas);
}
else if (medeniDurum == 'e' || medeniDurum == 'E')
{
    Console.WriteLine("Lütfen çocuk sayısını giriniz.");

 

cocukSayisi: int cocuk = Convert.ToInt32(Console.ReadLine());
    if (cocuk < 0)
    {
        Console.WriteLine("Geçersiz girş yaptınız cocuk sayısını tekrar giriniz.");
        goto cocukSayisi;
    }
    else
    {
        if (cocuk == 0)
        {
            double ekMaasli = maas * 1.03;
            Console.WriteLine("Maaşınız= " + ekMaasli);
        }
        else if (cocuk == 1)
        {
            Console.WriteLine("Maaşınız= " + (maas * 1.05));
        }
        else if (cocuk == 2)
        {
            Console.WriteLine("Maaşınız= " + (maas * 1.10));
        }
        else if (cocuk >= 3)
        {
            Console.WriteLine("Maaşınız= " + (maas * 1.15));
        }
    }
}

 

Console.ReadLine();

*/

#endregion
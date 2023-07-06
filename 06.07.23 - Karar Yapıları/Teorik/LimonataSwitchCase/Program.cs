

#region limoanata gazoz cay tercihini C, L veya K ile tercihe göre ekrana bas.
/*

secme: Console.WriteLine("Lütfen istediğiniz içeceği girin (C: Çay, L: Limonata, K: Kola");
string secim = Console.ReadLine();

if (secim == "C" || secim == "c")
{
    Console.WriteLine("Seçim Çay.");
}

else if (secim == "K" || secim == "k")
{
    Console.WriteLine("Seçim Kola.");
}

else if (secim == "L" || secim == "l")
{
    Console.WriteLine("Seçim Limonata.");
}

else
{
    Console.WriteLine("Lütfen harfle C, K veya L tercih edin! ");
    goto secme;
}

*/
#endregion

#region  Limonata Sorusu Switch Case

tercihYap: Console.WriteLine("Lütfen istediğiniz içeceği girin (C: Çay, L: Limonata, K: Kola");
string tercih = Console.ReadLine();

switch (tercih)
{
    case "c":
        Console.WriteLine("İçecek tercihiniz Çay.");
        break;

    case "2":

        Console.WriteLine("İçecek tercihiniz Limonata."); 3
    case "K":
    case "k":
        Console.WriteLine("İçecek tercihiniz Kola.");
        break;

    default:
        Console.WriteLine("Lütfen harfle C, K veya L tercih edin! ");
        goto tercihYap;
}

#endregion
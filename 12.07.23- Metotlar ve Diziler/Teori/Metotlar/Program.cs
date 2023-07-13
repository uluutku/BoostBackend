// DateTime metotları, bi tarih ve saat bilgisi ile çalışmak için kullanılan metotlardır.

// Şu anın tarihini ve saatini almak için:

DateTime zaman = DateTime.Now; //Bu bir metot değil özelliktir.
Console.WriteLine("Şu an: " + zaman);

zaman = zaman.AddHours(5);
zaman = zaman.AddDays(7);
zaman = zaman.AddMonths(2);
zaman = zaman.AddYears(2);
zaman = zaman.AddMilliseconds(3);

Console.WriteLine("Şu an: " + zaman);
Console.WriteLine("Kısa tarih: " + zaman.ToShortDateString());
Console.WriteLine("Uzun tarih: " + zaman.ToLongDateString());
Console.WriteLine("Uzun zaman: " + zaman.ToLongTimeString());
Console.WriteLine("Kısa zaman: " + zaman.ToShortTimeString());

Console.WriteLine(zaman.Year.ToString()); // zaman değişkenindeki yıl bilgisini alıp stringe çevirir.

Console.WriteLine(DateTime.Now.Year); // şu anki yıl bilgisi
Console.WriteLine(DateTime.Now.Month);
Console.WriteLine(DateTime.Now.Day);
Console.WriteLine(DateTime.Now.Hour);
Console.WriteLine(DateTime.Now.Minute);
Console.WriteLine(DateTime.Now.Second);
Console.WriteLine(DateTime.Now.Millisecond);


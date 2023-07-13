//10 nottan en büyüğü en küçüğü ve ortalamayı bulma.

double enKucukNot = 100;
double enBuyukNot = 0;
double notToplami = 0;
double notOrtalama = 0;

for (int i = 1; i <= 10; i++)

{	
	tekrar:
    Console.WriteLine($"Lütfen {i}. notu giriniz: ");
	double girilenNot = double.Parse(Console.ReadLine());
	if (girilenNot >= 0 && girilenNot <= 100)
	{
		if (girilenNot >= enBuyukNot) {
			enBuyukNot = girilenNot;
		}

		if (girilenNot <= enKucukNot)
		{
			enKucukNot = girilenNot;
		}

		notToplami = (notToplami + girilenNot);
		notOrtalama = (notToplami / 10.0);
	}

	else
	{
		Console.WriteLine("Lütfen notu kontrol edip tekrar giriniz.");
		goto tekrar;
	}
}

Console.WriteLine("Notlar arasındaki en büyük not: " + enBuyukNot);
Console.WriteLine("Notlar arasındaki en büyük not: " + enKucukNot);
Console.WriteLine("Notların ortalaması: " + notOrtalama);
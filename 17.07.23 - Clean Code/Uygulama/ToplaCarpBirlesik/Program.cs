
Topla(10, 20);

void Topla(int sayi1, int sayi2)
{
    int toplamSonuc = (sayi1 + sayi2);
    Console.WriteLine("Toplama işlemi sonucu: " + toplamSonuc);
    Console.WriteLine("Çarpma işlemi sonucu: " + Carp(sayi1, sayi2) );
}



static int Carp(int sayi1, int sayi2)
{
    int carpmaSonuc = sayi1 * sayi2;
    return carpmaSonuc; 
}
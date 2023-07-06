// Tip Dönüşümleri

// Implict tür dönüşümü: Eğer dönüştürüleceği türe sorunsuz şekilde sığıyorsa (ör int 1 değeri double a daha rahat sığar gibi)
// Convert demeye gerek kalmadan direk kendi dönüştürür buna implict dönüşüm denir.

//Örnek

int sayi1 = 10;
double sayi2 = sayi1; // burada doğrudan birbirine farklı veri tipleri eşitlense de sığacağı için dümdüz eşitler
Console.WriteLine(sayi2);

//--------------------------------------------------

// Explict tür dönüşümü: Eğer değer daha kapsamlı bir veri içerirken daha az veri kapsayabilen bir tipe dönüştürülürse verinin bir kısmı atılmak zorunda kalır.
// Mesela int değişkeni virgülden sonrasını almadığından 1 gibi değerleri alır, içine 1.52 bir double değeri atılırsa küsüratı atar.

//Örnek

double sayi3 = 1.312;
//int sayi4 = sayi3; // Bu satır hata verir çünkü 0.312 değeri kaybolacak, bunu dönüştüreceksen bizzat söylemen lazım.
int sayi4 = (int)sayi3; // Böyle verirsen adam illa istiyor yapacak bişey yok diyor. Bu EXPLICT dönüşüm.
Console.WriteLine(sayi4);


//--------------------------------------------------

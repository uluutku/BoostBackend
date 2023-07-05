namespace Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Kullanıcıdan alınan iki sayının ortalamasını hesaplayan ve ekrana yazdıran algoritma.

            // Ctrl + k + s ile region gibi wrapler geliyor.

            int sayi1, sayi2;

            Console.WriteLine("Lütfen sayı 1 i girin: ");
            sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen sayı 2 i girin: ");
            sayi2 = int.Parse(Console.ReadLine());

            double ortalama = (sayi1 + sayi2) / 2.0;

            Console.WriteLine("Girdiğiniz iki sayının ortalaması: " + ortalama);

            #endregion

            #region Kullanıcıdan alınan sayının karesi ve küpünü hesaplayan algoritma.
            int sayi;

            Console.WriteLine("Lütfen sayıyı girin: ");
            sayi = int.Parse(Console.ReadLine());

            double karesi = sayi * sayi;
            double kupu = karesi * sayi;

            Console.WriteLine("Sayının karesi: " + karesi + " ve Küpü: " + kupu);
            Console.WriteLine("Sayının karesi: {0} ve Küpü: {1}", karesi, kupu);

            #endregion

            #region kullanıcıdan fahrenayt cinsinden alınan derecenin celcius karşılığı

            Console.WriteLine("Lütfen Fahrenayt değerini girin: ");
            double fahrenayt = double.Parse(Console.ReadLine());

            double celsius = (fahrenayt - 32) / 1.8;
            Console.WriteLine("Celsius karşılığı: {0}", celsius);
            #endregion

            #region basamak değerleri bulma

            Console.WriteLine("Lütfen basamaklarına ayrılacak sayıyı girin: ");
            int tumSayi = int.Parse(Console.ReadLine());

            int yuzler, onlar, birler;

            yuzler = tumSayi / 100;
            onlar = (tumSayi - yuzler * 100) / 10;
            birler = tumSayi - yuzler * 100 - onlar * 10;

            Console.WriteLine(tumSayi + " sayısınının, yüzler basamağı: " + yuzler + " onlar basamağı: " + onlar + " birler basamağı: " + birler);
            //?? Console.WriteLine("{} sayısınının, yüzler basamağı: {}, onlar basamağı: {}, birler basamağı: {}",tumSayi,yuzler,onlar,birler);

            #endregion

            #region mod alarak basamak değerleri bulma

            Console.WriteLine("Lütfen basamaklarına ayrılacak sayıyı girin: ");
            int tumSayi = int.Parse(Console.ReadLine());

            int yuzler, onlar, birler;

            birler = tumSayi % 10;
            onlar = (tumSayi / 10) % 10;
            yuzler = (tumSayi / 100) % 10;



            Console.WriteLine(tumSayi + " sayısınının, yüzler basamağı: " + yuzler + " onlar basamağı: " + onlar + " birler basamağı: " + birler);
        //?? Console.WriteLine("{} sayısınının, yüzler basamağı: {}, onlar basamağı: {}, birler basamağı: {}",tumSayi,yuzler,onlar,birler);

        #endregion

            #region kontrollü basamak değerleri bulma

        sayiAl: Console.WriteLine("Lütfen basamaklarına ayrılacak sayıyı girin: ");
            int tumSayi = int.Parse(Console.ReadLine());

            if (tumSayi >= 100 && tumSayi <= 999)
            {
                int yuzler, onlar, birler;

                yuzler = tumSayi / 100;
                onlar = (tumSayi - yuzler * 100) / 10;
                birler = tumSayi - yuzler * 100 - onlar * 10;

                Console.WriteLine(tumSayi + " sayısınının, yüzler basamağı: " + yuzler + " onlar basamağı: " + onlar + " birler basamağı: " + birler);
            }

            else
            {
                Console.WriteLine("Lütfen 3 basamaklı bir sayı girin.");
                goto sayiAl;
            }

            #endregion





        }
    }
}
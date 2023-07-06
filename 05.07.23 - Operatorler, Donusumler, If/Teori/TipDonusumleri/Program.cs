namespace _2_TipDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tip Dönüşümler:
            //Bir veri tipindeki değeri farkı bir veri tipine çevirmek için, .NET Convert sınıfı, Pars() metodu ve Casting işlemi tip dönüşümünü karşılar.
            //Ayrıca ToString() ile veriyi stringe dönüştürebiliriz.
            //Dış dünyaya gösterilecek her şey string olmak zorunda.

            int sayi = 1000;
            byte donusutrulenSayi = (byte)sayi; //Casting ile dönüştürebildiği kadar dönüştürür.

            //Sonuç olarak 1000 sayısınının byte'taki sayı kadarına bölümünden kalanı bize verir 232 olarak gösterir.

            Console.WriteLine("Byte'a dönüştürülen 1000 sayısı: " + donusutrulenSayi);
            Console.WriteLine("1000 değerinin byte'a göre modu: " + (1000 % 256));

            byte sayi2 = 255; //byte tipindeki değer aralığı 0 - 255'tir.
            int donusturulenSayi2 = sayi2; // Bu işlem kapalı dönüşümdür. Implicit Conversion. Byte tipindeki alınabilecek değerleri int tipi kapsadığı için kapalı dönüşüm olarak gerçekleştirilir.

            Console.WriteLine("Integer'a dönüştürülmüş 255 sayısı: " + donusturulenSayi2);

            Console.WriteLine(); //alt satıra geç
            Console.WriteLine(new string('*', 30)); // Ekrana yan yana 30 adet * ile ayraç.
            Console.WriteLine();

            bool dogruMu = true;


            string donusturulmusBoolDeger2 = dogruMu.ToString();
            byte donusturulmusBoolDeger3 = Convert.ToByte(dogruMu);
            sbyte donusturulmusBoolDeger4 = Convert.ToSByte(dogruMu);
            short donusturulmusBoolDeger5 = Convert.ToInt16(dogruMu);
            ushort donusturulmusBoolDeger6 = Convert.ToUInt16(dogruMu);
            int donusturulmusBoolDeger7 = Convert.ToInt32(dogruMu);
            uint donusturulmusBoolDeger8 = Convert.ToUInt32(dogruMu);
            long donusturulmusBoolDeger9 = Convert.ToInt64(dogruMu);
            ulong donusturulmusBoolDeger10 = Convert.ToUInt64(dogruMu);
            double donusturulmusBoolDeger11 = Convert.ToDouble(dogruMu);
            float donusturulmusBoolDeger12 = Convert.ToSingle(dogruMu);

            Console.WriteLine("String e Dönüştürülmüş Bool Değeri: " + donusturulmusBoolDeger2);
            Console.WriteLine("Byte a Dönüştürülmüş Bool Değeri: " + donusturulmusBoolDeger3);
            Console.WriteLine("SByte a Dönüştürülmüş Bool Değeri: " + donusturulmusBoolDeger4);
            Console.WriteLine("Short a Dönüştürülmüş Bool Değeri: " + donusturulmusBoolDeger5);
            Console.WriteLine("UShort a Dönüştürülmüş Bool Değeri: " + donusturulmusBoolDeger6);
            Console.WriteLine("Int e Dönüştürülmüş Bool Değeri: " + donusturulmusBoolDeger7);
            Console.WriteLine("UInt e Dönüştürülmüş Bool Değeri: " + donusturulmusBoolDeger8);
            Console.WriteLine("Long a Dönüştürülmüş Bool Değeri: " + donusturulmusBoolDeger9);
            Console.WriteLine("Ulong a Dönüştürülmüş Bool Değeri: " + donusturulmusBoolDeger10);
            Console.WriteLine("Double a Dönüştürülmüş Bool Değeri: " + donusturulmusBoolDeger11);
            Console.WriteLine("Float a Dönüştürülmüş Bool Değeri: " + donusturulmusBoolDeger12);


            Console.WriteLine(); //alt satıra geç
            Console.WriteLine(new string('*', 30)); // Ekrana yan yana 30 adet * ile ayraç.
            Console.WriteLine();

            byte dogruMu2 = 1;
            decimal dogruMu3 = 0.5M;
            int dogruMu4 = 0;
            int dogruMu5 = -1;
            int dogruMu6 = -5;

            bool booleanDogruMuDegeri2 = Convert.ToBoolean(dogruMu2);
            bool booleanDogruMuDegeri3 = Convert.ToBoolean(dogruMu3);
            bool booleanDogruMuDegeri4 = Convert.ToBoolean(dogruMu4);
            bool booleanDogruMuDegeri5 = Convert.ToBoolean(dogruMu5);
            bool booleanDogruMuDegeri6 = Convert.ToBoolean(dogruMu6);

            Console.WriteLine("Boolean'a Dönüştürülmüş Byte (1) değeri: " + booleanDogruMuDegeri2);
            Console.WriteLine("Boolean'a Dönüştürülmüş Decimal (0.5) değeri: " + booleanDogruMuDegeri3);
            Console.WriteLine("Boolean'a Dönüştürülmüş Int (0) değeri: " + booleanDogruMuDegeri4);
            Console.WriteLine("Boolean'a Dönüştürülmüş Int (-1) değeri: " + booleanDogruMuDegeri5);
            Console.WriteLine("Boolean'a Dönüştürülmüş Int (-5) değeri: " + booleanDogruMuDegeri6);

            //Not: Eğer boolean a dönüştürülünce 0 gelmişse False, başka ne gelirse gelsin True alır.

            Console.WriteLine(); //alt satıra geç
            Console.WriteLine(new string('*', 30)); // Ekrana yan yana 30 adet * ile ayraç.
            Console.WriteLine();

            int sayiDegeri = 20;
            Console.WriteLine(sayiDegeri.ToString()); // Ekrana string basmak için .ToString ile dönüştürülür.
            Console.WriteLine(sayiDegeri); // Ancak .NET Core da buna gerek olmadan direk basılabilir.

            Console.WriteLine(); //alt satıra geç
            Console.WriteLine(new string('*', 30)); // Ekrana yan yana 30 adet * ile ayraç.
            Console.WriteLine();

            string metinselSayiDegeri = "2000";
            Console.WriteLine("Metinsel Sayı Değeri: " + metinselSayiDegeri);

            Console.WriteLine(); //alt satıra geç
            Console.WriteLine(new string('*', 30)); // Ekrana yan yana 30 adet * ile ayraç.
            Console.WriteLine();



            /*
             
            Console.ReadLine(); // Hatadan önce durmak için.

            byte sayisalByteSayiDegeri = Convert.ToByte(metinselSayiDegeri);
            Console.WriteLine("Byte a Dönüştürülmüş Metinsel Sayı Değeri: " + sayisalByteSayiDegeri);

            // Not: Hata ==> Overflow (taşma hatası) 2000 sayısı 0-255 den büyük olduğu için taşıma hatası döner. Convert ile dönüştürürken casting gibi yapabildiğini yapmaz yapamıyorum der.

            */


            metinselSayiDegeri = "1000,00";
            //metinselSayiDegeri = "1000,75"

            double sayisalDoubleDegeri = Convert.ToDouble(metinselSayiDegeri);
            Console.WriteLine("Double a dönüştürülmüş Metinsel Sayı Değeri: " + sayisalDoubleDegeri);

            float sayisalFloatDegeri = Convert.ToSingle(metinselSayiDegeri);
            Console.WriteLine("Double a dönüştürülmüş Metinsel Sayı Değeri: " + sayisalFloatDegeri);

            decimal sayisalDecimalDegeri = Convert.ToDecimal(metinselSayiDegeri);
            Console.WriteLine("Double a dönüştürülmüş Metinsel Sayı Değeri: " + sayisalDecimalDegeri);

            Console.WriteLine(); //alt satıra geç
            Console.WriteLine(new string('*', 30)); // Ekrana yan yana 30 adet * ile ayraç.
            Console.WriteLine();

            // Metinsel Birleştirme:
            string girilenDeger1 = "Bilge Adam Akademi ";
            string girilenDeger2 = "Boost Yıldız Yazılımcı Yetiştirme Programı";
            string toplamMetinselDeger = girilenDeger1 + girilenDeger2;
            Console.WriteLine(toplamMetinselDeger);

            Console.WriteLine(); //alt satıra geç
            Console.WriteLine(new string('*', 30)); // Ekrana yan yana 30 adet * ile ayraç.
            Console.WriteLine();

            // String Birleştirme:
            string girilenDeger3 = "12412521";
            string girilenDeger4 = "3463634643";
            string toplamMetinselDeger2 = girilenDeger3 + girilenDeger4;
            Console.WriteLine(toplamMetinselDeger2);

            Console.WriteLine(); //alt satıra geç
            Console.WriteLine(new string('*', 30)); // Ekrana yan yana 30 adet * ile ayraç.
            Console.WriteLine();

            // Stringi Inte Cevirip Birleştirme:
            string girilenDeger5 = "1243221";
            string girilenDeger6 = "3432323";
            int toplamMetinselDeger3 = Convert.ToInt32(girilenDeger5) + Convert.ToInt32(girilenDeger6);
            Console.WriteLine(toplamMetinselDeger3);

            //Boxing ve Unboxing araştırılacak. Bir Console App öğrneği yapılacak. Açıklamalarıyla birlikte Olacak. Uygulamanın Program.cs dosyasını AdSoyad-BoxingOdev.cs olarak Teams'de açılan ödeve eklenecek.
        }
    }
}
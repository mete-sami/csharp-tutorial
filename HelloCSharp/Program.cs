using System;


namespace HelloCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //1) Kullanıcı ekrandan iki sayı girecek. Bu aralıktaki sayıların toplamını ekrana yazdır.
            #region Ödev Soru -1
            //Console.WriteLine("Lütfen ilk sayıyı giriniz");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Lütfen ikinci sayıyı giriniz");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());


            //int toplam = 0;
            //for (int i = sayi1 + 1; i < sayi2; i++)
            //{
            //    toplam = toplam + i;
            //}

            //Console.WriteLine(toplam);
            //Console.ReadLine();
            #endregion


            //5) 1 den 100 e kadar olan 2 ve 3 e bölünebilen kaç adet sayı var?
            #region Ödev Soru-5

            //int sayac = 0;
            //for (int i = 1; i < 100; i++)
            //{
            //    if (i % 2 == 0 && i % 3 == 0)
            //    {
            //        sayac++;
            //    }
            //}

            //Console.WriteLine(sayac);
            //Console.ReadLine();


            #endregion

            //6) Kullanıcı dışarıdan bir sayı girsin. Örneğin 3 girdiğinde 3*3 lük bir kare oluştursun ( Toplamda 9 yıldız olacak.)

            #region Soru-6

            Console.WriteLine("Lütfen bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < sayi; i++)
            {
                for (int j = 1; j < sayi; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("*");
            }

            Console.ReadLine();
            #endregion



            #region soru1
            //Dışarıdan girilen iki sayının toplamını veren program.

            //Console.WriteLine("Lütfen birinci sayıyı giriniz");
            //string sayi1 = Console.ReadLine();

            //Console.WriteLine("Lütfen ikinci sayıyı giriniz");
            //string sayi2 = Console.ReadLine();


            //int x = Convert.ToInt32(sayi1);
            //int y = Convert.ToInt32(sayi2);

            //int z  = x * y;

            //Console.WriteLine(z);
            //Console.ReadLine();
            #endregion

            #region soru2

            //Dışarıdan 2 adet not girilecek. Vize ve final. Vizenin yani dışarıdan girilen ilk notun %30 u ikinci notun yani finalin %70 i alınarak ortalama NOT yazılacak ( 100 üzerinden )


            //double, decimal, float
            //Console.WriteLine("Lütfen vize notunu giriniz");
            //double not1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Lütfen final notunu giriniz");
            //double not2 = Convert.ToDouble(Console.ReadLine());

            //double sonuc = (not1 * 0.3) + (not2 * 0.7);

            //Console.WriteLine("Not: " + sonuc);
            //Console.ReadLine();
            #endregion

            #region soru3

            //Dışarıdan girilen nota göre EĞER 0-45 arasındaysa "BU ÇOCUK OKUMAZ" 45-55 arasındaysa "AKMASA DA DAMLIYOR 55-70 "ZEKİ AMA ÇALIŞMIYOR" 70-85 ARASI 4 ,85-100 ARASI MAŞALLAH,
            //Eğer NOT 0-100 DEĞİLSE LÜTFEN GEÇERLİ BİR NOT GİRİNİZ


            //Console.WriteLine("Lütfen notunuzu giriniz");
            //int not = Convert.ToInt32(Console.ReadLine());

            //if(not >= 0 && not < 45)
            //{
            //    Console.WriteLine("OKUMAZ TORNACIYA GÖNDER!");
            //}
            //else if(not >= 45 && not < 55)
            //{
            //    Console.WriteLine("AKMASA DA DAMLIYOR");
            //}
            //else if(not >= 55 && not < 70)
            //{
            //    Console.WriteLine("ORTA ŞEKER");
            //}
            //else if(not >= 70 && not < 85)
            //{
            //    Console.WriteLine("İYİ ARKADAŞ");
            //}
            //else if(not >= 85 && not < 100)
            //{
            //    Console.WriteLine("EN İYİSİ");
            //}
            //else
            //{
            //    Console.WriteLine("Lütfen düzgün bir not giriniz");
            //}

            //Console.ReadLine();


            #endregion

            #region soru4

            //Kullanıcı dışarıdan bir sayı girsin. 0 dan o kullanıcının girdiği sayıya kadar olan sayıların toplamını ekrana yaz.

            //Console.WriteLine("Lütfen bir sayı giriniz");

            //int sayi = Convert.ToInt32(Console.ReadLine());

            //int toplam = 0;

            //for (int i = 0; i < sayi; i++)
            //{
            //    toplam = toplam + i;
            //}

            //Console.WriteLine(toplam);

            //Console.ReadLine();

            #endregion

            #region soru5
            //Kullanıcının dışarıdan girdiği sayıya kadar olan ÇİFT SAYILARI toplayıp ekrana yazdır


            //Console.WriteLine("Lütfen bir sayı giriniz");

            //int sayi = Convert.ToInt32(Console.ReadLine());

            //int toplam = 0;

            //for (int i = 0; i <= sayi; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        toplam = toplam + i;
            //    }
            //}

            //Console.WriteLine(toplam);

            //Console.ReadLine();



            #endregion

            #region soru6
            //Kullanıcının dışarıdan girdiği kelimedeki harfleri ekrana yaz

            //Console.WriteLine("Lütfen bir kelime giriniz");

            //string kelime = Console.ReadLine();

            //for (int i = 0; i < kelime.Length; i++)
            //{
            //    Console.WriteLine(kelime[i]);
            //}

            //Console.ReadLine();

            #endregion




        }
    }
}

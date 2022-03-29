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

            //Yol - 1

            //Console.WriteLine("Lütfen bir sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());


            //for (int i = 0; i < sayi; i++)
            //{
            //    for (int j = 1; j < sayi; j++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine("*");
            //}

            //Console.ReadLine();

            // Yol - 2 ** Tek forla yapılacak

            //int sayac = 0;
            //for (int i = 0; i < sayi * sayi; i++)
            //{
            //    Console.Write("*");

            //    sayac++;

            //    if (sayac == sayi)
            //    {
            //        Console.Write("\n");
            //        sayac = 0;
            //    }

            //}

            //Console.ReadLine();

            #endregion


            //7 Kullanıcı ekrandan iki sayı girecek. Çarpma operatörü kullanmadan iki sayıyı çarp ekrana yaz.
            #region soru-7

            //Console.WriteLine("Lütfen ilk sayıyı giriniz");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Lütfen ikinci sayıyı giriniz");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //3 * 5
            // 5 + 5 + 5
            // 3 + 3 + 3 + 3 + 3

            //int toplam = 0;
            //for (int i = 0; i < sayi1; i++)
            //{
            //    toplam = toplam + sayi2;
            //}

            //Console.WriteLine("Sonuç: " + toplam);
            //Console.ReadLine();


            //2. yol Mehmet
            //int toplam = 0;
            //int j = 1;
            //do
            //{
            //    toplam += sayi1;
            //    j++;
            //} while (j <= sayi2);



            //Console.WriteLine("Sonuç : " + toplam);
            //Console.ReadKey();

            //3. yol

            //int toplam = 0;
            //int sayac = 0;
            //while (sayac < sayi1)
            //{
            //    toplam = toplam + sayi2;
            //    sayac++;
            //}

            //Console.WriteLine("Sonuç : " + toplam);
            //Console.ReadKey();

            #endregion

            //9) Dışarıdan girilen bir N sayısına kadar olan sayıların karelerinin toplamını hesaplayan program.

            #region soru 9
            //Console.WriteLine("Lütfen bir sayı giriniz");

            //int sayi = Convert.ToInt32(Console.ReadLine());

            //int toplam = 0;

            //for (int i = 0; i < sayi; i++)
            //{
            //    //toplam = toplam + (i * i);
            //    toplam += (i * i);

            //}

            //Console.WriteLine("Sonuç: " + toplam);
            //Console.ReadLine();
            #endregion


            //10) Kullanıcı dışarıdan bir fiyat girecek. Girdiği fiyatın KDV li hali (%18 i) ekrana yazacak FAKAT kullanıcının girdiği fiyat 200 üzerindeyse %10 indirim uygulayıp KDV yi öyle hesapla.


            //Soru - 12  Dışarıdan 3 tane sayı girilecek ve program en küçük sayıyı bulacak.


            #region soru - 12

            //Console.WriteLine("Lütfen ilk sayıyı giriniz");
            //int x = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine("Lütfen ikinci sayıyı giriniz");
            //int y = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Lütfen üçüncü sayıyı giriniz");
            //int z = Convert.ToInt32(Console.ReadLine());


            //if(x < y && x < z)
            //{
            //    Console.WriteLine("En küçük sayı x ");
            //}
            //else if (y < z && y < x)
            //{
            //    Console.WriteLine("En küçük sayı y ");
            //}
            //else
            //{
            //    Console.WriteLine("En küçük sayı z ");
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


            //DİZİLER

            //int[] sayidizi = new int[5];
            //sayidizi[0] = -10;
            //sayidizi[1] = 4;
            //sayidizi[2] = 2;
            //sayidizi[3] = 11;
            //sayidizi[4] = 6;


            //string[] isimDizi = new string[4];
            //isimDizi[0] = "Çağatay";
            //isimDizi[1] = "Korhan";
            //isimDizi[2] = "Burçin";
            //isimDizi[3] = "Aykut";

            //isim dizisinin elemanlarını tek tek console a yaz!

            //for (int i = 0; i < isimDizi.Length; i++)
            //{
            //    Console.WriteLine(isimDizi[i]);
            //}

            //Console.ReadLine();

            //int[] myNum = { 3, 6, 7777, 89, 120, 202 };
            //int toplam = 0;
            //for (int i = 0; i < myNum.Length; i++)
            //{
            //    toplam += myNum[i];
            //}
            //Console.WriteLine(toplam);
            //Console.ReadLine();



            //Random rnd = new Random();
            //int rastgeleSayi = rnd.Next(1, 200);

            //Console.WriteLine(rastgeleSayi);
            //Console.ReadLine();

            //for (int i = 0; i < 10; i++)
            //{

            //    Random rnd = new Random();
            //    int rastgeleSayi = rnd.Next(1, 200);

            //    Console.WriteLine(rastgeleSayi);

            //}

            //Console.ReadLine();

            #region sayı bulma oyunu
            //Sayı bulma oyunu
            //0 ile 100 arasında rastgele bir bulunacak sayı GENERATE edilir. ( ÜRETİLİR ) Kullanıcı console a bir sayı girerek tahminde bulunur. Kullanıcının 10 hakkı var. Kullanıcı sayıyı girdiğinde sistem ("Tahminden yüksek bir sayı girdiniz") veya ("Tahminden alçak bir sayı girdiniz") diye yönlendirir.

            Random rnd = new Random();
            int rastgeleSayi = rnd.Next(1, 100);


            int sayac = 10;


            while (sayac > 0)
            {
                Console.WriteLine("Tahmin gir!");
                int tahmin = Convert.ToInt32(Console.ReadLine());

                if (tahmin == rastgeleSayi)
                {
                    Console.WriteLine("EVREKA!!");
                }
                else if (tahmin < rastgeleSayi)
                {
                    Console.WriteLine("Tahminden alçak sayı girdiniz");
                    sayac--;

                }
                else
                {
                    Console.WriteLine("Tahminden yüksek sayı girdiniz");
                    sayac--;
                }
            }

            #endregion

            #region en küçük sayı bulma
            //7 elemanlı bir sayı dizi sayı dizisi tanımla. En küçük sayıyı ekrana yazdır.
            //int[] sayidizi = new int[7];
            //sayidizi[0] = 20;
            //sayidizi[1] = 10;
            //sayidizi[2] = -5;
            //sayidizi[3] = 9780;
            //sayidizi[4] = 2002;
            //sayidizi[5] = 0;
            //sayidizi[6] = 10;

            //for döngüsü ile bu dizinin en küçük elemanını bul

            //int minimumValue = sayidizi[0];

            //for (int i = 0; i < sayidizi.Length; i++)
            //{

            //    if(sayidizi[i] < minimumValue)
            //    {
            //        minimumValue = sayidizi[i];
            //    }

            //}

            #endregion


        }









    }
    }


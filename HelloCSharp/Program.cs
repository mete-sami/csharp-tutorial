using System;


namespace HelloCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1, sayac = 1; sayac <= 5; j = j + i)
            //    {
            //        Console.Write(j + i);
            //        sayac++;

            //    }
            //    Console.WriteLine("");

            //}


            //YAPAMADIK!
            //int sayac = 2;

            //for (int i = 2; i <= 26; i++)
            //{      

            //    if (i % 5 == 1)
            //    {
            //        Console.WriteLine("");
            //        sayac++;
            //    }

            //}

            //Console.Read();



            //Soru - 17  ÖDEV

            //int sayac = 1;
            //for (int i = 1; i < 15; i++)
            //{
            //    Console.Write(i);

            //    if (i == 1 || i == 3 || i == 6 || i == 10)
            //    {
            //        Console.WriteLine("");
            //    }


            //}



            //Soru - 15  ÖDEV
            //Dışarıdan girilen en az 5 basamaklı sayının ilk ve son basamakları arasındaki sayıların toplamını bulan program.


            Console.WriteLine("Lütfen bir sayı giriniz");
            //string sayi = Console.ReadLine();

            int sayi = Convert.ToInt32(Console.ReadLine());

            //string yeniSayi = sayi.Substring(1, sayi.Length - 2);


            //int toplam = 0;
            //foreach (var item in yeniSayi)
            //{
            //    toplam = toplam + Convert.ToInt32(item.ToString());
            //}

            //Console.WriteLine("Toplam: " + toplam);

            bool bolunmeyeDevam = true;
            int sayac = 0;
            int toplam = 0;

            while (bolunmeyeDevam)
            {
                if (sayi % 10 != 0)
                {
                    toplam = toplam + (sayi % 10);
                    sayac++;
                    sayi = (sayi - (sayi % 10)) / 10;
                   
                }
                else
                {
                    bolunmeyeDevam = false;
                }
            }

            Console.WriteLine("Sayıların toplamı: " + toplam);
            Console.WriteLine("Sayaç: " + sayac);
            Console.Read();


        }

    }
}


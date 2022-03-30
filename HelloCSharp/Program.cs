using System;


namespace HelloCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Dışarıdan aldığı kelimenin sayısını bana veren uyguluma

            //Console.WriteLine("Lütfen bir metin giriniz");
            //string data = Console.ReadLine();

            //Console.WriteLine(data.Length);
            //Console.ReadLine();

            //Dışarıdan girilen metindeki sağ ve sol boşluklar hariç kaç karakter var?
            //data = data.Trim();

            //Console.WriteLine(data.Length);

            //Dışarıdan girilen metindeki a harfi HARİÇ kaç karakter var? Örneğin Çağatay kelimesini girerse 4 yazacak.

            //string newData = data.Replace("a", "");
            //Console.WriteLine(newData.Length);

            //2. yol
            //int sayac = 0;
            //for (int i = 0; i < data.Length; i++)
            //{
            //    if (data[i] != 'a')
            //    {
            //        sayac++;
            //    }
            //}

            //Console.WriteLine(sayac);
            //Console.ReadLine();

            string[] isimler = new string[7];
            isimler[0] = "Çağatay";
            isimler[1] = "Şivan";
            isimler[2] = "Emre";
            isimler[3] = "Dilek";
            isimler[4] = "Abdullah";
            isimler[5] = "Mehmet";
            isimler[6] = "Ece";



            #region soru-1
            //1) Dizinin tüm elemanlarını büyült ve başka bir diziye at.
            //string[] newNames = new string[6];

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    newNames[i] = isimler[i].ToUpper();
            //}

            #endregion


            #region soru-2
            //2) Dizide 4 harf veya altında kaç isim var?

            //int sayac = 0;

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //   if(isimler[i].Length <= 4)
            //    {
            //        sayac++;
            //    }
            //}

            //Console.WriteLine(sayac);
            //Console.ReadLine();
            #endregion


            #region soru-3
            //3) Dizinin tüm elemanlarının ilk harfini sil ve başka bir diziye at.
            //string[] newNames = new string[6];

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    newNames[i] = isimler[i].Substring(1);
            //}

            #endregion


            #region soru-4
            //4) Dizide M harfi ile başlayan kaç adet isim var ?

            //int sayac = 0;
            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    //if(isimler[i].ToLower()[0] == 'm')
            //    //{
            //    //    sayac++;
            //    //}

            //    if (isimler[i].ToLower().StartsWith('m'))
            //    {
            //        sayac++;
            //    }
            //}

            //Console.WriteLine(sayac);
            //Console.ReadLine();
            #endregion


            #region soru-diğer
            //Dizideki elemanları bir döngü ile gez. Daha sonra her bir elemanın ilk 4 harfini ekrana yazdır.

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    if(isimler[i].Length < 4)
            //    {
            //        Console.WriteLine(isimler[i]);

            //    }
            //    else
            //    {
            //        Console.WriteLine(isimler[i].Substring(0, 4));
            //    }

            //}

            //Console.ReadLine();

            #endregion


            //var name = "Çağatay";
            //var year = 2022;
            //var onlineStatus = false;

            //foreach (var item in isimler)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.ReadLine();

            //Aşağıdaki metni bir harfi küçük bir harfi büyük olacak şekilde ekrana yazdır.

            //string fullName = "Çağatay Yıldız";
            //string resultFullName = "";

            //for (int i = 0; i < fullName.Length; i++)
            //{

            //    if (i % 2 == 0)
            //    {
            //        resultFullName = resultFullName + fullName[i].ToString().ToUpper();
            //    }
            //    else
            //    {
            //        resultFullName = resultFullName + fullName[i].ToString().ToLower();
            //    }

            //}


            //Console.WriteLine(resultFullName);
            //Console.ReadLine();

            //int x = 5;
            //int y = 10;

            //string sonuc = x.ToString() + y.ToString();

            //Console.WriteLine(sonuc);
            //Console.ReadLine();


            #region string metotlar soru 5
            //5) Dizide içerisinde 2 adet a harfi geçen KAÇ eleman var ?

            //int total = 0;
            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    int aCount = 0;
            //    for (int j = 0; j < isimler[i].Length; j++)
            //    {
            //        if (isimler[i][j].ToString().ToLower() == "a")
            //        {
            //            aCount++;
            //        }

            //    }
            //    if (aCount == 2)
            //    {
            //        total++;
            //    }
            //}



            //Console.WriteLine("2 adet a harfi iceren " + total + " oge var");
            //Console.ReadLine();

            #endregion


            #region soru-11
            // 11) Dizinin elemanlarındaki SADECE a harflerini büyültüp elemanları başka bir diziye ata

            //string[] newNameArray = new string[7];

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    newNameArray[i] = isimler[i].Replace("a", "A");
            //}



            #endregion


            //19) Kullanıcı dışarıdan bir sayı girecek o sayı ekranda oluşacak üçgenin TABANI olacak.

            Console.WriteLine("Lütfen bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sayi2 = sayi;

            for (int i = 0; i < sayi; i++)
            {


                for (int j = 0; j < sayi2 - 1; j++)
                {
                    Console.Write(" ");
                }

                sayi2--;

                for (int k = 0; k < i; k++)
                {
                    Console.Write("* ");
                }

                Console.Write("\n");
               
            }

            Console.ReadLine();

            
        }

    }
}


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




            //1) Dizinin tüm elemanlarını büyült ve başka bir diziye at.
            //string[] newNames = new string[6];

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    newNames[i] = isimler[i].ToUpper();
            //}



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


            //3) Dizinin tüm elemanlarının ilk harfini sil ve başka bir diziye at.
            //string[] newNames = new string[6];

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    newNames[i] = isimler[i].Substring(1);
            //}


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
        }

    }
}


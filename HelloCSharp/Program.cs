using System;


namespace HelloCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "Siemens";

            //ToUpper ve ToLower metotları geriye string döndüğü için bir string değere atayabiliyoruz.
            string newName =  name.ToUpper();

            string newName2 = name.ToLower();

            string newName3 = name.Trim();

            string newName4 = name.Substring(1);

            string newName5 = name.Substring(1, 3);


            #region Metot-1

            //string data = Hello();

            //Console.WriteLine(data);
            //Console.ReadLine();

            //Geriye string dönen dışarıdan bir parametre almayan bir metot yaz
            string Hello()
            {
                return "Siemens!";
            }

            #endregion

            #region metot-2
            //string data = Birlestir("Çağatay", "Yıldız");

            //Console.WriteLine(data);
            //Console.ReadLine();

            ////Dışarıdan iki string parametre alan ve aldığı parametreleri aralarında boşluk bırakarak string dönen bir metot yaz.

            //string Birlestir(string name, string surname)
            //{
            //    return name + " " + surname;
            //}
            #endregion

            #region metot-3
            ////Dışarıdan int bir değer alan ve aldığı değerin karesini bana return eden bir metot yaz

            //int KareHesapla(int x)
            //{
            //    return x * x;
            //}

            //int sonuc = KareHesapla(12);

            //Console.Write(sonuc);
            //Console.Read();
            #endregion

            #region metot-4

            //Dışarıdan 3 tane int sayı alan ve bu aldığı sayıların ORTALAMASINI bana döndüren metot

            //double Ortalama(int x, int y, int z)
            //{
            //    double sonuc = (x + y + z) / 3.0;

            //    return sonuc;
            //}

            //double data = Ortalama(2, 5, 10);

            //Console.WriteLine(data);
            //Console.ReadLine();

            #endregion

            #region metot-5
            //Dışarıdan bir string dizi ALAN ve aldığı dizideki eleman sayısını bana DÖNDÜREN metot
            //int getArrayLength(string[] isimler)
            //{
            //    int length = isimler.Length;

            //    return length;
            //}

            //string[] isimler = { "Çağatay", "Sami", "Burak" };

            //int sonuc = getArrayLength(isimler);

            //Console.WriteLine(sonuc);
            //Console.Read();
            #endregion

            #region metot-6
            //Dışarıdan string bir dizi alan ve dizinin içerisinde KAÇ elemanda "a" harfi geçtiğini bana söyleyen metot

            //int getArrayCountByA(string[] isimler)
            //{

            //    int sayac = 0;

            //    foreach (var item in isimler)
            //    {

            //        if (item.Contains("a"))
            //        {
            //            sayac++;
            //        }

            //    }

            //    return sayac;

            //}

            //string[] isimler = { "Çağatay", "Sami", "Burak", "Yunus" };

            //int aLength = getArrayCountByA(isimler);

            //Console.WriteLine(aLength);
            //Console.Read();
            #endregion


            #region metot-7
            //Dışarıdan bir fiyat alan ve aldığı fiyatın KDV li halini bana return eden metot. FİYAT 200 den büyükse KDV %18 den hesaplanacak değilse %8 den hesaplanacak

            //double KDVCalc(double fiyat)
            //{
            //    double sonuc;

            //    if (fiyat > 200)
            //    {
            //        sonuc = fiyat * 1.18;
            //    }
            //    else
            //    {
            //        sonuc = fiyat * 1.08;
            //    }

            //    return sonuc;
            //}

            //double data =  KDVCalc(220);

            //Console.WriteLine(data);
            //Console.Read();

            #endregion


        }

    }
}


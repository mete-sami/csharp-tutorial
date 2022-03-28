using System;


namespace HelloCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

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

            //Dışarıdan girilen nota göre EĞER 0-45 arasındaysa "BU ÇOCUK OKUMAZ" 45-55 arasındaysa "AKMASA DA DAMLIYOR 55-70 "ZEKİ AMA ÇALIŞMIYOR" 70-85 ARASI 4 ,85-100 ARASI MAŞALLAH,
            //Eğer NOT 0-100 DEĞİLSE LÜTFEN GEÇERLİ BİR NOT GİRİNİZ

            #region soru3

            Console.WriteLine("Lütfen notunuzu giriniz");
            int not = Convert.ToInt32(Console.ReadLine());

            if(not >= 0 && not < 45)
            {
                Console.WriteLine("OKUMAZ TORNACIYA GÖNDER!");
            }
            else if(not >= 45 && not < 55)
            {
                Console.WriteLine("AKMASA DA DAMLIYOR");
            }
            else if(not >= 55 && not < 70)
            {
                Console.WriteLine("ORTA ŞEKER");
            }
            else if(not >= 70 && not < 85)
            {
                Console.WriteLine("İYİ ARKADAŞ");
            }
            else if(not >= 85 && not < 100)
            {
                Console.WriteLine("EN İYİSİ");
            }
            else
            {
                Console.WriteLine("Lütfen düzgün bir not giriniz");
            }

            Console.ReadLine();


            #endregion


        }
    }
}

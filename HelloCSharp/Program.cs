using System;


namespace HelloCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "Çağatay";

            //name değerindeki harflerin tamamını büyült ve başka bir değere ata!
            string upperName = name.ToUpper();


            string city = "İZMİR";
            string lowerCity = city.ToLower();


            string metalBands = "Iron Maiden, In Flames, Gojira, Rotting Christ";
            //Virgülle ayrılan metal gruplarını bir diziye at.

            string[] metalBandsArray = metalBands.Split(',');


            //Aşağıdaki metinde ı karakterlerini i ile değiştir
            string metin = "Çağatay Yıldız";
            string sonuc = metin.Replace("ı", "i");






            Console.WriteLine(sonuc);
            Console.ReadLine();


        }

       

    }
}


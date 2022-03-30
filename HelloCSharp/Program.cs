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


            //Aşağıdaki metinde a karakterini yok et!
            string metin2 = "Çağatay Yıldız";
            string sonuc2 = metin2.Replace("a", "");


            //Aşağıdaki metinde ilk a karakterini bul ve yerini bana söyle!!
            string metin3 = "Çağatay Yıldız";

            //Index of metodu ile karakterin metindeki ilk yerini bulabiliyorum!
            int indexNo = metin3.IndexOf('a');

            //Yukarıdaki metin3 isimli değerde a karakterinin son indexini bul ve bana söyle!

            int indexNo2 = metin3.LastIndexOf('a');


            //Aşağıdaki metinde kaç karakter var?
            string country = "Türkiye";
            int countryLength = country.Length;


            //Trim End ile boşlukları temizliyoruz
            string book = "Zaman Makinası      ";
            string bookSonuc = book.TrimEnd();

            //SubString
            string company = "Siemens Teknoloji";
            int indexNoCompany = company.IndexOf("Teknoloji");

            string companySonuc = company.Substring(0, 7);


            //Kullanıcı dışarıdan bir telefon numarası girecek. Girdiği telefon numarası formatı "+905437331470" şeklinde olacak. Ben bu formatı 5437331470 şekline çevirip ekrana yaz.

         

            

            Console.WriteLine(indexNoCompany);
            Console.ReadLine();


        }

       

    }
}


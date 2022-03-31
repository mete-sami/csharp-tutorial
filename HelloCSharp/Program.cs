using System;


namespace HelloCSharp
{
    class Program
    {
        static void Main(string[] args)
        {


            #region soru-1
            // 1) Dışarıdan bir metin alan aldığı değerdeki karakter sayısını dönen metot

            int getCharCount(string data)
            {
                int length = data.Length;
                return length;
            }

            #endregion

            #region soru-2

            //2) Dışardan iki metin alan aldığı metinleri BÜYÜTÜP aralarında bir boşluk bırakarak dönen metot
            string wordConcat(string x, string y)
            {
                string result = x.ToUpper() + " " + y.ToUpper();

                return result;
            }
            #endregion

            #region soru-3
            //3) Dışarıdan bir metin alan ve aldığı metinde kaç adet "a" harfi olduğunu söyleyen metot

            //int calcA(string word)
            //{
            //    int sayac = 0;

            //    string newWord = word.ToLower();

            //    foreach (var item in newWord)
            //    {
            //        if(item == 'a')
            //        {
            //            sayac++;
            //        }
            //    }

            //    return sayac;
            //}

            //int result = calcA("ÇAğAtay");
            //Console.Write(result);
            //Console.Read();

            #endregion

            #region soru-4
            //4) Dışarıdan bir metin alan aldığı metnin sadece ilk harfini büyük diğer harflerini küçük yazacak şekilde yeni bir metin oluşturarak dönen metot. çağatay - Çağatay

            string nameCalc(string word)
            {
                string result = word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower();
                return result;
            }



            #endregion

            #region soru-5
            //5) Dışarıdan iki metin alan aldığı metinlerin ilk harflerini büyültüp diğer harflerini küçülten ve aralarında boşluk bırakarak bir metin halinde return eden metot

            string fullNameCalc(string x, string y)
            {
                string result = nameCalc(x) + " " + nameCalc(y);
                return result;
            }



            #endregion

            #region soru-6
            //6) Dışarıdan bir metin alan aldığı metnin sadece ilk üç harfini döndüren metot. Uyarı: Metin 2 harfliyse sadece iki harfini döndürsün.Sistem hata vermemeli

            string wordCalcThree(string word)
            {
                string result = "";

                if (word.Length >= 3)
                {
                    result = word.Substring(0, 3).ToLower();
                }
                else
                {
                    result = word.ToLower();
                }

                return result;
            }

            #endregion

            #region soru-7
            //7) Dışarıdan iki sayı alan, aldığı sayıların KARELERİNİN toplamını dönen metot

            int calcNumbers(int x, int y)
            {
                int result = (x * x) + (y * y);

                return result;
            }



            #endregion

            #region soru-8
            //8) Dışarıdan üç sayı alan ve bu sayılardan en büyüğünü döndüren metot
            int findNumber(int x, int y, int z)
            {
                if (x > y && x > z)
                {
                    return x;
                }
                else if(y > x && y > z)
                {
                    return y;
                }
                else
                {
                    return z;
                }
                

            }

            #endregion

            #region soru-9
            //9) Dışarıdan bir sayı alan aldığı sayı tekse "TEK SAYI" değilse "ÇİFT SAYI" şeklinde metin return eden metot

            string findNumberMode(int x)
            {
                if (x % 2 == 0)
                {
                    return "Çift sayı";
                }
                else
                {
                    return "Tek sayı";
                }
            }


            #endregion

            #region soru-10
            //10) Dışarıdan aldığı metni ikili harfler şeklinde string dizi olarak döndüren metot.Örneğin “Machine Head" metnin “Ma”,”ch”,”in” gibi..

            //string[] calcArrayByWord(string word)
            //{
            //    int arrayLength = 0;

            //    if (word.Length % 2 == 0)
            //    {
            //        arrayLength = word.Length / 2;
            //    }
            //    else
            //    {
            //        arrayLength = (word.Length / 2) + 1;
            //    }

            //    string[] nameArray = new string[arrayLength];

            //    int sayac = 0;
            //    for (int i = 0; i < word.Length; i = i +2)
            //    {
            //        //Döngü son kez dönüyorsa VE tek sayıysa dizinin son elemanı bir harf olacak
            //        if (word.Length % 2 == 1 && i == word.Length - 1)
            //        {
            //            nameArray[sayac] = word.Substring(i, 1);
            //        }
            //        else
            //        {
            //            nameArray[sayac] = word.Substring(i, 2);
            //        }


            //        sayac++;

            //    }

            //    return null;

            //}

            //calcArrayByWord("Çağatay");



            #endregion

            #region soru-11
            //11) Dışarıdan aldığı metni char[] dizisi şeklinde harflerini döndüren metot

            char[] GetWordConvertCharArray(string word)
            {
                char[] charArray = new char[word.Length];


                for (int i = 0; i < word.Length; i++)
                {

                    charArray[i] = word[i];

                }

                return charArray;

            }

            char[] result = GetWordConvertCharArray("Çağatay");

            #endregion

            #region soru-12

            double CalcCircleLength(double r)
            {
                //2 * pi sayısı * r

                double circleLength = 2 * Math.PI * r;
                return circleLength;
            }

            #endregion

            #region soru-13
            //Dışarıdan aldığı yarıçapla dairenin alanını hesaplayan metot

            double CalcCircleArea(double r)
            {
                double area = Math.PI * r * r;

                return area;
            }

            #endregion

            #region soru-14
            //void anahtar kelimesi metodun dışarıya değer dönmeyeceğini belirtir
           // 14) Dışarıdan aldığı 2 ismi aralarında boşluk bırakacak şekilde console a yazdıran metot.

            void WriteFullName(string name, string surname)
            {
                Console.WriteLine(name + " " + surname);
                Console.Read();
            }

            WriteFullName("Çağatay", "Yıldız");
            #endregion

            #region soru-15
            //15) Dışarıdan bir sayı alan ve bu sayıya göre kare çizen metot.
            void FillSquare(int x)
            {

                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        Console.Write("*");
                    }

                    Console.Write("\n");
                }

                Console.ReadLine();

            }

            //FillSquare(10);


            #endregion

        }

    }
}


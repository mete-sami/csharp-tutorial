﻿using System;


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



            #region soru-10
            //10) Dışarıdan aldığı metni ikili harfler şeklinde string dizi olarak döndüren metot.Örneğin “Machine Head" metnin “Ma”,”ch”,”in” gibi..

            string[] calcArrayByWord(string word)
            {
                int arrayLength = 0;

                if (word.Length % 2 == 0)
                {
                    arrayLength = word.Length / 2;
                }
                else
                {
                    arrayLength = (word.Length / 2) + 1;
                }

                string[] nameArray = new string[arrayLength];

                int sayac = 0;
                for (int i = 0; i < word.Length; i = i +2)
                {
                    //Döngü son kez dönüyorsa VE tek sayıysa dizinin son elemanı bir harf olacak
                    if (word.Length % 2 == 1 && i == word.Length - 1)
                    {
                        nameArray[sayac] = word.Substring(i, 1);
                    }
                    else
                    {
                        nameArray[sayac] = word.Substring(i, 2);
                    }
                    
                  
                    sayac++;
                   
                }

                return null;

            }

            calcArrayByWord("Çağatay");



            #endregion



            //7) Dışarıdan iki sayı alan, aldığı sayıların KARELERİNİN toplamını dönen metot
            //8) Dışarıdan üç sayı alan ve bu sayılardan en büyüğünü döndüren metot
            //9) Dışarıdan bir sayı alan aldığı sayı tekse "TEK SAYI" değilse "ÇİFT SAYI" şeklinde metin return eden metot

            //11) Dışarıdan aldığı metni char[] dizisi şeklinde harflerini döndüren metot
        }

    }
}


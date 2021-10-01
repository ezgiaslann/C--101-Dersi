using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 5; // Bellekde 1 byte yer kaplar. 0 ve 255 arasında bir değer alabilir.
            sbyte c = 5; // 1 byte. -128 ile 127 arasında değer alabilir.

            short s = 5; // 2 byte. -32768 den 32767' ye kadar tam sayı değerleri alabilir.
            ushort us = 5; // 2 byte. 0 dan 65365' e kadar tam sayı değerleri alabilir.
            //Unsigned değerler 0' dan küçük değerleri alamıyorlar.


            //Tamsayılar için değişken tipleri.
            Int16 i16 = 2; // 2 byte. 
            int i = 2;     // 4 byte. -2147483648' den 2177483647' ye kadar olan tam sayı değerlerini alabilir.
            Int32 i32 = 2; // 4 byte.
            Int64 i64 = 2; // 8 byte.
            uint ui = 2;   // 4 byte.

            long l = 4;    // 8 byte.
            ulong ul = 4;  // 8 byte.

            // Reel sayılar için kullanılan tipler.
            float f = 5;    // 4 byte.
            double d = 5;   // 8 byte.
            decimal de = 5; // 16 byte.

            char ch = '2';       // 2 byte.
            string str = "Ezgi"; // Sınırsız.    

            bool b1 = true;
            bool b2 = false;

            // Tarihi saati tutmak için kullanıyoruz.
            DateTime dt = DateTime.Now; // Çalıştırdığımız anın tarih ve saatini verir.
            
            Console.WriteLine(dt);

            /* object her türden veriyi alabiliyor.
             Aslında tüm değişken tipleri birer objecttir. */
            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;

            // String ifadeler
            string str1 = string.Empty;
            str1 = "Ezgi ASLAN";
            string ad = "Ezgi";
            string soyad = "ASLAN";
            string tamIsim = ad + " " + soyad;

            // integer tanımlama şekilleri
            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 + integer2;

             // boolean
            bool bool1 = 10 > 2;

            //Değişken Dönüşümleri
            string str20 = "20";
            int int20 = 20;

            string yeniDeger = str20 + int20.ToString();
            
            Console.WriteLine(yeniDeger); // Çıktısı 2020.

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21); 

            int int22 = int20 + int.Parse(str20); // Çıktısı 40.

           Console.WriteLine(int22); 
        }
    }
}

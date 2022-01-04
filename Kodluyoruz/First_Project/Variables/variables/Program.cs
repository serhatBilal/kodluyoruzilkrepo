using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer1 = 222;
            Console.WriteLine(integer1);
            byte byte1 = 2;
            Console.WriteLine(byte1);
            double double1 = 2.22;
            Console.WriteLine(double1);
            bool bool1 = true;
            Console.WriteLine(bool1);
            DateTime date1 = DateTime.Now;
            Console.WriteLine(date1);
            string date2 = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(date2);
            string str1 = "20";
            int int2 = 20;
            int sonuc = Convert.ToInt32(str1) + int2 ;
            Console.WriteLine(sonuc);
            string sonuc1 = str1 + int2.ToString();
            Console.WriteLine(sonuc1);
            decimal a = 12;
            Console.WriteLine(a);
            char karakter = 'S';
            Console.WriteLine(karakter);

        }
    }
}

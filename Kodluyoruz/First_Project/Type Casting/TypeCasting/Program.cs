using System;

namespace TypeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Implicit Conversion***");
            byte a = 1;
            byte b = 2;
            byte c = 3;

            int d = a+b+c;
            Console.WriteLine(d);

            Console.WriteLine("***Explicit Conversion***");

            int e = 15;
            byte f = (byte)e;
            Console.WriteLine(f);

            float g = 10.2f;
            byte h = (byte)g;
            Console.WriteLine(h);

            Console.WriteLine("***ToString Metod***");

            int i = 102;
            string j = i.ToString();
            Console.WriteLine(j);

            string k = 12.5f.ToString();
            Console.WriteLine(k);

            Console.WriteLine("***System Convert***");

            string l ="10";
            string m = "20";
            int sayi1,sayi2,toplam;

            sayi1 = Convert.ToInt32(l);
            sayi2 = Convert.ToInt32(m);
            toplam = sayi1+sayi2;
            Console.WriteLine(toplam);



        }
    }
}

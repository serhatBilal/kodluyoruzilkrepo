using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[5];
            sayilar[1]= 10;
            Console.WriteLine(sayilar[1]);


            string[] renkler = {"Mavi","Kırmızı","Beyaz"};
            Console.WriteLine(renkler[2]);

            foreach(var renk in renkler){
                Console.WriteLine(renk);
            }
        }
    }
}

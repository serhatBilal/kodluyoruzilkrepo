using System;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            int derece=12;
            Console.WriteLine(Gunler.Pazartesi);
            Console.WriteLine((int)Gunler.Pazartesi);
            
            if(derece<(int)HavaDurumu.Coksoguk)
                Console.WriteLine("Disarisi cok soguk");
            else if(derece>(int)HavaDurumu.soguk && derece<=(int)HavaDurumu.normal)
                Console.WriteLine("Istersen disari cikabilirsin");
            else{
                Console.WriteLine("Hava Durumu : {0} ",derece);
            }
        }
    }

    enum Gunler{
        Pazartesi =1,
        Sali,
        Carsamba,
        Persembe,
        Cuma,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu{
        Coksoguk=0,
        soguk=5,
        normal=18,
        sicak =23,
        cokSicak=32
    }
}

using System;

namespace forLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int tekToplam = 0;
            int ciftToplam = 0;
            for(int i = 0;i <=10;i++){
                Console.WriteLine(i);
            }

            for(int i = 0; i <=1000;i++){
                if(i % 2 == 1){
                    tekToplam+=i;
                }else{
                    ciftToplam+=i;
                }

            }
            Console.WriteLine("Tek sayi toplami : " + tekToplam + " Cift sayi toplami " + ciftToplam );

            for (int i = 0; i < 10; i++)
            {
                if(i==4){
                    break;
                }
                Console.WriteLine(i);
            }
             for (int i = 0; i < 10; i++)
            {
                if(i==4){
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}

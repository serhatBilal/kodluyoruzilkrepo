using System;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 2;
            sayi1 = sayi1+2;
            Console.WriteLine(sayi1);
            int sayi2 = 10;
            sayi2++;
            Console.WriteLine(sayi2);

            int sayi3 = 30;
            sayi3 /=10;
            Console.WriteLine(sayi3);

            int sayi4 = 21;
            int islem = sayi4%2;
            Console.WriteLine(islem);

            Console.WriteLine(sayi1==sayi3);
            Console.WriteLine(sayi1<=sayi3);
            Console.WriteLine(sayi1>=sayi3);
            Console.WriteLine(sayi1!=sayi3);

            if(sayi1>=sayi3 && sayi1!=sayi3){
                Console.WriteLine("Harika");
            }

             if(sayi1>=sayi3 || sayi1!=sayi3){
                Console.WriteLine("Harika");
            }

             if(sayi1>=sayi3 && !(sayi1!=sayi3)){
                Console.WriteLine("Harika");
            }



            
        }
    }
}

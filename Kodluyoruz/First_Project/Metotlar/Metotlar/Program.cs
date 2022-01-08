using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Topla(5,2));

            Metotlar metot = new Metotlar();
            metot.EkranaYaz("Serhat BILAL");
        }

        static int Topla(int a,int b){
            return a+b;
        }
    }

    class Metotlar{
        public void EkranaYaz(String value){

            Console.WriteLine(value);
            
        }
    }
}

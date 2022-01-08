using System;

namespace metotlar3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Expo(2,4));
            string text = "Serhat BILAL";

           Console.WriteLine(text.CheckSpaces()); 
           Console.WriteLine(text.MakeUpperCase()); 
        }

        public static int Expo(int sayi,int üs){
            if(üs<2){
                return sayi; 
            }
                
            return Expo(sayi,üs-1)*sayi;
        }
    }

   public static class Extension{
        public static bool CheckSpaces(this string param){
            return param.Contains(" ");
        }

        public static string MakeUpperCase(this string param){
            return param.ToUpper();
        }

    }
}

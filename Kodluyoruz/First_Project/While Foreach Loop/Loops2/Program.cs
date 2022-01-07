using System;

namespace Loops2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;

            while(sayac <= sayi){

                toplam+=sayac;
                sayac++;

            }
            Console.WriteLine(toplam/sayi);

            char character = 'a';
            while (character <= 'z'){
                Console.Write(character);
                character++;
            }

            string[] arabalar = {"Audi","BMW","VOLVO"};

            foreach(var araba in arabalar){
                Console.WriteLine(araba);
            }
    }
}

       
}

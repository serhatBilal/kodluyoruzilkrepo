using System;

namespace ArrayMetot
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dizi = new string[3];
            dizi[0]="Mavi";
            dizi[1]="Kirmizi";
            dizi[2]="Beyaz";

            foreach (var x in dizi)
            {
                Console.WriteLine(x);
            }
            //Siralanmis dizi
            Array.Sort(dizi);
            foreach (var x in dizi)
            {
                Console.WriteLine(x);
            }
            // Eleman silme
            Array.Clear(dizi,0,1); // 0. indexten sonra 1 adet eleman sil.
             foreach (var x in dizi)
            {
                Console.WriteLine(x);
            }

            //Dizi sıralamasını terse cevir

            Array.Reverse(dizi);
             foreach (var x in dizi)
            {
                Console.WriteLine(x);
            }



        }
    }
}

using System;
using System.Collections;

namespace ArrayListler
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = {11,12,13};
            ArrayList liste = new ArrayList();
            liste.Add(1);
            liste.Add(4);
            liste.Add(5);
            liste.Add(2);
            liste.Add(77);

            
            liste.AddRange(dizi);
            liste.Sort();

            Console.WriteLine("Elemanın index numarasi: "+liste.BinarySearch(77));

            liste.Reverse();

            liste.Clear();

            foreach(var x in liste){
                 Console.WriteLine(x);
            }



            
            
            

        }
    }
}

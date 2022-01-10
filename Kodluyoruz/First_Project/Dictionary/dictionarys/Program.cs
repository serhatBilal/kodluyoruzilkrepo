using System;
using System.Collections.Generic;

namespace dictionarys
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> kullanici = new Dictionary<int, string>();

            kullanici.Add(1,"Serhat BİLAL");
            kullanici.Add(2,"Nurseven BERKER");
            kullanici.Add(3,"Ahmet Ahmet");

          

            Console.WriteLine(kullanici.Count);
            Console.WriteLine(kullanici.ContainsKey(1));
            Console.WriteLine(kullanici.ContainsValue("Nurseven BERKER"));

            kullanici.Remove(3);

              foreach(var x in kullanici.Values){
                Console.WriteLine(x);
            }


        }
    }
}

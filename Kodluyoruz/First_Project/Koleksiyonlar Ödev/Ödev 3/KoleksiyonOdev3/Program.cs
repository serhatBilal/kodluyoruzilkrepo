using System;
using System.Collections;

namespace KoleksiyonOdev3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde
            saklayan ve dizinin elemanlarını sıralayan programı yazınız.
             */
            string sesli="aeıioöuüAEIİOÖUÜ";
            ArrayList sesliler = new ArrayList();

            Console.Write("Cümleyi giriniz : ");
            string cumle = Console.ReadLine();
            for(int i=0;i<cumle.Length;i++){
                for(int j=0;j<sesli.Length;j++){
                    if(cumle[i]==sesli[j]){
                        sesliler.Add(cumle[i]);
                    }
                }
            }

            foreach(var x in sesliler){
                Console.Write(x + ",");
            }
        }
    }
}

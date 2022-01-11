using System;
using System.Collections;

namespace KoleksiyonOdev2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)
            */
            ArrayList buyuk = new ArrayList();
            ArrayList kucuk = new ArrayList();
            ArrayList dizi = new ArrayList();
            int kToplam=0;
            int bToplam=0;
            
            for(int i=1;i<=20;i++){
                Console.Write(i+". Sayiyi giriniz : ");
                int sayi= int.Parse(Console.ReadLine());
                dizi.Add(sayi);
            }

            dizi.Sort();

            for(int i=0;i<3;i++){
                kucuk.Add(dizi[i]);
            }

            dizi.Reverse();

            for(int i=0;i<3;i++){
                buyuk.Add(dizi[i]);
            }

            foreach(int x in kucuk){
                kToplam+=x;
            }

            foreach(int x in buyuk){
                bToplam+=x;
            }
            Console.WriteLine("Buyuk grup toplami: "+ bToplam);
            Console.WriteLine("Kucuk grup toplami: "+ kToplam);
            Console.WriteLine("Kucuk grup ortalamasi: "+ (kToplam/3));
            Console.WriteLine("Kucuk grup ortalamasi: "+ (bToplam/3));
            

        }
    }
}

using System;

namespace Metot2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sayi = "999";
            bool sonuc = int.TryParse(sayi, out int outSayi);

            if (sonuc)
            {
                Console.WriteLine("Basarili");
                Console.WriteLine(outSayi);

            }else{
                Console.WriteLine("Dönüşüm Basarisiz");
            }

            Metot metot = new Metot();
            metot.Topla(10,11,out int toplamSonucu);
            Console.WriteLine(toplamSonucu);
            metot.EkranaYazdir(1111);

        }
    }

    class Metot{
        public void Topla(int a,int b, out int toplam){
            toplam=a+b;
        }

        public void EkranaYazdir(string value){
            Console.WriteLine(value);
        }
        public void EkranaYazdir(int value){
            Console.WriteLine(value);
        }
        
    }
}

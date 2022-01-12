using System;

namespace StatikSinif
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calisan sayisi : {0} ",Calisan.CalisanSayisi);
            Calisan calisan = new Calisan("Serhat","BILAL","TEST");
            Console.WriteLine("Calisan sayisi : {0} ",Calisan.CalisanSayisi);
            Console.WriteLine(Islemler.Topla(150,300));
            Console.WriteLine(Islemler.Cikar(300,100));

            
        }
    }

    class Calisan{

        private static int calisanSayisi;

        private string isim;
        private string soyisim;
        private string departman;

        public static int CalisanSayisi { get => calisanSayisi;}

        static Calisan(){
            calisanSayisi=0;
        }

        public Calisan(string isim,string soyisim,string departman){
            this.isim = isim;
            this.soyisim = soyisim;
            this.departman= departman;
            calisanSayisi++;
        }
    }

    static class Islemler{
        public static long Topla(int sayi1,int sayi2){

            return sayi1+sayi2;
        }
        public static long Cikar(int sayi1,int sayi2){

            return sayi1-sayi2;
        }
    }
}

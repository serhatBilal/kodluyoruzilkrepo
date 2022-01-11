using System;

namespace ConstructorMetot
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteriler musteri = new Musteriler("Serhat","BILAL",01,30);
            musteri.ShowInfo();
            Musteriler musteri2 = new Musteriler("Nurseven","BERKER");
            musteri2.ShowInfo();
            
        }
    }

    class Musteriler{
        public string Ad;
        public string Soyad;
        public int Id;
        public int Yas;

        public void ShowInfo(){
            Console.WriteLine("Musteri Adi : {0} ",Ad);
            Console.WriteLine("Musteri Soyadi : {0} ",Soyad);
            Console.WriteLine("Musteri Idsi : {0} ",Id);
            Console.WriteLine("Musteri Yasi : {0} ",Yas);
        }

        public Musteriler(string ad,string soyad,int id,int yas){
            this.Ad=ad;
            this.Soyad=soyad;
            this.Id=id;
            this.Yas=yas;

        }

        public Musteriler(string ad,string soyad){
            this.Ad=ad;
            this.Soyad=soyad;

        }


    }
}

using System;

namespace Siniflar
{
    class Program
    {
        static void Main(string[] args)
        {

            Calisanlar calisan = new Calisanlar();

            calisan.Ad="Serhat";
            calisan.Soyad="BILAL";
            calisan.Yas=30;
            calisan.Id=01;
            calisan.Departman="TEST";
            calisan.showInfo();
            
        }
    }

    class Calisanlar{

        public string Ad;
        public string Soyad;
        public int Yas;
        public int Id;
        public string Departman;

        public void showInfo(){
            Console.WriteLine("Calisan Adi: {0}",Ad );
            Console.WriteLine("Calisan Soyadi: {0}",Soyad );
            Console.WriteLine("Calisan Yasi: {0}",Yas);
            Console.WriteLine("Calisan Idsi: {0}",Id );
            Console.WriteLine("Calisan Departmani: {0}",Departman );
        }

    }
}

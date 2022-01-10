using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> renkler = new List<string>();

            renkler.Add("Bordo");
            renkler.Add("Mavi");
            renkler.Add("Sari");
            renkler.Add("Kirmizi");
            renkler.Add("Beyaz");

            List<int> sayilar = new List<int>();

            sayilar.Add(1);
            sayilar.Add(2);
            sayilar.Add(3);
            sayilar.Add(4);
            sayilar.Add(5);

            sayilar.Remove(1);
            renkler.Remove("Kirmizi");

            sayilar.RemoveAt(3);
            renkler.RemoveAt(3);

            renkler.ForEach(renk=> Console.WriteLine(renk));
            sayilar.ForEach(sayi=> Console.WriteLine(sayi));
            if(sayilar.Contains(4))
            {
                Console.WriteLine("4 Bulundu");
            }else{
                Console.WriteLine("4 Bulunamadi");
            }
            //Eleman ile index'e erişim
            Console.WriteLine(sayilar.BinarySearch(4));

            //Diziyi Liste çevirmek

            string[] diziIsimler = {"Serhat","Nurseven","Batuhan","Çağatay"};
            List<string> listIsimler = new List<string>(diziIsimler);

            listIsimler.ForEach(x=> Console.WriteLine(x));
            listIsimler.Clear();
            listIsimler.ForEach(x=> Console.WriteLine(x));

            // List içinde nesne tutmak

            List<Kullanicilar> kullanici = new List<Kullanicilar>();
            Kullanicilar user = new Kullanicilar();
            user.Isim="Serhat";
            user.Soyisim="BILAL";
            user.Yas=30;

            kullanici.Add(user);

            foreach(var x in kullanici){
                Console.WriteLine("Kullanici Adi : " + x.Isim);
                Console.WriteLine("Kullanici Soyadi : " + x.Soyisim);
                Console.WriteLine("Kullanici Yasi : " + x.Yas);
            }

            List<Kullanicilar> newList = new List<Kullanicilar>();

            newList.Add(new Kullanicilar(){
                Isim="Nurseven",
                Soyisim="BERKER",
                Yas=29
            });

            foreach(var x in newList){
                Console.WriteLine("Kullanici Adi : " + x.Isim);
                Console.WriteLine("Kullanici Soyadi : " + x.Soyisim);
                Console.WriteLine("Kullanici Yasi : " + x.Yas);
            }
            


        }
    }

    public class Kullanicilar{

        private string isim;
        private string soyIsim;
        private int yas;

       

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim {get => soyIsim; set => soyIsim = value;}
        public int Yas {get=> yas; set => yas = value;}

        

    }
}

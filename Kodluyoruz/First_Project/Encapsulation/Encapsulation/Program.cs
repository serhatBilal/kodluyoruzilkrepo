using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            Ogrenci ogrenci1 = new Ogrenci("Serhat","BILAL",4,"B054");

            ogrenci1.ShowStudentInfo();
            ogrenci1.ClassDown();
            ogrenci1.ShowStudentInfo();
            ogrenci1.ClassDown();
            ogrenci1.ClassDown();
            ogrenci1.ClassDown();
            ogrenci1.ClassDown();
            ogrenci1.ShowStudentInfo();


        }
    }

    class Ogrenci{

        private string isim;
        private string soyisim;
        private int sinif;
        private string ogrenciNo;

        public Ogrenci()
        {
        }

        public Ogrenci(string isim, string soyisim, int sinif, string ogrNo)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Sinif = sinif;
            this.OgrenciNo = ogrenciNo;
        }

        

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Sinif { get => sinif;
         set {  
             if(sinif<1){
                Console.WriteLine("Sinif en dusuk 1 olabilir");
                sinif=1;
             }else{
                sinif = value;
             }
                 
         }  }
        public string OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }

        public void ShowStudentInfo(){
            Console.WriteLine("Ogrenci adi              : {0}",this.Isim);
            Console.WriteLine("Ogrenci soyadi           : {0}",this.Soyisim);
            Console.WriteLine("Ogrenci sinifi           : {0}",this.Sinif);
            Console.WriteLine("Ogrenci ogrenci numarasi : {0}",this.OgrenciNo);
        }

        public void ClassUp(){
            this.Sinif = this.Sinif+1;
        }

        public void ClassDown(){
            this.Sinif = this.Sinif-1;
        }
    }
}

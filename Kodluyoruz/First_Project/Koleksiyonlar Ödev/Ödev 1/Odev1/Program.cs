using System;
using System.Collections;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /* Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanarak yazınız.)
            Negatif ve numeric olan girişleri engelleyin.
            Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
            */

            ArrayList asal = new ArrayList();
            ArrayList asalOlmayan = new ArrayList();
            int asalElemanToplami=0;
            int asalOlmayanElemantoplami=0;

            for(int i=1;i<=20;i++){
                Console.Write(i+ ". Sayiyi giriniz: ");
                try{
                    int sayi= int.Parse(Console.ReadLine());
                    if(sayi!=0){
                        if(asalMi(sayi)){
                        asal.Add(sayi);
                    }else{
                        asalOlmayan.Add(sayi);
                    }
                    }else{
                        Console.WriteLine("Sadece pozitif tam sayi giriniz");
                        i--;
                    }   
                }catch(Exception){
                    Console.WriteLine("Sadece pozitif tam sayi giriniz");
                    i--;
                }
                
            }

            asal.Sort();
            asal.Reverse();
            asalOlmayan.Sort();
            asalOlmayan.Reverse();

            Console.WriteLine("Asal sayilar");
            foreach(int x in asal){
                Console.Write(x + " ");
                asalElemanToplami+=x;
            }

            Console.WriteLine("\n");
            Console.WriteLine("Asal olmayan sayilar");
            foreach(int x in asalOlmayan){
                Console.Write(x + " ");
                asalOlmayanElemantoplami+=x;
            }
 
            Console.WriteLine("\n");
            Console.WriteLine("Asal olan eleman sayisi: " + asal.Count);
            Console.WriteLine("Asal olmayan eleman sayisi: " + asalOlmayan.Count);
            Console.WriteLine("Asal olan sayilarin ortalamasi: " + asalElemanToplami/asal.Count);
            Console.WriteLine("Asal olmayan sayilarin ortalamasi: " + asalOlmayanElemantoplami/asalOlmayan.Count);
  
        }

        static  bool asalMi(int n){
            int counter=0;
            bool check;

            if(n==1 || n==0){
                counter++;
            }

            if(n==2){
                counter=0;
            }

            for(int i=2;i<n;i++){
                if(n % i == 0){
                    counter++;
                }
            }

            if(counter==0){
                check=true;
            }else{
                check=false;
            }
            return check;
        }
    }
}
    

    

   


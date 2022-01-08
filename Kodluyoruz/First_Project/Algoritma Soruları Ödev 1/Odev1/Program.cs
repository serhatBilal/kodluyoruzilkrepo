using System;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1- Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın. 
            
            int n;
            Console.Write("Pozitif bir sayi giriniz...");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n + " Adet sayi giriniz");
            int[] dizi = new int[n];

            for(int i = 0;i<n;i++){
                dizi[i]=Convert.ToInt32(Console.ReadLine());
            }

            foreach(var x in dizi){
                if(x%2==0){
                    Console.Write(x + " ");
                }
            }

            

            2- Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            

            int n,m;
            Console.WriteLine("Pozitif iki tam sayi giriniz");
            Console.Write("N sayisi : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("M sayisi : ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n + " adet pozitif sayi giriniz");
            int[] dizi = new int[n];

            for(int i =0;i<n;i++){
                dizi[i]=Convert.ToInt32(Console.ReadLine());
            }

            for(int i=0;i<dizi.Length;i++){
                if(m== dizi[i] || m%dizi[i]==0){
                    Console.WriteLine(dizi[i]);
                }
            }

            

            3- Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

            
            Console.WriteLine("Pozitif sayi girin");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n+" adet kelime giriniz");
            string[] dizi = new string[n];

            for(int i=0;i<n;i++){
                dizi[i]=Console.ReadLine();
            }

            Array.Reverse(dizi);

            foreach(var x in dizi){
                Console.WriteLine(x);
            }
            

            4-Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
            

            Console.WriteLine("Bir cumle yaziniz");
            string text = Console.ReadLine();
            int toplamHarf = 0;
            for(int i=0;i<text.Length;i++){
                if(text[i] != ' '){
                    toplamHarf++;
                }
                else{
                    continue;
                }
            }

            string[] dizi = text.Split(' ');
            Console.WriteLine("Toplam kelime sayisi :" + dizi.Length);
            Console.WriteLine("Toplam harf sayisi :" + toplamHarf);

            */

        }
    }
}

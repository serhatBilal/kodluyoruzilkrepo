using System;

namespace ifElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if(time < 18){
                Console.WriteLine("Tünaydın");
            }
            else if(time < 12){
                Console.WriteLine("Günadyin");
            }
            else{
                Console.WriteLine("Iyi Geceler");
            }

            String sonuc = time < 21 ? "Good Afternoon" : "Good Night";
            Console.WriteLine(sonuc);

            String sonuc2 = time >= 6 && time < 12 ? "Good Morning" : time < 18 ? "Good Afternoon" : "Good night "; 
            Console.WriteLine(sonuc2);
        }
    }
}

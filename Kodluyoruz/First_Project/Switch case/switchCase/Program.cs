using System;

namespace switchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            switch (month)
            {
                case 1:
                Console.WriteLine("Ocak ayindasiniz");
                break;
                case 2:
                Console.WriteLine("Subat ayindasiniz");
                break;
                case 3:
                Console.WriteLine("Mart ayindasiniz");
                break;
                case 4:
                Console.WriteLine("Nisan ayindasiniz");
                break;
                case 5:
                Console.WriteLine("Mayis ayindasiniz");
                break;
                case 6:
                Console.WriteLine("Haziran ayindasiniz");
                break;
                default:
                Console.WriteLine("Yalnis giris");
                break;
            }

            switch (month)
            {
                case 1:
                case 2:
                case 12:
                Console.WriteLine("Mevsim kis");
                break;
                case 3:
                case 4:
                case 5:
                Console.WriteLine("Mevsim ilkbahar");
                break;
                case 6:
                case 7:
                case 8:
                Console.WriteLine("Mevsim yaz");
                break;
                case 9:
                case 10:
                case 11:
                Console.WriteLine("Mevsim sonbahar");
                break;
                default:
                Console.WriteLine("Bir hata olustu");
                break;
            }
        }
    }
}

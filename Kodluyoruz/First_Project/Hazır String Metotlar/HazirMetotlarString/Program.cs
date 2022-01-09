using System;

namespace HazirMetotlarString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Merhaba Dünya Merhaba";
            string text2 = "Selam Dünya Selam";

            Console.WriteLine(text.Length);
            Console.WriteLine(text.ToLower());
            Console.WriteLine(text.ToUpper());
            Console.WriteLine(String.Concat(text,"Nasilsiniz"));
            Console.WriteLine(text2.Contains("Dünya"));
            Console.WriteLine(text2.EndsWith("Selam"));
            Console.WriteLine(text2.StartsWith("Dünya"));
            Console.WriteLine(text.Split(' ')[0]);
            
        }
    }
}

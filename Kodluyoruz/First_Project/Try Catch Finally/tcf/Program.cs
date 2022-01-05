using System;

namespace tcf
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
               int a = Convert.ToInt32("serhat");  
            }
            catch (Exception e)
            {
                Console.WriteLine("Bir sorun olustu" + " " + e);
                
            }
            finally{
                Console.WriteLine("Islem Tamamlandı");
            }
        }
    }
}

using System;

namespace HazirMetotlar2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.Second);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.Month);

            Console.WriteLine(DateTime.Now.AddSeconds(2));
            Console.WriteLine(DateTime.Now.AddMinutes(2));
            Console.WriteLine(DateTime.Now.AddHours(2));
            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddMonths(2));
            

            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Abs(-10));
            Console.WriteLine(Math.Sqrt(10));
            Console.WriteLine(Math.Pow(10,2));
            Console.WriteLine(Math.Log(10));
            


        }
    }
}

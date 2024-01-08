using System;

namespace zadanie_10
{
    class Program
    {
        static void Main(string[] args)
        {
            float gradus = (float)Convert.ToDouble(Console.ReadLine());
            float min = (float)Convert.ToDouble(Console.ReadLine());
            float sec = (float)Convert.ToDouble(Console.ReadLine());
            ugol ugol = new ugol(gradus,min,sec);
            float TotalRadians = ugol.ToRadians();
            Console.WriteLine( TotalRadians);
            Console.ReadKey();
        }
        
    }
}

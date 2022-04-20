using System;

namespace task11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" eded daxil edin:");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (n != 0)
            {
                sum = n % 10 + sum;
                n = n / 10;
            }
            Console.WriteLine("\ndaxil edilmis ededin reqemlerinin cemi:\n" + sum);
        }
    }
}

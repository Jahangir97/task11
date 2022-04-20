using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Soz sayini daxil et:");
            int wordsCount = Convert.ToInt32(Console.ReadLine());
            string[] words = new string [wordsCount];
            Console.WriteLine("Sozu daxil et:");
            int i;
            for (i = 0; i < wordsCount; i++)
            {
                words[i] = Console.ReadLine();
            }
            Console.WriteLine("\n");
            foreach (string str in words)
            {
                if (str.Length > 5)
                {
                    Console.WriteLine(str);
                }
            }
        }
    }
}

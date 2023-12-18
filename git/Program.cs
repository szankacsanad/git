using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int>();

            while (true)
            {
                Console.Write("Adj meg egy szamot (adj meg 0t hogy befejezodjon a program): ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num == 0)
                {
                    Environment.Exit(0);
                }

                numbers.Add(num);

                Console.Write("Eddigi szamok: ");
                for (int i = 0; i < numbers.Count; i++)
                {
                    Console.Write(numbers[i]);
                    if (i < numbers.Count - 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}

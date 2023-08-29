using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp113
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            for (count = 1; count <= 10; ++count)
            {
                if (count == 5)
                {
                    break;
                }
                Console.Write($"{count}");
            }
            Console.WriteLine($"\nBroke out of loop at count ={count}");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_3_ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int j = int.Parse(Console.ReadLine());

            if (j % 2 == 0)
            {
                Console.WriteLine("Число является чётным");
            }
            else
            {
                Console.WriteLine("Число является нечётным");
            }
            Console.ReadKey();
        }
    }
}

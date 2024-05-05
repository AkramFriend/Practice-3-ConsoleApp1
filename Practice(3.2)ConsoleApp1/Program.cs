using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_3._2_ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                if ((number % 2 == 1) && (number % number == 0))
                    Console.WriteLine("Это число простое");
                else
                    Console.WriteLine("Это число непростое");
                break;
            }
            Console.ReadKey();
        }
    }
}

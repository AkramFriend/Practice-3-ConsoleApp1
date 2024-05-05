using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_3._4_ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int idontnoNumber = r.Next(1, 101);
            int count = 0;

            for (; ; )
            {
                Console.WriteLine("Угадай число! \nВведите его");
                count++;
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber < idontnoNumber)
                {
                    Console.Write("Данное число меньше загаданного. Попробуйте ещё раз!");
                }
                else if (userNumber > idontnoNumber)
                {
                    Console.Write("Данное число больше загаданного. Попробуйте ещё раз!");
                }
                else
                {
                    Console.Write($"Вы отгадали число. Вы гадали {count} раз");
                    Console.ReadKey();
                    break;
                }  
            }
        }
    }
}


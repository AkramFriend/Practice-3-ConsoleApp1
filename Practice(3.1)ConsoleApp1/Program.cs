using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_3._1_ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Доброго времени суток, сударь! Не подскажите, сколь у Вас карт имеется? ");
            int userCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nТеперь номинал всякой карты");
            int value = int.Parse(Console.ReadLine());
            
            int sum = 0;

            for (int i = 0; i <= userCount; i++);
            {
                sum += value;
                Console.WriteLine($"{sum}");
            }
        }
    }
}

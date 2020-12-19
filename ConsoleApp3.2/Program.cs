using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double cost = 24; //стоимсть
                int year = 1826;
                Console.WriteLine("Введите настоящий год");
                int n_year = int.Parse(Console.ReadLine());
                while (year < n_year)
                {
                    cost += cost / 100 * 6;
                    year++;
                    Console.WriteLine($"За {year} год, состоянии их счёта:  {Math.Round(cost, 2)}$");
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            Console.ReadKey();
        }
    }
}
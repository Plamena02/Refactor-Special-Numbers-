using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Рефакторирайте_специалните_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                int sum = 0;
                var x = i;
                
                while (x > 0)
                {
                    sum += x % 10;
                    x = x / 10;
                }
                bool p = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{i} -> {p}");

            }

        }
    }
}

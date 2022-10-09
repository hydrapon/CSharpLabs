using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOne.Tasks
{
    internal class Task2
    {
        public void start()
        {
            Console.Write("x: ");
            int x = ConsoleReadLine<int>.read();

            Console.Write("y: ");
            int y = ConsoleReadLine<int>.read();

            Console.Write("z: ");
            int z = ConsoleReadLine<int>.read();

            double numerator = Math.Pow(x, 12) + Math.Sqrt(Math.Pow(z, 6) - 5 * x * y);
            double denominator = Math.Abs(-7 * Math.Pow(x, 2) * Math.Pow(y, 8) + z);
            Console.WriteLine("Результат: " + Math.Round(numerator / denominator + 7, 5));
        }
    }
}

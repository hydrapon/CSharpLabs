using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOne.Tasks
{
    internal class Task5
    {
        private double halfmeter(double a, double b, double c) => (a + b + c) / 2;

        public void start()
        {
            Console.Write("Сторона 'a': ");
            double a = Math.Round(ConsoleReadLine<double>.read(), 2);

            Console.Write("Сторона 'b': ");
            double b = Math.Round(ConsoleReadLine<double>.read(), 2);

            Console.Write("Сторона 'c': ");
            double c = Math.Round(ConsoleReadLine<double>.read(), 2);

            if (a + b < c || b + c < a || c + a < b)
            {
                Console.WriteLine("Треугольник не существует");
                return;
            }

            double p = halfmeter(a, b, c);

            Console.WriteLine($"S = {Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 2)}");
        }
    }
}

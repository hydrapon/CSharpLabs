using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOne.Tasks
{
    internal class Task4
    {
        private string fillingCells(double arg1, double arg2, double arg3, double arg4)
        {
            return String.Format("|{0,10}|{1,10}|{2,10}|", Math.Round(arg1, 2), Math.Round(arg2, 2), Math.Round(arg3, 2), Math.Round(arg4, 2));
        }
        public void start()
        {
            double[] numbers = new double[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Введите число {i + 1}: ");
                numbers[i] = ConsoleReadLine<double>.read();
            }

            string rowsName = String.Format("|{0,10}|{1,10}|{2,10}|", "N", "Abs", "Sqrt", "Pow 5");
            string separator = string.Join("", Enumerable.Repeat("_", rowsName.Length));

            Console.WriteLine(separator);
            Console.WriteLine(rowsName);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(separator);
                Console.WriteLine(this.fillingCells(numbers[i], Math.Abs(numbers[i]), Math.Sqrt(numbers[i]), Math.Pow(numbers[i], 5)));
            }
            Console.WriteLine(separator);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOne.Tasks
{
    internal class Task7
    {
        private void startCoordinates(double x, double y) => Console.WriteLine($"Точка является началом координат, которая лежит на оси {(x == 0 && y == 0 ? "x и y" : x == 0 ? 'x' : 'y')}");

        public void start()
        {
            Console.Write("Координаты по оси x: ");
            double x = ConsoleReadLine<double>.read();

            Console.Write("Координаты по оси y: ");
            double y = ConsoleReadLine<double>.read();

            if (x > 0 && y > 0)
                Console.WriteLine("I четверть");
            else if (x > 0 && y < 0)
                Console.WriteLine("IV четверть");
            else if (x < 0 && y > 0)
                Console.WriteLine("II четверть");
            else if (x < 0 && y < 0)
                Console.WriteLine("III четверть");
            else if (x == 0 || y == 0)
                this.startCoordinates(x: x, y: y);
        }
    }
}

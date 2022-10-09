using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LabOne.Tasks
{
    enum Wall
    {
        One = 1,
        Two = 2
    }

    class СalculationWallpaper
    {
        public double height;
        public double width;
        public double length;
        public double price;

        public double squareLengthWall(int count = 1) => this.length * this.height * count;

        public double squareWidthWall(int count = 1) => this.width * this.height * count;

        public double squareCeiling() => this.width * this.length;
    }

    class Task1
    {
        public void start()
        {

            СalculationWallpaper cw = new СalculationWallpaper();

            Console.Write("Введите высоту стен: ");
            cw.height = ConsoleReadLine<double>.read();

            Console.Write("Введите ширину стен: ");
            cw.width = ConsoleReadLine<double>.read();

            Console.Write("Введите длину стен: ");
            cw.length = ConsoleReadLine<double>.read();

            Console.Write("Введите цену обоев: ");
            cw.price = ConsoleReadLine<double>.read();

            double totalQuare = cw.squareLengthWall((int)Wall.Two) + cw.squareWidthWall((int)Wall.Two) + cw.squareCeiling();
            double totalPrice = totalQuare * cw.price;

            Console.WriteLine("Общая стоимость обоев: " + totalPrice);
        }
    }
}

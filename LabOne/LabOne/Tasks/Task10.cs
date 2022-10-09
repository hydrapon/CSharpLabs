using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOne.Tasks
{
    internal class Task10
    {
        public void start()
        {
            Console.Write("Количество баллов от 0 до 5: ");
            int score = ConsoleReadLine<int>.read();

            switch (score)
            {
                case 5:
                    Console.WriteLine("Отлично");
                    break;
                case 4:
                    Console.WriteLine("Хорошо");
                    break;
                case 3:
                    Console.WriteLine("Удовлетворительно");
                    break;
                case >= 0 and <= 2:
                    Console.WriteLine("Неудовлетворительно");
                    break;
                default: 
                    Console.WriteLine("Количество баллов должно быть в диапазоне от 0 до 5");
                    break;
            }
        }
    }
}

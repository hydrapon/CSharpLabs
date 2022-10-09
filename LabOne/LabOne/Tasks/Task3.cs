using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LabOne.Tasks
{
    internal class Task3
    {
        private readonly int _price = 2500;

        public void start()
        {
            Console.Write("Название театра: ");
            string theatre = ConsoleReadLine<string>.read();

            Console.Write("Название спектакля: ");
            string performance = ConsoleReadLine<string>.read();

            Console.Write("Время начала: ");
            string time = ConsoleReadLine<string>.read();

            Console.WriteLine($"Приглашаем в наш театр “{theatre}”. У нас вы можете насладиться спектаклем “{performance}” в {time}. Стоимость билета {_price} руб");
        }

    }
}

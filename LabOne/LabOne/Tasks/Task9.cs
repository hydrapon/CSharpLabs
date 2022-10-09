using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOne.Tasks
{
    internal class Task9
    {
        private string[] _monthsNames = {"Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"};
        public void start()
        {
            Console.Write("Введите день: ");
            int day = ConsoleReadLine<int>.read();

            Console.Write("Введите месяц: ");
            int month = ConsoleReadLine<int>.read();

            Console.Write("Введите год: ");
            int year = ConsoleReadLine<int>.read();

            try
            {
                new DateOnly(year: year, month: month, day: day);
            } catch
            {
                Console.WriteLine("Неверный формат даты");
                return;
            }

            int daysLeft = DateTime.DaysInMonth(year, month) - day;

            Console.WriteLine($"Месяц: {this._monthsNames[month - 1]}. Дней до конца месяца: {daysLeft}");
        }
    }
}

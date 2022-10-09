using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOne.Tasks
{
    internal class Task11
    {
        private string strYearTransform(int age)
        {
            if (age > 10)
            {
                age = age % 100;
                if (age > 10 && age < 19)
                {
                    return "лет";
                }
            }

            switch (age % 10)
            {
                case 1:
                    return "год";
                case >= 2 and <= 4:
                    return "года";
                default:
                    return "лет";
            }
        }

        private string ageCategory(int age)
        {
            switch (age)
            {
                case <= 11: return "ребенок";
                case >= 12 and <= 15: return "подросток";
                case >= 16 and <= 25: return "юноша";
                case >= 26 and <= 70: return "мужчина";
                case >= 77 and <= 99: return "старик";
                default: return "долгожитель";
            }
        }

        public void start()
        {
            Console.Write("Введите имя: ");
            string name = ConsoleReadLine<string>.read();

            Console.Write("Введите возраст: ");
            int age = ConsoleReadLine<int>.read();
            if(age < 0)
            {
                Console.WriteLine("Некорректный возраст");
            }

            Console.WriteLine($"{name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower()} - {this.ageCategory(age)}. Ему {age} {this.strYearTransform(age)}.");
        }
    }
}

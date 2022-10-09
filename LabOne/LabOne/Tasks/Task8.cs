using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOne.Tasks
{
    internal class Task8
    {
        public void start()
        {
            Console.Write("Введите трехзначное число: ");
            int number = ConsoleReadLine<int>.read();

            int[] nums = number.ToString().Select(t => int.Parse(t.ToString())).ToArray();
            if (nums.Length != 3)
            {
                Console.WriteLine("Число не трехзначное");
                return;
            }

            int x, y, z; 

            x = nums[0];
            y = nums[1];
            z = nums[2];

            if (z != y)
                Console.WriteLine($"{x}{z}{y}");

            if (y != 0)
            {
                if(x != y)
                    Console.WriteLine($"{y}{x}{z}");
                if(x != y)
                    Console.WriteLine($"{y}{z}{x}");
            }

            if(z != 0)
            {
                if (z != y)
                    Console.WriteLine($"{z}{y}{x}");
                if (x != y && y != z)
                    Console.WriteLine($"{z}{x}{y}");
            }
        }
    }
}

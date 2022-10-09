using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOne.Tasks
{
    internal class Task6
    {
        private bool isPalindome(int[] numsArr)
        {
            for (int i = 0; i < numsArr.Length; i++)
                if (numsArr[i] != numsArr[numsArr.Length - 1 - i]) return false;

            return true;
        }

        public void start()
        {
            Console.Write("Введите семизначное число: ");
            int number = ConsoleReadLine<int>.read();

            int[] nums = number.ToString().Select(t => int.Parse(t.ToString())).ToArray();

            if (nums.Length != 7)
            {
                Console.WriteLine("Число не семизначное");
                return;
            }

            bool result = isPalindome(nums);

            if (result)
            {
                Console.WriteLine("Число является палиндромом");
                return;
            }

            Console.WriteLine("Число не является палиндромом");
        }
    }
}

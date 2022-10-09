using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOne
{
    internal class ConsoleReadLine<T>
    {
        private static void errorWithRestartLab(string? errorMessage)
        {
            string msg;
            if (!string.IsNullOrEmpty(errorMessage))
            {
                msg = errorMessage;
            } else
            {
                msg = "Некорректный формат данных";
            }
            Console.WriteLine(msg);
            Console.WriteLine();
            Program.changeTask();
        }
        private static void checkLine(string? line, string? errorMessage)
        {
            if (string.IsNullOrEmpty(line))
            {
                ConsoleReadLine<T>.errorWithRestartLab(errorMessage);
            }
        }

        private static string readString(string? errorMessage)
        {
            string? line = Console.ReadLine();
            ConsoleReadLine<T>.checkLine(line, errorMessage);
            if(line == null)
            {
                throw new Exception("Некорректный тип данных");
            }
            return line;
        }

        private static double readDouble(string? errorMessage)
        {
            string? line = Console.ReadLine();
            ConsoleReadLine<T>.checkLine(line, errorMessage);
            try
            {
                return Convert.ToDouble(line);
            } catch
            {
                ConsoleReadLine<T>.errorWithRestartLab(errorMessage);
                throw new Exception("Некорректный тип данных");
            }
        }

        private static int readInt(string? errorMessage)
        {
            string? line = Console.ReadLine();
            ConsoleReadLine<T>.checkLine(line, errorMessage);
            try
            {
                return Convert.ToInt32(line);
            }
            catch
            {
                ConsoleReadLine<T>.errorWithRestartLab(errorMessage);
                throw new Exception("Некорректный тип данных");
            }
        }


        public static T read(string? errorMessage = null)
        {
            if (typeof(T) == typeof(System.String))
            {
                return (T)Convert.ChangeType(ConsoleReadLine<T>.readString(errorMessage), typeof(T));
            } 
            else if (typeof(T) == typeof(System.Double))
            {
                return (T)Convert.ChangeType(ConsoleReadLine<T>.readDouble(errorMessage), typeof(T));
            }
            else if (typeof(T) == typeof(System.Int32))
            {
                return (T)Convert.ChangeType(ConsoleReadLine<T>.readInt(errorMessage), typeof(T));
            }
            else
            {
                throw new Exception("Некорректный тип данных");
            }
        }
    }
}

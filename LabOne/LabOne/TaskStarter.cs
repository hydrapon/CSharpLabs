using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOne
{
    internal class TaskStarter
    {
        public static void start(int numTask)
        {
            Factory factory = new Factory();

            switch (numTask)
            {
                case 1:
                    factory.CreateTask1().start();
                    break;
                case 2:
                    factory.CreateTask2().start();
                    break;
                case 3:
                    factory.CreateTask3().start();
                    break;
                case 4:
                    factory.CreateTask4().start();
                    break;
                case 5:
                    factory.CreateTask5().start();
                    break;
                case 6:
                    factory.CreateTask6().start();
                    break;
                case 7:
                    factory.CreateTask7().start();
                    break;
                case 8:
                    factory.CreateTask8().start();
                    break;
                case 9:
                    factory.CreateTask9().start();
                    break;
                case 10:
                    factory.CreateTask10().start();
                    break;
                case 11:
                    factory.CreateTask11().start();
                    break;
                default:
                    Console.WriteLine("Неверный номер задачи");
                    break;
            }
        }
    }
}

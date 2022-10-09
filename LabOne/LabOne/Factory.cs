using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabOne.Tasks;

namespace LabOne
{
    abstract class AbstractFactory
    {
        public abstract Task1 CreateTask1();
        public abstract Task2 CreateTask2();
        public abstract Task3 CreateTask3();
        public abstract Task4 CreateTask4();
        public abstract Task5 CreateTask5();
        public abstract Task6 CreateTask6();
        public abstract Task7 CreateTask7();
        public abstract Task8 CreateTask8();
        public abstract Task9 CreateTask9();
        public abstract Task10 CreateTask10();
        public abstract Task11 CreateTask11();

    }
    internal class Factory: AbstractFactory
    {
        public override Task1 CreateTask1()
        {
            return new Task1();
        }

        public override Task2 CreateTask2()
        {
            return new Task2();
        }

        public override Task3 CreateTask3()
        {
            return new Task3();
        }

        public override Task4 CreateTask4()
        {
            return new Task4();
        }

        public override Task5 CreateTask5()
        {
            return new Task5();
        }

        public override Task6 CreateTask6()
        {
            return new Task6();
        }

        public override Task7 CreateTask7()
        {
            return new Task7();
        }

        public override Task8 CreateTask8()
        {
            return new Task8();
        }

        public override Task9 CreateTask9()
        {
            return new Task9();
        }

        public override Task10 CreateTask10()
        {
            return new Task10();
        }

        public override Task11 CreateTask11()
        {
            return new Task11();
        }
    }
}

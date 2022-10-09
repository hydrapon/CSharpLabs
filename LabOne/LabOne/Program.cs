using LabOne;
using System;

internal class Program
{

    public static void changeTask()
    {
        Console.Write("Введите номер задачи от 1 до 11 или 0 для выхода: ");
        int numTask = ConsoleReadLine<int>.read();

        Console.Clear();

        if (numTask == 0) Environment.Exit(0);

        TaskStarter.start(numTask);
        Console.WriteLine();
        Program.changeTask();
    }
    private static void Main(string[] args)
    {
        Program.changeTask();
    }
}
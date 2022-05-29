using System;
using ConsoleTestLinux;


public static class Program
{
    public static void Main(string[] args)
    {
        var user = new User("Vlad", "5555");
        Console.WriteLine(user.Name);
        new Thread(() =>
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Hello world!");
                Thread.Sleep(1000);
            }
        }).Start();
        Console.ReadLine();
    }
}


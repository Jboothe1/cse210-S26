using System;

class Program
{
     static void Main(string[] args)
    {
        // Console.WriteLine("Hello Sandbox World!");
        Console.WriteLine("Please input your first name");
        string firstname = Console.ReadLine();
        Console.WriteLine("Please input your last name");
        string lastname = Console.ReadLine();
        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}.");
    }
    }

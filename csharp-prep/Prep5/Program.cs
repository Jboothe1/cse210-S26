using System;

class Program
{
    static void Main(string[] args)
    {
        jlb_DisplayWelcome();

        string jlb_userName = jlb_PromptUserName();
        int jlb_userNumber = jlb_PromptUserNumber();

        int jlb_birthYear;
        jlb_PromptUserBirthYear(out jlb_birthYear);

        int jlb_squaredNumber = jlb_SquareNumber(jlb_userNumber);

        jlb_DisplayResult(jlb_userName, jlb_squaredNumber, jlb_birthYear);
    }

    static void jlb_DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string jlb_PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string jlb_userName = Console.ReadLine();

        return jlb_userName;
    }

    static int jlb_PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int jlb_userNumber = int.Parse(Console.ReadLine());

        return jlb_userNumber;
    }

    static void jlb_PromptUserBirthYear(out int jlb_birthYear)
    {
        Console.Write("Please enter the year you were born: ");
        jlb_birthYear = int.Parse(Console.ReadLine());
    }

    static int jlb_SquareNumber(int jlb_number)
    {
        int jlb_squaredNumber = jlb_number * jlb_number;

        return jlb_squaredNumber;
    }

    static void jlb_DisplayResult(string jlb_userName, int jlb_squaredNumber, int jlb_birthYear)
    {
        int jlb_currentYear = DateTime.Now.Year;
        int jlb_ageThisYear = jlb_currentYear - jlb_birthYear;

        Console.WriteLine($"{jlb_userName}, the square of your number is {jlb_squaredNumber}");
        Console.WriteLine($"{jlb_userName}, you will turn {jlb_ageThisYear} this year.");
    }
}
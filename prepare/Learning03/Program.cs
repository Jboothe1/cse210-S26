using System;

class Program
{
    static void Main(string[] args)
    {
         Fraction jlbFraction1 = new Fraction();
        Console.WriteLine(jlbFraction1.jlbGetFractionString());
        Console.WriteLine(jlbFraction1.jlbGetDecimalValue());

        Fraction jlbFraction2 = new Fraction(5);
        Console.WriteLine(jlbFraction2.jlbGetFractionString());
        Console.WriteLine(jlbFraction2.jlbGetDecimalValue());

        Fraction jlbFraction3 = new Fraction(3, 4);
        Console.WriteLine(jlbFraction3.jlbGetFractionString());
        Console.WriteLine(jlbFraction3.jlbGetDecimalValue());

        Fraction jlbFraction4 = new Fraction(1, 3);
        Console.WriteLine(jlbFraction4.jlbGetFractionString());
        Console.WriteLine(jlbFraction4.jlbGetDecimalValue());

        Console.WriteLine();

        Random jlbRandom = new Random();
        Fraction jlbRandomFraction = new Fraction();

        for (int jlbIndex = 1; jlbIndex <= 20; jlbIndex++)
        {
            int jlbTop = jlbRandom.Next(1, 11);
            int jlbBottom = jlbRandom.Next(1, 11);

            jlbRandomFraction.jlbSetTop(jlbTop);
            jlbRandomFraction.jlbSetBottom(jlbBottom);

            Console.WriteLine($"Fraction {jlbIndex}: string: {jlbRandomFraction.jlbGetFractionString()} Number: {jlbRandomFraction.jlbGetDecimalValue()}");
        }
    }
}
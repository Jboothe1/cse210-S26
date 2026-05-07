using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> jlb_numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int jlb_userNumber = -1;

        while (jlb_userNumber != 0)
        {
            Console.Write("Enter number: ");
            jlb_userNumber = int.Parse(Console.ReadLine());

            if (jlb_userNumber != 0)
            {
                jlb_numbers.Add(jlb_userNumber);
            }
        }

        int jlb_sum = jlb_getSum(jlb_numbers);
        double jlb_average = jlb_getAverage(jlb_numbers);
        int jlb_largestNumber = jlb_getLargestNumber(jlb_numbers);
        int jlb_smallestPositiveNumber = jlb_getSmallestPositiveNumber(jlb_numbers);

        Console.WriteLine($"The sum is: {jlb_sum}");
        Console.WriteLine($"The average is: {jlb_average}");
        Console.WriteLine($"The largest number is: {jlb_largestNumber}");

        if (jlb_smallestPositiveNumber != 0)
        {
            Console.WriteLine($"The smallest positive number is: {jlb_smallestPositiveNumber}");
        }

        jlb_numbers.Sort();

        Console.WriteLine("The sorted list is:");
        foreach (int jlb_number in jlb_numbers)
        {
            Console.WriteLine(jlb_number);
        }
    }

    static int jlb_getSum(List<int> jlb_numbers)
    {
        int jlb_sum = 0;

        foreach (int jlb_number in jlb_numbers)
        {
            jlb_sum += jlb_number;
        }

        return jlb_sum;
    }

    static double jlb_getAverage(List<int> jlb_numbers)
    {
        int jlb_sum = jlb_getSum(jlb_numbers);
        double jlb_average = (double)jlb_sum / jlb_numbers.Count;

        return jlb_average;
    }

    static int jlb_getLargestNumber(List<int> jlb_numbers)
    {
        int jlb_largestNumber = jlb_numbers[0];

        foreach (int jlb_number in jlb_numbers)
        {
            if (jlb_number > jlb_largestNumber)
            {
                jlb_largestNumber = jlb_number;
            }
        }

        return jlb_largestNumber;
    }

    static int jlb_getSmallestPositiveNumber(List<int> jlb_numbers)
    {
        int jlb_smallestPositiveNumber = 0;

        foreach (int jlb_number in jlb_numbers)
        {
            if (jlb_number > 0)
            {
                if (jlb_smallestPositiveNumber == 0 || jlb_number < jlb_smallestPositiveNumber)
                {
                    jlb_smallestPositiveNumber = jlb_number;
                }
            }
        }

        return jlb_smallestPositiveNumber;
    }
}
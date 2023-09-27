
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numberList = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numberList.Add(number);
            }
        }

        int sum = 0;
        foreach (int num in numberList)
        {
            sum += num;
        }

        Console.WriteLine("The sum is: " + sum);

        int count = numberList.Count;
        double average = (double)sum / count;
        Console.WriteLine("The average is: " + average);

        numberList.Sort();
        int largest = numberList[count - 1];
        Console.WriteLine("The largest number is: " + largest);

        bool foundSmallestPositive = false;
        for (int i = 0; i < count; i++)
        {
            if (numberList[i] > 0)
            {
                Console.WriteLine("The smallest positive number is: " + numberList[i]);
                foundSmallestPositive = true;
                break;
            }
        }

        if (!foundSmallestPositive)
        {
            Console.WriteLine("There are no positive numbers in the list.");
        }

        foreach (int num in numberList)
        {
            Console.WriteLine(num);
        }
    }
}

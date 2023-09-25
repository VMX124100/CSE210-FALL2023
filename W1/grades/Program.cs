using System;

class Program
{
    static void Main()
    {
        Console.Write("\nPlease enter the grade percentage: ");
        int per = int.Parse(Console.ReadLine());

        string grade = "";
        string add = "";

        if (per >= 90)
        {
            grade = "A";
        }
        else if (per >= 80)
        {
            grade = "B";
        }
        else if (per >= 70)
        {
            grade = "C";
        }
        else if (per >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        int PoM = per % 10;

        if (per >= 60 && per < 97)
        {
            if (PoM >= 7)
            {
                add = "+";
            }
            else if (PoM <= 3)
            {
                add = "-";
            }
        }

        Console.WriteLine("");
        Console.WriteLine("Your letter grade is: " + grade + add);

        if (per >= 70)
        {
            Console.WriteLine("\nCongratulations, you are approved\n");
        }
        else
        {
            Console.WriteLine("\nPut more effort next time\n");
        }
    }
}

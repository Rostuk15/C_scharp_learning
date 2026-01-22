using System;

namespace ZYklWhile;

class Program
{
    static void WhileMain(string[] args)
    {
    WorkZykl();
    HomeWorkZykl();
    HomeWorkZYkl2();
    }

    static void WorkZykl()
    {
        int count = 0;
        int limit = int.Parse(Console.ReadLine());

        while (count < limit)
        {
            count++;
            System.Console.WriteLine(count);
        }  
    }

    static void HomeWorkZykl()
    {
        int count = 0;
        int oddNumberSCount = 0;
        int evenNumberCount = 0;

        Console.Write("Write your num: ");
        int Parne = int.Parse(Console.ReadLine());

        while (count < Parne)
        {
            count++;
            Console.WriteLine(count);

            if (count % 2 == 0) // парне
            {
                evenNumberCount++;
            }
            else // непарне
            {
                oddNumberSCount++;
            }
        
    }

    Console.WriteLine("Du hast " + evenNumberCount + " parne und " + oddNumberSCount + " neparne nummern.");
    }

    static void HomeWorkZYkl2()
    {
        uint oddNumberCount = 0;
        uint evenNumberCount = 0;

        int oddNumberSum = 0;
        int evenNumberSum = 0;

        Console.WriteLine("Your first Nummber:");
        int currentValue = int.Parse(Console.ReadLine());

        Console.WriteLine("Your last NUmmber:");
        int limit = int.Parse(Console.ReadLine());

        while(currentValue <= limit)
        {   
            if (currentValue % 2 == 0)
            {
                evenNumberSum = evenNumberSum + currentValue;
                evenNumberCount++;
            }    
            else
            {
                oddNumberSum += currentValue;
                oddNumberCount++;
            }
            currentValue++;
        }


        Console.WriteLine("Odd Number: " + oddNumberCount);
        System.Console.WriteLine("Even Number: " + evenNumberCount);
        Console.WriteLine("Odd Number Sum: " + oddNumberSum);
        System.Console.WriteLine("Even Number Sum: " + evenNumberSum);
        Console.ReadLine();
    }

}
using System;

namespace C_learning;

class Program
{
    static void Main(string[] args)
    {
        SumFromInput();
        HomeworkExample();
        Homeworkresult1();
        HomeworkExample2();
        LogischOperator1();
        switchOperator1();
        fastCalc();
    }

    static void SumFromInput()
    {
        Console.WriteLine("Sreib nummer 1: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Sreib nummer 2: ");
        int b = Convert.ToInt32(Console.ReadLine());

        int result = a + b;
        Console.WriteLine(result);
    }

    static void HomeworkExample()
    {
        int a = 5;
        int b = 6;
        double c = 7.5;

        double result = a + b * c;
        Console.WriteLine(result);
    }

    static void Homeworkresult1()
    {
        double FirstValue, SecondValue;
    
        Console.WriteLine("Screiben deine 1 nummer:");
        FirstValue = double.Parse(Console.ReadLine());

        Console.WriteLine("Screiben deine 2 nummer");
        SecondValue = double.Parse(Console.ReadLine());

        double result = (FirstValue + SecondValue) / 2;
        Console.WriteLine("Deine arifmetsnummer ist " + result);
    }
    static void HomeworkExample2()
    {
        int a;

        a = int.Parse(Console.ReadLine());

        if(a % 2 == 0)
        {
            Console.WriteLine("a ist parne");
        }
        else    
        {
            Console.WriteLine("a ist nicht parne");
        }
    }

    static void LogischOperator1()
/*      
*       && sokraschonoe und (якщо один з операторів фалз то він дальше не йде)
*       || sokraschonoe oder так само   
*        & und 
*        | oder
*        ! nicht
*/

    {
        bool isInfected = false;

        if(!isInfected)
        {
            Console.WriteLine("Pesonen ist Gesund");
        }
        else
        {
            Console.WriteLine("Pesonen ist ungesund");
        }

        int fanSpeen = 300;

        bool isHighTemp = true;
        bool hasNoCooling = fanSpeen<=0;

        if (isHighTemp || hasNoCooling)
        {
            Console.WriteLine("Gefahr den Prozessor beschädigen");
        }
    }

    static void switchOperator1()
    {
        int a = int.Parse(Console.ReadLine());

        switch (a)
        {
            case 1:
                Console.WriteLine("Du screibst nummer 1");
                break;
            case 2: 
            Console.WriteLine("Du screibst nummer 2");
                break;
            default:    
                Console.WriteLine("Falsche nummer");
                break;
        }

        string b = Console.ReadLine();

        switch (b)
        {
            case "+":
            case "-":
                Console.WriteLine("Du schreibst plus ode ninus");
                break;
            default:    
                Console.WriteLine("Du schreibst falsche symbol");
                break;
        }
    }

    static void fastCalc()
    {
        ConsoleKey consoleKey = Console.ReadKey().Key;
        
    }
}








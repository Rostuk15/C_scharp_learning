using System;

namespace HomeWorkCalculator;


class MyCalculator
{   
    static void CalcMain(string[] args)
    {
    SwitchMainProzess(); 
    IF_else_MainProzess();
    }

    static void SwitchMainProzess()
    {
        Console.WriteLine("Write your num: ");
        double aS = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("WRrite your operator: ");
        string opS = Console.ReadLine();

        Console.WriteLine("Write your 2 num: ");
        double bS = Convert.ToDouble(Console.ReadLine());

        double resultS = 0;

        switch (opS)
        {
            case "+":
                resultS = aS + bS;
                break;
            case "-":
                resultS = aS - bS;
                break;
            case "*":
                resultS = aS * bS;
                break;
            case "/":
                resultS = aS / bS;
                break;
        }

        Console.WriteLine("Result is: " + resultS);
    }




   static void IF_else_MainProzess()
    {
        while (true)
        {
            Console.Clear();

            double a = 0;
            double b = 0;

            try
            {
                Console.WriteLine("Screib deine 1 nummer: ");
                a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Screib deine 2 nummer: ");
                b = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Write("We need a number!");
                Console.ReadLine();
                continue;
            }

            Console.WriteLine("Schreib deine operator: ");
            string op = Console.ReadLine();

            double result = 0;

            if (op == "+")
            {
                result = a + b;
            }
            else if (op == "-")
            {
                result = a - b;
            }
            else if (op == "*")
            {
                result = a * b;
            }
            else if (op == "/")
            {
                result = a / b;
            }

            Console.WriteLine("Dein Ergebnis ist: " + result);
            Console.ReadLine();
        }
    }


    /* написати програму де буде визначення які кнопки і потім для оперторів викоритсати якшо в тому є такий оператор то робить */
}
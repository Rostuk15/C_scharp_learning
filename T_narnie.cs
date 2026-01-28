using System;

namespace C_learning.C_Scharp_learning_udemy;

public class T_narnie
{
    static void Main(String[] args)
    {
        T_nar();
    }

    /* тернарний оператор - [первий операнд - условие] ? [2 операнд - if_true] : [3 операнд if_false] */
    
    static void T_nar()
    {
        bool accessAllowed;
        
        string storedPassword = "qwerty";
        string enteredPassword = Console.ReadLine();
        
        if (enteredPassword == storedPassword)
            {
                accessAllowed = true;
            }
        else
            {
                accessAllowed = false;
            }

        Console.WriteLine(accessAllowed);

        Console.ReadLine();
        
        accessAllowed = enteredPassword == storedPassword ? true : false;
        Console.WriteLine(accessAllowed);
        Console.ReadLine();
        
        int inputData = int.Parse(Console.ReadLine());
        int outputData = (inputData < 0) ? 0 : inputData;
        
        Console.ReadLine();

        Console.WriteLine("Write your number: ");
        int inputNumber = int.Parse(Console.ReadLine());
        
        string outputNumber = inputNumber % 2 == 0 ? "even" : "odd";
        Console.WriteLine(outputNumber);
        
    }
    
}


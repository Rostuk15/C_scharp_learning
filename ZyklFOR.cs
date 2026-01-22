using System;

namespace ZyklFor;

class Program 
{
    static void ZyklForMain(string[] args)
    {
    WorkFor();
    }

    static void WorkFor()
    {
        /*
        * цикл фор особености
        * кілька перемінних
        * цифл фор в обратном порядку
        * кілька условій 
        */
        
    /*
    *    for (;;)
    *    {
    *       Console.Writeline("for is working");
    *       System.Threading.Thread.Sleep(300);
    *    }
    */

    int i = 0;

    for (; i < 3; i++)
    {
        System.Console.WriteLine("for_1 " + i);
    }
    for (; i < 5; i++)
    {
        System.Console.WriteLine("for_2 " + i);
    }
    for ( int k = 5; k >= 0; k--)
    {
        System.Console.WriteLine(k);
    }

    /* break */

    for (int j = 0; j < 100; j++)
    {
        System.Console.WriteLine(j);

        if (j == 10)
        {
            break;
        }
    }

    for (int l = 0;l < 100; l++)
    {
        string msg = Console.ReadLine();

        if (msg == "exit")
        {
            break;
        }
    }

    /* Continue */
    int o = 0, m;
    
    for (int i1 = 0; o < 5;o++)
    {
        if (o == 2)
        {
            continue;
        }
        System.Console.WriteLine(o);
    }
    

    }  
}
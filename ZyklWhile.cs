using System;

namespace ZYklWhile;

class Program
{
    static void Main(string[] args)
    {
    WorkZykl();
    HomeWorkZykl();
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
        int countParne = 0;
        int countNeParne = 0;

        Console.Write("Write your num: ");
        int Parne = int.Parse(Console.ReadLine());

        while (count < Parne)
        {
            count++;
            Console.WriteLine(count);

            if (count % 2 == 0) // парне
            {
                countParne++;
            }
            else // непарне
            {
                countNeParne++;
            }
        
    }

    Console.WriteLine("Du hast " + countParne + " parne und " + countNeParne + " neparne nummern.");
}

}
using System;

namespace ZYklWhile;

class Program
{
    static void Main(string[] args)
    {
        int count = 0;
        int limit = int.Parse(Console.ReadLine());

        while (count < limit)
        {
            count++;
            System.Console.WriteLine(count);
        }  
    }
}
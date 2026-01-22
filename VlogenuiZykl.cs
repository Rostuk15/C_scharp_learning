using System;
using System.Collections.Concurrent;

namespace VlogeniyZykl;

class Program
{
    public Program()
    {
    }

    static void Main(string[] args)
    {
        VlogeniyZyklWork();
        HomeWork();
        gptWork();
    }

    static void VlogeniyZyklWork()
    {
        System.Console.WriteLine("Write hight Quadrat: ");
        int height = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Write width Quadrat: ");
        int width = int.Parse(Console.ReadLine());


        for (int j = 0; j < height; j++)
        {
            for (int i = 0; i < width; i++)
            {
                Console.WriteLine("#");
            }
            System.Console.WriteLine();
        }
        Console.ReadLine();
    }

    static void HomeWork()
    {
        Console.Write("Введи висоту трикутника: ");
        int height = int.Parse(Console.ReadLine());

        // 1) Трикутник зліва вниз ▲
        for (int i = 1; i <= height; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        // 2) Трикутник справа вниз ▲
        for (int i = 1; i <= height; i++)
        {
            for (int space = 1; space <= height - i; space++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= i; j++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        // 3) Трикутник зліва вверх ▼
        for (int i = height; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
    }

    static void gptWork()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();

        for (int o = 2; o <= 10; o++)
        {
            if (o % 2 == 0)
            {
                Console.Write(o + " ");
            }
        }

        Console.WriteLine();

        for (int smuga = 0; smuga <= 5; smuga++)
        {
            Console.Write("#");
        }

        for (int smuga = 0; smuga <= 5; smuga++)
        {
            Console.WriteLine("#");
        }

        for (int povtor = 0; povtor <= 3; povtor++)
        {
            for (int vertical = 0; vertical <= 3; vertical++)
            {
                Console.Write("#");
            }

            Console.WriteLine();
        }
        
        for (int first = 0; first <= 5; first++)
        {
            Console.Write("#");
        }
        Console.WriteLine();
        for (int inn = 0; inn <= 3; inn++)
        {
            Console.WriteLine("#    #");
        }
        for (int last = 0; last <= 5; last++)
        {
            Console.Write("#");
        }    
        
        
        
        Console.WriteLine();
        
        System.Console.WriteLine("Write hight ram: ");
        int height = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Write width ram: ");
        int width = int.Parse(Console.ReadLine());
        

        for (int first = 0; first <= 5; first++)
        {
            Console.Write("#");
        }

        for (int len = 0; len < height; len++)
        {
            for (int s = 0; s < width - 2; s++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("#");
        }
        
        for (int first = 0; first <= 5; first++)
        {
            Console.Write("#");
        }
    }

} 

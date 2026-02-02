using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Globalization;


namespace C_learning;

public class Massiv
{
    static void Main(String[] args)
    {
        massiv_Urok();
        massiv_Selbst();
        Massiv_HW();
        TypischLösungen();
        statunddiap();
    }
    
    /* массивм , одномірні массиви, тип елемента і імя [] */
    
    static void massiv_Urok()
    {
        int[] myArray;

        myArray = new int[4];
        myArray[1] = 5;

        Console.WriteLine(myArray[1]);

        int a = myArray[1];
        Console.WriteLine(a);
        
        /* inizialisazia massiv */
        
        int[] myArray3 = new int[5] { 1, 2, 3, 4, 5 };      /* muss 5 element sofort sein */ 
        int[] myArray4 = new int[] { 1, 2, 3, 4, 5 };      /* oder hier [] oder {}-nummer*/ 
        int[] myArray5 = new [] { 1, 2, 3, 4, 5 };
        int[] myArray6 = new int[5];                        /* nur mit int... */
        int[] myArray7 = {1, 2, 3, 4, 5 };
        int[] myArray8 = Enumerable.Repeat(5, 5).ToArray();     /* massiv 10 element erhalt 5 */
        int[] myArray9 = Enumerable.Range(4,5).ToArray(); /* massiv startet von 5 geht bis 8 */
        
        
        /* massiv and zykl */

        int[] myArray10 = { 10, 3, 2, 55 };
        
        for (int i = 0; i < myArray9.Length; i++)
        {
            Console.WriteLine(myArray9[i]);
        }

    }
    
    static void massiv_Selbst()
    {
        string[] myArray2;
        myArray2 = new string[4];
        myArray2[0] = "a";
        myArray2[1] = "25";
        Console.WriteLine(myArray2[0]);
        
        string b = myArray2[1];
        Console.WriteLine(b);
    }


    static void Massiv_HW()
    {
        
        Console.WriteLine("write your Index: ");
        int index = int.Parse(Console.ReadLine());
        
        int[] myArrayHw = new int[index];
        
        for (int i = 0; i < myArrayHw.Length; i++)
        {
            Console.Write($"Введи значення для індексу {i}: ");
            myArrayHw[i] = int.Parse(Console.ReadLine());
        }
        
        for (int k = myArrayHw.Length - 1; k >= 0; k--)
            {
            Console.WriteLine(myArrayHw[k]);
            }

        int result = 0;
            
        for (int k = 0; k < myArrayHw.Length; k++)
        {
            if (myArrayHw[k] % 2 == 0)
                {
                    result += myArrayHw[k];    
                    Console.WriteLine(myArrayHw[k]);
                }
        }        
        Console.WriteLine(result);
        
        /* min num */

        int[] myarrayHw1 = { 2, 3, 99, 49, 64, 77, 4, 42, 5 };
        
        int minValue = myarrayHw1[0];
        
        for (int i = 1; i < myarrayHw1.Length; i++)
            {
                if (myarrayHw1[i] < minValue)
                    {
                    minValue = myarrayHw1[i];
                    }
            }

        Console.WriteLine(minValue);
    }

    static void TypischLösungen()
    {
        int[] myarray1 = { 2, 3, 99, 49, 64, 77, 4, 42, 5, 77, 2, 99, 4 };

        int result = myarray1.Max();
        Console.WriteLine(result);
        Console.WriteLine(myarray1.Where(i => i % 2 == 0).Sum());
        Console.WriteLine(myarray1.Where(i => i % 2 != 0).Min());
        
        int[] result2 = myarray1.Distinct().ToArray();  // унікальні елементи масиву
        int[] result3 = myarray1.OrderBy(i => i).ToArray(); // відсортовані елементи старого масиву 
        
        Array.Sort(myarray1);
        int result4 = Array.Find(myarray1, i => i < 70); // first numm FindLast - last
        
        int[] result5 = Array.FindAll(myarray1, i => i > 70);
        
        int result6 = Array.FindIndex(myarray1, i => i == 77);
        
        Array.Reverse(myarray1);
        
        // int result7 = Array.Where(i => i <= 0).FirstOrDefault();
       //  Console.WriteLine(result7);
    }
    
    static void statunddiap()
    {
        int[] myarray2 = { 2, 3, 99, 49, 64, 77, 4, 42, 5, 77, 2, 99, 4 };

        Console.WriteLine(myarray2.Length - 1);
        Console.WriteLine(myarray2[^1]);
        Index myIndex = new Index(3, true); // from end ^3
        Console.WriteLine(myarray2[myIndex]);
        
        int[] myarray3 = myarray2[1..4];
        
        string str = "Hello World";
        Console.WriteLine(str[0]);
        
        foreach (int item in myarray2[..4])
            {
            Console.WriteLine(item);
            }
    }
    
}
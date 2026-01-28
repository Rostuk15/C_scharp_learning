namespace C_learning;

public class Massiv
{
    static void Main(String[] args)
    {
        massiv_Urok();
        massiv_Selbst();
    }
    
    /* массивм , одномірні массиви, тип елемента і імя [] */
    
    staic void massiv_Urok()
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
    
}
using System;
class Program
{
    static void Main()
    {
        //implicit converter as it dont lose any data 
        //as float is bigger data type 
        int i = 1010;
        float f = i;
        Console.WriteLine(f);
    }
}

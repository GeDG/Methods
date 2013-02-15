using System;

class GetMax
{
    static int getMax(int a, int b) 
    {
        int max = a > b ? a : b;
        return max;
    }
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine(getMax(getMax(a,b),c));
    }
}


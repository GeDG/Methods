using System;

class returnMaxOfPortionArray
{
    static int maxElement(int index,int[] arr) 
    {
        int max = 0;
        for (int i = index; i < arr.Length; i++)
        {
            if (arr[i] > max)
                max = arr[i];
        }
        return max;
    }
    static void Main()
    {
        int[] arr = new int[] { 1, 2, 3, 4, 5, 2, 5, 6, 6, 7, 7, 8, 8, 9, 9, 0, 3, 8, 7, 6, 65, 5, 4, 34, 3, 3, 52, 4, 4, 56, 7 };
        int index = int.Parse(Console.ReadLine());
        Console.WriteLine( maxElement(index, arr));
    }
}


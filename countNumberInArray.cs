using System;

class countNumberInArray
{
    static int getCount(int[] arr,int num) 
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == num)
            {
                count++;
            }
        }
        return count;
    }
    static void Main()
    {
        int[] arr = new int[] { 2, 3, 4, 5, 6, 5, 3, 42, 1, 3, 5, 32, 5, 54, 5, 1, 123, 2, 2, 5, 5, 1, 254, 5, 5, 5, 12, 3, 34, 5, 54, 6, 5, 765, 86856, 5, 54, 75, 4, 2 };
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(getCount(arr,num));
    }
}


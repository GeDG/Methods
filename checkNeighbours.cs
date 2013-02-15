using System;

class checkNeighbours
{
    static bool isNumber(int num)
    {
        if (num > 0 && num <= 0) 
        {
            return true;
        }
        return false;
    }
    static int getMax(int a, int b)
    {
        int max = a > b ? a : b;
        return max;
    }
    static bool checkNeigh(int position,int[] arr)
    {
        if (position - 1 < 0 && isNumber(arr[position + 1]))
        {
            if (getMax(arr[position + 1], arr[position]) == arr[position])
                return true;
            return false;
        }
        else if (isNumber(arr[position - 1]) && position + 1 > arr.Length)
        {
            if (getMax(arr[position - 1], arr[position]) == arr[position])
                return true;
            return false;
        }
        else if (isNumber(arr[position - 1]) && isNumber(arr[position + 1]))
        {
            if (getMax(getMax(arr[position] - 1, arr[position]), arr[position + 1]) == arr[position])
                return true;
            return false;
        }
        else return false;
    }
    static void Main()
    {
        int[] arr = new int[] { 1, 2, 3, 4, 5, 2, 5, 6, 6, 7, 7, 8, 8, 9, 9, 0, 3, 8, 7, 6, 65, 5, 4, 34, 3, 3, 52, 4, 4, 56, 7 };
        int position = int.Parse(Console.ReadLine());

        Console.WriteLine(checkNeigh(position, arr));
    }
}


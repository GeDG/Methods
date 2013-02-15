using System;

class setOfIntegerNumbers
{
    static int min(int[] set) 
    {
        int min = set[set.Length - 1];
        for (int i = 0; i < set.Length - 1; i++)
        {
            if (set[i] < min)
                min = set[i];
        }
        return min;
    }

    static int max(int[] set)
    {
        int max = 0;
        for (int i = 0; i < set.Length; i++)
        {
            if (max > set[i])
                max = set[i];
        }
        return max;
    }

    static int average(int[] set) 
    {
        return sum(set) / set.Length;
    }

    static int sum(int[] set) 
    {
        int sum = 0;
        for (int i = 0; i < set.Length; i++)
        {
            sum += set[i];
        }
        return sum;
    }
    static int pro(int[] set)
    {
        int pro = 1;
        for (int i = 0; i < set.Length; i++)
        {
            pro *= set[i];
        }
        return pro;
    }

    static void Main()
    {

    }
}


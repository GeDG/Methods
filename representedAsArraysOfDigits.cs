using System;

class representedAsArraysOfDigits
{
    static string ReverseDigits(int number) 
    {
        string array = (number.ToString());
        array = array.split("");
        Array.Reverse(array);
        return array;
    }
    //-8---adds two positive integer numbers represented as arrays of digits -----//
    static string NewStringFromTwoOther(int[] smaller,int[] bigger) 
    {
        int help = 0; int i = 0; string nString;
        smaller = ReverseDigits(smaller).join("");
        bigger = ReverseDigits(bigger).join("");

        while (i < smaller.Length) 
        {
            if (int.Parse(bigger[i]) + int.Parse(smaller[i]) + help < 10) 
            {
                nString[i] = String(int.Parse(bigger[i]) + int.Parse(smaller[i]) + help);
                help = 0;
            }
            else 
            {
                nString[i] = String((int.Parse(bigger[i]) + int.Parse(smaller[i]) + help) % 10);
                help = 1;
            }
            i++;
        }

        while(i < bigger.Length){
            if (int.Parse(bigger[i]) + help < 10)
            {
                nString[i] = String(int.Parse(bigger[i]) + help);
                help = 0;
            }
            else 
            {
                nString[i] = String((int.Parse(bigger[i]) + help) % 10);
                help = 1;
            }
            i++;
        }

        if (help == 1) {
            nString[i] = "1";
        }

        return nString;
    }

    static void ArraysOfDigitsReverse(int[] first,int[] second) {
        if (first.Length < second.Length) 
        {
            Console.WriteLine(NewStringFromTwoOther(first, second));
        }
        else 
        {
            Console.WriteLine(NewStringFromTwoOther(second, first));
        }
    }
    static void Main()
    {

    }
}


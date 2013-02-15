using System;

class textBasedMenu
{
    static void Main()
    {
        Console.WriteLine("Reverses the digits of a number type = 1");
        Console.WriteLine("Calculates the average of a sequence of integers type = 2");
        Console.WriteLine("Solves a linear equation a * x + b = 0 type = 3");
        int option = int.Parse(Console.ReadLine());
        if (option == 1)
        {
            string number = Console.ReadLine();
            while (decimal.Parse(number) < 0) 
            {
                number = Console.ReadLine();
                Console.WriteLine("The decimal number should be non-negative");
            }
            char[] help = number.ToCharArray();
            Array.Reverse(help);
            Console.WriteLine(help);
        }
        else if(option == 2)
        {
            Console.WriteLine("length of sequence = ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
			{
			    arr[i] = int.Parse(Console.ReadLine());
                sum += arr[i];
			}
            Console.WriteLine(sum / arr.Length);
        }
        else if(option == 3)
        {
            Console.WriteLine("Enter a = ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b = ");
            double b = double.Parse(Console.ReadLine());
            if(a == 0)
            {
                Console.WriteLine("a should not be equal to 0 !");
            }
            else
            {
                Console.WriteLine("x = " + (-b/a));
            }
        }
        else
            Console.WriteLine("Invalid option");
    }
}


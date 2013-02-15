using System;

class HelloName
{
    static void printName(string name)
    {
        Console.WriteLine("Hello, " + name + " !" );
    }
    static void Main()
    {
        string name = Console.ReadLine();
        printName(name);
    }
}


using System;
using System.Collections.Generic;

public abstract class Calculator<T>
{
    public abstract T Add(T a, T b);
    public abstract T average(T a, int b);
    public abstract T pro(T a, T b);
}

public class Calculator: Calculator<int>
{
    public override int Add(int a, int b)
    {
        return a + b;
    }
    public override int average(int a, int b) 
    {
        return a / b;
    }
    public override int pro(int a, int b)
    {
        return a * b;
    }
}

class genericMethod<T> where T : new()
{

    Calculator<T> calculator;

    public genericMethod(Calculator<T> calculator)
    {
        this.calculator = calculator;
    }

    public T Sum(List<T> items)
    {
        T sum = new T();

        for (int i = 0; i < items.Count; i++)
        {
            sum = calculator.Add(sum, items[i]);
        }

        return sum;
    }

    public T average(List<T> items) 
    {
        T average = new T();

        average = calculator.average(Sum(items),items.Count);
        return average;
    }

    public T pro(List<T> items)
    {
        T product = new T();
        for (int i = 0; i < items.Count; i++)
        {
            product = calculator.pro(product, items[i]);
        }
        return product;
    }
}
class newClass
{
    static void Main()
    {
        
    }
}


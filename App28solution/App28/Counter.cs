using System;

public class Counter
{
    public int Count { get; set; }

    public Counter(int count = 0)
    {
        Count = count;
    }

    public int Increment()
    {
        return ++Count;
    }

    public int Decrement()
    {
        return --Count;
    }
}
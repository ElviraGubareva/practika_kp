using System;
using System.Collections.Generic;

public class Plan<T>
{
    public List<T> Items { get; set; }

    public Plan()
    {
        Items = new List<T>();
    }

    public void Add(T item)
    {
        Items.Add(item);
    }

    public void Remove(T item)
    {
        Items.Remove(item);
    }

    public Plan<T> Clone()
    {
        var clone = new Plan<T>();
        foreach (var item in Items)
        {
            clone.Items.Add(item);
        }
        return clone;
    }
}

public class Program
{
    public static void Main()
    {
        var plan = new Plan<string>();
        plan.Add("Task 1");
        plan.Add("Task 2");

        var clonedPlan = plan.Clone();

        clonedPlan.Remove("Task 1");

        int? nullableInt = null;
        if (nullableInt.HasValue)
        {
            Console.WriteLine(nullableInt.Value);
        }
        else
        {
            Console.WriteLine("nullableInt is null");
        }

        var list = new List<string> { "Item 1", "Item 2" };
        var dictionary = new Dictionary<string, string> { { "Key 1", "Value 1" }, { "Key 2", "Value 2" } };
        Console.ReadLine();
    }
}

using System;
using System.Collections.Generic;

public class MyList<T>
{
    private List<T> _list;

    public MyList()
    {
        _list = new List<T>();
    }

    public void Add(T item)
    {
        _list.Add(item);
    }

    public T this[int index]
    {
        get
        {
            return _list[index];
        }
    }

    public int Count
    {
        get
        {
            return _list.Count;
        }
    }
}

public static class MyListExtensions
{
    public static T[] GetArray<T>(this MyList<T> list)
    {
        T[] array = new T[list.Count];
        for (int i = 0; i < list.Count; i++)
        {
            array[i] = list[i];
        }
        return array;
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyList<int> myList = new MyList<int>();
        myList.Add(1);
        myList.Add(2);
        myList.Add(3);

        int[] array = myList.GetArray();
        Console.WriteLine("Значения элементов массива: " + string.Join(", ", array));
        Console.ReadLine();
    }
}

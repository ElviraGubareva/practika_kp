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
class Program
{
    static void Main(string[] args)
    {
        MyList<int> myList = new MyList<int>();
        myList.Add(1);
        myList.Add(2);
        myList.Add(3);
        Console.WriteLine("Элемент по индексу 1: " + myList[1]);
        Console.WriteLine("Общее количество элементов: " + myList.Count);
        Console.ReadLine();
    }
}

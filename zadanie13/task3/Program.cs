using System;

public class MyInfo
{
    private string name;
    public event EventHandler NameChanged;

    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Имя не может быть null или пустым.");
            }

            if (name != value)
            {
                name = value;
                OnNameChanged(EventArgs.Empty);
            }
        }
    }

    protected virtual void OnNameChanged(EventArgs e)
    {
        NameChanged?.Invoke(this, e);
    }
}

public class Program
{
    public static void Main()
    {
        try
        {
            MyInfo myInfo = new MyInfo();
            myInfo.NameChanged += MyInfo_NameChanged;

            myInfo.Name = "Эльвира Губарева"; 
            myInfo.Name = ""; 
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
        Console.ReadLine();
    }

    private static void MyInfo_NameChanged(object sender, EventArgs e)
    {
        Console.WriteLine("Значение поля name было изменено.");
    }
}

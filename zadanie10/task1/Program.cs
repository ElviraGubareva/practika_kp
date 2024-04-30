using System;
public class Стол
{
    private string название;
    private double площадьS;
    public Стол(string название, double площадьS)
    {
        this.название = название;
        this.площадьS = площадьS;
    }

    public string ПолучитьНазвание()
    {
        return название;
    }

    public double ПолучитьПлощадьS()
    {
        return площадьS;
    }

    public void ВывестиИнформацию()
    {
        Console.WriteLine($"Название: {название}, Площадь: {площадьS} см^2");

    }

    public double Стоимость(double k)
    {
        return Math.Pow(площадьS, 2) / 3 + k;
    }

}
public class Письменный : Стол
{

    private string используемыйМатериал;
    private double стоимостьОтделки;

    public Письменный(string название, double площадьS, string используемыйМатериал)
        : base(название, площадьS)
    {
        this.используемыйМатериал = используемыйМатериал;
    }

    public string ПолучитьМатериал()
    {
        return используемыйМатериал;
    }

    public new void ВывестиИнформацию()
    {
        base.ВывестиИнформацию();
        Console.WriteLine($"Используемый материал: {используемыйМатериал}");
    }

    public new double Стоимость(double k)
    {
        double базоваяСтоимость = base.Стоимость(k);
        стоимостьОтделки = базоваяСтоимость * 0.1;
        return базоваяСтоимость + стоимостьОтделки;
    }

    public double ПолучитьСтоимостьОтделки()
    {
        return стоимостьОтделки;
    }

}
class Program
{

    static void Main()
    {
        Стол стол = new Стол("Обеденный", 1200);
        Письменный письменныйСтол = new Письменный("Офисный", 1400, "Дуб");

        стол.ВывестиИнформацию();
        Console.WriteLine($"Стоимость стола: {стол.Стоимость(100)}");

        письменныйСтол.ВывестиИнформацию();
        Console.WriteLine($"Стоимость письменного стола: {письменныйСтол.Стоимость(150)}");
        Console.WriteLine($"Стоимость отделки: {письменныйСтол.ПолучитьСтоимостьОтделки()}");
        Console.ReadLine();
    }
}

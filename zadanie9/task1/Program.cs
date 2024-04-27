using System;

namespace task1
{
    interface Ix
    {
        void Method();
    }

    interface Iy
    {
        void Method();
    }

    interface Iz
    {
        void Method();
    }

    public class TestClass : Ix, Iy, Iz
    {
        public int w { get; set; }

        public TestClass(int parameter)
        {
            w = parameter;
        }

        public void Method()
        {
            int result = 7 * w - 4 - w * 3 + 6 + w;
            Console.WriteLine($"Результат для Ix: {result}");
        }

        void Iz.Method()
        {
            int result = 7 * w - 4 - w * 3 + 6 + w;
            Console.WriteLine($"Результат для Iz: {result}");
            Console.ReadLine();
        }
    }

    class Program
    {
        static void Main()
        {
            TestClass test = new TestClass(2); 

            ((Ix)test).Method();
            ((Iy)test).Method();
            Iz iz = test;
            iz.Method();
        }
    }
}

// See https://aka.ms/new-console-template for more information

delegate double MyDelegate(int argument1, int argument2, int argument3);

class Program
{
    public static int Method()
    {
        Random random = new Random();
        int ran = random.Next(0, 100);
        Console.WriteLine(ran);
        return ran;
    }

    static void Main()
    { 
        MyDelegate myDelegate1 = delegate (int a, int b, int c)
        {
            return (a + b + c)/3;
        };

        double result = myDelegate1(Method(), Method(), Method());
        Console.WriteLine("Среднеарифметическое равно {0}", result);
    }
}


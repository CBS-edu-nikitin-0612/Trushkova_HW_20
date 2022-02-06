// See https://aka.ms/new-console-template for more information

delegate double MyDelegate(int argument1, int argument2, int argument3);

class Program
{
    //Создание рандомного целого числа
    public static int Method()
    {
        Random random = new Random();
        int ran = random.Next(0, 100);
        Console.WriteLine(ran);
        return ran;
    }

    static void Main()
    { 
        //Анонимный метод для расчета среднеарифметического значения трех чисел
        MyDelegate myDelegate1 = delegate (int a, int b, int c)
        {
            return (a + b + c)/3;
        };

        //Расчет и вывод на экран среднеарифметического значения трех чисел
        double result = myDelegate1(Method(), Method(), Method());
        Console.WriteLine("Среднеарифметическое равно {0}", result);
    }
}


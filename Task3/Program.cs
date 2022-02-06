// See https://aka.ms/new-console-template for more information

delegate int MyDelegate();
delegate double MyDelegates(MyDelegate[] myDelegates);

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
        //Создание массива делегатов, предназначенных для создания рандомного целого числа 
        MyDelegate[] myDelegates = new MyDelegate[]
        {
            Method,
            Method,
            Method,
            Method,
            Method
        };

        //Анонимный метод для расчета среднеарифметического значения чисел
        MyDelegates myDelegates1 = delegate (MyDelegate[] array)
        {
            double mean = 0;
            for (int i = 0; i < array.Length; i++)
            {
                mean += array[i]();
            }
            mean /= array.Length;
            return mean;
        };

        //Расчет и вывод на экран среднеарифметического значения чисел
        double result = myDelegates1(myDelegates);
        Console.WriteLine("Среднеарифметическое равно {0}", result);
    }
}

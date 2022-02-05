// See https://aka.ms/new-console-template for more information

internal delegate double MyDelegate(double argument1, double argument2);


class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, Teacher!");

        MyDelegate Add = (double a, double b) => { return a + b; };
        MyDelegate Sub = (double a, double b) => { return a - b; };
        MyDelegate Mul = (double a, double b) => { return a * b; };
        MyDelegate Div = (double a, double b) =>
        {
            if (b != 0) return a / b;
            else return 0;            
        };

        double a = 12;
        double b = 2;
        try
        {
            Console.WriteLine("\nВведите арифметическое действие, которое нужно выполниь:");
            string? arithmetic = Console.ReadLine();
            if (arithmetic != null)
            {
                double result = arithmetic switch
                {
                    "+" => Add(a, b),
                    "-" => Sub(a, b),
                    "*" => Mul(a, b),
                    "/" => Div(a, b),
                    _ => throw new Exception("Введен неправльный арифметический знак")
                };
                Console.WriteLine(result);
            }
        }
        catch (Exception ex)
        { Console.WriteLine(ex.Message.ToString()); }
    }
}



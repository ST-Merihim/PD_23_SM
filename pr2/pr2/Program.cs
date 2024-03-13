using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть довжини сторін трикутника:");

        Console.Write("Сторона а: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Сторона b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Сторона c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Перевірка на дійсність трикутника
        if (a + b > c && a + c > b && b + c > a)
        {
            // Обчислення периметру
            double perimeter = a + b + c;
            Console.WriteLine($"Периметр трикутника: {perimeter}");

            // Обчислення площі за формулою Герона
            double s = perimeter / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            Console.WriteLine($"Площа трикутника: {area}");

            // Визначення виду трикутника
            if (a == b && b == c)
            {
                Console.WriteLine("Трикутник є рівностороннім.");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("Трикутник є рівнобедреним.");
            }
            else
            {
                Console.WriteLine("Трикутник є різностороннім.");
            }
        }
        else
        {
            Console.WriteLine("Трикутник з такими сторонами не існує.");
        }
    }
}

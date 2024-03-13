//ex1//
﻿using System;

class Program
{
    static void Main(string[] args)
    {
        int lastDigit = 0;

        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter another number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int num3 = int.Parse(Console.ReadLine());

        int startInterval = 1;
        int endInterval = 10 + lastDigit;

        Console.WriteLine("Numbers that lie on the interval [{0}, {1}]:", startInterval, endInterval);
        if (num1 >= startInterval && num1 <= endInterval)
            Console.WriteLine(num1);
        if (num2 >= startInterval && num2 <= endInterval)
            Console.WriteLine(num2);
        if (num3 >= startInterval && num3 <= endInterval)
            Console.WriteLine(num3);

        Console.ReadKey();
    }
}
//ex2//
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

// 3//
﻿using System;

class Program
{
    static void Main(string[] args)
    {
        int lastDigit = 0;

        int arrayLength = 10 + lastDigit;

        int[] X = new int[arrayLength];
        Random random = new Random();
        for (int i = 0; i < arrayLength; i++)
        {
            X[i] = random.Next(100);
        }

        int minValue = X[0];
        int maxValue = X[0];
        for (int i = 1; i < arrayLength; i++)
        {
            if (X[i] < minValue)
            {
                minValue = X[i];
            }
            else if (X[i] > maxValue)
            {
                maxValue = X[i];
            }
        }

        Console.Write("Array X: ");
        foreach (int value in X)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();

        Console.WriteLine($"Minimum value: {minValue}");
        Console.WriteLine($"Maximum value: {maxValue}");
    }
}
//ex4//
﻿using System;

class Program
{
    static void Main(string[] args)
    {
        int lastDigit = 0;

        int arrayLength = 10 + lastDigit;

        int[] X = new int[arrayLength];
        Random random = new Random();
        for (int i = 0; i < arrayLength; i++)
        {
            X[i] = random.Next(-99, 100);
        }

        Console.Write("Enter the number M: ");
        int M = int.Parse(Console.ReadLine());

        int[] Y = Array.FindAll(X, x => Math.Abs(x) > Math.Abs(M));

        Console.Write("Array X: ");
        foreach (int value in X)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();

        Console.WriteLine($"Number M: {M}");
        Console.Write("Array Y: ");
        foreach (int value in Y)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();
    }
}
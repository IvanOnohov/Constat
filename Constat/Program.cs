using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int result = CalculateAbsoluteDifference(n);
        Console.WriteLine("Результат: " + result);
    }

    static int CalculateAbsoluteDifference(int n)
    {
        int difference = Math.Abs(n - 123);
        if (n > 123)
        {
            return 3 * difference; // Умножаем на 3, если n больше 123
        }
        return difference;
    }
}
using System;

class Program
{
    static void Main()
    {
        int choice;
        do
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Введите первое число:");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Сумма: {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine("Введите уменьшаемое число:");
                    int minuend = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите вычитаемое число:");
                    int subtrahend = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Разность: {minuend - subtrahend}");
                    break;
                case 3:
                    Console.WriteLine("Введите первый множитель:");
                    int factor1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второй множитель:");
                    int factor2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Произведение: {factor1 * factor2}");
                    break;
                case 4:
                    Console.WriteLine("Введите делимое число:");
                    int dividend = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите делитель:");
                    int divisor = Convert.ToInt32(Console.ReadLine());
                    if (divisor != 0)
                    {
                        Console.WriteLine($"Частное: {dividend / divisor}");
                    }
                    else
                    {
                        Console.WriteLine("Деление на ноль невозможно.");
                    }
                    break;
<<<<<< part2              
case 5:
    Console.WriteLine("Введите основание:");
    double baseNum = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите показатель степени:");
    double exponent = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Результат возведения в степень: {Math.Pow(baseNum, exponent)}");
        break;
case 6:
    Console.WriteLine("Введите число для извлечения корня:");
    double number = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Корень числа: {Math.Sqrt(number)}");
        break;
case 7:
    Console.WriteLine("Введите число для округления:");
    double numToRound = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Округленное число: {Math.Round(numToRound)}");
        break;
case 8:
    Console.WriteLine("Выход из программы.");
        break;
    default:
        Console.WriteLine("Неверный выбор. Попробуйте снова.");
        break;
=======
            }
        }
        while (choice != 4);
    }
}

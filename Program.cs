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
Console.WriteLine("Введите номер операции:");
Console.WriteLine("1. Сложение");
Console.WriteLine("2. Вычитание");
Console.WriteLine("3. Умножение");
Console.WriteLine("4. Деление");
Console.WriteLine("5. Возведение в степень N");
Console.WriteLine("6. Квадратный корень");
Console.WriteLine("7. 1 процент");
Console.WriteLine("8. Факториал");
Console.WriteLine("9. Выйти из программы");
int x;
int a, b;
double n;
do
{
   Console.WriteLine("Введите номер операции:");
   x = Convert.ToInt32(Console.ReadLine());
    if (x == 1)
    {
        Console.WriteLine("Введите первое число");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Сумма равна = {a + b}");
    }
    else if (x == 2)
    {
        Console.WriteLine("Введите первое число");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Разность равна = {a - b}");
    }
    else if (x == 3)
    {
        Console.WriteLine("Введите первое число");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Произведене = {a * b}") ;
    }
    else if (x == 4)
    {
        Console.WriteLine("Введите первое число");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Частное = {a / b} ");
    }
    else if (x == 5)
    {
        Console.WriteLine("Введите возводимое число");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите степень возведения");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Произведене = {Math.Pow(a,b)} ");
    }
    else if (x == 6)
    {
        Console.WriteLine("Введите число для квадратного корня");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Произведене = {Math.Sqrt(n)} ");
    }
    else if (x==7)
    {
        Console.WriteLine("Введите число из которого нужно получить 1%");
        a = Convert.ToInt32(Console.ReadLine());
        b = 1;
        Console.WriteLine($"1 процент = {a * (b / 100m)} ");
    }
    else if (x == 8)
    {
        Console.WriteLine("Введите число для факториала");
        int m = int.Parse(Console.ReadLine());
        {
            b = 1;
            for (a = 1; a <= m; a++)
                b = b * a;
        }
        Console.WriteLine($"Фактоиал = {b} ");
        }
} while (x != 9);
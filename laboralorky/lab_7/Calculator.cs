char again = 'y';
while (again == 'y')
{
    double a;
    double b;
    double total;
    char oper;

    Console.WriteLine("Введите первое число:");
    a = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите оператор:");
    oper = Convert.ToChar(Console.ReadLine());

    Console.WriteLine("Введите второе число:");
    b = Convert.ToDouble(Console.ReadLine());

    if (oper == '+')
    {
        total = a + b;
        Console.WriteLine("Cумма " + a + " и " + b + " = " + total + ".");
    }

    else if (oper == '-')
    {
        total = a - b;
        Console.WriteLine("Разность " + a + " и " + b + " = " + total + ".");
    }

    else if (oper == '*')
    {
        total = a * b;
        Console.WriteLine("Умножение " + a + " на " + b + " = " + total + ".");
    }

    else if (oper == '/')
    {
        total = a / b;
        Console.WriteLine("Деление " + a + " на " + b + " = " + total + ".");
    }
    else if (oper == '%')
    {
        total = a * (b / 100);
        Console.WriteLine($"{a}% от {b} = {total}.");
    }
    else if (oper == '^')
    {
        total = Math.Pow(a, b);
        Console.WriteLine($"Число {a} в степени {b} = {total}.");
    }
    else if (oper == '√')
    {
        total = Math.Sqrt(a);
        Console.WriteLine(total);

    }
    else
    {
        Console.WriteLine("Неизвестный оператор.");
    }
    Console.WriteLine("Вы хотите продолжить работу с калькулятором? (y/n)");
    again = Convert.ToChar(Console.ReadLine());
}
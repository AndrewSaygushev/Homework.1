// task2
Console.WriteLine("Введите первое число");
int Number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int Number2 = Convert.ToInt32(Console.ReadLine());

if (Number1 > Number2)
{
Console.WriteLine($"Первое число {Number1} больше, чем второе число {Number2}");

}
else
{
Console.WriteLine($"Второе число {Number2} больше, чем первое число {Number1}");
}

Console.WriteLine();

// task4
Console.WriteLine("Введите три числа");
int Number1 = Convert.ToInt32(Console.ReadLine());
int Number2 = Convert.ToInt32(Console.ReadLine());
int Number3 = Convert.ToInt32(Console.ReadLine());

int max = Number1;

if (Number2 > max)
{
max = Number2;
}

if (Number3 > max)
{
max = Number3;
}

Console.WriteLine($"Наибольшее из введеных чисел - {max}");

// task6
Console.WriteLine("Введите число");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number % 2 == 0)
{
Console.WriteLine($"{Number} -> да");
}
else
{
Console.WriteLine($"{Number} -> нет");
}
Console.WriteLine();

// task8
int i = 1;
Console.WriteLine("Введите число");
int Number = Convert.ToInt32(Console.ReadLine());

while (i < Number)
{
if (i % 2 == 0)
{
Console.Write($"{i},");
}
i++;
}
Console.WriteLine();
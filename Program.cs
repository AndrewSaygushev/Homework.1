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
// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

Console.Write("Введите первое число: ");
string? numLine1 = Console.ReadLine();
Console.Write("Введите второе число: ");
string? numLine2 = Console.ReadLine();

if(numLine1 != null && numLine2 != null)
{
    int num1 = int.Parse(numLine1);
    int num2 = int.Parse(numLine2);

    if(num1 == (int)Math.Pow(num2, 2))
    {
        Console.WriteLine("Первое число - квадрат второго!");
    }
    else
    {
        Console.WriteLine("Первое число - не квадрат второго!");
    }
}
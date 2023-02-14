// Напишите программу, которая принимает
// на вход два числа и проверяет, является
// ли одно число квадратом другого.
// Console.Writeline("вводим первое число");
// int numA = int.Parse(Console.ReadLine()??"0");
// Console.Writeline("вводим второе число");
// int numB = int.Parse(Console.ReadLine()??"0");
// SquareTest(numA, numB);
// SquareTest(numB, numA);
// void SquareTest(int num1, int num2)
// {
//     if(num1 == num2*num2){
//     Console.Writeline("первое число является квадратом второго");
// }
//     else
// {
//     Console.Writeline("первое число не является квадратом второго");
// }
// }


// 1
void squareTest(int firstNum, int secondNum)
{
    if(firstNum == Math.Pow(secondNum,2))
    {
        Console.WriteLine($"Число {firstNum} является квадратом {secondNum}");
    }
    else
    {
        Console.WriteLine($"Число {firstNum} не является квадратом {secondNum}");
    }
}

Console.WriteLine("Введите первое число: ");
int firstNumer = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNumer = Convert.ToInt32(Console.ReadLine());

squareTest(firstNumer,secondNumer);

squareTest(secondNumer,firstNumer);

// 2
Console.WriteLine("Введите 2 числа:");
double num1 = Convert.ToDouble(Console.ReadLine());
double num2 = Convert.ToDouble(Console.ReadLine());
double square = Math.Pow(num1, 2);

if (num2 == square)
{
    Console.WriteLine("Да, число {0} квадрат {1}", num2, num1);
}
else
{
    Console.WriteLine("Нет, число {0} не квадрат числа {1}", num2, num1);
}
// Напишите программу, которая будет
// принимать на вход два числа и выводить,
// является ли второе число кратным первому.
// Если второе число некратно первому,
// то программа выводит остаток от деления.
Console.WriteLine("введите первое число");
int firstNum = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("введите второе число");
int secondNum = Convert.ToInt32(Console.ReadLine());
int rem = firstNum%secondNum;
if (rem == 0){
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine("не кратно, остаток "+ rem);
}
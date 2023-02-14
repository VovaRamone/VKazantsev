// Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
Console.WriteLine("введите число");
int num = int.Parse(Console.ReadLine()??"0");
bool oper = ((num%23 == 0) && (num%7 == 0));
if(oper)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine("не кратно");
}
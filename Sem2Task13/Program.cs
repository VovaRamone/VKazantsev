// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
string num = Console.ReadLine();
if(num.Length >= 3)
{
    Console.WriteLine("что-то");
}
else
{
    Console.WriteLine("что-то2");
}
char[] array = num.ToCharArray();

// int A = int.Parse(Console.ReadLine()??"0");
Console.WriteLine(array[2]);

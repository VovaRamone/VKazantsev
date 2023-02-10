// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// line N = Console.ReadLine();
// if(lineN != null){
//     N = int.Parse(lineN);
//     res = N % 10;
//     Console.WriteLine("Последняя цифра "+res);
// }
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number <1000)
{
    Console.WriteLine("Последняя цифра числа" + number%10);
}
else
Console.WriteLine("Введено не то число");
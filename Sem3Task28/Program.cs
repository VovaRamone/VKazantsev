// Напишите программу, которая принимает на
// вход число N и выдаёт произведение чисел
// от 1 до N.
// using System.Numerics;

// int ReadData(string line)
// {
//     Console.Write(line);
//     return Convert.ToInt32(Console.ReadLine() ?? "0");
// }

// void PrintResult(string line)
// {
//     Console.WriteLine(line);
// }

// BigInteger FactorCalc(long BigInteger)
// {
//     BigInteger res = 1;
//     for (int i = 0; i <= N; i++)
//     {
//         res = res * i;
//     }
//     return res;    
// }









using System.Numerics;

int ReadData(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()??"0");
}

void PrintData(string message)
{
    Console.WriteLine(message);
}

BigInteger FactorCalc (int num)
{
    BigInteger fact = 1;
    for (int i = 2; i <= num; i++)
    {
        fact = fact * i;
    }
    return fact;
}

int N = ReadData("Enter your value: ");
PrintData("The factorial of set value is " + FactorCalc(N));


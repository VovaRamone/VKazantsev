// Принимает на вход число и возвращает сумму числа

int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

int RecSumDig(int num)
{
    if (num == 0)
    {
        return 0;
    }
    else
    {
        return num%10 + RecSumDig(num / 10);
    }    
}

int number  = ReadData("Введите число N: ");
int res = RecSumDig(number);
Console.WriteLine(res);

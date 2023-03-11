// Напишите прграмму, которая будет принимать 2 числа А и В
// возведите А в степень В с помощью рекурсии

// Метод для считывания сообщения с консоли, который возвращает число
int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

long RecPow (int a, int b)
{
    if (b <= 1)
    {
        return a;
    }
    else
    {
        return a * RecPow (a, b - 1);
    }
}

long MyPow(int a, int b)
{
    if (b == 2)
    {
        return 4;
    }
    else
    {
        return MyPow(a, b / 2) * MyPow(a, b / 2);
    }
}

int a = ReadData("Введите число a: ");
int b = ReadData("Введите число b: ");
long res1 = RecPow(a, b);
Console.WriteLine(res1);
long res2 = MyPow(a, b);
Console.WriteLine(res2);

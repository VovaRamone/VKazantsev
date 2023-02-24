// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

int ReadData(string line)
{
    Console.Write(line);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int SumSimple(int numA)
{
    int sum = 0;
    for (int i = 0; i < numA; i++)
    {
        sum+=i;
        // sum = sum + i
    }

    return sum;
}

int SumGausse(int numA)
{    
    return ((1 + numA) * numA) / 2;    
}

int numberA = ReadData("Введите число А: ");

DateTime d1 = DateTime.Now;
int res1 = SumSimple(numberA);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
int res2 = SumGausse(numberA);
Console.WriteLine(DateTime.Now - d2);

PrintResult("Сумма чисел от 1 до А равна (простой метод): " + res1);
PrintResult("Сумма чисел от 1 до А равна (метод Гауса): " + res2);

// Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника



int ReadData(string line)
{
    Console.Write(line);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}


// n!/k!*(n-k)!
long Factorial(int n)
{
    long res = 1;
    for (int i = 1; i <= n; i++)
    {
        res = res * i;
    }
    return res;
}

//         1
//        1 1
//       1 2 1
void PrintPascalTriangle(int nRow)
{
    for (int i = 0; i < nRow; i++)
    {
        for (int k = 0; k < nRow - i; k++)
        {
            Console.Write(" ");
        }

        for (int j = 0; j <= i; j++)
        {
            Console.Write(" ");
            Console.Write(Factorial(i)/Factorial(j)*Factorial(i - j));
        }
        Console.WriteLine();        
    }
}

int countRow = ReadData("Введите кол-во строк треугольника Паскаль: ");
PrintPascalTriangle(countRow);


// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

// Создаём метод типа void, который выводит в консоль данные пользователя
void PrintData(string msg, double value)
{
    Console.WriteLine(msg + value);
}


// int ReadData(string line)
// {
//     Console.Write(line);
//     return Convert.ToInt32(Console.ReadLine() ?? "0");
// }

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}



int[] Gen1DArr(int len, int min, int max)
{
    // Блок корректировки входных данных
    if(min > max)
    {
        int buf = min;
        min = max;
        max = buf;
    }
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

(int posit, int negot) NegPosSum(int[] arr)
{
    int positSum = 0;
    int negotSum = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0)
        {
            positSum+=arr[i];
        }
        else
        {
            negotSum+=arr[i];
        }
    }
    return(positSum, negotSum);
}

int[] testArr = Gen1DArr(12, -9, 9);
Print1DArr(testArr);

(int posit, int negot) results = NegPosSum(testArr);
PrintData("Сумма положительных значений в массиве", results.posit);
PrintData("Сумма отрицательных значений в массиве", results.negot);


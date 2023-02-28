// Напишите программу, которая перевернёт
// одномерный массив (последний элемент
// будет на первом месте, а первый - на
// последнем и т.д.)

int[] Gen1DArr(int len, int min, int max)
{
    // Корректировка входных данных
    if (min > max)
    {
        int buf = min;
        min = max;
        max = buf;
    }

    Random rnd = new Random();
    int[] arr = new int[len];

    for (int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }

    return arr;
}

void Print1DArr(int[] arr)
{
    Console.Write("[");

    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]},\t");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}

void SwapArray(int[] arr)
{
    int bufElem = 0;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        bufElem = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = bufElem;
    }      
}

int[] SwapNewArray(int[] arr)
{
    int[] outArr = new int[arr.Length];
    for (int i = 0; i < outArr.Length; i++)
    {
        outArr[i] = arr[arr.Length - 1 - i];
    }
    return outArr;
}

int[] testArray = Gen1DArr(123, 10, 100);
Print1DArr(testArray);
Console.WriteLine();
// SwapArray(testArray);
int[] newArray = SwapNewArray(testArray);
Print1DArr(testArray);
Console.WriteLine();
Print1DArr(newArray);
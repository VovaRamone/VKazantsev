// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

int[] Gen1DArr(int len, int min, int max)
{
    if (min > max) //to ensure
    {
        int temp = min;
        min = max;
        max = temp;
    }
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
        arr[i] = new Random().Next(min, max + 1);
    return arr;
}
//prints 1D array into consle
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
        Console.Write($"{arr[i]}, ");
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}
void InvertArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = -arr[i];
    }
}

int[] testArr = Gen1DArr(12, -9, 9);
Print1DArr(testArr);
InvertArr(testArr);
Print1DArr(testArr);

// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов

// Метод для считывания сообщения с консоли, который возвращает число
int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод для печати
void PrintData(string message)
{
    Console.WriteLine(message);
}

// Метод генерации двумерного массива
int[,] Gen2DArr(int numRows, int numCols, int min, int max)
{
    // Корректировка входных данных
    if (min > max)
    {
        int buf = min;
        min = max;
         max = buf;
    }
    Random rnd = new Random();
    int[,] arr = new int[numRows, numCols];
    for (int i = 0; i < numRows; i++)
    {
        for (int j = 0; j < numCols; j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr;
}

// Метод печати двумерного массива в цвете
void Print2DArr(int[,] arr)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new Random().Next(0, 16)];
            Console.Write(arr[i, j] + "  ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

// Метод для подсчета суммы элементов в строке двумерного массива
int GetRowSum(int[,] arr, int row)
{
    int rowSum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        rowSum += arr[row, j];
    }
    return rowSum;
}

// Метод для нахождения строки с наименьшей суммой элементов строки двумерного массива
int FindSmallestRow(int[,] arr)
{
    int minSum = int.MaxValue;
    int minRow = -1;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int rowSum = GetRowSum(arr, i);
        if (rowSum < minSum)
        {
            minSum = rowSum;
            minRow = i;
        }
    }
    return minRow;
}

// Просим пользователя ввести нужные данные
int numRows = ReadData("Введите количество строк: ");
int numCols = ReadData("Введите количество столбцов: ");
int min = ReadData("введите минимальное значение: ");
int max = ReadData("Введите максимальное значение: ");

// Генерируем массив при помощи метода Gen2DArr
int[,] arr = Gen2DArr(numRows, numCols, min, max);
// Печатаем сгенерированный двумерный массив, на основе введенных пользователем значений
Print2DArr(arr);

// Создаём переменную для обозначения строки с наименьшей суммой элементов строки двумерного массива
int minRow = FindSmallestRow(arr);
// Создаём переменную для вывода суммы элементов строки с наименьшей суммой элементов
int minSum = GetRowSum(arr, minRow);
// Выводим результат в консоль
PrintData($"В строке {minRow} находится наименьшая сумма элементов. Сумма элементов равна: {minSum}");
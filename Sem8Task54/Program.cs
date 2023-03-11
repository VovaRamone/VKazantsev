// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void Sort2DArr(int[,] arr)
{
    // Проходим по строкам
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        // Создаём временный массив для хранения текущей строки
        int[] row = new int[arr.GetLength(1)];
        // Проходим по столбцам
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            // копируем текущий элемент строки в массив
            row[j] = arr[i, j];
        }
        // Сортируем элементы массива в порядке возрастания при помощи оператора Sort
        Array.Sort(row);
        // Изменяем порядок элементов в массиве в порядке убывания при помощи оператора Reverse
        Array.Reverse(row);
        // копируем отсортированные элементы обратно в строку заданного изначально массива
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = row[j];
        }
    }
}
// Метод генерации двумерного массива
int[,] Gen2DArr(int countRow, int countColumn, int min, int max)
{
    // Корректировка входных данных
    if (min > max)
    {
        int buf = min;
        min = max;
         max = buf;
    }
    Random rnd = new Random();
    int[,] arr = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr;
}
// Метод печати двумерного массива в цвете
void Print2DArr(int[,] arr)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Blue, ConsoleColor.Green, ConsoleColor.Magenta, ConsoleColor.Red, ConsoleColor.Yellow};

    for (int i = 0; i < arr.GetLength(0); i++)
    {
    for (int j = 0; j < arr.GetLength(1); j++)
        {
            // Устанавливаем определенный цвет на элемент массива исходя из остатка текущего элемента разделенного на 5
            // Таким образом мы сопоставим каждый элемент массива с одним из пяти возможных цветов.
            Console.ForegroundColor = col[arr[i,j] % 5];
            Console.Write(arr[i, j] + "  ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Генерируем массив при помощи метода Gen2DArr
int[,] arr = Gen2DArr(5, 5, 10, 99);
// Печатаем изначальный массив
Print2DArr(arr);
// Сортируем его по убыванию
Sort2DArr(arr);
// Печатаем отсортированный массив
Print2DArr(arr);
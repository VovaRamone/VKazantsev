// Напишите программу, которая заполнит спирально массив 4 на 4.

// Метод для считывания сообщения с консоли, который возвращает число
int ReadData(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

// Метод генерации двумерного спиралевидного массива 
int[,] GenSpiral2DArray(int rows, int cols)
{
    // Создадим двумерный массив, выделим под него новый объект
    int[,] spiralArray = new int[rows, cols];
    // Вызываем метод заполнения спиралевидного массива
    FillSpiral2DArray(spiralArray, 0, 0, rows - 1, cols - 1, 1);
    // Возвращаем результат
    return spiralArray;
}

// Метод заполнения спиралевидного массива
void FillSpiral2DArray(int[,] arr, int rowStart, int colStart, int rowEnd, int colEnd, int num)
{
    // проверка на заполнение массива для выхода из рекурсии
    if (rowStart > rowEnd || colStart > colEnd) return;
    // Заполняем верхнюю строку
    for (int i = colStart; i <= colEnd; i++)
    {
        arr[rowStart, i] = num;
        num++;
    }
    // Заполняем правый столбец
    for (int i = rowStart + 1; i <= rowEnd; i++)
    {
        arr[i, colEnd] = num;
        num++;
    }
    // Заполняем нижнюю строку
    for (int i = colEnd - 1; i >= colStart && rowStart < rowEnd; i--)
    {
        arr[rowEnd, i] = num;
        num++;
    }
    // Заполняем левый столбец
    for (int i = rowEnd - 1; i > rowStart && colStart < colEnd; i--)
    {
        arr[i, colStart] = num;
        num++;
    }
    // Используем рекурсивный метод для заполнения внутренней части спирали
    FillSpiral2DArray(arr, rowStart + 1, colStart + 1, rowEnd - 1, colEnd - 1, num);
}

// Метод печати двумерного массива двузначными числами
void Print2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]:D2} ");
        }
        Console.WriteLine();
    }
}

// Просим пользователя ввести нужные данные
int rowsAndCols = ReadData("Введите число строк и столбцов: ");
// Генерируем двумерный спиралевидный массив при помощи метода GenSpiral2DArray
int[,] spiralArray = GenSpiral2DArray(rowsAndCols, rowsAndCols);
// Console.WriteLine("Spiral Array:");
// Выводим массив в консоль при помощи метода Print2DArr
Print2DArr(spiralArray);










// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Метод для считывания сообщения с консоли, который возвращает число
int ReadData(string message)
    {
        Console.Write(message);
        return int.Parse(Console.ReadLine() ?? "0");
    }

// Метод генерации двумерного массива
int[,] Gen2DArr(int numRows, int numCols, int min, int max)
    {
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

// Метод для нахождения произведения между двумя матрицами
int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    // В переменные положим количество строк и столбцов первой матрицы
    int numRows1 = matrix1.GetLength(0);
    int numCols1 = matrix1.GetLength(1);
    
    // В переменные положим количество строк и столбцов второй матрицы
    int numRows2 = matrix2.GetLength(0);
    int numCols2 = matrix2.GetLength(1);
    
    // Проверка совпадает ли количество столбцов первой матрицы с количеством строк второй матрицы
    if (numCols1 != numRows2)
    {
        // Если не совпадают выводим сообщение в консоль
        Console.WriteLine(" Ошибка: количество столбцов первой матрицы должно совпадать с количеством строк второй матрицы.");
    }
    
    // Создаём новую матрицу для хранения результата произведения двух матриц
    int[,] result = new int[numRows1, numCols2];
    
    // Итерируем по строкам первой матрицы
    for (int i = 0; i < numRows1; i++)
    {
        // Итерируем по столбцам второй матрицы
        for (int j = 0; j < numCols2; j++)
        {
            int sum = 0;            
            // Итерируем по столбцам первой матрицы и строкам второй матрицы, т.к. они и так равны
            for (int k = 0; k < numCols1; k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }            
            // кладём результат в новую матрицу
            result[i, j] = sum;
        }
    }    
    // возвращаем результат
    return result;
}

// Вводим данные по первой матрице
int numRows1 = ReadData("Введите количество строк первой матрицы: ");
int numCols1 = ReadData("Введите количество столбцов первой матрицы: ");
int[,] matrix1 = Gen2DArr(numRows1, numCols1, 1, 9);
Console.WriteLine("Матрица 1:");
Print2DArr(matrix1);

int numRows2 = ReadData("Введите количество строк второй матрицы: ");
int numCols2 = ReadData("Введите количество столбцов второй матрицы: ");
int[,] matrix2 = Gen2DArr(numRows2, numCols2, 1, 9);
Console.WriteLine("Матрица 2:");
Print2DArr(matrix2);

// Проверка совпадает ли количество столбцов первой матрицы с количеством строк второй матрицы
if (numCols1 != numRows2)
{
    Console.WriteLine(" Ошибка: количество столбцов первой матрицы должно совпадать с количеством строк второй матрицы.");
    return;
}

// Генерируем двумерный массив произведения двух матриц
int[,] res = MultiplyMatrices(matrix1, matrix2);
// Выводим сообщение в консоль
Console.WriteLine("Произведение двух матриц:");
Print2DArr(res);
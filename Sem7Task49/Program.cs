// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.


// int[,] Gen2DArr(int countRow, int countColumn, int min, int max)
// {
//     // Корректировка входных данных
//     if (min > max)
//     {
//         int buf = min;
//         min = max;
//         max = buf;
//     }
//     Random rnd = new Random();
//     int[,] arr = new int[countRow, countColumn];
//     for (int i = 0; i < countRow; i++)
//     {
//         for (int j = 0; j < countColumn; j++)
//         {
//             arr[i, j] = rnd.Next(min, max + 1);
//         }        
//     }
//     return arr;
// }

// void Print2DArr(int[,] arr)
// {
//     ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
//                                         ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
//                                         ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
//                                         ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
//                                         ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
//                                         ConsoleColor.Yellow};

//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.ForegroundColor = col[new Random().Next(0,16)];
//             Console.Write(arr[i, j] + " ");
//             Console.ResetColor();
//         }
//         Console.WriteLine();
//     }
// }

// void Update2DArr(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i = i + 2)
//     {
//         for (int j = 0; j < arr.GetLength(1); j = j + 2)
//         {            
//             arr[i, j] *= arr[i, j];
//         }
//     }
// }




int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

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
            Console.ForegroundColor = col[new Random().Next(0,16)];
            Console.Write(arr[i, j] + "  ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

int [,] RemastArr(int[,] arr, int countRow, int countColumn)
{
    for (int i = 0; i < countRow; i = i + 2)
    {
        for (int j = 0; j < countColumn; j = j + 2)
        {            
                arr[i, j] = arr[i, j]*arr[i, j];            
        }
    }
    return arr;
}

int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int[,] testArr = Gen2DArr(row, column, 1, 10);
Print2DArr(testArr);
Console.WriteLine();
int[,] resArr = RemastArr(testArr, row, column);
Print2DArr(resArr);





// Console.Clear();
// int ReadData(string WrDate)
// {
//     Console.WriteLine(WrDate);
//     int result = int.Parse(Console.ReadLine() ?? "0");
//     return result;
// }

// void PrintData(string text, int print)
// {
//     Console.WriteLine($"{text}:{print}");
// }

// int[,] GenArry(int min, int max, int RowCount, int ColCount)
// {
//     int buf;
//     if (min > max)
//     {
//         buf = min;
//         min = max;
//         max = buf;
//     }
//     int[,] binarray = new int[RowCount, ColCount];
//     System.Random numSintezator = new System.Random();
//     for (int i = 0; i < RowCount; i++)
//     {
//         for (int j = 0; j < ColCount; j++)
//         {
          
//             binarray[i,j] = numSintezator.Next(min, max);
//             if(i%2==0 && j%2==0)
//             {
//                 binarray[i,j] *=binarray[i,j];
//             }
            
//         }
//     }
//     return binarray;
// }

// void PrintArry(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {

//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]}\t");
//         }
//        Console.WriteLine();
//     }

// }
// int row=ReadData("Введите кол-во строк");
// int col=ReadData("Введите кол-во столбцов");
// int[,] array = GenArry(20, 100, row, col);
// Console.WriteLine("Исходный массив:");
// PrintArry(array);
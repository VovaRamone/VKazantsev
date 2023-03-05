// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

// int[,] Gen2DArrMod(int countRow, int countColumn, int min, int max)
// {
//     // Корректировка входных данных
//     if (min > max)
//     {
//         int buf = min;
//         min = max;
//         max = buf;
//     }
//     Random rnd = new Random();
//     int[,] resArr = new int[countRow, countColumn];
//     for (int i = 0; i < countRow; i++)
//     {
//         for (int j = 0; j < countColumn; j++)
//         {
//             resArr[i, j] = i + j;
//         }        
//     }
//     return resArr;
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






Console.Clear();


int[,] GenArry( int RowCount, int ColCount)
{
    int[,] binarray = new int[RowCount, ColCount];
    
    for (int i = 0; i < RowCount; i++)
    {
        for (int j = 0; j < ColCount; j++)
        {
            binarray[i,j] = i+j;
        }
    }
    return binarray;
}

void PrintArry(int[,] array)
{
     ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new Random().Next(0,16)];
            Console.Write($"{array[i,j]}\t");
            Console.ResetColor();
        }
       Console.WriteLine();
    }

}

int[,] array = GenArry( 8, 9);
Console.WriteLine("Исходный массив:");
PrintArry(array);
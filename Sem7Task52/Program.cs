// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Создаём метод для чтения целочисленных данных с консоли
int ReadData(string line)
{
    Console.Write(line);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

// Создаём метод для генерации двумерного массива случайных чисел
int[,] Gen2DArr(int countRow, int countColumn, int min, int max)
{
    // Корректировка входных данных
    if (min > max)
    {
        int buf = min;
        min = max;
        max = buf;
    }
    // Запускаем генератор случайных чисел
    Random rnd = new Random();
    // Создаём массив, выделяем под него новый объект
    int[,] arr = new int[countRow, countColumn];
    // Используем два цикла for для прохода по строкам и столбцам массива
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            // Генерируем в массив случайное число
            arr[i, j] = rnd.Next(min, max + 1);
        }        
    }
    // Возвращаем результат
    return arr;
}

// Создаём метод для вывода двумерного массива в консоль где столбцы будут окрашены в определенный цвет
void Print2DArr(int[,] arr)
{
    // Создаём массив из 16 возможных цветов, выделяем под него новый объект
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                            ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                            ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                            ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                            ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                            ConsoleColor.Yellow};
    // Используем два цикла for для прохода по строкам и столбцам массива
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            // Зададим для столбцов синий цвет
            Console.ForegroundColor = col[1];
            // Выведим результат в консоль используя табуляцию
            Console.Write(arr[i, j] + "\t");
            // Сброс цвета
            Console.ResetColor();
        }
        // Вывод пустой сроки в консоль, для отступа
        Console.WriteLine();
    }
}

// Создаём метод для вычисления среднеарифметического значения по столбцам. Массив будет типа double, т.к. будут дробные числа
double[] CalculateColumnMeans(int[,] arr)
{
    // В переменную colCount положим длину столбца в массиве
    int colCount = arr.GetLength(1);
    // Создаём массив для хранения среднеарифметического числа, выделяем под него новый объект
    double[] means = new double[colCount];
    // Вычисляем среднеарифметическое число в каждом стобце массива
    for (int j = 0; j < colCount; j++)
    {
        // Создаём переменную для суммирования элементов в столбце
        double sum = 0;
        // Проходим по каждой строке
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            // Добавляем текущий элемент в переменную
            sum += arr[i, j];
        }
        // Вычисляем среднеарифметическое в столбце и помещаем полученный результат в массив
        means[j] = sum / arr.GetLength(0);
    }
    // Возвращем результат
    return means;
}

// Просим пользователя ввести количество строк и столбцов
int rowCount = ReadData("Enter the number of rows: ");
int colCount = ReadData("Enter the number of columns: ");        
// Генерируем двумерный массив случайных чисел, задав нужные значения
int[,] arr = Gen2DArr(rowCount, colCount, 10, 99);
// Выводим двумерный массив в консоль
Print2DArr(arr);

// Вычисляем среднеарифметическое по столбцам
double[] columnMeans = CalculateColumnMeans(arr);
// Печатаем среднеарифметическое по каждому столбцу массива красным цветом,
// ограничив кол-во цифр после запятой от дробного значения до двух, также применив табуляцию
for (int j = 0; j < colCount; j++)
{
    // Задаём цвет текста красным
    Console.ForegroundColor = ConsoleColor.Red;
    // Выводим полученное среднеарифметическое, применив конвертацию в строковую переменную
    Console.Write(columnMeans[j].ToString("F2") + "\t");
    // Сброс цвета на дефолт
    Console.ResetColor();
}


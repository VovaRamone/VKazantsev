// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// * При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16).      

// Создаём метод для чтения целочисленных данных с консоли
int ReadData(string line)
{
    Console.Write(line);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

// Создаём метод для генерации двумерного массива случайных вещественных чисел
double[,] Gen2DArr(int countRow, int countColumn, double min, double max)
{
    // Корректировка входных данных
    if (min > max)
    {
        double buf = min;
        min = max;
        max = buf;
    }
    // Запускаем генератор случайных чисел
    Random rnd = new Random();
    // Создаём массив, выделяем под него новый объект
    double[,] arr = new double[countRow, countColumn];
    // Используем два цикла for для прохода по строкам и столбцам массива
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            // Генерируем в массив случайное число с двумя знаками после запятой
            arr[i, j] = Math.Round((min + (max - min) * rnd.NextDouble()), 2);
        }
    }
    // Возвращаем результат
    return arr;
}

// Создаём метод для вывода двумерного массива в консоль где каждая цифра числа будет в разном цвете
void Print2DArrColored(double[,] arr)
{
    // Создаём массив из 16 возможных цветов для цифр, выделяем под него новый объект
    ConsoleColor[] col = new ConsoleColor[] { ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.Cyan,
                                    ConsoleColor.DarkBlue, ConsoleColor.DarkCyan, ConsoleColor.DarkGray,
                                    ConsoleColor.DarkGreen, ConsoleColor.DarkMagenta, ConsoleColor.DarkRed,
                                    ConsoleColor.DarkYellow, ConsoleColor.Gray, ConsoleColor.Green,
                                    ConsoleColor.Magenta, ConsoleColor.Red, ConsoleColor.White,
                                    ConsoleColor.Yellow };
    // Используем два цикла for для прохода по строкам и столбцам массива
    for (int i = 0; i < arr.GetLength(0); i++)
    {        
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            // Преобразуем число в строку с двумя знаками после запятой
            string str = arr[i, j].ToString("0.00");
            // Итерируем по символам в строке
            for (int k = 0; k < str.Length; k++)
            {
                // Устанавливаем цвета консоли на случайный цвет из массива цветов при помощи метода ForegroundColor
                Console.ForegroundColor = col[new Random().Next(0, 16)];
                // Вывод очередного символа числа в консоль
                Console.Write(str[k]);
            }
            // Вывод пробела в консоль
            Console.Write(" ");
            // Сброс цвета при помощи метода ResetColor
            Console.ResetColor();
        }
        // Вывод пробела в консоль
        Console.WriteLine();
    }
}

// Просим пользователя ввести количество строк и столбцов
int rows = ReadData("Введите количество строк: ");
int cols = ReadData("Введите количество столбцов: ");
// Генерируем двумерный массив случайных вещественных чисел, задав нужные значения
double[,] arr = Gen2DArr(rows, cols, 0.0, 10.0);
// Выводим двумерный массив в консоль с каждой цифрой числа в разном цвете
Print2DArrColored(arr);
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// *Заполнить числами Фиббоначи и выделить цветом найденную цифру.

// Создаём метод для чтения целочисленных данных с консоли
int ReadData(string line)
{
    Console.Write(line);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

// Создаём метод для генерации двумерного массива заполненного числами Фибоначчи.
int[,] Gen2DArrFib(int countRow, int countColumn)
{
    // Создаём массив, выделяем под него новый объект
    int[,] arr = new int[countRow, countColumn];
    // Заполняем массив числами Фибоначчи
    int a = 0, b = 1;
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = b;
            int c = a + b;
            a = b;
            b = c;
        }
    }
    // Возвращаем полученный результат
    return arr;
}

// Создаём метод для вывода двумерного массива в консоль, в котором подсветим искомое число, если таковое найдется.
void Print2DArrFib(int[,] arr, int targetNumber)
{
    // Создадим булеву переменную для индикации искомого числа, присвоим ей значение false
    bool foundTarget = false;
    // Используем два цикла for для прохода по строкам и столбцам массива
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == targetNumber)
            {
                // Если искомое число найдено, подкрашиваем его в зеленый цвет и меняем булево значение на true
                Console.ForegroundColor = ConsoleColor.Green;
                foundTarget = true;
            }
            else
            {
                // В противном случае сбросим цвет
                Console.ResetColor();
            }
            // Выводим результат в консоль используя табуляцию
            Console.Write(arr[i, j] + "\t");
        }
        // Выводим пустую строку, для отступа
        Console.WriteLine();
    }
    // Проверка на то, является ли булево число ложным. Оператор выполняется если целевое число не найдено
    if (!foundTarget)
    {
        // Выводим сообщение в консоль
        Console.WriteLine($"Искомое число {targetNumber} не найдено в массиве");
    }
}

// Просим пользователя ввести количество строк и столбцов, а также искомое число в массиве
int rows = ReadData("Enter number of rows: ");
int cols = ReadData("Enter number of columns: ");
int targetNumber = ReadData("Enter target number: ");
// Генерируем двумерный массив чисел Фибоначчи, задав нужные параметры
int[,] arr = Gen2DArrFib(rows, cols);
// Печатаем массив в консоль
Print2DArrFib(arr, targetNumber);
// Нажать кнопку для выхода из программы
Console.ReadLine();

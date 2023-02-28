// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// * Отсортировать массив методом пузырька
// * Отсортируйте массив методом подсчета
// * Сравнить скорость работы метода пузырька и подсчета

// Создаём метод сортировки массива пузырьком, используя два цикла for.
void BubbleSort(int[] arr)
{
    int n = arr.Length;
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
}

// Создаём метод сортировки массива подсчетом
void CountingSort(int[] arr)
{
    int n = arr.Length;
    int[] count = new int[1000];

    // При помощи цикла for вычисляем повторения по каждому числу
    for (int i = 0; i < n; i++)
    {
        count[arr[i]]++;
    }

    // Переписываем отсотрированный массив в оригинальный массив
    int index = 0;
    for (int i = 0; i < count.Length; i++)
    {
        for (int j = 0; j < count[i]; j++)
        {
            arr[index] = i;
            index++;
        }
    }
}

// Создаём метод для подсчета количества чётных чисел в массиве при помощи цикла foreach
int CountEven(int[] arr)
{
    int count = 0;
    foreach (int num in arr)
    {
        if (num % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

// Создаём метод для вывода полученного результата в консоль
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}

// Создаём метод, который будет генерировать массив (входные значения: длина массива, минимальное и максимальное значение массива)
int[] Gen1DArr(int len, int min, int max)
{
    // Проверка на то что max больше либо равен min
    if (min > max)
    {
        int buf = min;
        min = max;
        max = buf;
    }

    // Создаём переменную rand, выделяем под неё новый объект. Переменная будет генерировать случайное значение.
    Random rand = new Random();

    // Создаём массив, выделяем под него новый объект. В массив положим длину массива, которую введем в консоль
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(min, max + 1);
    }
    return arr;
}

// // Генерируем одномерный массив, указав необходимые данные (в данном случае необходимы 3-значные числа)
int[] arr = Gen1DArr(10, 100, 999);

// Выводим оригинальный массив (до сортировки)
Console.WriteLine("Оригинальный массив (неотсортированный):");
Print1DArr(arr);
Console.WriteLine();

// Выводим массив отсортированный методом пузырька и количество чётных чисел в массиве
// Подключаем оператор Datetime.Now для отслеживания времязатратности на вычисление метода.
DateTime d1 = DateTime.Now;
BubbleSort(arr);
DateTime d2 = DateTime.Now;
Console.WriteLine("Массив отсортированный методом пузырька:");
Print1DArr(arr);
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел: {CountEven(arr)}");
Console.WriteLine($"На сортировку массива методом пузырька затрачено {(d2 - d1).TotalMilliseconds} мс.");

// Выводим массив отсортированный методом подсчёта и количество чётных чисел в массиве
// Подключаем оператор Datetime.Now для отслеживания времязатратности на вычисление метода.
d1 = DateTime.Now;
CountingSort(arr);
d2 = DateTime.Now;
Console.WriteLine("Массив отсортированный методом подсчета:");
Print1DArr(arr);
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел: {CountEven(arr)}");
Console.WriteLine($"На сортировку массива методом подсчёта затрачено {(d2 - d1).TotalMilliseconds} ms.");
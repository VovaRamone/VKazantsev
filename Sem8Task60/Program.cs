// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Метод для считывания сообщения с консоли, который возвращает число
int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод генерации 3-мерного массива случайных неповторяющихся чисел
int[,,] Gen3DUniqArr(int rows, int columns, int layers, int min, int max)
{
    Random rnd = new Random();
    int[,,] arr = new int[rows, columns, layers];
    // Генерируем неповторяющиеся числа и заполним ими новый массив set, выделим под это новый объект
    HashSet<int> set = new HashSet<int>();
    // Проходим по всем слоям массива
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < layers; k++)
            {
                int num;
                // Выполняем до тех пор пока массив не будет заполнен случайными неповторяющимися числами
                do
                {
                    num = rnd.Next(min, max + 1);
                    // Добавляем элемент если его ещё нет в массиве set
                } while (!set.Add(num));
                arr[i, j, k] = num;
            }
        }
    }
    return arr;
}

// Печатаем 3-мерный массив, который будет построчно выводить массив, добавляя индексы каждого элемента.
void Print3DArr(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]} ({i}, {j}, {k})\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

// Просим пользователя ввести нужные данные
int rows = ReadData("Введите количество строк: ");
int cols = ReadData("Введите количество столбцов: ");
int layers = ReadData("Введите количество слоёв: ");

// Генерируем 3-мерный массив случайных неповторяющихся чисел при помощи метода Gen3DUniqArr
int[,,] arr = Gen3DUniqArr(rows, cols, layers, 10, 99);
// Выводим массив в консоль при помощи метода Print3DArr
Print3DArr(arr);

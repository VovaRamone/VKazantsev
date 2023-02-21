// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// * Вывести таблицу с границами и значениями друг над другом

// Создаём метод, который будет считывать с консоли сообщение и возвращать число
int ReadInput(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

// Создаём метод для создания строки таблицы
string LineBuilder(int end, int pow)
{   
    // Создаём пустую строку
    string res = String.Empty;
    // Создаём цикл fori от 1 до end
    for (int i = 1; i <= end; i++)
    {
        // Добавляем к res форматированную строку с возведением в степень
        res = res + String.Format("|{0,6}", Math.Pow(i, pow));
    }
    // Возвращаем полученное значение с символом "|" для разделения полученных значений при выводе таблицы в консоль
    return res + "|";
}

// Просим ввести конечное число в консоль, при помощи ранее созданного метода
int N = ReadInput("Введите конечное число: ");

// Вычисляем длину таблицы, используя первую строку таблицы
int tableWidth = LineBuilder(N, 1).Length;

// Выводим таблицу в консоль
// Для вывода разделителя используем новую строковую переменную для расчета длины таблицы
Console.WriteLine(new string('_', tableWidth));
Console.WriteLine(LineBuilder(N, 1));
Console.WriteLine(new string('-', tableWidth));
Console.WriteLine(LineBuilder(N, 3));
Console.WriteLine(new string('-', tableWidth));
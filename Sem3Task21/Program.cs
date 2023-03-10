// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// Создаём метод, который будет считывать с консоли сообщение и возвращать число
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

// Создаём метод типа void, который выводит в консоль данные пользователя
void PrintData(string msg, double value)
{
    Console.WriteLine(msg + value);
}

// Создаём метод, который находит расстояние между точками в 3D пространстве
double CalcLen3D(int x1, int x2, int y1, int y2, int z1, int z2)
{
    // Возвращаем полученное значение по формуле Пифагора
    return Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
}

// Вводим координаты для каждой из точек в 3D прострастве
int x1 = ReadData("Введите координату x точки А: ");
int y1 = ReadData("Введите координату y точки А: ");
int z1 = ReadData("Введите координату z точки А: ");
int x2 = ReadData("Введите координату x точки B: ");
int y2 = ReadData("Введите координату y точки B: ");
int z2 = ReadData("Введите координату z точки B: ");

// Создаём переменную типа double, которой присваиваем полученный результат из метода CalcLen3D
double res = CalcLen3D(x1, x2, y1, y2, z1, z2);
// Выводим результат в консоль
PrintData("Расстояние между точками А и В: ", res);

// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// *Найдите площадь треугольника образованного пересечением 3 прямых

// Создаём метод, который будет считывать с консоли сообщение и возвращать число
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Создаём метод для вывода в консоль
void PrintData(string msg)
{
    Console.WriteLine(msg);
}

// Создаём метод, включающий в себя массив типа double, для нахождения заданных точек
double[] FindAllPoints(double k1, double b1, double k2, double b2, double k3, double b3)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    double x2 = (b3 - b2) / (k2 - k3);
    double y2 = k2 * x2 + b2;

    double x3 = (b3 - b1) / (k1 - k3);
    double y3 = k1 * x3 + b1;

    double[] points = { x, y, x2, y2, x3, y3 };

    return points;
}

// Создаём метод типа double, для нахождения расстояния между двумя точками
double FindDistance(double x1, double y1, double x2, double y2)
{
    // Рассчитываем расстояние используя формулу для нахождения расстояния
    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    // Возвращаем полученный результат
    return distance;
}

// Создаём метод типа double, для нахождения площади треугольника по длинам его сторон
double CalculateArea(double distance1, double distance2, double distance3)
{
    // Вычисляем полупериметр треугольника
    double s = (distance1 + distance2 + distance3) / 2;
    // Вычисляем площадь по формуле Герона
    double area = Math.Sqrt(s * (s - distance1) * (s - distance2) * (s - distance3));
    // Возвращаем полученный результат
    return area;
}

// Задаём переменные для наклона и точки пересечения по оси Y трех линий.
double k1, b1, k2, b2, k3, b3;

// Просим пользователя ввести значения
k1 = ReadData("Введите k1:");
b1 = ReadData("Введите b1:");
k2 = ReadData("Введите k2:");
b2 = ReadData("Введите b2:");
k3 = ReadData("Введите k3:");
b3 = ReadData("Введите b3:");

// Вызываем метод нахождения точек, для нахождения точек пересечения трех прямых
double[] intersectionPoints = FindAllPoints(k1, b1, k2, b2, k3, b3);

// Проверяем пересекаются ли линии, при помощи оператора NaN "not a number"
if (intersectionPoints[0] == double.NaN || intersectionPoints[1] == double.NaN)
{
    // Если условие выполняется и линии не пересекаются, тогда выводим сообщение
    PrintData("Линии не пересекаются");
}
else
{
    // В противном случае, вычисляем расстоние между каждой парой точек пересечения
    double distance1 = FindDistance(intersectionPoints[0], intersectionPoints[1], intersectionPoints[2], intersectionPoints[3]);
    double distance2 = FindDistance(intersectionPoints[2], intersectionPoints[3], intersectionPoints[4], intersectionPoints[5]);
    double distance3 = FindDistance(intersectionPoints[4], intersectionPoints[5], intersectionPoints[0], intersectionPoints[1]);

    // В переменную area положим площадь треугольника сформированного пересечениями трёх линий
    double area = CalculateArea(distance1, distance2, distance3);

    // Выводим результат в консоль
    PrintData($"Точка пересечения ({intersectionPoints[0]}, {intersectionPoints[1]})");
    PrintData($"Площадь треугольника равна {area}");
}

// Нажать клавишу чтобы выйти из консоли
Console.ReadLine();

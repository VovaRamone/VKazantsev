// Напишите программу, которая принимает на
// вход три числа и проверяет, может ли
// существовать треугольник с сторонами
// такой длины.

// // Создаём метод, который будет считывать с консоли сообщение и возвращать число
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine()??"0");
// }

// // Создаём метод типа void, который выводит в консоль данные пользователя
// void PrintData(string msg, double value)
// {
//     Console.WriteLine(msg + value);
// }

// bool TriangleTest(int a, int b, int c)
// {
//     bool res = false;
//     if (Test(a, b, c) && Test(b, a, c) && Test(c, a, b))
//     {
//         res = true;
//     }
//     return res;
// }

// bool Test(int a, int b, int c)
// {
//     return (a <= b + c);
// }


// Console.WriteLine("Введите длины сторон треугольника: ");
// double a = double.Parse(Console.ReadLine());
// double b = double.Parse(Console.ReadLine());
// double c = double.Parse(Console.ReadLine());

// if (a + b > c && a + c > b && b + c > a)
// {
//     Console.WriteLine("Треугольник существует");
// }
// else
// {
//     Console.WriteLine("Треугольник не существует");
// }





// int ReadDataToInt(string msg)
// {
//     Console.Write(msg);
//     return (int.Parse(Console.ReadLine() ?? "0"));
// }

// //output the result
// void PrintAnswer(string explain, bool num)
// {
//     Console.WriteLine(explain + num);
// }
// bool TestABC(int a, int b, int c)
// {
//     if (a <= b + c)
//         return true;
//     else
//         return false;
// }

// //if triangle with such sides exists
// bool IfTriangle(int a, int b, int c)
// {
//     if (TestABC(a, b, c) && TestABC(b, a, c) && TestABC(c, a, b))
//         return true;
//     else
//         return false;
// }
// int sideA = ReadDataToInt("Length of side 1: ");
// int sideB = ReadDataToInt("Length of side 2: ");
// int sideC = ReadDataToInt("Length of side 3: ");
// PrintAnswer("A triangle with such sides can exist: ", IfTriangle(sideA, sideB, sideC));










int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg)
{
    Console.WriteLine(msg);
}

bool TriangleTest(int a, int b, int c)
{
    bool result = false;
    if (FitTest(a, b, c) && FitTest(b, a, c) && FitTest(c, a, b)) result = true;
    return result;
}

bool FitTest(int a, int b, int c)
{
    return a <= b + c;
}

int valA = ReadData("Enter the first side length: ");
int valB = ReadData("Enter the second side length: ");
int valC = ReadData("Enter the third side length: ");

if (TriangleTest(valA, valB, valC)) PrintData($"The triangle with sides {valA}, {valB} and {valC} could exist!");
else PrintData($"The triangle with sides {valA}, {valB} and {valC} is impossible");
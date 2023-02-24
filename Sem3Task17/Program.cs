// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// <тип> <имя метода>(<тип> <название переменной>)
// {
//     return <тип>
// }
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

void PrintQuoterTest(int x, int y)
{
    if(x > 0 && y > 0)Console.WriteLine("Точка в первой четверти");
    if(x > 0 && y < 0)Console.WriteLine("Точка во второй четверти");
    if(x < 0 && y < 0)Console.WriteLine("Точка в третьей четверти");
    if(x < 0 && y > 0)Console.WriteLine("Точка в четвертой четверти");
}

int coordX = ReadData("Введите координату Х");
int coordY = ReadData("Введите координату Y");
PrintQuoterTest(coordX, coordY);
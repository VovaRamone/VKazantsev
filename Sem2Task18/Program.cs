// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine()??"0");
// }
// void PrintAnswer(int num)
// {
//     if(num > 0 && num < 5)
//     {
//         if(num == 1)Console.WriteLine("X больше 0, Y больше нуля");
//         if(num == 2)Console.WriteLine("X больше 0, Y меньше нуля");
//         if(num == 3)Console.WriteLine("X меньше 0, Y меньше нуля");
//         if(num == 4)Console.WriteLine("X меньше 0, Y больше нуля");
//     }

// }



// int coordX = ReadData("Введите координату Х");
// int coordY = ReadData("Введите координату Y");
// PrintAnswer(coordX, coordY);


int ReadInput(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine());
}

void SearchXY(int num)
{
    if (num > 0 && num < 5)
    {
        if (num == 1)
            Console.WriteLine("x > 0 , y > 0");
        if (num == 2)
            Console.WriteLine("x > 0 , y < 0");
        if (num == 3)
            Console.WriteLine("x < 0 , y < 0");
        if (num == 4)
            Console.WriteLine("x < 0 , y > 0");
    }
    else
        Console.WriteLine("Вы ввели не номер четверти");
}

int quarter = ReadInput("Введите номер четверти: ");
SearchXY(quarter);

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine()??"0");
// }

// void LineBuilder(int num, int pow)
// {
//     string res = string.Empty;
//     for(int i = 1 ; i <= num; i++)
//     {
//         res = res + Math.Pow(i, pow) + " ";
//     }
//     return res;
// }
// int num = ReadData("Введите конечное число: ");
// LineBuilder(num);





int ReadInput(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

string LineBuilder(int end, int pow)
{
    string res = String.Empty;
    
    for(int i = 1; i<=end; i++)
    {
        res = res + Math.Pow(i, pow)+ " ";        
    }
    return res;   
}

int N = ReadInput("Введите конечное число: ");
Console.WriteLine(LineBuilder(N,1));
Console.WriteLine(LineBuilder(N,2));


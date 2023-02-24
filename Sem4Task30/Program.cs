// Напишите программу, которая выводит
// массив из 8 элементов, заполненный нулями
// и единицами в случайном порядке.

// int ReadData(string line)
// {
//     Console.Write(line);
//     return Convert.ToInt32(Console.ReadLine() ?? "0");
// }

// void Print1DArr(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.length - 1; i++)
//     {
//         Console.Write(arr[] + ", ");
//     }
// }
// Console.Write(arr[arr.length - 1]);

// int[] Gen1DArr(int len, int min, int max)
// {
//     int[] arr = new int[num];
//     for (int i = 0; i < arr.length; i++)
//     {
//         arr[i] = new Random().Next(min, max + 1);
//     }
//     return arr;
// }

// Console.WriteLine ("]");


int[] Gen1DArr(int len, int min, int max)
{
        int[] arr = new int[len];
        
        
            for(int i=0; i<len; i++) arr[i] =  new Random().Next(min,max+1);
            
                return arr;
                }
                
                //prints 1D array into consle
                void Print1DArr(int[] arr)
                {
                        Console.Write("[");
                            for(int i=0; i < arr.Length-1; i++) Console.Write($"{arr[i]}, ");
                                Console.WriteLine($"{arr[arr.Length-1]}]");
                                }
Print1DArr(Gen1DArr(8,0,1));
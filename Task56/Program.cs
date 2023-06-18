// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],3} ");
        }
        Console.WriteLine();
    }
}

int SumLine(int[,] arr, int i)
{
int sum = arr[i,0];
for (int j = 1; j < arr.GetLength(1); j++)
{
sum += arr[i,j];
}
return sum;
}



int[,] arr = new int[4, 4];
FillArray(arr);
PrintArray(arr);
int minSum = 1;
int sum = SumLine(arr, 0);
for (int i = 1; i < arr.GetLength(0); i++)
{
if (sum > SumLine(arr, i))
{
sum = SumLine(arr, i);
minSum = i+1;
}
}
System.Console.WriteLine($"В строке {minSum} наименьшая сумма чисел.");
/*
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] generate2DArray(int lengthRow, int lengthCol, int deviation)
{
    int[,] array = new int[lengthRow, lengthCol];
    for (int i = 0; i < lengthRow; i++)
    {
        for (int j = 0; j < lengthCol; j++)
        {
            array[i, j] = new Random().Next(deviation + 1);
        }
    }
    return array;
}
void printColor(string message, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(message);
    Console.ResetColor();
}
void print2DArray(int[,] array)
{

    Console.Write("\t");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        printColor(i + "\t", ConsoleColor.Red);
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printColor(i + "\t", ConsoleColor.Red);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int minSumOfRowIndex(int[,] array)
{
    int index = 0;
    int minSum = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        if (i == 0)
        {
            minSum = sum;
        }
        else
        {
            if (sum < minSum)
            {
                minSum = sum;
                index = i;
            }
        }
    }
    return index;
}

int[,] array = generate2DArray(5, 2, 9);
print2DArray(array);
int index = minSumOfRowIndex(array);
Console.WriteLine($"Номер строки с минимальной суммой: {index}");
/*
 Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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
void print2DArray(int[,] array, string Name = "")
{
    printColor(Name, ConsoleColor.DarkCyan);
    Console.WriteLine();
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
int[,] multiplyArrays(int[,] array1, int[,] array2)
{
    int[,] resultArray = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            int value = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                value = value + array1[i, k] * array2[k, j];
            }
            resultArray[i, j] = value;
        }
    }
    return resultArray;
}

int[,] array1 = generate2DArray(2, 3, 5);
print2DArray(array1, "Матрица первая");
int[,] array2 = generate2DArray(3, 2, 5);
print2DArray(array2, "Матрица вторая");
int[,] resultArray = multiplyArrays(array1, array2);
print2DArray(resultArray, "Результирующая матрица");
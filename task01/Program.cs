/*
 Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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
int[,] sortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = array.GetLength(1)-1; k > 0; k--)
            {
                if(array[i,k]>array[i,k-1])
                {
                    int buf=array[i,k];
                    array[i,k]=array[i,k-1];
                    array[i,k-1]=buf;
                }
            }
        }

    }

    return array;
}

int[,] array = generate2DArray(3, 4, 15);
print2DArray(array, "Изначальный массив");
int[,] sortedArray = sortArray(array);
print2DArray(sortedArray, "Сортированный массив");
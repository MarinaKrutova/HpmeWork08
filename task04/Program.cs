/*
 ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
 которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/


bool numberInArray(int number, int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (number == array[i])
        {
            return true;
        }
    }
    return false;
}


int[,,] generate3DArray(int lengthRow, int lengthCol, int lengthHeight)
{
    int[] uniqueNumbers = new int[lengthRow * lengthCol * lengthHeight];

    int[,,] array = new int[lengthRow, lengthCol, lengthHeight];
    for (int i = 0; i < lengthRow; i++)
    {
        for (int j = 0; j < lengthCol; j++)
        {
            for (int k = 0; k < lengthHeight; k++)
            {
                while (true)
                {
                    int number = new Random().Next(10, 100);
                    if (!numberInArray(number, uniqueNumbers))
                    {
                        array[i, j, k] = number;
                        uniqueNumbers[i + j + k] = number;
                        break;
                    }
                }
            }
        }

    }
    return array;
}

void print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
       for (int j = 0; j < array.GetLength(1); j++)
       {
        for (int k = 0; k < array.GetLength(2); k++)
        {
        Console.WriteLine($"{array[i,j,k]}({i},{j},{k})");
        }
       } 
    }
}
int[,,] array = generate3DArray(2, 2, 2);
print3DArray(array);
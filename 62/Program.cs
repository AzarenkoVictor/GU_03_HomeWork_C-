// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int column = 4;
int line = 4;

SpiralFillArray(array);
PrintArray(array);

void SpiralFillArray(int[,] array)
{
    int s = 1;

    for (int y = 0; y < column; y++)
    {
        array[0, y] = s;
        s++;
    }
    for (int x = 1; x < line; x++)
    {
        array[x, column - 1] = s;
        s++;
    }
    for (int y = column - 2; y >= 0; y--)
    {
        array[line - 1, y] = s;
        s++;
    }
    for (int x = line - 2; x > 0; x--)
    {
        array[x, 0] = s;
        s++;
    }

    int c = 1;
    int d = 1;

    while (s < line * column)
    {
        while (array[c, d + 1] == 0)
        {
            array[c, d] = s;
            s++;
            d++;
        }

        while (array[c + 1, d] == 0)
        {
            array[c, d] = s;
            s++;
            c++;
        }

        while (array[c, d - 1] == 0)
        {
            array[c, d] = s;
            s++;
            d--;
        }

        while (array[c - 1, d] == 0)
        {
            array[c, d] = s;
            s++;
            c--;
        }
    }

    for (int x = 0; x < line; x++)
    {
        for (int y = 0; y < column; y++)
        {
            if (array[x, y] == 0)
            {
                array[x, y] = s;
            }
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j] + "  ");
            }
            else
                Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine(" ");
    }
}
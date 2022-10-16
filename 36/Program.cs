// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите длинну массива"); int dl = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число массива"); int from = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число массива"); int to = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int[] array = new int[dl];

void FillArray(int[] array, int from, int to)
{ for (int i = 0; i < array.Length; i++) { array[i] = new Random().Next(from, to); } }

void PrintArray(int[] array)
{ for (int i = 0; i < array.Length; i++) { if (i == array.Length - 1) Console.Write($"{array[i]} "); else Console.Write($"{array[i]}, "); } }

int OddElement(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
            sum = sum + array[i];
    }
    return sum;
}

FillArray(array, from, to);
Console.WriteLine("Создали массив трехзначных чисел");
PrintArray(array);
OddElement(array);
Console.WriteLine();
Console.WriteLine($"сумма элементов, стоящих на нечётных позициях равна: {sum}");
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите длинну массива"); int dl = Convert.ToInt32(Console.ReadLine());

int from = 100;
int to = 1000;
int sum = 0;

void FillArray(int[] array, int from, int to)
{ for (int i = 0; i < array.Length; i++) { array[i] = new Random().Next(from, to); } }

void PrintArray(int[] array)
{ for (int i = 0; i < array.Length; i++) { if (i == array.Length - 1) Console.Write($"{array[i]} "); else Console.Write($"{array[i]}, "); } }

int[] array = new int[dl];



int EvenNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            sum = sum + 1;
    }
    return sum;
}

FillArray(array, from, to);
Console.WriteLine("Создали массив трехзначных чисел");
PrintArray(array);
EvenNumbers(array);
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве {sum}");
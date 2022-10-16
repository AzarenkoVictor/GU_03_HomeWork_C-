// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


Console.WriteLine("Введите длинну массива"); int dl = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число массива"); int from = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число массива"); int to = Convert.ToInt32(Console.ReadLine());

double[] array = new double[dl];

void FillArray(double[] array, int from, int to)
{ for (int i = 0; i < array.Length; i++) { array[i] = Math.Round((new Random().Next(from, to)) + 0.1 * (new Random().Next(1, 9)), 1); } }

void PrintArray(double[] array)
{ for (int i = 0; i < array.Length; i++) { if (i == array.Length - 1) Console.Write($"{array[i]} "); else Console.Write($"{array[i]} ,  "); } }

double min = 0;
double max = 0;
double diff = 0;

double minmax(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= max)
        { max = array[i]; }
        else if (array[i] < min)
        {
            min = array[i];
        }
    }
    diff = Math.Round((max - min), 1);
    return diff;
}

FillArray(array, from, to);
Console.WriteLine("Создали массив вещественных чисел");
PrintArray(array);
minmax(array);
Console.WriteLine();
Console.WriteLine($"разница между максимальным и минимальным элементом массива равна: {diff}");
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Введите число - подсчитаем количество положительных. Для выхода нажмите 0 "); int number = Convert.ToInt32(Console.ReadLine());
int amount = 0;
if (number > 0) { amount = 1; }
while (number != 0)
{
    Console.WriteLine($"Введите число    Введено {amount} положительных чисел"); number = Convert.ToInt32(Console.ReadLine());
    if (number > 0) { amount = amount + 1; }
}
Console.WriteLine($"Итого: введено {amount} положительных чисел");
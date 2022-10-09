// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// // Решение 1 - Математика
// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());
// if ((a / 10000 == a % 10) && ((a-(a/10000)*10000)) / 1000 == (((a % 100) / 10)))
// {
//     Console.WriteLine("Введенное число " + a + " является полиндромом");
// }
// else
// {
//     Console.WriteLine("Введенное число " + a + " не является полиндромом");
// }

// Решение 2 - Строки

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
string n = Convert.ToString(a);
int length = n.Length-1;
int z = 0;
for (int i = 0; i <= (length / 2); i++)
{
    if (n[i] != n[length - i])
    {
        z = z + 1;
    }
}
if (z == 0)
{
    Console.WriteLine("Число является полиндромом");
}
if (z > 0)
{
    Console.WriteLine("Число не является полиндроном");
}

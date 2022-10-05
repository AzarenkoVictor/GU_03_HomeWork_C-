// Задача 13: Напишите программу, 
// которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введи число");
string a = Console.ReadLine();
int dl = a.Length;
int b = Convert.ToInt32(a);

Console.WriteLine("Введи номер цифры для отображения");     // Я усложнил задачу - мы сами выбираем, какую цифру мы хотим увидеть )
int j = Convert.ToInt32(Console.ReadLine());

int e = Convert.ToInt32(Math.Pow(10, (dl - (j - 1))));

if (dl >= j)
{
    int с = b % e;
    Console.WriteLine(j + " цифрой числа " + b + " является " + ((b % e) / (e / 10)));
}
else
    Console.WriteLine("Это " + dl + " значное число, в нем нет " + j + " цифры !");

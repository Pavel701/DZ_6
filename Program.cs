// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine());

int count = 0;

for (int i = 1; i <= m; i++)
{
    Console.Write($"Введите {i}-е число: ");
    double num = double.Parse(Console.ReadLine());

    if (num > 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество положительных чисел: {count}");

///////////////////////////////////////////////////////////////////
//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

double k1, b1, k2, b2, x, y;

Console.WriteLine("Введите значения для первой прямой:");
Console.Write("k1 = ");
k1 = double.Parse(Console.ReadLine());
Console.Write("b1 = ");
b1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значения для второй прямой:");
Console.Write("k2 = ");
k2 = double.Parse(Console.ReadLine());
Console.Write("b2 = ");
b2 = double.Parse(Console.ReadLine());

if (k1 == k2)
{
Console.WriteLine("Прямые параллельны");
} 
else 
{
x = (b2 - b1) / (k1 - k2);
y = k1 * x + b1;
Console.WriteLine($"Точка пересечения прямых: ({x}, {y})");
}

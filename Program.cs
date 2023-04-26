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

﻿// 26 Напишите программу,
//  которая принимает на вход число и выдаёт количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5


Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
int count = 0; //количество цифр в числе
Console.Clear();
while (A > 0)
{
    A /= 10; // A = A/10
    count++;
}
Console.WriteLine($"Количество цифр в числе = {count}");
﻿// Напишите программу, котрая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число ");

int x = Convert.ToInt32(Console.ReadLine());

if (x < 100 || x>999)
{
    Console.WriteLine("Данное число не является трехзначным, введите число от 100 до 999");
}
else 
{
int a=x/10;

int b=a%10;

Console.WriteLine($"Вторая цифра числа {b}");
}
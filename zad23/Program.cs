﻿// Напишите программу, которая принимает на вход число(N) и выдаёт таблицу кубов чисел от 1 до N
// Например, 5 -> 1, 8, 27, 64, 125
Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
int count =1;
while (count<=N)
{
    Console.Write($"{Math.Pow(count,3)}, ");
     count++;
}

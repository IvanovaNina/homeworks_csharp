﻿// Напишите программу, которая на вход принимает цифру, обозначающую день недели и проверяет, является ли этот день выходным
// Например, 1-нет, 6- да, 7- да

Console.WriteLine("Введите цифру: ");

int x = Convert.ToInt32(Console.ReadLine());

if (x > 7 || x <1)
{
    Console.WriteLine("Такого дня недели нет, введите цифру от 1 до 7");
}
else
{
    if (x==6 || x==7)
    {
    Console.WriteLine("Это выходной день ");
    }
else
    {
    Console.WriteLine("Этот день не является выходным днем");
    }
}

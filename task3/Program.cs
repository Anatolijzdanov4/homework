﻿// Напишите программу которая на вход принимает число и выдает являеться ли число четным

System.Console.WriteLine("Введите число");
int Number = Convert.ToInt32(Console.ReadLine());
if((Number % 2) == 0)
{
    System.Console.WriteLine("Четное");
}
else 
{
    System.Console.WriteLine("Не четое");
}
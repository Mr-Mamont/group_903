﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число и получите результат: ");
	int number = int.Parse(Console.ReadLine());
	int remain = number % 2;
	if (remain == 0)
	{
	    Console.WriteLine("Число " + number + " четное?");
	    Console.WriteLine("ДА!");
	}
	else
	{
	    Console.WriteLine("Число " + number + " четное?");
	    Console.WriteLine("НЕТ!");
	}


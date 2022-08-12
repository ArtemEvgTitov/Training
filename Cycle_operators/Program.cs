﻿/*
Монетки

На столе лежат n монеток. Некоторые из них лежат вверх решкой, а некоторые – гербом. 
Определите минимальное число монеток, которые нужно перевернуть, 
чтобы все монетки были повернуты вверх одной и той же стороной.
Входные данные
В первой строке входного файла INPUT.TXT записано натуральное число N (1 ≤ N ≤ 100) – число монеток. 
В каждой из последующих N строк содержится одно целое число – 1 если монетка лежит решкой вверх и 0 если вверх гербом.
Выходные данные
В выходной файл OUTPUT.TXT выведите минимальное количество монет, которые нужно перевернуть.
*/

Console.Write("\nВведите число монеток: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] coins = new int[n];
for (int i = 0; i < coins.Length; i++)
{
    coins[i] = new Random().Next(0, 2);
}
Console.WriteLine("\nИсходное положение монеток: " + string.Join(", ", coins));
int count = 0;
for (int i = 0; i < coins.Length; i++)
{
    if (coins[i] == 0)
    {
        coins[i]++;
        count++;
    }
}
Console.WriteLine("Итоговое положение монеток: " + string.Join(", ", coins));
Console.WriteLine("Количество перевёрнутых монеток: " + count);
Console.WriteLine();
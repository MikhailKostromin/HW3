//Напишите программу, которая считывает с консоли числа (по одному в строке) до тех пор, пока сумма введённых чисел не будет равна 0 
// и сразу после этого выводит сумму квадратов всех считанных чисел.Гарантируется, что в какой-то момент сумма введённых чисел окажется равной 0,
// после этого считывание продолжать не нужно.
// В примере мы считываем числа 1, -3, 5, -6, -10, 13; в этот момент замечаем, что сумма этих чисел равна нулю и выводим сумму их квадратов, не обращая внимания на то, что остались ещё не прочитанные значения.﻿



Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = N;
double sum2 = Math.Pow (N,2);


while  ( sum != 0)
{
 Console.WriteLine("Введите число: ");
 N = Convert.ToInt32(Console.ReadLine());
 sum += N;
 sum2 += Math.Pow (N,2);
}

Console.WriteLine("Сумма квадратов заданных чисел = "+sum2);
using System;
using Cw2;

Console.WriteLine("Hello, World");
int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int min = StatisticsHelper.GetMin(numbers);
Console.WriteLine(min);
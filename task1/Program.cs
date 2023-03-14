// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using static Library2Darrays;

int myRows = GetValueFromUser(" укажите количество строк в матрице: ");
int myColumns = GetValueFromUser("укажите количество столбцов в матрице : ");
int[,] myMatrix = Create2D(myRows, myColumns);
Console.WriteLine();
Fill2DWithRandomNumbers(myMatrix);
Console.WriteLine("Получилась  матрица:");
string s = Print2D(myMatrix);
Console.WriteLine(s);

System.Console.WriteLine("Упорядочиваю элементы строк по убыванию");
ArrangingElementsInDescendingOrderInARow(myMatrix);
Console.WriteLine();
Print2D(myMatrix);
string ss = Print2D(myMatrix);
Console.WriteLine(ss);
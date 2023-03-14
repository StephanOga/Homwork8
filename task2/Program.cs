// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Не поняла, зачем тут прямоугольность. Решила отступить от условия и сделать решение для любой матрицы.

using static Library2Darrays;

int myRows = GetValueFromUser("Создаю матрицу, введите число строк: ");
int myColumns = GetValueFromUser("а теперь столбцов: ");

Console.WriteLine();
int[,] myMatrix = Create2D(myRows, myColumns);
Fill2DWithRandomNumbers(myMatrix);
string printMyMatrix = Print2D(myMatrix);
Console.WriteLine(printMyMatrix);

Console.WriteLine("Ищу минимальную сумму элементов строки матрицы");
string minSummy = ShowMinSumOfElementsInARow(myMatrix);
Console.WriteLine(minSummy);

string seekRow = ShowRowWihAMinSum(myMatrix, int.Parse(minSummy));
Console.WriteLine(seekRow);
public static class Library2Darrays
{
    public static int[,] Create2D(int rows, int columns)
    {
        return new int[rows, columns];
    }

    public static int GetValueFromUser(string text)
    {
        int value = 0;
        bool flag = false;
        while (!flag)
        {
            Console.WriteLine(text);
            flag = int.TryParse(Console.ReadLine(), out value);
        }
        return value;
    }

    public static void Fill2DWithRandomNumbers(int[,] matrix, int min = 0, int max = 100)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = new Random().Next(min, max);
            }
        }
    }

    public static string Print2D(int[,] matrix)
    {
        string result = String.Empty;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                result += ($"{matrix[i, j],3} ");
            }
            result += "\n";
        }
        return result;
    }

    public static void ArrangingElementsInDescendingOrderInARow(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = j + 1; k < matrix.GetLength(1); k++)
                {
                    if (matrix[i, j] < matrix[i, k])
                    {
                        int temp = matrix[i, j];
                        matrix[i, j] = matrix[i, k];
                        matrix[i, k] = temp;
                    }
                }
            }
        }
    }

    public static string ShowMinSumOfElementsInARow(int[,] matrix)
    {
        string result = "";
        int minSum = 0;

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            minSum += matrix[0, j];
        }

        for (int i = 1; i < matrix.GetLength(0); i++)
        {
            int sum = 0;
            int endRow = matrix.GetLength(1) - 1;  // признак конца строки
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j != endRow)
                {
                    sum += matrix[i, j];
                }

                if (j == endRow)   // то есть достигаю конца строки и начинаю сравнивать sum и minSum
                {
                    sum += matrix[i, j];
                    if (sum < minSum)
                    {
                        minSum = sum;
                    }
                }
            }
        }
        result += minSum;
        return result;
    }

    public static string ShowRowWihAMinSum(int[,] matrix, int minimalSum)
    {
        string res = "";
        int summy = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int endRow = matrix.GetLength(1) - 1;
                if (j != endRow)
                {
                    summy += matrix[i, j];
                }
                else
                {
                    summy += matrix[i, j];
                    if (summy == minimalSum)
                    {
                        res += "Минимальная сумма элементов находится в строке: "+ $"{i}";
                    }                
                    else summy = 0;
                }
            }    
        }
        return res;
    }
}


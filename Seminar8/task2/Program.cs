// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


void Main()
{
  int[,] matrix = GenerateMatrix(ReadInt("Insert rows: "), ReadInt("Insert colums: "), 1, 10);
  PrintMatrix(matrix);
  int min_value = FindMinSumInRows(matrix);
  System.Console.WriteLine($"минимальное значение в строке {min_value}");
}

int ReadInt(string text)
{
  System.Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}



int[,] GenerateMatrix(int n, int m, int leftBorder, int rightBorder)
{
  Random rand = new Random();
  int[,] matrix = new int[n, m];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {

      matrix[i, j] = rand.Next(leftBorder, rightBorder + 1);
    }
  }
  return matrix;
}


int FindMinSumInRows(int[,] matrix)
{
  int rows = matrix.GetLength(0);
  int columns = matrix.GetLength(1);
  int[] sum = new int[rows];
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      sum[i] += matrix[i, j];
    }
  }

  int min_val = sum.Min();
  System.Console.WriteLine($"значение min_val в переводе на человеческие строки {min_val+1}");
  for (int i = 0; i < sum.Length; i++)
  {
    Console.WriteLine(sum[i] + " ");
  }

  int min_index = Array.IndexOf(sum, min_val);
  return min_index;
}


void PrintMatrix(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      System.Console.Write(matr[i, j] + "\t");
    }
    System.Console.WriteLine();
  }
}

Main();
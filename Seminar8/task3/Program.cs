// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



void Main()
{
  int[,] a = GenerateMatrix(ReadInt("Insert rows of 1 matrix: "), ReadInt("Insert colums of 1 matrix: "), 1, 3);
  int[,] b = GenerateMatrix(ReadInt("Insert rows of 2 matrix: "), ReadInt("Insert colums of 2 matrix: "), 1, 3);
  if (a.GetLength(1) == b.GetLength(0))
  {
    System.Console.WriteLine("first matrix");
    PrintMatrix(a);
    System.Console.WriteLine();
    System.Console.WriteLine("second matrix");
    PrintMatrix(b);
    System.Console.WriteLine();
    int[,] new_matrix = MultiplOfTwoMatrix(a, b);
    PrintMatrix(new_matrix);
  }
  else
  {
    System.Console.WriteLine("Can't multiply matrices!");
  }
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


int[,] MultiplOfTwoMatrix(int[,] a, int[,] b)
{
  int rows1 = a.GetLength(0);
  int columns1 = a.GetLength(1);
  int rows2 = b.GetLength(0);
  int columns2 = b.GetLength(1);
  int[,] new_matr = new int[rows1, columns2]; // число строк которой равно числу строк первой матрицы, а число столбцов равно числу столбцов второй матрицы
  // строка на столбец
  for (int i = 0; i < rows1; i++)
  {
    for (int j = 0; j < columns2; j++)
    {
      int sum = 0;
      for (int k = 0; k < columns1; k++)
      {
        sum += a[i, k] * b[k, j];
      }
      new_matr[i, j] = sum;
    }
  }
  return new_matr;
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
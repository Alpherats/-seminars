// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void Main()
{
  int rows = ReadInt("Insert rows: ");
  int cols = ReadInt("Insert cols: ");
  int[,] matrix = GenerateMatrix(rows, cols, 1, 10);
  PrintMatrix(matrix);
  FindAverage(matrix, rows, cols);

}

int ReadInt(string text)
{
  System.Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}



int[,] GenerateMatrix(int m, int n, int leftBorder, int rightBorder)
{
  Random rand = new Random();
  int[,] matrix = new int[m, n];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {

      matrix[i, j] = rand.Next(leftBorder, rightBorder + 1);
    }
  }
  return matrix;
}


double[] FindAverage(int[,] matr, int rows, int cols)
{
  double[] col_averg = new double[cols];

  for (int j = 0; j < cols; j++)
  {
    double sum = 0;

    for (int i = 0; i < rows; i++)
    {
      sum += matr[i, j];
    }
    System.Console.WriteLine(Math.Round(sum / rows, 3));
    col_averg[j] = sum / rows;
  }
  return col_averg;
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
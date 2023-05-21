// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

void Main()
{
  double[] arr = GenerateArr(7, 1, 20);
  Print_Arr(arr);
  FindMaxAndMin(arr, out double max, out double min);
  System.Console.WriteLine($"Max number - {max}, Min number - {min}, their subtraction - {max - min}");
}

double[] GenerateArr(int size, int leftBorder, int rightBorder)
{
  double[] temp_arr = new double[size];
  Random rand = new Random();
  for (int i = 0; i < size; i++)
  {
    temp_arr[i] = Math.Round(rand.Next(leftBorder, rightBorder + 1) + rand.NextDouble(), 2);
  }
  return temp_arr;
}
void Print_Arr(double[] arr)
{
  System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}
void FindMaxAndMin(double[] arr, out double max_num, out double min_num)
{

  max_num = arr[1];
  min_num = arr[0];
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] > max_num)
    {
      max_num = arr[i];
    }
    if (min_num > arr[i])
    {
      min_num = arr[i];
    }
  }


}
Main();
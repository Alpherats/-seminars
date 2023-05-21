// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void Main()
{
  int[] arr = GenerateArr(7, 1, 99);
  Print_Arr(arr);
  SumOfOddElem(arr);
}


int[] GenerateArr(int size, int leftBorder, int rightBorder)
{
  int[] temp_arr = new int[size];
  Random rand = new Random();
  for (int i = 0; i < size; i++)
  {
    temp_arr[i] = rand.Next(leftBorder, rightBorder + 1);
  }
  return temp_arr;
}


int SumOfOddElem(int[] arr)
{
  int sum_of_odd_elem = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (i % 2 == 1)
    {
      sum_of_odd_elem += arr[i];
    }
  }
  System.Console.WriteLine(sum_of_odd_elem);
  return sum_of_odd_elem;
}


void Print_Arr(int[] arr)
{
  System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

Main();
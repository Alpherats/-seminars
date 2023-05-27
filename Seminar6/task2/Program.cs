//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
void Main()
{

  int[] arr = new int[4] { ReadInt("Insert b1: "), ReadInt("Insert k1: "), ReadInt("Insert b2: "), ReadInt("Insert k2: ") };
  FindXAndY(2, 5, 4, 9);

}


int ReadInt(string text)
{
  System.Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}


void FindXAndY(double b1, double k1, double b2, double k2)
{
  double[] temp_arr = new double[2];
  temp_arr[0] = (b2 - b1) / (k1 - k2);
  temp_arr[1] = k1 * temp_arr[0] + b1;
  System.Console.WriteLine($"({temp_arr[0]},{temp_arr[1]})");
}
Main();
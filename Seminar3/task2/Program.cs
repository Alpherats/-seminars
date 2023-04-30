// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

int ReadInt(string text)
{
  System.Console.Write(text);
  return Convert.ToInt32(System.Console.ReadLine());
}

double CalcDist(int[] arr1, int[] arr2)
{
  
  double dist =Math.Round(Math.Sqrt(Math.Pow((arr2[0]-arr1[0]),2) + Math.Pow((arr2[1]-arr1[1]),2) + Math.Pow((arr2[2]-arr1[2]),2)),2);
  return dist;
}


int[] first_coord = new int [3];

first_coord[0] = ReadInt("Insert X of the first coord ");
first_coord[1] = ReadInt("Insert Y of the first coord ");
first_coord[2] = ReadInt("Insert Z of the first coord ");

int[] second_coord = new int [3];

second_coord[0] = ReadInt("Insert X of the second coord ");
second_coord[1] = ReadInt("Insert Y of the second coord ");
second_coord[2] = ReadInt("Insert Z of the second coord ");

System.Console.WriteLine(CalcDist(first_coord,second_coord));
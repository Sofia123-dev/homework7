// Задача 47.
// void FillArray(double[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       double tmp = Math.Round(new Random().NextDouble(), 2);
//       array [i,j] = Math.Round(tmp * (10 + 20)-10, 2); 
//     }
// }

// void PrintArray(double[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//       Console.Write($"{array[i, j],3} \t");
//     Console.WriteLine();
//   }
// }

// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// double[,] array = new double[rows, cols];
// FillArray(array);
// PrintArray(array);
// Console.WriteLine();


// Задача 50.
void FillArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
      array[i, j] = new Random().Next(-20, 20);
}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      Console.Write($"{array[i, j],3} \t");
    Console.WriteLine();
  }
}

// string Foundel(int [,] array, int el)
// {
//   string result = $"{el} -> такого элемента нет";
//    for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       if (array [i,j] == el) result=$"положение элемента {el}: cтрока - {i}, столбик - {j}";
//     }
//   }
//   return result;
// }

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[rows, cols];
// FillArray(array);
// PrintArray(array);
// Console.Write("Введите искомое число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Foundel(array,num));



// Задача 52
string SumRows(int [,] array)
{
  double tmp = Convert.ToDouble(array.GetLength(0));
  double [] array2 = new double [array.GetLength(1)];
  string result = $"среднее арифметическое каждого столбца: {string.Join(", ", array2)} ";
   for (int i = 0; i < array.GetLength(1); i++)
  {
    for (int j = 0; j < array.GetLength(0); j++)
    {
      array2 [i] += array [j,i]/tmp;
    }
  }
  result = $"среднее арифметическое каждого столбца: {string.Join(", ", array2)} ";
  return result;
}
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
Console.WriteLine(SumRows(array));
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
Console.WriteLine("Введите количество строк массива");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int cols = int.Parse(Console.ReadLine());

int[,] resultMatrix = GetMatrix(rows, cols);  
Console.WriteLine("Осходный двумерный массив");
PrintMatrix(resultMatrix);

Console.WriteLine("Построчно упорядоченный по убыванию двумерный массив");
StreamLineArray(resultMatrix);
PrintMatrix(resultMatrix);

/// <summary>
/// Этот медод заполняет массив рандомными числами от 1 до 9
/// </summary>
/// <param name="rows">количество строк</param>
/// <param name="cols">количество столбцов</param>
/// <returns>заполненный двумерный массив целых чисел</returns>
int[,] GetMatrix(int rows, int cols)
{
  int[,] matrix = new int[rows, cols];
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < cols; j++)
    {
      matrix[i, j] = new Random().Next(10);
    }
  }
  return matrix;
}

/// <summary>
/// Этот метод печатает заполненный массив который передали на вход
/// </summary>
/// <param name="matr">двумерный массив</param>
void PrintMatrix(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      Console.Write(matr[i, j] + "\t");
    }
    Console.WriteLine();
  }
}

/// <summary>
/// Метод построчно распределяет числа по убыванию
/// </summary>
/// <param name="result">двумерный массив</param>
void StreamLineArray(int[,] result)
{
  for (int i = 0; i < result.GetLength(0); i++)
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
      for (int k = 0; k < result.GetLength(1) - 1; k++)
      {
      if (result[i, k] < result[i, k + 1])
      {
        int max = result[i, k + 1];
        result[i, k + 1] = result[i, k];
        result[i, k] = max;
      }
      }
    }
  }
}


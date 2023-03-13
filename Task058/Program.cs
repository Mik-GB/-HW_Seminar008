// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.Clear();
Console.WriteLine("Введите число строк первой матрицы");
int firstRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов первой матрицы");
int firstCols = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число строк второй матрицы");
int secondRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов второй матрицы");
int secondCols = Convert.ToInt32(Console.ReadLine());

int[,] firstResultMatrix = FirstGetMatrix(firstRows, firstCols);
Console.WriteLine("Первая матрица:");
PrintMatrix(firstResultMatrix);
int[,] secondResultMatrix = FirstGetMatrix(secondRows, secondCols);
Console.WriteLine("Вторая матрица:");
PrintMatrix(secondResultMatrix);

if (firstCols != secondRows)
{
  Console.WriteLine("Умножение матриц невозможно");
  return;
}

int[,] prodResultMatrix = ProductMatrix(firstResultMatrix, secondResultMatrix);
Console.WriteLine("Матрица произведений:");
PrintMatrix(prodResultMatrix);
/// <summary>
/// Создание первой двумерной матрицы с рандомными числами от 1 до 9
/// </summary>
/// <param name="firstRows">число строк первой матрицы</param>
/// <param name="firstCols">число столбцов первой матрицы</param>
/// <returns>заполненный массив первой матрицы</returns>
int[,] FirstGetMatrix(int firstRows, int firstCols)
{
  int[,] firstMatrix = new int[firstRows, firstCols];
  for (int i = 0; i < firstRows; i++)
  {
    for (int j = 0; j < firstCols; j++)
    {
      firstMatrix[i, j] = new Random().Next(1, 10);
    }
  }
  return firstMatrix;
}
/// <summary>
/// Создание второй двумерной матрицы с рандомными числами от 1 до 9
/// </summary>
/// <param name="secondRows">число строк второй матрицы</param>
/// <param name="secondtCols">число столбцов второй матрицы</param>
/// <returns>заполненный массив второй матрицы</returns>
int[,] SecondGetMatrix(int secondRows, int secondtCols)
{
  int[,] secondMatrix = new int[secondRows, secondCols];
  for (int i = 0; i < secondRows; i++)
  {
    for (int j = 0; j < secondCols; j++)
    {
      secondMatrix[i, j] = new Random().Next(1, 10);
    }
  }
  return secondMatrix;
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
/// Метод считает произведение двух двумерных матриц
/// </summary>
/// <param name="firstMatr">Первая матрица</param>
/// <param name="secondMatr">Вторая матрица</param>
/// <returns>Матрица произведение</returns>
int[,] ProductMatrix(int[,] firstMatr, int[,] secondMatr)
{
  int[,] prodMatrix = new int[firstMatr.GetLength(0), secondMatr.GetLength(1)];
  for (int i = 0; i < prodMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < prodMatrix.GetLength(1); j++)
    {
      for (int n = 0; n < firstMatr.GetLength(1); n++)
      {
        prodMatrix[i, j] += firstMatr[i, n] * secondMatr[n, j];
      }
    }
  }
  return prodMatrix;
}

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите количество строк массива");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int cols = int.Parse(Console.ReadLine());

if (rows == cols)
{
  Console.WriteLine("Задан не прямоугольный массив");
  return;
}

int[,] resultMatrix = GetMatrix(rows, cols);
Console.WriteLine("Осходный двумерный массив");
PrintMatrix(resultMatrix);
NumberMinLineArray(resultMatrix);

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
/// Этот метод проверяет суммы строк в двумерной массиве и распознает минимальную сумму строк
/// </summary>
/// <param name="array">двумерный массив</param>
void NumberMinLineArray(int[,] array)
{
  int minRow = 0;
  int minSumRow = 0;
  int sumRow = 0;
  for (int j = 0; j < array.GetLength(1); j++)
  {
    minRow += array[0, j];
  }
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++) 
    {
      sumRow += array[i, j];
    }
    if (sumRow < minRow)
    {
      minRow = sumRow;
      minSumRow = i;
    }
    sumRow = 0;
  }
  Console.Write($"Наименьшая сумма элементов на {minSumRow + 1} строке");
}

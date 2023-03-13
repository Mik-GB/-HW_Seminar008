// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("Введите количество строк матрицы");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы");
int cols = int.Parse(Console.ReadLine());
Console.WriteLine("Введите глубину массива");
int deep = int.Parse(Console.ReadLine());

int[,,] resultMatrix = GetMatrix(rows, cols, deep);
Console.WriteLine("Осходный двумерный массив");
PrintMatrix(resultMatrix);

/// <summary>
/// Заполняет трехмерную матрицы случайными числами от 1 до9
/// </summary>
/// <param name="rows">кол-во строк</param>
/// <param name="cols">кол-во столбцов</param>
/// <param name="deep">глубина матрицы</param>
/// <returns>Трехмерная матрица</returns>
int[,,] GetMatrix(int rows, int cols, int deep)
{
  int[,,] matrix = new int[rows, cols, deep];
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < cols; j++)
    {
      for (int k = 0; k < deep; k++)
      {
        matrix[i, j, k] = new Random().Next(10);
      }
    }
  }
  return matrix;
}

/// <summary>
/// Этот метод печатает заполненный массив который передали на вход
/// </summary>
/// <param name="matr">трехмерная матрица</param>
void PrintMatrix(int[,,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      for (int k = 0; k < matr.GetLength(2); k++)
      {
        Console.Write($"{matr[i, j, k]}({i},{j},{k}) \t");
      }
    }
    Console.WriteLine();
  }
}
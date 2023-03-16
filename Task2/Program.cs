// Задача 48: Задайте двумерный массив 
// размера m на n, каждый элемент в массиве
//  находится по формуле: Aₘₙ = m+n. 
//  Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


int Promt(string message)
{
  Console.WriteLine(message);
  int num = Convert.ToInt32(Console.ReadLine());
  return num;
}

int[,] CreateOutputArray(int m, int n)
{
  int[,] matrix = new int[m, n];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = i+j;
      Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
  }
  return matrix;
}

int m = Promt ("Введите количество строк: ");
int n = Promt ("Введите количество столбцов: ");

CreateOutputArray(m, n);



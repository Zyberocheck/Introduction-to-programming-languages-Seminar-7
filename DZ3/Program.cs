// Задача 52. Задайте двумерный массив из
// целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int InPutNumber(string message)
{
  Console.WriteLine(message);
  int num = Convert.ToInt32(Console.ReadLine());
  return num;
}


int m = InPutNumber("Введите количество строк: ");
int n = InPutNumber("Введите количество столбцов: ");


int[,] CreateArray(int m, int n)
{
  int[,] matrix = new int[m, n];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(1, 10);
    }
    Console.WriteLine();
  }
  return matrix;
}


int [,] PrintArray(int [,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
  }
  return matrix;
}


void ArithmeticMath (int [,] matrix)
{
   for (int j = 0; j < matrix.GetLength(1); j++)
  {
    double poi = 0;    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
    poi= poi + matrix[i,j];
    }
    Console.Write($"{ poi / matrix.GetLength(0)}   ");    
  }  
}

int [,] matrix = CreateArray(m,n);
PrintArray (matrix);
Console.WriteLine();
ArithmeticMath(matrix);




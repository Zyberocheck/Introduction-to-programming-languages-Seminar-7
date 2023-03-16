// Решение в группах задач:
// Задача 49: Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса
//  чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4




// int Promt(string message)
// {
//   Console.WriteLine(message);
//   int num = Convert.ToInt32(Console.ReadLine());
//   return num;
// }

// int[,] CreateOutputArray(int m, int n)
// {
//   int[,] matrix = new int[m, n];
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       matrix[i, j] = new Random().Next(1, 10);
//       Console.Write(matrix[i, j] + " ");
//     }
//     Console.WriteLine();
//   }
//   Console.WriteLine();
//   return matrix;
// }

// int[,] CreateNewArray(int [,] matrix)
// {
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       if (i%2 ==0 && j%2 == 0)
//       matrix[i, j] = matrix[i, j]*matrix[i, j];
//       Console.Write(matrix[i, j] + " ");
//     }
//     Console.WriteLine();
//   }
//   return matrix;
// }


// CreateNewArray(CreateOutputArray(3, 4));


// Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на 
// главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


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
      matrix[i, j] = new Random().Next(1, 10);
      Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
  }
  Console.WriteLine();
  return matrix;
}

int SumOfElements(int [,] matrix)
{ 
    int sum =0;
  
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (i==j)
      sum+=matrix[i,j];
    }
    }
  return sum;
}


Console.WriteLine(SumOfElements(CreateOutputArray(3, 4)));

// int SummOfElements(int [,] matrix)
//  {
//   int sum = 0;
//   for (int i = 0, j = 0; i < matrix.GetLength(0) && j < matrix.GetLength(1); i++, j++)
//   sum += matrix[i, j];
//   return sum;
//   }    // таже запись но кароче

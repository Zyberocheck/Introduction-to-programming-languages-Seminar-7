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
//       if (i%2 == 0 && j%2 == 0)
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

// int SumOfElements(int [,] matrix)
// { 
//     int sum =0;
  
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       // if (i==j)
//       sum+=matrix[i,j];
//     }
//     }
//   return sum;
// }


// Console.WriteLine(SumOfElements(CreateOutputArray(3, 4)));






// int SummOfElements(int [,] matrix)
//  {
//   int sum = 0;
//   for (int i = 0, j = 0; i < matrix.GetLength(0) && j < matrix.GetLength(1); i++, j++)
//   sum += matrix[i, j];
//   return sum;
//   }    // таже запись но кароче


int [,] CreateArray()
{
  int m = new Random().Next(2, 4);
  int n = new Random().Next(2, 4);
  int [,] matrix = new int [m, n];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(1, 10);
    }
  
  }
  return matrix;
}


int [,] PrintArray(int [,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
            Console.Write(matrix[i, j] + "\t");
    }
  Console.WriteLine();
  }
  return matrix;
}


int [] Array(int [,] matrix)
{
  int k =0;
  int [] newArray = new int [matrix.GetLength(0)*matrix.GetLength(1)];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
     for (int j = 0; j < matrix.GetLength(1); j++)
    {
      newArray[k]= matrix [i,j];
      k++;
     }
  }
  return newArray;
}


int [] SortArray(int [] array)
{
    for (int i = 0; i < array.Length - 1; i++)
{
    int minPosition = i;
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[j] < array [minPosition])
        {
            minPosition = j;
        }
    }
    int temp = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temp;
}
return array;
}

int [,] matrix = CreateArray();
PrintArray (matrix);
Console.WriteLine();
int [] newArray = Array(matrix);
Console.WriteLine(String.Join(", ", newArray));
SortArray(newArray);
Console.WriteLine(String.Join(", ", newArray));

// --------------------------------------------------------------------------

// int el = newArray[0];
// int count = 1;
// for (int i = 1; i < newArray.Length; i++)
// {
//     if (el == newArray[i])
//     {
//       count ++;
//     }
//     else
//     {
//       Console.WriteLine($"Число {el} встречается в массиве {count} раз");
//       count = 1;
//       el = newArray[i];
//     }
// }
// Console.WriteLine($"Число {el} встречается в массиве {count} раз");


// это с семинара
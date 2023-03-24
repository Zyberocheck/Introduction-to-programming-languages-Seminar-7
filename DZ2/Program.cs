// Задача 50. Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же 
// указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int InPutNumber(string message)
{
  Console.WriteLine(message);
  int num = Convert.ToInt32(Console.ReadLine());
  return num;
}

int m = InPutNumber("Введите количество строк: ");
int n = InPutNumber("Введите количество столбцов: ");
int numIsk = InPutNumber ("Введите искомое: ");
Console.WriteLine();


int[,] CreateArray(int m, int n)
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


void SearchNumberInArray(int numIsk, int [,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (numIsk == matrix[i,j])
      {
      Console.WriteLine("Такое число есть");
       return;
      }
    }
   
    
  }
   System.Console.WriteLine("Такого числа нет");
 
}

int[,] matrixa = CreateArray(m, n);


Console.WriteLine();
SearchNumberInArray(numIsk,matrixa);




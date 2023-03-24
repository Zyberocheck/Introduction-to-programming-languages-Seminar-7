// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


double[,] CreateOutputArray (int m, int n)
{
    double[,] randarray = new double[ m,n];
    for (int i = 0; i < randarray.GetLength(0); i++)
    {
        for (int j = 0; j < randarray.GetLength(1); j++)
        {
            randarray[i,j] = new Random().NextDouble();
            randarray[i,j] = Math.Round(randarray[i,j] * 10, 1);
            Console.Write(randarray[i,j] + "   ");
        }  
        Console.WriteLine();
        Console.WriteLine();
    }
    return randarray;
}

CreateOutputArray(3,4);




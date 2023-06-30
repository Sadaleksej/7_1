// See https://aka.ms/new-console-template for more information
using System;
using static System.Console;

Clear();
double[,] arrr = new double[6,6];
FilArray(arrr);
PrintArray(arrr);
WriteLine();
//CompareArray(arrr);
//PrintArray(arrr);
//Console.WriteLine();
//Console.WriteLine($"Сумма элементов на нечетных позициях: {SumUnEven(arrr)}");

void FilArray(double[,] ar)
{
 Random rnd = new Random();
    for (int i = 0; i < ar.GetLength(0); i++) 
    {
         for (int j = 0; j < ar.GetLength(1); j++) 
         {
             ar[i,j] = rnd.NextDouble() * 200-100;
         }
    }
}




void PrintArray(double[,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++) 
    {
         for (int j = 0; j < ar.GetLength(1); j++) Write(string.Format("{0:F2}", ar[i,j])+" ");
    WriteLine();
    }
WriteLine();
}
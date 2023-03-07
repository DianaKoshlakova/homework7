// Напишите программу, которая на вход принимает позиции 
//элемента в двумерном массиве, и возвращает значение этого
// элемента или же указание, что такого элемента нет.

using System;
using static System.Console;

Write("Введите индекс строки: ");
int rows=int.Parse(ReadLine());

Write("Введите индекс колонки: ");
int columns=int.Parse(ReadLine());

int[,] numbers = new int[3 , 10];
FillArray(numbers);
PrintArray(numbers);

if (rows < numbers.GetLength(0) && columns < numbers.GetLength(1)) Console.WriteLine(numbers[rows, columns]);
else Console.WriteLine($"{rows}{columns} -> такого числа в массиве нет");

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
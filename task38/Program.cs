// Задача 38.
//Заполнить одномерный массив вещественных чисел и найти сумму максимального и минимального элементов

using System;

int size = 4;
double[] array = new double[4];
Random myRandom = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = Math.Round(myRandom.NextDouble() * 100, 2);
    Console.Write("{0} ", array[i]);
}


double max = array[0];
double min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max){
        max = array[i];
    }
    else if (array[i] < min){
        min = array[i];
    }
}

double sum = max + min;
Console.Write(" -> {0} ", sum);

Console.WriteLine();
Console.ReadKey();
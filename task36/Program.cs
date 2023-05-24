// Задача 36.
//Заполнить одномерный массив случайными числами и найти сумму элементов на нечётных позициях


int size = 4;
int[] array = new int[4];
Random myRandom = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = myRandom.Next(0, 100);
    Console.Write("{0} ", array[i]);
}

int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0){
        sum += array[i];
    }
}

Console.Write(" -> {0} ", sum);

Console.WriteLine();
Console.ReadKey();
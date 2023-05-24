// Задача 34.
//Заполнить одномерный массив случайными трёххначными числами и вывести количество чётных среди них


int size = 4;
int[] array = new int[4];
Random myRandom = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = myRandom.Next(100, 999);
    Console.Write("{0} ", array[i]);
}

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0){
        count += 1;
    }
}

Console.Write(" -> {0} ", count);

Console.WriteLine();
Console.ReadKey();

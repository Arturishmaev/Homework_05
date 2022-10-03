//Задача 34: Задайте массив заполненный случайными положит. трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве
//[345, 897, 568, 234] -> 2



void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {

        System.Console.Write($" [{array[i]}] ");
    }

}

int[] array = new int[5];
FillArray(array);
PrintArray(array);

int plus = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        plus += 1;

    }
}
System.Console.WriteLine();
System.Console.WriteLine($"Количество четных элементов в массиве : {plus}");



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
}

void PrintArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {

        System.Console.Write($" [{array[i]}] ");
    }

}


int sum =0;
int[] array = new int[10];
FillArray(array);
PrintArray(array);

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 != 0)
    {
        sum += array[i];

    }
}
System.Console.WriteLine();
System.Console.WriteLine($"Сумма нечетных элементов в массиве : {sum}");



//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 11);
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {

        System.Console.Write($" [{array[i]}] ");
    }
}

double[] array = new double[5];

FillArray(array);
PrintArray(array);

double minValue = array.Min();
double maxValue = array.Max();
double result = maxValue - minValue;


System.Console.WriteLine();
System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива : {result}");
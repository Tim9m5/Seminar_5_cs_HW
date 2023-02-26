// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

/*
Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = GetArray(size, 100, 999);
Console.WriteLine($"Массив: [ {String.Join("; ", array)} ] ");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue +1);
    }
    return result;
}

int count = 0;
int size1 = array.Length;
for (int i = 0; i < size1; i++)
{
    if (array[i] % 2 == 0)
    {
    count = count + 1;
    }
}
Console.WriteLine($"Количество четных чисел в массиве: {count}");
*/

//----------------------------------------------------------------------

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
/*
Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите min элемент массива: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите max элемент массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] array = GetArray(size, minValue, maxValue);
Console.WriteLine($"Массив: [ {String.Join("; ", array)} ] ");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue +1);
    }
    return result;
}

int sum = 0;
int size1 = array.Length;
for (int i = 0; i < size1; i++)
{
    if (i % 2 != 0)
    {
    sum = sum + array[i];
    }
}
Console.WriteLine($"Сумма элементов на нечетных позициях в массиве: {sum}");
*/

//----------------------------------------------------------------------------

// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
/*
Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] array = GetArray(size, 0, 1);
Console.WriteLine($"Массив: [ {String.Join("; ", array)} ] ");

double[] GetArray(int size, double minValue, double maxValue)
{
    double[] result = new double[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = (new Random().NextDouble());
    }
    return result;
}

double max = 0;
double min = 1;
int size1 = array.Length;
for (int i = 0; i < size1; i++)
{
    if (max < array[i])
    {
        max = array[i];
    }
    
}

for (int i = 0; i < size1; i++)
{
    if (min > array[i])
    {
        min = array[i];
    }
}

Console.WriteLine($"Разница между максимальным {max} и минимальным {min} элементом массива равна {max - min}");
*/

//---------------------------------------------------------------------------------------------------------------
// Черновик
/*
Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите min элемент массива: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите max элемент массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] array = GetArray(size, minValue, maxValue);
Console.WriteLine($"Массив: [ {String.Join("; ", array)} ] ");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue +1);
    }
    return result;
}

int max = minValue;
int min = maxValue;
int size1 = array.Length;
for (int i = 0; i < size1; i++)
{
    if (max < array[i])
    {
        max = array[i];
    }
    
}

for (int i = 0; i < size1; i++)
{
    if (min > array[i])
    {
        min = array[i];
    }
}


Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {max - min}");
*/

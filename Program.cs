// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


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

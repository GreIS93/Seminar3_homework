// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива


void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-9, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}

void SumOfPositive(int[] arr)
{
    int count = arr.Length;
    int index = 0;
    int sum = 0;
    while (index < count)
    {
        if (arr[index] > 0)
        {
            sum = sum + arr[index];
            index++;
        }
        else index++;
    }
    Console.WriteLine("Сумма положительных элементов массива = " + sum);
}

void SumOfNegative(int[] arr2)
{
    int count = arr2.Length;
    int index = 0;
    int sum = 0;
    while (index < count)
    {
        if (arr2[index] < 0)
        {
            sum = sum + arr2[index];
            index++;
        }
        else index++;
    }
    Console.WriteLine("Сумма отрицательных элементов массива = " + sum);
}

int[] array = new int[12];

FillArray(array);
PrintArray(array);
Console.WriteLine();

SumOfPositive(array);
SumOfNegative(array);
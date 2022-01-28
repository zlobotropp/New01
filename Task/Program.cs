﻿int[] CreateArray(int count) // Метод создания массива
{
    return new int[count];
}
void FillArray(int[] array, int minValue, int maxValue) // метод заполнения массива
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
}
string PrintArray(int[] array) // метод печати массива
{
    int count = array.Length;
    string res = String.Empty;
    for (int i = 0; i < count; i++)
    {
        res += $"{array[i]} ";
    }
    return res;
}

int[] EvenNumbers(int[] array)// метод создания другого массива на основе первого, состоящего из чётных чисел
{
    int[] arrayB = new int[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            arrayB[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref arrayB, count);
    return arrayB;
}

int[] array = CreateArray(10); // создаем массив
FillArray(array,-500,500); // заполняем массив
Console.WriteLine(PrintArray(array)); //печатаем начальный массив
Console.WriteLine(PrintArray(EvenNumbers(array))); // печатаем массив на основе первого, но только чётнеых числа


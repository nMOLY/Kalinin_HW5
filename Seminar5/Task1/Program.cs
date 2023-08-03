//Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Введите размерность массива ");
int length = int.Parse(Console.ReadLine());
int[] array = SetArray(length);
GetArray(array);
Console.WriteLine("");
if (GetEvenNumbers(array) == 0) Console.WriteLine("В массиве нет четных чисел");
else Console.WriteLine($"Количестве четных чисел в массиве равно {GetEvenNumbers(array)}");

int[] SetArray(int length)
{
    int[] array= new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void GetArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int GetEvenNumbers(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}
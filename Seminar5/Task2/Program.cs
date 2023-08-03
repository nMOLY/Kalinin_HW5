//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Введите размерность массива ");
int length = int.Parse(Console.ReadLine());
int[] array = SetArray(length);
GetArray(array);
Console.WriteLine("");
Console.Write($"Сумма элементов массива, стоящих на нечетной позиции равна {GetSumOfOddPositionNumbers(array)}");

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

int GetSumOfOddPositionNumbers(int[] array)
{
    int sum = 0;
    for (int i=0; i<array.Length; i++)
    {
        if (i % 2 == 1) sum += array[i];
    }
    return sum;
}
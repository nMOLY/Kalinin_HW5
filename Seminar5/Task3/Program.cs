//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите размерность массива ");
int length = int.Parse(Console.ReadLine());
double[] array = SetArray(length);
GetArray(array);
Console.WriteLine("");
Console.Write($"Разница между максимальным и минимальным числом из массива равна {MinMaxArrayValueDifference(array)}");

double[] SetArray(int length)
{
    double[] array= new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = Math.Round((new Random().NextDouble()*1000), 2);
    }
    return array;
}

void GetArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

double MinMaxArrayValueDifference(double[] array)
{
    double min = array[0];
    double max = array[1];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i]) min = array[i];
        if (max < array[i]) max = array[i];
    }
    return Math.Round((max-min), 2);
}

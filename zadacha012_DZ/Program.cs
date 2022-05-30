/*
Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

int NeedIntNumberForLengthOfArray() // метод, который просит пользователя ввести число >0 и проверяет его на int (для размерности массива)
{
    bool temp = true;
    int result = 0;
    while (temp)
    {
        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            temp = false;
        }
        else Console.WriteLine("Ошибка! Вы ввели не число. Или отрицательное число. Введите число: ");
    }
    return result;
}

void PrintArray(double[] arr) // метод который печатает массив на консоль
{
    foreach (int item in arr)
        Console.Write($"{item} ");
    Console.WriteLine();
}

double[] FillArrayRandom(int length) // метод, который заполняет массив случайными числами [99,100)
{
    double[] array = new double[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-99,100);
    }
    return array;
}

void Difference(double[] array) // метод который вычисляет разницу между максимальным и минимальным элементами массива
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    double diff = max - min;
    Console.WriteLine($"{max} - {min} = {diff}");
    Console.WriteLine($"Разница между максимальным элементом и минимальным = {diff}");
}


Console.Write("Введите размерность массива: ");
int length = NeedIntNumberForLengthOfArray();
double[] array = FillArrayRandom(length);
Console.Write($"Ваш массив -> ");
PrintArray(array);
Difference(array);
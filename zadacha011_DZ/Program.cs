/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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

void PrintArray(int[] arr) // метод который печатает массив на консоль
{
    foreach (int item in arr)
        Console.Write($"{item} ");
    Console.WriteLine();
}

int[] FillArrayRandom(int length) // метод, который заполняет массив случайными числами [1,100)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

void SumOfElements(int[] array) // метод, который считает сумму элементов в массиве, стоящих на нечётных позициях
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
        {
            sum += array[i];
        }
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sum}");
}

Console.Write("Введите размерность массива: ");
int length = NeedIntNumberForLengthOfArray();
int[] array = FillArrayRandom(length);
Console.Write($"Ваш массив -> ");
PrintArray(array);
SumOfElements(array);
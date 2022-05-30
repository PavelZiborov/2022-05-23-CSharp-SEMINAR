/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int NeedIntNumberForLengthOfArray() // метод, который просит пользователя ввести число >0 и проверяет его на int
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

int[] FillArrayRandom(int length) // метод, который заполняет массив случайными положительными трёхзначными числами
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void FindParityNumberInArray(int[] array) // метод, который ищет и печатает количество четных чисел в массиве
{
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            quantity += 1; // quantity = quantity + 1
    }
    Console.WriteLine($"Количество четных чисел = {quantity}");
}

Console.Write("Введите размерность массива: ");
int length = NeedIntNumberForLengthOfArray();
int[] array = FillArrayRandom(length);
Console.Write($"Ваш массив -> ");
PrintArray(array);
FindParityNumberInArray(array);
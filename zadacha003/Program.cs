/*
Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/


int NeedIntNumber() // метод который проверяет число на int
{
    bool temp = true;
    int result = 0;
    while (temp)
    {
        if (int.TryParse(Console.ReadLine(), out result))
        {
            temp = false;
        }
        else Console.WriteLine("Ошибка! Вы ввели не число. Введите число: ");
    }
    return result;
}

void PrintArray(int[] arr) // метод который печатает массив на консоль
{
    foreach (int item in arr)
        Console.Write($"{item} ");
}

int[] FillArrayManually(int length) // метод который заполняет массив элементами вручную
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива №{i + 1}: ");
        array[i] = NeedIntNumber();
    }
    return array;
}

void CheckingAvailabilityElementInArray(int[] array, int element) // метод который проверяет наличие элемента в массиве
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == element || array[i] == -element)
        {
            Console.WriteLine($"В этом массиве присутствует число {element}");
            return;
        }
    }
    Console.WriteLine($"В этом массиве нет числа {element}");
}

Console.WriteLine("Введите размерность массива:");
int length = NeedIntNumber();
int[] array = FillArrayManually(length);

Console.Write($"Ваш массив: ");
PrintArray(array);
Console.WriteLine();

Console.WriteLine("Какое число вы хотите найти в массиве?");
int element = NeedIntNumber();
CheckingAvailabilityElementInArray(array, element);
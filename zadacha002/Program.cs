/*
Напишите программу замена элементов массива:
положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/

int[] InitArray(int length) // метод который задает массив случайными числами от -9 до 9 
{
    int[] arr = new int[length];
    Random rnd = new Random();

    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(-9, 10); // [a,b)
    }
    return arr;
}

int[] ReplaceArray(int[] arr) // метод который заменяет положительные элементы на соответствующие отрицательные, и наоборот
{
    int[] negativeArray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        negativeArray[i] = arr[i] * -1;
    }
    return negativeArray;
}

void PrintArray(int[] arr) // метод который печатает массив
{
    foreach (int item in arr)
        Console.Write($"{item} ");
}

Console.WriteLine("Введите размерность массива:");
int length = int.Parse(Console.ReadLine());
int[] array1 = InitArray(length);
int[] array2 = ReplaceArray(array1);

Console.WriteLine("Массив:");
PrintArray(array1);
Console.WriteLine("");
Console.WriteLine("Полученный массив:");
PrintArray(array2);


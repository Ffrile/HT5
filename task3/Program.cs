// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

System.Console.WriteLine("Введите длину массива");
int length = Convert.ToInt32(Console.ReadLine());


int[] MakeNewArray(int length)
{
    int[] result = new int[length];

    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(0, 15);
    }
    return result;
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write(item + " ");
    }
}

int DiffBetween(int[] array)
{
    int min = array[0];
    int max = array[0];
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
        else if (array[i] > max)
        {

            max = array[i];
        }
        result = max - min;
    }
    return result;
}

int[] arr = MakeNewArray(length);
PrintArray(arr);
System.Console.WriteLine();
System.Console.WriteLine(DiffBetween(arr));
// // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// // [3, 7, 23, 12] -> 19

// // [-4, -6, 89, 6] -> 0


System.Console.WriteLine("Введите длину массива");
int length = Convert.ToInt32(Console.ReadLine());


int[] MakeNewArray(int length)
{
    int[] result = new int[length];

    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(-10, 10);
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

int SumOddNum(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            result += array[i];
        }
    }
    return result;
}
int[] arr = MakeNewArray(length);
PrintArray(arr);
System.Console.WriteLine();
System.Console.WriteLine(SumOddNum(arr));


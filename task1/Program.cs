// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


System.Console.WriteLine("Введите длину массива");
int length = Convert.ToInt32(Console.ReadLine());

int[] MakeNewArray(int length)
{
    int[] result = new int[length];

    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(100, 1000);
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

int NumberEven(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            result++;
        }
    }
    return result;
}


int[] arr = MakeNewArray(length);
PrintArray(arr);
System.Console.WriteLine(); // без этой строчки соединяет массив и кол-во четных значений может есть другой вариант???
System.Console.WriteLine(NumberEven(arr));


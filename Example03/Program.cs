// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.Clear();

Console.WriteLine("Введите длину массива");
int length = IntoInt();

if (length < 0)
{
    Console.WriteLine("Incorrect number");
    return;
}

Console.WriteLine("Введите элементы массива по порядку");

int[] arr = GetArray(length);
PrintArray(arr);


void PrintArray(int[] array)
{
    string message = string.Join(" ,", array);
    Console.WriteLine($"[{message}], ");
}



int[] GetArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        int element = IntoInt();
        array[i] = element;
    }
    return array;
}


int IntoInt()
{
    bool isParsed = int.TryParse(Console.ReadLine(), out int num);
    if (!isParsed || num < 1)
    {
        return -1;
    }
    else
    {
        return num;
    }
}

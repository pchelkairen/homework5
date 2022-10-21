// Поиск суммы элементов массива
int[] arr = {1,4,8,2};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i] } ");
    }
    Console.WriteLine();
}

PrintArray (arr);

int sum = arr.Sum();
Console.WriteLine($"Sum: {sum}");


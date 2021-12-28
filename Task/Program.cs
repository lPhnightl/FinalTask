
int[] FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 20);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

int[] FilterArray(int[] array)
{
    int[] arrOut = new int[array.Length];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) { arrOut[j] = array[i]; j++;}
    }
    Array.Resize(ref arrOut, j);
    return arrOut;
}

int[] arrTask = new int[20];
arrTask = FillArray(arrTask);
Console.WriteLine("Изначальный массив:");
PrintArray(arrTask);
Console.WriteLine();
Console.WriteLine("Отфильтрованный массив:");
PrintArray(FilterArray(arrTask));

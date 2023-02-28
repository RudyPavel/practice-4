int[] GenerateArray(int length)
{
    int[] a = new int[length];

    Random rnd = new Random();

    for (int i = 0; i < length; i++)
    {
        a[i] = rnd.Next(0, 100);
    }

    return a;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        Console.Write(' ');
    }

    Console.WriteLine();
}

int[] arr = GenerateArray(8);
PrintArray(arr);
int[] arr = new int[10];
Random rand = new Random();

for (int i = 0; i < 10; i++)
{
    arr[i] = rand.Next(1, 101);
}

Console.WriteLine("Массив:");
foreach(int num in arr)
{
    Console.Write(num + " ");
}

int count = 0;
for (int i = 0; i < 10; i++)
{
    if(arr[i] >= 20 && arr[i] <= 90)
    {
        count++;
    }
}
Console.WriteLine();
Console.WriteLine("Количество элементов в диапазоне [20, 90]: " + count);
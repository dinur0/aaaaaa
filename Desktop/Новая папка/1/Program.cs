Console.WriteLine("Введите кол-во строк: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int num2 = Convert.ToInt32(Console.ReadLine());
SortingArray(FillArray(num1, num2));

int[,] FillArray(int first, int second)
{
    int[,] array = new int[first, second];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 11);
            Console.Write(array[i, j] + "|");
        }
        Console.WriteLine();
    }
    return array;
}

void SortingArray(int[,] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1)-1; j++)
        {
            for (int k = j; k < arr.GetLength(1); k++)
            {
                if (arr[i, j] < arr[i, k])
                {
                    temp = arr[i, j];
                    arr[i, j] = arr[i, k];
                    arr[i, k] = temp;
                }
            }
        }
    }
Console.WriteLine("Ответ: ");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "|");
        }
        Console.WriteLine();
    }

}

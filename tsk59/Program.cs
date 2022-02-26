// Задача 59: В прямоугольной матрице найти строку с наименьшей суммой элементов.

Console.Clear();
Console.Write("Введите количество строк массива: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int y = int.Parse(Console.ReadLine());
int[,] arr = new int[x, y];

void FillArray()
{
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
}

void PrintArray()
{
    int n = FindLessRow();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        if (i == n - 1)
            Console.WriteLine($" <- Минимальная сумма значений содержится в строке № {n}");
        else
            Console.WriteLine();
    }
}

int FindLessRow()
{
    int[] min_row = new int[x];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            min_row[i] += arr[i, j];
        }
    }
    int min_indx = 0;
    int min_rw = min_row[0];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (min_rw > min_row[i])
        {
            min_indx = i;
            min_rw = min_row[i];
        }
    }
    return min_indx + 1;
}

FillArray();
PrintArray();
// Console.WriteLine($"Минимальная сумма значений содержится в строке № {FindLessRow()}");
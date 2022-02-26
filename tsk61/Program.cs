// Задача 61: Найти произведение двух матриц.

Console.Clear();
Console.Write("Введите количество строк массивов: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массивов: ");
int y = int.Parse(Console.ReadLine());
int[,,] arr = new int[x, y, 3];


void FillArray()
{
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j, 0] = new Random().Next(1, 10);
            arr[i, j, 1] = new Random().Next(1, 10);
        }
}

void PrintArray(int n)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j, n]} ");
        }
        Console.WriteLine();
    }
}

void ArrayMult()
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j,2] = arr[i,j,0] * arr[i,j,1];
        }
    }
}


FillArray();
PrintArray(0);
Console.WriteLine();
PrintArray(1);
Console.WriteLine();
ArrayMult();
Console.WriteLine("Произведение матриц:");
PrintArray(2);

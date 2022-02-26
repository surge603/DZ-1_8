// Задача 63: Сформировать трёхмерный массив с не повторяющимися двузначными числами и вывести его на экран построчно, с индексами элементов.

Console.Clear();
Console.Write("Введите x-размерность массива: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите y-размерность массива: ");
int y = int.Parse(Console.ReadLine());
Console.Write("Введите z-размерность массива: ");
int z = int.Parse(Console.ReadLine());
int[,,] arr = new int[x, y, z];
int[] arr2 = new int[x * y * z];


void FillArray()
{
    arr2[0] = new Random().Next(10, 100);
    for (int i = 1; i < arr.Length; i++)
    {
        bool found = true;
        int n;
        while (found)
        {
            n = new Random().Next(10, 100);
            found = false;
            for (int j = 0; j < i; j++)
            {
                if (n == arr2[j])
                {
                    found = true;
                }
            }
            if (!found) arr2[i] = n;
        }
    }
    int nn = 0;
    for (int i = 0; i < x; i++)
        for (int j = 0; j < y; j++)
            for (int k = 0; k < z; k++)
            {
                arr[i, j, k] = arr2[nn];
                nn++;
            }


}

void PrintArray()
{
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                Console.WriteLine($"Arr[{i},{j},{k}] = {arr[i, j, k]}");
            }
        }
    }
}


FillArray();
PrintArray();


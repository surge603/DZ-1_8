// Задача 65: Спирально заполнить двумерный массив:

Console.Clear();
Console.Write("Введите количество строк массива: ");
int y = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int x = int.Parse(Console.ReadLine());

int[,] arr = new int[x, y];
int full_box = x * y;
int step = 0;
int round = 0;

void PrintArray()
{
    for (int i = 0; i < y; i++)
    {
        for (int j = 0; j < x; j++)
        {
            if (arr[j, i] < 10) Console.Write('0');
            Console.Write($"{arr[j, i]} ");
        }
        Console.WriteLine();
    }
}

int direct = 0; //направление заполнения: 0-вправо, 1-вниз, 2-влево, 3-вверх

void FillArray()
{
    int xx = 0;
    int yy = 0;
    bool fill = true; // флаг, разрешающий заполнять очередную ячейку
    while (step < full_box)
    {
        if (fill)
        {
            step++;
            arr[xx, yy] = step;
        }
        // if (step == full_box) break; // если матрица
        if (direct == 0)
        {
            if (xx == x - 1)
            {
                direct = 1;
                fill = false;
            }
            else if (arr[xx + 1, yy] != 0)
            {
                direct = 1;
                fill = false;
            }
            else
            {
                xx++;
                fill = true;
            }
        }
        else if (direct == 1)
        {
            if (yy == y - 1)
            {
                direct = 2;
                fill = false;
            }
            else if (arr[xx, yy + 1] != 0)
            {
                direct = 2;
                fill = false;
            }
            else
            {
                yy++;
                fill = true;
            }
        }
        else if (direct == 2)
        {
            if (xx == 0)
            {
                direct = 3;
                fill = false;
            }
            else if (arr[xx - 1, yy] != 0)
            {
                direct = 3;
                fill = false;
            }
            else
            {
                xx--;
                fill = true;
            }

        }
        else if (direct == 3)
        {
            if (yy == 0)
            {
                direct = 0;
                fill = false;
            }
            else if (arr[xx, yy - 1] != 0)
            {
                direct = 0;
                fill = false;
            }
            else
            {
                yy--;
                fill = true;
            }
        }
    }
}

FillArray();
PrintArray();


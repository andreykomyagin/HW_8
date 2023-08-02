// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
void FillArray(int [,] matr)
{
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(1,10);
        }
    }
}

void PrintArray(int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void Task54()
{
    int n = Input("Введите количество строк: ");
    int m = Input("Введите количество столбцов: ");
    int maxPosition = 0;
    int [,] matr = new int [n,m];
    FillArray(matr);
    PrintArray(matr);
    Console.WriteLine();
    int tempr = 0;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m - 1; j++)
        {
            maxPosition = j;
            for (int k = j + 1; k < m; k++)
            {
                if ( matr[i, k] > matr[i, maxPosition] )
                {
                    maxPosition = k;
                }
            }
            tempr = matr [i, j];
            matr [i, j] = matr[i, maxPosition];
            matr[i, maxPosition] = tempr;
        }
    }
    PrintArray(matr);
}
Task54();
Console.WriteLine("Следующая задача!");
Console.WriteLine();

void Task56()
{
    int n = Input("Введите количество строк: ");
    int m = Input("Введите количество столбцов: ");
    int [,] matr = new int [n,m];
    FillArray(matr);
    PrintArray(matr);
    Console.WriteLine();
    int [] sum = new int [n];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            sum[i]= sum[i] + matr[i,j];
        }
    }

    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"{sum[i]} - {i}-ая строка");
    }
    Console.WriteLine();
    int min_sum = 0;
    for (int i =0; i < n; i++)
    {
        if(sum[i] < sum[min_sum] )
        {
            min_sum = i;
        }
    }
    Console.WriteLine($"{min_sum} - номер строки с наименьшей суммой");
}

Task56();
Console.WriteLine("Следующая задача!");
Console.WriteLine();
void Task58()
{
    int rows = 4;
    int colomns = 4;
    int [,] matr = new int [rows, colomns];
    int delta_i = 0;
    int delta_j = 1;
    int i = 0;
    int j = 0;
    int steps = colomns;
    int turns = 0;
    for (int k = 0; k < matr.Length; k++)
    {
        matr[i, j] = k + 1;
        steps--;
        if (steps == 0)
        {
            steps = rows - 1 -turns/2;
            turns++;
            int temp = -delta_i;
            delta_i = delta_j;
            delta_j = temp;
        }
        i += delta_i;
        j += delta_j;
    }
    PrintArray(matr);
}
Task58();
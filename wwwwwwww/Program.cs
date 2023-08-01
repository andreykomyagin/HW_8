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

//Task56();

void Task58()
{
    int [,] matr = new int [4,4];
    for (int i = 0; i < 4; i++)
    {
        matr[0,i] = i + 1;
    }
    for (int i = 1; i < 4 ; i ++)
    {
        matr[i, 3] = 4 + i;
    }
    for (int i = 2; i >=0; i = i - 1)
    {
        matr[3, i] = matr[3, i+1] + 1;
    }
    for (int i = 2; i >0; i= i -1)
    {
        matr[i,0] = matr[i+1,0] + 1;
    }
    for (int i = 1; i < 3; i++)
    {
        matr[1,i] = matr[1,i-1]+1;
    }
    for(int i = 2; i <=2; i++)
    {
        matr[i,2]= matr[i-1,2]+1;
    }
    for(int i = 1; i >=1; i=i-1)
    {
        matr[2,i]= matr[2,i+1]+1;
    }
    PrintArray(matr);
}
//Task58();
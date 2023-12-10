// Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] matrix()
{
    Random rand = new Random();
    int x = rand.Next(2, 10);
    int y = rand.Next(2, 10);
    int[,] matr = new int[x, y];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            matr[i, j] = rand.Next(-10, 10);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    Console.WriteLine("Матрица: ");
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + "   ");
        }
        Console.WriteLine();
    }
}

int[,] a = matrix();
PrintMatrix(a);

int[,] matrixch(int[,] m)
{
    int t = 0;
    for (int u = 0; u < m.GetLength(1); u++)
    {
        t = m[0, u];
        m[0, u] = m[m.GetLength(0)-1, u];
        m[m.GetLength(0)-1, u] = t;
    }
    return m;
}

int[,] b = matrixch(a);
PrintMatrix(b);
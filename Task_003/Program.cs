//Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int[,] matrix()
{
    Random rand = new Random();
    int x = rand.Next(1, 10);
    int y = rand.Next(1, 10);
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
int number = 0;
int searchsum(int[,] m)
{
    int min = 10000;
    for (int i = 0; i < m.GetLength(0); i++)
    {
        int s = 0;
        for (int j = 0; j < m.GetLength(1); j++)
        {
            s += m[i, j];
        }
        if (min > s)
        {
            min = s;
            number = i;
        }
    }
    return min;
}

Console.WriteLine(searchsum(a) + " " + number);
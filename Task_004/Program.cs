//Задача 4*(не обязательная): Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
//Под удалением понимается создание нового двумерного массива без строки и столбца
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
    Console.WriteLine("Матрица" + matr.GetLength(0) + "x" + matr.GetLength(1) + ": ");
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

int[,] dell(int[,] m)
{
    int x = 0;
    int y = 0;
    int[,] b = new int[m.GetLength(0) - 1, m.GetLength(1) - 1];
    int min = 10000;
    for (int i = 0; i < m.GetLength(0); i++)
    {
        int s = 0;
        for (int j = 0; j < m.GetLength(1); j++)
        {
            s = m[i, j];
            if (min > s)
            {
                min = s;
                x = i;
                y = j;
            }
        }
    }
    int c = 0;
    bool cc = true;
    for (int i = 0; i < m.GetLength(0); i++)
    {
        if (i == x && cc == true)
        {
            c += 1;
            cc = false;
        }
        else
        {
            int o = 0;
            bool oo = true;
            for (int j = 0; j < m.GetLength(1); j++)
            {
                if (j == y && oo == true)
                {
                    o += 1;
                    oo = false;
                }
                else
                {
                    b[i - c, j - o] = m[i, j];

                    //PrintMatrix(b);
                }
            }
        }
    }

    return b;
}
PrintMatrix(dell(a));
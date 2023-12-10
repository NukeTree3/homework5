//Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
int Input(string vvod)
{
    Console.Write(vvod);
    return Convert.ToInt32(Console.ReadLine());
}

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


void PositionPrint(int[,] matrix, int xpos, int ypos)
{
    int x = matrix.GetLength(0);
    int y = matrix.GetLength(1);
    if (xpos <= x-1 && ypos <= y-1 && xpos >= 0 && ypos >= 0)
    {
        Console.WriteLine(matrix[xpos, ypos]);
    }
    else
    {
        Console.WriteLine("такого элемета нет");
    }
}

int xpos = Input("Введите позицию x: ");
int ypos = Input("Введите позицию y: ");
int[,] a = matrix();
PrintMatrix(a);
PositionPrint(a, xpos, ypos);
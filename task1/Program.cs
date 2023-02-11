// Filling the picture

int[,] pic = new int[,]
{
    {0,0,1,0,0},
    {0,1,0,1,0},
    {1,0,0,0,1},
    {0,1,0,1,0},
    {0,0,1,0,0}
};

void PrintImage(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            // Console.Write(matrix[i, j] + " ");
            if (matrix[i, j] == 0) Console.Write(" ");
            else Console.Write("+");
        Console.WriteLine();
    }
}

void FillImage(int i, int j)
{
    if (pic[i, j] == 0)
    {
        pic[i, j] = 1;
        FillImage(i - 1, j);
        FillImage(i, j - 1);
        FillImage(i + 1, j);
        FillImage(i, j + 1);
    }
}

PrintImage(pic);
FillImage(1, 2);
PrintImage(pic);

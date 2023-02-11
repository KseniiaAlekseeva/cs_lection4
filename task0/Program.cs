string[,] table = new string[2, 5];

table[1, 2] = "word";

// for (int i = 0; i < matrix.GetLength(0); i++)
//     for (int j = 0; j < matrix.GetLength(1); j++)
//         Console.WriteLine(table[i, j]);


void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 10);
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + " ");
        Console.WriteLine();
    }
}

int[,] matr = new int[3, 4];
PrintArray(matr);
FillArray(matr);
Console.WriteLine();
PrintArray(matr);
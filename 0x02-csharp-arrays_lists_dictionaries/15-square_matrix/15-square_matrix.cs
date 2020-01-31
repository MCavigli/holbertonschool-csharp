using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        // int[,] newMatrix = new int;
        int[,] newMatrix = myMatrix.Clone() as int[,];
        for (int i = 0; i < myMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < myMatrix.GetLength(1); j++)
            {
                newMatrix[i, j] *= newMatrix[i, j];
            }
        }
        return newMatrix;
    }
}
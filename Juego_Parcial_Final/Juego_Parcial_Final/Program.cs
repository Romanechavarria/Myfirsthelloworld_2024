using System;

public class Program
{
    private static void Main(string[] args)
    {
        // Definir las dimensiones de la matriz 5x5
        int rows = 5;
        int cols = 5;

        // Crear la matriz
        int[,] matrix = new int[rows, cols];
        int currentRow = 0, currentCol = 0; // Iniciar en la posición (0,0)
        
        // Llenar la matriz con números aleatorios
        FillMatrix(matrix);

        // Mostrar la matriz inicial
        DisplayMatrix(matrix);

        // Esperar la tecla ESC para salir
        WaitForExit(matrix, ref currentRow, ref currentCol);
    }

    private static void FillMatrix(int[,] matrix)
    {
        Random random = new Random();

        // Llenar la matriz con números aleatorios entre 1 y 9
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = random.Next(1, 10); // Números aleatorios entre 1 y 9
            }
        }

        // Asegurarse de que el número base en la posición (0,0) sea 0
        matrix[0, 0] = 0;
    }

}

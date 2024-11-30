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

    }
}

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

    private static void DisplayMatrix(int[,] matrix)
    {
        Console.Clear();

        // Mostrar la matriz en consola
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                // Si estamos en la posición (0,0), pintamos en verde
                if (i == 0 && j == 0)
                {
                   
                    Console.Write($"{matrix[i, j]} ");
                   
                }
                else
                {
                    Console.Write($"{matrix[i, j]} ");
                }
            }
            Console.WriteLine();
        }
    }

    private static void WaitForExit(int[,] matrix, ref int currentRow, ref int currentCol)
    {
        // Mostrar un mensaje y esperar que el usuario mueva la "base" con las flechas
        Console.WriteLine("\nUsa las flechas para moverte. Presiona ESC para salir...");
        
        while (true)
        {
            // Esperar una tecla
            var key = Console.ReadKey(true).Key;

            // Si es ESC, salir
            if (key == ConsoleKey.Escape)
                break;

            // Realizar la operación según la tecla presionada
            if (key == ConsoleKey.RightArrow && currentCol < matrix.GetLength(1) - 1)
            {
                // Mover a la derecha: sumar el valor de la posición anterior con el actual
                matrix[currentRow, currentCol + 1] += matrix[currentRow, currentCol];
                matrix[currentRow, currentCol] = 0; // Poner en cero la posición anterior
                currentCol++; // Moverse a la nueva columna
            }
            else if (key == ConsoleKey.LeftArrow && currentCol > 0)
            {
                // Mover a la izquierda: sumar el valor de la posición anterior con el actual
                matrix[currentRow, currentCol - 1] += matrix[currentRow, currentCol];
                matrix[currentRow, currentCol] = 0; // Poner en cero la posición anterior
                currentCol--; // Moverse a la nueva columna
            }
            else if (key == ConsoleKey.UpArrow && currentRow > 0)
            {
                // Mover hacia arriba: sumar el valor de la posición anterior con el actual
                matrix[currentRow - 1, currentCol] += matrix[currentRow, currentCol];
                matrix[currentRow, currentCol] = 0; // Poner en cero la posición anterior
                currentRow--; // Moverse a la nueva fila
            }
            else if (key == ConsoleKey.DownArrow && currentRow < matrix.GetLength(0) - 1)
            {
                // Mover hacia abajo: sumar el valor de la posición anterior con el actual
                matrix[currentRow + 1, currentCol] += matrix[currentRow, currentCol];
                matrix[currentRow, currentCol] = 0; // Poner en cero la posición anterior
                currentRow++; // Moverse a la nueva fila
            }

            // Mostrar la matriz actualizada después de cada movimiento
            DisplayMatrix(matrix);


        }
    }
}

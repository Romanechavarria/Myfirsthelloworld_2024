using System;

public class Program
{
    private static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.Write("Ingrese el número de estudiantes: ");
            int numEstudiantes = Convert.ToInt32(Console.ReadLine());

            // Variables para contar ganadores y perdedores
            int ganadores = 0;
            int perdedores = 0;

            // Recorrer el número de estudiantes
            for (int i = 1; i <= numEstudiantes; i++)
            {
                Console.WriteLine($"\nEstudiante #{i}");

                // Ingresar las notas del estudiante
                Console.Write("Ingrese la cantidad de notas: ");
                int cantidadNotas = Convert.ToInt32(Console.ReadLine());
                double sumaNotas = 0;

                for (int j = 1; j <= cantidadNotas; j++)
                {
                    Console.Write($"Ingrese la nota #{j}: ");
                    double nota = Convert.ToDouble(Console.ReadLine());
                    sumaNotas += nota; // Sumar las notas
                }

                // Calcular el promedio
                double promedio = sumaNotas / cantidadNotas;

                // Clasificar al estudiante según su promedio
                string categoria;
                if (promedio >= 4.5)
                {
                    categoria = "Excelente";
                    ganadores++;
                }
                else if (promedio >= 4.0)
                {
                    categoria = "Sobresaliente";
                    ganadores++;
                }
                else if (promedio >= 3.5)
                {
                    categoria = "Bueno";
                    ganadores++;
                }
                else
                {
                    categoria = "Insuficiente";
                    perdedores++;
                }

                // Mostrar la categoría y el promedio
                Console.WriteLine($"El promedio del estudiante #{i} es: {promedio:F2} - Categoría: {categoria}");
            }

            // Mostrar la cantidad de ganadores y perdedores
            Console.WriteLine($"\nTotal de estudiantes ganadores: {ganadores}");
            Console.WriteLine($"Total de estudiantes perdedores: {perdedores}");

            // Preguntar si desea ingresar otro grupo de estudiantes
            Console.WriteLine("\n¿Desea ingresar otro grupo de estudiantes? (S/N)");
            string respuesta = Console.ReadLine().ToUpper();

            if (respuesta == "N")
            {
                continuar = false;
            }
        }
    }
}

using System;

public class Program
{
    private static void Main(string[] args)
    {
        bool continuar = true;  // controla si el juego se repite o no
        Random random = new Random(); // para generar numeros aleatorios 

        while (continuar)  // reinicia el juego mientras que continuar siga siendo verdadero
        {
            Console.Clear();
            Console.WriteLine("Bienvenidos al juego 'Adivina el número'!");

            int jugadores = 0;

            // Elegir el número de jugadores (mínimo 2 y máximo 4)
            do
            {
                Console.Write("Ingrese el número de jugadores (entre 2 y 4): ");
                jugadores = Convert.ToInt32(Console.ReadLine());
            } while (jugadores < 2 || jugadores > 4);  // se repite mientras el numero dejudadores este entre el rango

            // Definir el rango del numero secreto

            int rangoMax = jugadores switch
            {
                2 => 50,
                3 => 100,
                4 => 200,
                _ => 50
            };

            // Generar el número aleatorio en el rango establecido

            int numeroSecreto = random.Next(0, rangoMax + 1); // el numero secreto esta entre cero y 0 y rango maximo

            bool acertado = false;  // controlar si alguien adivino el numero 

           

            // Comienza el juego de adivinanza, este se repite hasta que alguiente adivine el numero
            while (!acertado)
            {
                for (int i = 1; i <= jugadores; i++)
                {
                    Console.WriteLine($"\nTurno del Jugador #{i}");
                    Console.Write("Ingrese un número: ");
                    int intento = Convert.ToInt32(Console.ReadLine());

                    // verifico si el numero ingresado es igual al numero secreto

                    if (intento == numeroSecreto)
                    {
                        Console.WriteLine("¡HAS GANADO!");
                        acertado = true;
                        break;
                    }
                    else if (intento > numeroSecreto)
                    {
                        Console.WriteLine("MENOR");
                    }
                    else
                    {
                        Console.WriteLine("MAYOR");
                    }
                }

                
            }

            // Preguntar si quieren jugar otra vez
            Console.WriteLine("\n¿Desean jugar otra vez? (S/N)");
            string respuesta = Console.ReadLine().ToUpper();

            if (respuesta == "N")
            {
                continuar = false;
            }
        }
    }
}
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        //Realizar un programa en C# que obtenga el promedio de calificaciones de un grupo de N alumnos.

        //variables de entrada
        int n;
        bool continuar = true;
        double calificacion, promedio, sumacalificaciones;
        string respuesta;

        while (continuar)
        {
            Console.WriteLine("ingrese el numero de estudiantes");
            n = Convert.ToInt32(Console.ReadLine());

            sumacalificaciones = 0;  // se reinicia la suma para cada grupo

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("ingrese la calificacion del alumno");
                calificacion = Convert.ToDouble(Console.ReadLine());

                // suma de caliaficaciones

                sumacalificaciones += calificacion;
            }

            //calcular el promedio

             promedio = sumacalificaciones / n;

            Console.WriteLine($"El promedio de las calificiones es: {promedio:F2}%");

            //preguntar si se quiere calcular para otro grupo
            Console.WriteLine("¿desea calcular el promedio de otro grupo de alumnos (S/N)");
            respuesta = Console.ReadLine().ToUpper();


           

            if (respuesta == "N")
            
            {
                continuar = false;
            }

            



        }

       
    }
}
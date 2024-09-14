using System;

public class Program
{
    private static void Main(string[] args)
    {
        /*Escriba un programa que pida los coeficientes de una ecuación de primer grado 
         (a x + b = 0) y muestre la solución.
        Una ecuación de primer grado puede no tener solución, tener una solución única, o que todos los números sean solución. La fórmula de las soluciones es x = -b / a*/

        // declatar variables

        double a, x, b;

        //pedir datos por pantalla
        Console.Write("ingrese el coeficiente a ");
        a = Convert.ToDouble(Console.ReadLine());

        Console.Write("ingrese el coeficiente b ");
        b = Convert.ToDouble(Console.ReadLine());

        Console.Write("ingrese el coeficiente x ");
        x = Convert.ToDouble(Console.ReadLine());

        // resolver la ecuacion
        if (a!= 0)
        {
            x = -b / a;

            Console.WriteLine($"la solucion de la ecuacion es: x = {x}");

        }
        else if (b == 0)

        {
            Console.WriteLine("todos los numeros son la solucion");
        }
        else
        {
            Console.WriteLine("la ecuancion no tiene solucion");
        }
    }
}
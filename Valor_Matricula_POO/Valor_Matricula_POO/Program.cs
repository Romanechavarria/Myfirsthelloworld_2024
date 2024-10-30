using EjercicioMatrícula;

public class Program
{
    private static void Main(string[] args)
    {
        /*Se desea obtener el valor de la matrícula de un estudiante cuyo valor se calcula de la siguiente manera:
· Si toma 20 o menos créditos, paga el crédito al valor normal.
· Si toma por encima de 20 créditos, se pagarán los créditos extras al doble de valor normal.
· Si el estudiante es de estrato 1, 2 o 3 recibe los siguientes descuentos:
- Si el estrato es 1, el descuento es del 80%.
- Si el estrato es 2, el descuento es del 50%.
- Si el estrato es 3, el descuento es del 30%.
Además, los estratos 1 y 2 reciben subsidio de alimentación y transporte de la siguiente manera:
· Para el estrato 1, el subsidio de alimentación y transporte es igual a $200.000.
· Para el estrato 2, el subsidio de alimentación y transporte es igual a $100.000.
Se debe informar al usuario sobre el costo de la matrícula y el valor del subsidio.
La aplicación debe preguntar al usuario si quiere volver al inicio o no para calcular la matrícula de un nuevo estudiante.
Hacer uso de todos los elementos de programación que hemos visto hasta el momento, incluyendoPOO (clases, propiedades, métodos)*/

        //solicitar datos al usuario

        bool continuar = true;

        while (continuar)
        {
            // Solicitar datos al usuario
            Console.WriteLine("Ingrese el número de créditos del estudiante:");
            int creditos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el estrato del estudiante (1, 2, 3, etc.):");
            int estrato = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de un crédito:");
            decimal valorCredito = Convert.ToDecimal(Console.ReadLine());

            // Crear un objeto de la clase Estudiante
            Estudiante estudiante = new Estudiante
            {
                Creditos = creditos,
                Estrato = estrato,
                ValorCredito = valorCredito
            };

            // Mostrar la información del costo de matrícula y subsidio
            estudiante.MostrarInformacion();

            // Preguntar al usuario si desea realizar otro cálculo
            Console.WriteLine("\n¿Desea calcular la matrícula de otro estudiante? (S/N):");
            string respuesta = Console.ReadLine().ToUpper();
            continuar = respuesta == "S";
        }


    }
}
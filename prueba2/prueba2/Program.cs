internal class Program
{
    private static void Main(string[] args)
    {
        // Construir un programa que pida un número y luego diga si este número es par o no.

        //declarar variables

        double numero;
        bool espar;

        //pedir datos por pantalla

        Console.WriteLine("ingrese el numero");
        numero = Convert.ToDouble(Console.ReadLine());

        //calcular el proceso

        if (numero %2 == 0)
        {
            espar = true;
        }
        else
                {
                  espar= false;
                 }

        // mostrar el mensaje

        if (espar)

        {
           Console.WriteLine("el numero es par");
        }
        else
        {
            Console.WriteLine("el numero no es par");
        }


    }
}
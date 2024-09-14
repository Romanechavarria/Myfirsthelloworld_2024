using System.Reflection.PortableExecutable;

public class Program
{
    private static void Main(string[] args)
    {
        /*Realizar un algoritmo con C# donde se solucione el siguiente problema: Un vendedor recibe un sueldo base de $XXXX. Además, recibe una comisión del 10% sobre el valor total de cada venta que realiza. El vendedor desea saber:
 ¿Cuánto dinero obtendrá por concepto de comisiones por las tres ventas que realiza en el mes?
 ¿Cuál es el total que recibirá en el mes tomando en cuenta su sueldo base y comisiones?
 ¿Cuál fue la venta que le generó la mayor comisión?
 ¿Cuál fue el promedio de las comisiones que recibió por cada venta?
Además, la empresa da un beneficio extra de $100.000 si el vendedor supera el objetivo del mes. El objetivo es sumar en las 3 ventas como mínimo $1.000.000 en ventas. Mostrar un mensaje donde indique si ganó o no el beneficio.
        */

        //declarar variables

        Double sueldobase, comision1, comision2, comision3, venta1, venta2, venta3, totalcomisiones, totalmes, ventamayor, promediocomisiones, totalventas;

        //pedir datos por pantalla

        Console.WriteLine("ingrese el sueldo base");
        sueldobase = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("ingrese el valor de la venta1");
        venta1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("ingrese el valor de la venta2");
        venta2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("ingrese el valor de la venta3");
        venta3 = Convert.ToDouble(Console.ReadLine());

        // calcular las comisiones

        comision1 = venta1 * 0.10;
        comision2 = venta2 * 0.10;
        comision3 = venta3 * 0.10;
        totalcomisiones = comision1 + comision2 + comision3;



        // calcular el total que recibira en el mes
        totalmes = sueldobase + totalcomisiones;

        // determinar la venta que genero mayor ganancia
        ventamayor = Math.Max(venta1, Math.Max(venta2, venta3));

        // calcular el promedio de las comisiones
        promediocomisiones = comision1 + comision2 + comision3 / 3;

        // calcular si gano el veneficio estra
        totalventas = venta1 + venta2 + venta3;

        







    }
}
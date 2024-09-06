public class Program
{
    private static void Main(string[] args)
    {

        // les los tres segmentos y que muestre si se puede construir un triangulo con estos segmentos

        //declaracion de variables 

        double seg1, seg2, seg3;
        bool istriangle;
        string msj;

        //pedir los datos por pantalla
        Console.Write("ingrese el segmento1");
        seg1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("ingrese el segmento2");
        seg2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("ingrese el segmento3");
        seg3 = Convert.ToDouble(Console.ReadLine());


        //validacion en una sola linea

       if (((seg1 + seg2) > seg3) && ((seg1 + seg3) > seg2) && ((seg2 + seg3)>seg1))
        {
            istriangle = true;
        }
        else
        {
            istriangle=false;
        }

        // mostrar mensaje

        if (istriangle)
        {
            Console.Write("el triangulo se puede construir");
        }
        else
        {
            Console.Write("el tringulo no se puede construir");
        }






    }



}
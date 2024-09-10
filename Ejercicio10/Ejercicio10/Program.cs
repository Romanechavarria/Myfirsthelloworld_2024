public class Program
{
    private static void Main(string[] args)
    {
        // construir un progrma que pida por pantalla 3 numeros y diga cual es el numero mayor el 
        // el del medio y el menor de los numeros ingresados

        // declarar variables

        double num1, num2, num3;

        // pedir datos por pantalla
        Console.Write("ingrese el primer numero: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("ingrese el segundo numero: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("ingrese el tercer numero: ");
        num3 = Convert.ToDouble(Console.ReadLine());

        //proceso validacion

        if (num1 > num2 && num1 > num3)
        {
            Console.WriteLine("el numero mayor es " + num1);
            if (num2 > num3)
            {
                Console.WriteLine("numero del medio es " + num2);

                Console.WriteLine("el numero menor es  " + num3);



            }
            else
            {
                Console.WriteLine("numero del medio es " + num3);
                Console.WriteLine("numero menor es " + num2);
            }
        }
        else
        {
            if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("el numero mayor es " + num2);
                if (num1 > num3)
                {
                    Console.WriteLine("numero del medio es " + num1);
                    Console.WriteLine("el numero menor es  " + num3);



                }
                else
                {
                    Console.WriteLine("numero del medio es " + num3);
                    Console.WriteLine("numero menor es " + num1);
                }
            }
            else
            {
                if (num3 > num2 && num3 > num1)
                {
                    Console.WriteLine("el numero mayor es " + num3);
                    if (num1 > num2)
                    {
                        Console.WriteLine("numero del medio es " + num1);
                        Console.WriteLine("el numero menor es  " + num2);



                    }
                    else
                    {
                        Console.WriteLine("numero del medio es " + num2);
                        Console.WriteLine("numero menor es " + num1);
                    }
                }
            }
        }




    }
}
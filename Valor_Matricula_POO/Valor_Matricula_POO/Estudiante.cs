

namespace EjercicioMatrícula
{
    public class Estudiante
    {
        // Propiedades
        public int Creditos { get; set; }
        public int Estrato { get; set; }
        public decimal ValorCredito { get; set; }

        // Método para calcular el costo de la matrícula
        public decimal CalcularCostoMatricula()
        {
            decimal costoMatricula = 0;

            // Calcular el costo de los créditos
            if (Creditos <= 20)
            {
                costoMatricula = Creditos * ValorCredito;
            }
            else
            {
                int creditosExtras = Creditos - 20;
                costoMatricula = (20 * ValorCredito) + (creditosExtras * ValorCredito * 2);
            }

            // Aplicar descuento de acuerdo al estrato
            decimal descuento = 0;
            switch (Estrato)
            {
                case 1:
                    descuento = 0.80m;
                    break;
                case 2:
                    descuento = 0.50m;
                    break;
                case 3:
                    descuento = 0.30m;
                    break;
            }
            costoMatricula -= costoMatricula * descuento;

            return costoMatricula;
        }

        // Método para calcular el subsidio
        public decimal CalcularSubsidio()
        {
            decimal subsidio = 0;

            // Calcular subsidio basado en el estrato
            if (Estrato == 1)
            {
                subsidio = 200000;
            }
            else if (Estrato == 2)
            {
                subsidio = 100000;
            }

            return subsidio;
        }

        // Método para mostrar la información al usuario
        public void MostrarInformacion()
        {
            decimal costoMatricula = CalcularCostoMatricula();
            decimal subsidio = CalcularSubsidio();

            Console.WriteLine($"\nEl costo de la matrícula es: ${costoMatricula}");
            if (subsidio > 0)
            {
                Console.WriteLine($"El estudiante recibe un subsidio de alimentación y transporte de: ${subsidio}");
            }
            else
            {
                Console.WriteLine("El estudiante no recibe subsidio de alimentación y transporte.");
            }
        }
    }
}
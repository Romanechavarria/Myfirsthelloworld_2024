

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

        
    }
}
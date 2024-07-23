using System.Diagnostics;

namespace ConsoleApp07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tasas de cambio respecto al peso argentino
            const decimal TASA_EURO = 923.46m;
            const decimal TASA_DOLAR = 845.50m;
            const decimal TASA_YUAN = 118.19m;

            decimal montoConvertido = 0;
            Console.Write("Ingrese la cantidad de dinero en pesos argentinos: ");

            if (!int.TryParse(Console.ReadLine(), out int pesos))
            {
                Console.WriteLine("¡¡¡Cantidad no valida!!!");
                return;
            }
            if (pesos <= 0)
            {
                Console.WriteLine("Monto en pesos argentinos(ARS) no valido");
                return;
            }
            Console.WriteLine("monedas disponobles para invertir");
            Console.WriteLine( "(D)ólar");
            Console.WriteLine( "(E)uro");
            Console.WriteLine( "(Y)uan");
            Console.Write("ingrese una opcion: ");

            char LetraIngresada=Console.ReadKey().KeyChar;
            Console.WriteLine();
            switch (char.ToUpper(LetraIngresada))
            {
                case 'D':
                    montoConvertido = calcularConversionMoneda(pesos, TASA_DOLAR);
                    Console.WriteLine($" con {pesos} ARS obtiene {montoConvertido} USD");
                    break;
                case 'E':
                    montoConvertido = calcularConversionMoneda(pesos, TASA_EURO);
                    Console.WriteLine($" con {pesos} ARS obtiene {montoConvertido} EUR");
                    break;
                case 'Y':
                    montoConvertido = calcularConversionMoneda(pesos, TASA_YUAN);
                    Console.WriteLine($" con {pesos} ARS obtiene {montoConvertido} CYN");
                    break;

                default:
                    Console.WriteLine("opcion ingresada no valida!");
                    break;
            }
        }

        private static decimal calcularConversionMoneda(int pesos, decimal cotizacion)
        {
            return Math.Truncate (pesos / cotizacion);
        }
    }
}

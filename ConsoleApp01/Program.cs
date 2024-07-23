namespace ConsoleApp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //defiición de variables
                double numero1;
                double numero2;
                double resultadoSuma;

                //ingreso de datos
                Console.Write("ingrese el primer valor a sumar: ");
                numero1 = double.Parse(Console.ReadLine());
                Console.Write("ingrese el segundo valor a sumar: ");
                numero2 = double.Parse(Console.ReadLine());

                //obtener resultado
                resultadoSuma = numero1 + numero2;

                //mostrar la información obtenida
                Console.WriteLine($"el resultado es:{resultadoSuma} ");

            }
            catch (Exception)
            {

                Console.WriteLine("algo se ingreso incorrectamente"); ;
            }



        }
    }
}

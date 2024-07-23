namespace ConsoleApp02.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //definir variables
            double numero1, numero2, suma, resta, producto;
            double cociente;

            //ingresar datos
            Console.Write("ingrese el primer número: ");
            numero1 = double.Parse(Console.ReadLine());
            Console.Write("ingrese el segundo número: ");
            numero2 = double.Parse(Console.ReadLine());

            //proceso
            suma=numero1 + numero2;
            resta=numero1 - numero2;
            producto=numero1 * numero2;

            Console.WriteLine($"la suma es: {suma}");
            Console.WriteLine($"la resta es: {resta}");
            Console.WriteLine($"el producto es: {producto}");

            if ( numero2! > 0 ) 
            { 
            cociente=numero1/ numero2;
                 Console.WriteLine($"la division es: {cociente}");
            }
            else 
            {
                Console.WriteLine("no se puede dividir por cero");
            }    
        }
    }
}

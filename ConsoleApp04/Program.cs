using System.Text;

namespace ConsoleApp04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float ladoCuadrado, perimetroCuadrado;
            double superficieCuadrado;
            Console.Write("Ingrese el lado del cuadrado:");
            ladoCuadrado = float.Parse(Console.ReadLine());
            if (ladoCuadrado > 0)
            {
                perimetroCuadrado = ladoCuadrado * 4;
                superficieCuadrado = Math.Pow(ladoCuadrado, 2);

                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Cuadrado de lado {ladoCuadrado}");
                sb.AppendLine($"Superficie: {superficieCuadrado}");
                sb.AppendLine($"Perímetro.: {perimetroCuadrado}");
                Console.WriteLine(sb.ToString());
            }
            else
            {
                Console.WriteLine("Lado mal ingresado");
            }
        }
    }
}

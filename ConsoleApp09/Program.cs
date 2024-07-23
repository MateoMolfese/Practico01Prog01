
namespace ConsoleApp09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("calculo de distancia entre dos puntos");
                int coordX1, coordY1, coordX2, coordY2;
                double distancia;
                Console.Write("ingrese la coord. X del punto 1:");
                coordX1 = int.Parse(Console.ReadLine());
                Console.Write("ingrese la coord. Y del punto 1:");
                coordY1 = int.Parse(Console.ReadLine());
                Console.Write("ingrese la coord. X del punto 2:");
                coordX2 = int.Parse(Console.ReadLine());
                Console.Write("ingrese la coord. Y del punto 2:");
                coordY2 = int.Parse(Console.ReadLine());
                if (estanEnMismaRecta(coordX1, coordY1, coordX2, coordY2))
                {
                    Console.WriteLine("los puntos estan en rectas perpendiculares");
                }
                distancia = calcularDistancia(coordX1, coordY1, coordX2, coordY2);
                Console.WriteLine($"la distancia entre ({coordX1},{coordY1}) y ({coordX2},{coordY2}) es {distancia:n2}");

            }
            catch (Exception)
            {

                Console.WriteLine("¡¡¡algunos de los datos fueron mal ingresados!!!"); ;
            }
        }
        /// <summary>
        /// método para calcular la distancia entre dos puntos del plano
        /// </summary>
        /// <param name="coordX1">coordenada X del primer plano</param>
        /// <param name="coordY1">coordenada Y del primer plano</param>
        /// <param name="coordX2">coordenada X del segundo plano</param>
        /// <param name="coordY2">coordenada Y del segundo plano</param>
        /// <returns>la distancia entre los puntos</returns>
        private static double calcularDistancia(int coordX1, int coordY1, int coordX2, int coordY2)
        {
            return Math.Sqrt(Math.Pow(coordX2 - coordX1, 2) + Math.Pow(coordY2 - coordY1, 2));
        }
        /// <summary>
        /// metodo para ver si dos puntos estan en una recta perpendicular
        /// </summary>
        /// <param name="coordX1">coordenada X del primer plano</param>
        /// <param name="coordY1">coordenada Y del primer plano</param>
        /// <param name="coordX2">coordenada X del segundo plano</param>
        /// <param name="coordY2">coordenada Y del segundo plano</param>
        /// <returns>bool</returns>
        private static bool estanEnMismaRecta(int coordX1, int coordY1, int coordX2, int coordY2)
        {
            if (coordY1 == coordY2 || coordX1 == coordX2)
            {
                return true;
            }
            return false;
        }
    }
}

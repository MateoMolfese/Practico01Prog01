namespace ConsoleApp03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double resultadoRadianes;
                int valorSexagesimal;
                const double RADIANES = 0.0174532925;
                Console.Write("Ingrese el valor en grados sexagesimales:");
                valorSexagesimal = int.Parse(Console.ReadLine());
                if (valorSexagesimal > 0)
                {

                    resultadoRadianes = valorSexagesimal * RADIANES;
                    Console
                        .WriteLine(
                        $"{valorSexagesimal} en grados equivalen a {resultadoRadianes} radianes");

                }
                else
                {
                    Console.WriteLine("No se puede convertir a radianes!!!");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Número mal ingresado!!!");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Número muy grande!!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Algo malo ha pasado!!!");
            }
        }
    }
}

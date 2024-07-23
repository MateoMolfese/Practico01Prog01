try
{
	int radio;
	double superficie, perimetro;

	Console.Write("ingrese el valor del radio de la circunferencia: ");
	radio = int.Parse(Console.ReadLine());
	if (radio > 0)
	{
		perimetro = 2 * Math.PI * radio;
		superficie = Math.PI * Math.Pow(radio, 2);
		Console.WriteLine($"la circunferencia tiene un perimetro de: {perimetro:n2}");
		Console.WriteLine($"la circunferencia tiene una superficie de: {superficie:n2}");

	}
	else
	{
		Console.WriteLine("radio mal ingresado...debe ser mayor que cero");
	}
}
catch (FormatException)
{

	throw; Console.WriteLine("radio mal ingresado!!!");
}
catch(OverflowException)
{
    Console.WriteLine("radiio demasiado grande para nro. entero");
}
catch (Exception)
{
    Console.WriteLine("error inesperado...");
}
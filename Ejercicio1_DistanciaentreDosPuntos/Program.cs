class Program
{
    static void Main(string[] args)
    {
        //1. Lea las coordenadas de dos puntos y que muestre la distancia entre los dos puntos
        //Datos de entrada: 4 Variables
        //Declaración de variables

        double x1,x2,y1,y2,distancia;

        //Solicitud de datos por patalla

        Console.Write("Por favor digita el X1: ");
        x1 = double.Parse(Console.ReadLine());

        Console.Write("Por favor digita el Y1: ");
        y1 = double.Parse(Console.ReadLine());

        Console.Write("Por favor digita el X2: ");
        x2 = double.Parse(Console.ReadLine());

        Console.Write("Por favor digita el Y2: ");
        y2 = double.Parse(Console.ReadLine());

        //proceso/cálculo
        distancia = Math.Sqrt((Math.Pow(x2-x1,2)) + (Math.Pow(y2-y1,2)));

        //Datos de salida

        Console.WriteLine("La distancia entre los pares ordenados (" + x1 + "," + y1 + ") y ("+ x2 + "," + y2 +") es = " +
            distancia);

        //otra forma para concatenar textos.
        //.ToString("N2") nos redondea a 2 decimales

        Console.WriteLine(string.Format("La distancia entre los pares ordenados({0},{1}) y ({2},{3})" +
            " es={4}" ,x1,y1,x2,y2,distancia.ToString("N2")));






    }
}
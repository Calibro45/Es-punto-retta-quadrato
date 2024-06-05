namespace EsercizioPunto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var punto1 = new Punto(1, 4);
            var punto2 = new Punto(5, 7);

            var retta = new Retta(punto1, punto2);

            var calcRetta = retta.Distanza();

            var lato = new Quadrato(retta);

            var perimetroQuadrato = lato.Perimetro();
            var areaQuadrato = lato.Area();

            Console.WriteLine(calcRetta);
            Console.WriteLine(perimetroQuadrato);
            Console.WriteLine(areaQuadrato);
        }
    }
}

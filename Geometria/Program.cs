namespace Geometria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo(5.0f, 10.0f);
            Quadrado qua = new Quadrado(4.0f);
            Circulo cir = new Circulo(3.0f);

            Console.WriteLine("--- RETÂNGULO ---");
            Console.WriteLine($"Área: {ret.CalcularArea()}");
            Console.WriteLine($"Perímetro: {ret.CalcularPerimetro()}");

            Console.WriteLine("\n--- QUADRADO ---");
            Console.WriteLine($"Área: {qua.CalcularArea()}");
            Console.WriteLine($"Perímetro: {qua.CalcularPerimetro()}");

            Console.WriteLine("\n--- CÍRCULO ---");
            Console.WriteLine($"Área: {cir.CalcularArea():F2}");
            Console.WriteLine($"Perímetro: {cir.CalcularPerimetro():F2}");

            Console.ReadLine();
        }
    }
}

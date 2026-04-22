namespace Mercadinho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto("Teclado Gamer", 150.00);
            Produto p2 = new Produto("Mouse Pad", 50.00);
            Produto p3 = new Produto("Kit de 5x Ventoinhas", 120);

            p1.ExibirDetalhes();
            p2.ExibirDetalhes();
            p3.ExibirDetalhes();

            Console.WriteLine("\n---DESPOIS DO DESCONTO---");

            p1.AplicarDesconto(10);
            p2.AplicarDesconto(20);
            p3.AplicarDesconto(30);

            p1.ExibirDetalhes();
            p2.ExibirDetalhes();
            p3.ExibirDetalhes();

            Produto copiaref = p1;
            copiaref.Nome = "Teclado genérico";
            copiaref.Preco = 100;

            Console.WriteLine("\nPRECO REAJUSTADO");
            copiaref.ExibirDetalhes();

            Console.WriteLine("\nPRECO REAJUSTADO APOS O DESCONTO");
            copiaref.AplicarDesconto(10);
            copiaref.ExibirDetalhes();


            Console.ReadKey();
        }
    }
}

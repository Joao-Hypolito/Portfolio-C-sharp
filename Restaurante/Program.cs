namespace Restaurante
{
    internal class Program
    {
        static void Main()
        {
            Pedido meuPedido = new Pedido(101);

            meuPedido.AdicionarItem("Pizza Calabresa", 55.00, 1);
            meuPedido.AdicionarItem("Refrigerante 2L", 12.00, 2);

            meuPedido.ExibirResumo();
        }
    }
}

namespace Pedido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var clienteJoao = new Cliente { Nome = "João" };
            var meuPedido = new Pedido { Numero = 0934, Cliente = clienteJoao };
            meuPedido.AdicionarItem("SSD 512GB", 180.00);

            meuPedido.Resumo();
        }
    }
}

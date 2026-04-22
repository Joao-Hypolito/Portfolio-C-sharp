namespace Sistema_Inventario_RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mochila minhaMochila = new Mochila(10.0);

            Item espada = new Item("Espada de Ferro", 3.5);
            Item pocao = new Item("Pocao de Cura", 0.5);

            Item mapaInicial = new Item("Mapa do tesouro", 0.1);
            minhaMochila.AdicionarItem(mapaInicial);

            minhaMochila.AdicionarItem(espada);
            minhaMochila.AdicionarItem(pocao);

            minhaMochila.MostrarInventario();

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}

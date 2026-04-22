namespace Post
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario1 = new Usuario("DEV");

            Post meuPost = new Post("Hoje evolui", usuario1);

            meuPost.AdicionarComentario("Excelente explicacao!");

            ExibirFeed(meuPost);

            Console.ReadKey();

            static void ExibirFeed(Post p)
            {
                Console.WriteLine($"Post: {p.Conteudo}");
                Console.WriteLine($"AUTOR: {p.Autor.Nome}");

                Console.WriteLine("\nCOMENTÁRIOS:");
                
                foreach (var c in p.Comentarios)
                {
                    Console.WriteLine($"  > {c.Texto}");
                }
                Console.WriteLine("================================");

            }

        }
    }
}

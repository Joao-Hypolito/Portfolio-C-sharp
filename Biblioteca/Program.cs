namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Autor autor1 = new Autor("J.R.R. Tolkien", "tolkien@gmail.com");
            Autor autor2 = new Autor("C.S.Lewis", "Lewis@gmail.com");

            Livro livro1 = new Livro("Senhor dos Aneis", 1954);
            Livro livro2 = new Livro("As Crônicas de Nárnia", 1950);

            livro1.AdicionarAutor(autor1);
            livro2.AdicionarAutor(autor2);

            livro1.ExibirDetalhes();
            Console.WriteLine("--------------");
            livro2.ExibirDetalhes();
        }
    }
}

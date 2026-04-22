using System;

namespace Decepticons
{
    class Program
    {
        static void Main(string[] args)
        {

            Lideres megatron = new Lideres("Megatron");
            Lideres starscream = new Lideres("Starscream");

            EsquadraoSeeker s1 = new EsquadraoSeeker("Skywarp");
            EsquadraoSeeker s2 = new EsquadraoSeeker("Thundercracker");

            Console.WriteLine("Selecione o Comandante Supremo (1 - Megatron / 2 - Starscream):");
            string opcao = Console.ReadLine();
            Lideres escolhido = (opcao == "1") ? megatron : starscream;

            EsquadraoSeeker elite = new EsquadraoSeeker("Seekers de Elite");
            elite.DefinirChefe(escolhido);
            elite.AdicionarSoldado(s1);
            elite.AdicionarSoldado(s2);

            Devastator devas = new Devastator("Devastator Clássico", escolhido);

            Console.Clear();
            Console.WriteLine("======= EXÉRCITO DECEPTICON PRONTO =======");
            elite.MostrarRelatorio();
            devas.ExibirStatus();

            Console.WriteLine("\n--- Pressione qualquer tecla para encerrar ---");
            Console.ReadKey();
        }
    }
}
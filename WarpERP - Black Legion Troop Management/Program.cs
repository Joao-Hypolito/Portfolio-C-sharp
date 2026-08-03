namespace WarpERP___Black_Legion_Troop_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Marine> tropas = new List<Marine>();
            bool rodando = true;

            while(rodando)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(@"
                ===================================================
                 WARPERP v1.0 - SISTEMA DE GESTÃO DA BLACK LEGION
                'Pela glória de Abaddon e do Caos Individido'
                ===================================================");
                Console.ResetColor();

                Console.WriteLine("\nEscolha uma opção do protocolo:");
                Console.WriteLine("1. Recrutar Novo Traidor (Cadastrar Tropa)");
                Console.WriteLine("2. Listar Batalhão Ativo");
                Console.WriteLine("3. Registrar Coleta de Crânios (Bater Ponto)");
                Console.WriteLine("4. Gerar Relatório de Cruzada");
                Console.WriteLine("5. Sair (Executar por Heresia)");

                Console.Write("Opcao > ");
                string opcao = Console.ReadLine();

                switch(opcao) 
                {
                    case "1":
                        break;

                    case "2":
                        break;

                    case "3":
                        break;

                    case "4":
                        break;

                    case "5":
                        break;
                }                
            }
        }
    }
}

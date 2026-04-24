namespace O_Gerenciador_de_Status_de_Guilda
{
    public class Program
    {
        static void Main(string[] args)
        {
            Guilda Guerreiros = new Guilda();
            Membro m1 = new Membro("Turin", 77, "Guerreiro");
            Guerreiros.AdicionarMembro(m1);

            Membro m2 = new Membro("Galadriel", 87, "Mago");
            Guerreiros.AdicionarMembro(m2);

            Console.WriteLine("---Status Iniciais---");
            Guerreiros.ExibirStatus();

            Console.WriteLine("\n ---Treinando Equipe---");
            Guerreiros.TreinarEquipe();

            Console.WriteLine("\n ---Status Pós Treino---");
            Guerreiros.ExibirStatus();

        }
    }
}

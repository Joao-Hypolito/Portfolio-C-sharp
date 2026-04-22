namespace Sistema_Notificacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Notificacao> notificacaos = new List<Notificacao>();

            notificacaos.Add(new Email("ana@gmail.com"));
            notificacaos.Add(new SMS("19999887766"));

            foreach( var n in notificacaos)
            {
                Console.WriteLine($"Mensagem recebida de: {n.Destinarario}");
                n.Enviar();
            }

        }
    }
}

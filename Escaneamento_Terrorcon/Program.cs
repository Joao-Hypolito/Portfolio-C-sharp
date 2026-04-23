namespace Escaneamento_Terrorcon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Verificacao Scourge = new Verificacao();

            Scourge.VerificarAno();
            Scourge.VerificarNota();
            Scourge.VerificarCombustivel();
            Scourge.MedidaFinal();
        }
    }
}

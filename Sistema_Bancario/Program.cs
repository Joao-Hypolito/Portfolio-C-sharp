namespace Sistema_Bancario
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<ContaBancaria> listabancaria = new List<ContaBancaria>();

            Console.WriteLine("Quantas contas deseja cadastrar? ");
            int Quant = int.Parse(Console.ReadLine());

            for(int i = 0; i < Quant; i++) {

                Console.WriteLine("Qual o nome do cliente? ");
                string nome = Console.ReadLine();

                Console.WriteLine("Qual o saldo do cliente? ");
                int num = int.Parse(Console.ReadLine());

                listabancaria.Add(new ContaBancaria(nome, num));
            }

            Console.WriteLine("---RELATORIO DE CONTAS---");

            foreach(ContaBancaria conta in listabancaria)
            {
                Console.WriteLine($"\nTitular: {conta.Titular}");
                Console.WriteLine($"Saldo R$: {conta.Saldo}");
                conta.Depositar(120);
            }
        }
    }
}

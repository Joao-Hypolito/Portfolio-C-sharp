namespace Alfandega
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double TotalP = 0;

            Console.WriteLine("Quantas caixas deseja colocar no elevador?");
            int total = int.Parse(Console.ReadLine());

            if(total > 5)
            {
                Console.WriteLine("O limite de caixas é de somente 5!!!");
                total = 5;
            }
            else
            {
                total = total;
            }

            for(int i = 0; i < total; i++)
            {
                Console.WriteLine($"Por favor, digitalize o peso da {i + 1}º caixa: ");
                TotalP += double.Parse(Console.ReadLine());
            }

            if (TotalP <= 500)
            {
                Console.WriteLine($"O total de Kg foi {TotalP}Kg, pode passar!!!");
            }
            else
            {
                Console.WriteLine($"O total foi {TotalP}Kg, sinto muito, ultrapassou o limite máximo de 500Kg!");
            }

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}

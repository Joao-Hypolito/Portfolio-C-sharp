namespace Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CAIXA ELETRÔNICO JABIROSCA ===");
            Console.WriteLine("Qual valor quer sacar? ");
            int nota = int.Parse(Console.ReadLine());

            int valorfinal = nota;

            int notas100 = nota / 100;
            nota = nota % 100;

            int notas50 = nota / 50;
            nota = nota % 50;

            int notas20 = nota / 20;
            nota = nota % 20;

            int notas10 = nota / 10;
            nota = nota % 10;

            int notas5 = nota / 5;
            nota = nota % 5;

            int notas2 = nota / 2;
            nota = nota % 2;

            if (nota != 0)
            {
                Console.WriteLine($"O valor {nota} não poderá ser sacado com as notas disponiveis (100, 50, 20, 10, 5, 2).");
            }
            else
            {
                if (notas100 > 0) Console.WriteLine($"- {notas100} nota(s) de 100 reais");
                if (notas50 > 0) Console.WriteLine($"- {notas50} nota(s) de 50 reais");
                if (notas20 > 0) Console.WriteLine($"- {notas20} nota(s) de 20 reais");
                if (notas10 > 0) Console.WriteLine($"- {notas10} nota(s) de 10 reais");
                if (notas5 > 0) Console.WriteLine($"- {notas5} nota(s) de 5 reais");
                if (notas2 > 0) Console.WriteLine($"- {notas2} nota(s) de 2 reais");
            }

            Console.Write("\nObrigado por usar nosso banco!");
        }
    }
}

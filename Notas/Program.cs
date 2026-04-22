namespace Notas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 5; i++) { 

            Console.WriteLine("Digite o nome do aluno: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a media final: ");
            double media = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a frequenci (%): ");
            double freq = double.Parse(Console.ReadLine());

            if (freq >= 75 && media >= 5)
            {
                Console.WriteLine($"O aluno(a) foi {nome} Aprovado");
            }
            else if (freq >= 75 && media >= 3)
            {
                Console.WriteLine($"O aluno(a) foi {nome}RE");
            }
            else
            {
                Console.WriteLine($"O aluno(a) foi {nome}Reprovado");
            }
        }

            Console.WriteLine("Todos os 5 alunos foram processados, aperte qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}

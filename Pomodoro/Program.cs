namespace Pomodoro
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int tempo_foco = 1;
            int tempo_pausa = 1;

            while (true)
            {
                

                Console.Clear();
                Console.WriteLine("=== POMODORO ===");
                Console.WriteLine("Escolha uma das opcoes:");
                Console.WriteLine($"Configuração atual: Foco: {tempo_foco:D2} min | Pausa: {tempo_pausa:D2} min");
                Console.WriteLine("1 - Iniciar Pomodoro");
                Console.WriteLine("2 - Mudar tempo de Foco");
                Console.WriteLine("3 - Mudar tempo de Pausa");
                Console.WriteLine("4 - Sair do Programa");
               
                Console.WriteLine("\nQual das Opcoes deseja?");

                string opcao = Console.ReadLine();
                int num = int.Parse(opcao);

                    if(num == 1)
                    {
                        Console.WriteLine("\nPressione alguma tecla para inciar a contagem!");
                        Console.ReadKey();   
                        
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\n[FOCO] Cronômetro inicial de {tempo_foco} minutos!");
                        ContagemRegressiva(tempo_foco);
                        AlertaSonoro();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"\n[PAUSA] hora de descansar por {tempo_pausa} muinutos!");
                        ContagemRegressiva(tempo_pausa);
                        AlertaSonoro();

                        Console.ResetColor();
                        Console.WriteLine("\nCiclo  concluído! Pressione qualquer tecla para continuar!");
                        Console.ReadKey();
                    }
                    if(num == 2)
                    {
                        Console.WriteLine($"Qual será o novo tempo de foco? Tempo atual: {tempo_foco:D2} min");
                        string op1 = Console.ReadLine();
                        int num1 = int.Parse(op1);
                        tempo_foco = num1;       
                    }
                    if(num == 3)
                    {
                        Console.WriteLine($"Qual será o novo tempo de descanso? Tempo atual: {tempo_pausa:D2} min");
                        string op2 = Console.ReadLine();
                        int num2 = int.Parse(op2);
                        tempo_pausa = num2;
                    }
                    if(num == 4)
                    {
                        break;
                    }
            }
        }

        static void AlertaSonoro()
        {
            for (int i =0; i < 3; i++)
            {
                Console.Beep(800,500);
                Thread.Sleep(200);
            }
        }

        static void ContagemRegressiva(int minutosTotais)
        {
            int segundosTotais = minutosTotais * 60;

            while(segundosTotais > 0)
            {
                int min = segundosTotais / 60;
                int seg = segundosTotais % 60;

                Console.Write($"\rTempo restante: {min:D2}:{seg:D2}");

                Thread.Sleep(1000);
                segundosTotais--;
            }
            Console.WriteLine();
        }
    }
}

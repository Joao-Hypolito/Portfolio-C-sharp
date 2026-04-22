namespace Sistema_Funcionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> ListaEmpresa = new List<Funcionario>();

            ListaEmpresa.Add(new Gerente("Ana", 5000));
            ListaEmpresa.Add(new DEV("Joao", 3000));

            foreach (var f in ListaEmpresa) {

                Console.WriteLine($"Salario antes do bonus: {f.Salario}");
                Console.WriteLine($"Nome: {f.Nome} | Bonus: {f.CalcularBonus()}");
            }
        }
    }
}

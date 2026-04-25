namespace Exercicio03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int inicio = 1;
            int final = 500;
            int soma = 0;

            listBox1.Items.Add($"Calculando soma dos pares entre {inicio} e {final}:");

            for (int i = inicio; i <= final; i++)
            {
                if (i % 2 == 0)
                {
                    soma += i;
                }
            }

            listBox1.Items.Add($"A soma dos números pares é: {soma}");
        }
    }
}

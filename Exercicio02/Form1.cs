using System.Numerics;

namespace Exercicio02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int a))
            {
                MessageBox.Show("Digite um número inteiro válido.");
            }

            if (!int.TryParse(textBox2.Text, out int b))
            {
                MessageBox.Show("Digite um número inteiro válido.");
            }

            if (!int.TryParse(textBox3.Text, out int c))
            {
                MessageBox.Show("Digite um número inteiro válido.");
            }

            if (!int.TryParse(textBox4.Text, out int d))
            {
                MessageBox.Show("Digite um número inteiro válido.");
            }

            int total = (a + b + c + d) / 4;

            LsResultado.Text = $"A média foi de {total}";

            if(total >= 5)
            {
                LsVeredito.Text = "Passou!!!";
            }
            else
            {
                LsVeredito.Text = "Reprovou!!!";
            }

        }

    }
}

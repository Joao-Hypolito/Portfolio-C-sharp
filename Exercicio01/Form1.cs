using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LsResultado.Items.Clear();

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

            LsResultado.Items.Add("===Números divisiveis por 2 ou 3===");

            if (a % 2 == 0 || a % 3 == 0)
            {
                LsResultado.Items.Add($"O número corresponde a exigencia: {a}");
            }
            if (b % 2 == 0 || b % 3 == 0)
            {
                LsResultado.Items.Add($"O número corresponde a exigencia: {b}");
            }
            if (c % 2 == 0 || c % 3 == 0)
            {
                LsResultado.Items.Add($"O número corresponde a exigencia: {c}");
            }
            if (d % 2 == 0 || d % 3 == 0)
            {
                LsResultado.Items.Add($"O número corresponde a exigencia: {d}");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LsResultado.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LsResultado.Items.Clear();
            textBox1.Clear();
            textBox1.Focus();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }
    }
}

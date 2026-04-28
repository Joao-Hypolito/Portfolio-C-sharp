namespace Exercicio04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox.Items.Add($"Possibilidades de soma 7 com dois dados:");

            for (int dado1 = 1; dado1 <= 6; dado1++)
            {

                for (int dado2 = 1; dado2 <= 6; dado2++)
                {
                    if (dado1 + dado2 == 7)
                    {
                        listBox.Items.Add($"Dado 1: {dado1} + Dado 2: {dado2} = 7");
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }
    }
}


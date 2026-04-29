namespace Exercicio05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            int s1, s2, s3;

            int.TryParse(textBox1.Text, out int n);

            s1 = 2;
            s2 = 7;
            s3 = 3;

            for (int i = 0; i < n; i++)
            {
                if (i % 3 == 0)
                {
                    listBox.Items.Add($"{s1}");
                    s1 = s1 * 2;
                }
                else if (i % 3 == 1)
                {
                    listBox.Items.Add($"{s2}");
                    s2 = s2 * 3;
                }
                else
                {
                    listBox.Items.Add($"{s3}");
                    s3 = s3 * 4;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            textBox1.Clear();
        }
    }
}

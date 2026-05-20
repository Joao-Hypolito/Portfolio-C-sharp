using System.Data.SqlClient;

namespace Estudo01
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n1 = int.Parse(textBox1.Text);
                int n2 = int.Parse(textBox3.Text);

                int soma = n1 + n2;

                textBox2.Text = soma.ToString();

                string stringConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\joaoh\Desktop\Importante\Exercicios de aprendizado\C#\Estudo01\Database1.mdf";

                using (SqlConnection conexao = new SqlConnection(stringConexao))
                {
  
                    string query = "INSERT INTO DADOS (Numero, Resultado) VALUES (@num, @res)";

                    using (SqlCommand comando = new SqlCommand(query, conexao))
                    {
                        // Vincula as variáveis do C# com os campos do Banco de Dados
                        comando.Parameters.AddWithValue("@num", n1);
                        comando.Parameters.AddWithValue("@res", soma);

                        conexao.Open();       // Abre a conexão
                        comando.ExecuteNonQuery(); // Executa o comando de salvar
                        conexao.Close();      // Fecha a conexão
                    }
                }

                MessageBox.Show("Dados gravados no banco de dados com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }

        catch (Exception ex)
        {
            MessageBox.Show("Erro ao processar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

namespace EscolaBD
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            new frmAlunos().ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void buttonNotas_Click(object sender, EventArgs e)
        {
            new frmNotas(1, "teste").ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmProfessores().ShowDialog();
        }
    }
}

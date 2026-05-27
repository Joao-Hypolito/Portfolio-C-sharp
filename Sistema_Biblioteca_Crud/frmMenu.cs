namespace Sistema_Biblioteca_Crud
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
        InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
        Application.Exit();
        }

        private void btnLivros_Click(object sender, EventArgs e)
        {
        new frmLivros().ShowDialog();
        }

        private void btnLeitores_Click(object sender, EventArgs e)
        {
        new frmLeitores().ShowDialog();
        }

        private void btnEmprestimo_Click(object sender, EventArgs e)
        {
            new frmEmprestimo().ShowDialog();
        }
    }
}

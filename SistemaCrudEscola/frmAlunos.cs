using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EscolaBD;
using EscolaBD.Controllers;
using EscolaBD.Models;

namespace EscolaBD
{
    public partial class frmAlunos : Form
    {
        private readonly AlunoController _aluno = new();
        public frmAlunos()
        {
            InitializeComponent();
        }

        private void CarregarGrid()
        {
            dgvAlunos.DataSource = _aluno.Listar();
            dgvAlunos.Columns["Id"].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmAlunos_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            _aluno.Inserir(new Aluno
            {
                Nome = txtNome.Text,
                Email = txtEmail.Text,
                DataNascimento = dtpDataNascimento.Value.Date,
                Turma = txtTurma.Text
            });
            CarregarGrid();
            Limpar();
            MessageBox.Show("Aluno salvo com sucesso!",
                "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Limpar()
        {
            txtId.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtTurma.Clear();
            dtpDataNascimento.Value = DateTime.Today;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var row = dgvAlunos.Rows[e.RowIndex];
            txtId.Text = row.Cells["Id"].Value.ToString();
            txtNome.Text = row.Cells["Nome"].Value.ToString();
            txtEmail.Text = row.Cells["Email"].Value.ToString();
            dtpDataNascimento.Value = (DateTime)row.Cells["DataNascimento"].Value;
            txtTurma.Text = row.Cells["Turma"].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
                return;

            _aluno.Atualizar(new Aluno
            {
                Id = int.Parse(txtId.Text),
                Nome = txtNome.Text,
                Email = txtEmail.Text,
                DataNascimento = dtpDataNascimento.Value.Date,
                Turma = txtTurma.Text
            });
            Limpar();
            CarregarGrid();
            MessageBox.Show("Edição efetuada com sucesso!",
                "Informação",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
                return;

            var ok = MessageBox.Show(
                "Deseja excluir este aluno?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ok == DialogResult.Yes)
            {
                _aluno.Excluir(int.Parse(txtId.Text));
                CarregarGrid();
                Limpar();
            }
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
                return;

            var frm = new frmNotas(int.Parse(txtId.Text), txtNome.Text);
            frm.ShowDialog();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

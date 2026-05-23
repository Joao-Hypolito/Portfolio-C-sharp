using EscolaBD.Models;
using EscolaBD.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaBD
{
    public partial class frmProfessores : Form
    {
        private readonly ProfessorRepositorio _professor = new();

        public frmProfessores()
        {
            InitializeComponent();
        }

        private void CarregarGrid()
        {
            dgvProfessores.DataSource = _professor.Listar();
            dgvProfessores.Columns["Id"].Visible = false;
        }

        private void Limpar()
        {
            txtId.Clear();
            txtNome.Clear();
            mtbCPF.Clear();
            txtEmail.Clear();
            txtEspecialidade.Clear();
            mtbTelefone.Clear();
            dtpAdmissao.Value = DateTime.Now;
            chkAtivo.Checked = true;
        }

        private void frmProfessores_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var prof = new Professores
            {
                Nome = txtNome.Text,
                CPF = mtbCPF.Text,
                Email = txtEmail.Text,
                Especialidade = txtEspecialidade.Text,
                Telefone = mtbTelefone.Text,
                DataAdmissao = dtpAdmissao.Value,
                Ativo = chkAtivo.Checked
            };

            _professor.Inserir(prof);
            CarregarGrid();
            Limpar();
            MessageBox.Show("Professor salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dtpAdmissao_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvProfessores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvProfessores.Rows[e.RowIndex];

            txtId.Text = row.Cells["Id"].Value.ToString();
            txtNome.Text = row.Cells["Nome"].Value.ToString();
            mtbCPF.Text = row.Cells["CPF"].Value?.ToString();
            txtEmail.Text = row.Cells["Email"].Value.ToString();
            txtEspecialidade.Text = row.Cells["Especialidade"].Value.ToString();
            mtbTelefone.Text = row.Cells["Telefone"].Value?.ToString();
            dtpAdmissao.Value = Convert.ToDateTime(row.Cells["DataAdmissao"].Value);
            chkAtivo.Checked = (bool)row.Cells["Ativo"].Value;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Selecione um professor na tabela primeiro!", "Aviso");
                return;
            }

            var prof = new Professores
            {
                Id = int.Parse(txtId.Text),
                Nome = txtNome.Text,
                CPF = mtbCPF.Text,
                Email = txtEmail.Text,
                Especialidade = txtEspecialidade.Text,
                Telefone = mtbTelefone.Text,
                DataAdmissao = dtpAdmissao.Value,
                Ativo = chkAtivo.Checked
            };

            _professor.Atualizar(prof);
            CarregarGrid();
            Limpar();
            MessageBox.Show("Dados atualizados com sucesso!", "Sucesso");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
                return;

            var ok = MessageBox.Show(
                "Deseja excluir este Professor?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ok == DialogResult.Yes)
            {
                _professor.Excluir(int.Parse(txtId.Text));
                CarregarGrid();
                Limpar();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

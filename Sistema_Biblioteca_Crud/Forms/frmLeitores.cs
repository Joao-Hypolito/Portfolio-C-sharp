using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Biblioteca_Crud.Models;
using Sistema_Biblioteca_Crud.Repositories;

namespace Sistema_Biblioteca_Crud
{
    public partial class frmLeitores : Form
    {
        private readonly ControllerLeitores _leitorController = new();
        public frmLeitores()
        {
        InitializeComponent();
        }

        private void frmLeitores_Load(object sender, EventArgs e)
        {
        CarregarGrid();
        }

        private void CarregarGrid()
        {
        dgvLeitores.DataSource = _leitorController.Listar();

        
        if (dgvLeitores.Columns["Id"] != null)
        {
        dgvLeitores.Columns["Id"].Visible = false;
        }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
        if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
        {
        MessageBox.Show("Nome e E-mail são obrigatórios!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
        }

        
        string telefoneTexto = mtbTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Trim();

        _leitorController.Inserir(new Leitores
        {
            Nome = txtNome.Text,
            Email = txtEmail.Text,
            
            Telefone = string.IsNullOrWhiteSpace(telefoneTexto) ? "" : mtbTelefone.Text,
            Turma = string.IsNullOrWhiteSpace(txtTurma.Text) ? "" : txtTurma.Text,
            Ativo = chkAtivo.Checked
        });

        CarregarGrid();
        Limpar();
        MessageBox.Show("Leitor salvo com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
        if (string.IsNullOrEmpty(txtId.Text))
        {
        MessageBox.Show("Selecione um leitor na tabela primeiro para editar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
        }

        string telefoneTexto = mtbTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Trim();

        _leitorController.Atualizar(new Leitores
        {
            Id = int.Parse(txtId.Text),
            Nome = txtNome.Text,
            Email = txtEmail.Text,
            Telefone = string.IsNullOrWhiteSpace(telefoneTexto) ? "" : mtbTelefone.Text,
            Turma = string.IsNullOrWhiteSpace(txtTurma.Text) ? "" : txtTurma.Text,
            Ativo = chkAtivo.Checked
        });

        Limpar();
        CarregarGrid();
        MessageBox.Show("Edição efetuada com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
        Limpar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
        Limpar();
        }

        private void Limpar()
        {
        txtId.Clear();
        txtNome.Clear();
        txtEmail.Clear();
        mtbTelefone.Clear();
        txtTurma.Clear();
        chkAtivo.Checked = true; 
        }

        private void dgvLeitores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        if (e.RowIndex < 0) return;

        var row = dgvLeitores.Rows[e.RowIndex];

        txtId.Text = row.Cells["Id"].Value?.ToString();
        txtNome.Text = row.Cells["Nome"].Value?.ToString();
        txtEmail.Text = row.Cells["Email"].Value?.ToString();
        mtbTelefone.Text = row.Cells["Telefone"].Value?.ToString();
        txtTurma.Text = row.Cells["Turma"].Value?.ToString();
        chkAtivo.Checked = row.Cells["Ativo"].Value != null && Convert.ToBoolean(row.Cells["Ativo"].Value);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Selecione um leitor na tabela primeiro para excluir!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var ok = MessageBox.Show("Deseja excluir este leitor do sistema?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ok == DialogResult.Yes)
            {
                _leitorController.Excluir(int.Parse(txtId.Text));
                CarregarGrid();
                Limpar();
                MessageBox.Show("Leitor excluído com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
}
}

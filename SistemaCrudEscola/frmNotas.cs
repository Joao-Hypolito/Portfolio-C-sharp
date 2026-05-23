using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EscolaBD.Models;
using EscolaBD.Controllers;

namespace EscolaBD
{
    public partial class frmNotas : Form
    {
        private readonly NotaController _nota = new();
        private readonly int _alunoId;

        public frmNotas(int alunoId, string alunoNome)
        {
            InitializeComponent();
            _alunoId = alunoId;
            label4.Text = $"Notas do aluno: {alunoNome}";
        }

        private void frmNotas_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            dgvNotas.DataSource = _nota.ListarPorAluno(_alunoId);
        }

        private void dgvNotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvNotas.Rows[e.RowIndex];
            txtId.Text = row.Cells["Id"].Value.ToString();
            txtDisciplina.Text = row.Cells["Disciplina"].Value.ToString()!;
            txtValor.Text = row.Cells["Valor"].Value.ToString()!;
            txtPeriodo.Text = row.Cells["Periodo"].Value.ToString()!;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            _nota.Inserir(new Notas
            {
                AlunoId = _alunoId,
                Disciplina = txtDisciplina.Text,
                Valor = decimal.Parse(txtValor.Text),
                Periodo = txtPeriodo.Text
            });
            CarregarGrid();
            Limpar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text)) return;
            _nota.Atualizar(new Notas
            {
                Id = int.Parse(txtId.Text),
                Disciplina = txtDisciplina.Text,
                Valor = decimal.Parse(txtValor.Text),
                Periodo = txtPeriodo.Text
            });
            CarregarGrid();
            Limpar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text)) return;
            _nota.Excluir(int.Parse(txtId.Text));
            CarregarGrid();
            Limpar();
        }

        private void Limpar()
        {
            txtId.Clear();
            txtDisciplina.Clear();
            txtValor.Clear();
            txtPeriodo.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

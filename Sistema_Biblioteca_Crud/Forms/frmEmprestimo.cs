using Sistema_Biblioteca_Crud.Models;
using Sistema_Biblioteca_Crud.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Biblioteca_Crud
{
    public partial class frmEmprestimo : Form
    {
        private readonly ControllerEmprestimo _emprestimoController = new();
        private readonly ControllerLeitores _leitorController = new();
        private readonly ControllerLivros _livroController = new();

        private int _idEmprestimoSelecionado = 0;
        public frmEmprestimo()
        {
        InitializeComponent();
        }
        private void frmEmprestimo_Load(object sender, EventArgs e)
        {
        ConfigurarComponentes();
        CarregarCombos();
        CarregarGrid();
        }

        private void ConfigurarComponentes()
        {

        dtpEmprestimo.Format = DateTimePickerFormat.Short;
        dtpEmprestimo.Value = DateTime.Today;

        dtpDevolucao.Format = DateTimePickerFormat.Short;
        dtpDevolucao.Value = DateTime.Today.AddDays(7);


        dgvEmprestimos.ReadOnly = true;
        dgvEmprestimos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvEmprestimos.AutoGenerateColumns = false;


        btnDevolver.Enabled = false;
        }

        private void CarregarCombos()
        {

        cboLeitor.DataSource = _leitorController.Listar();
        cboLeitor.DisplayMember = "Nome";
        cboLeitor.ValueMember = "Id";
        cboLeitor.SelectedIndex = -1;


        var livrosDisponiveis = _livroController.Listar()
            .Where(l => l.Quantidade > 0 && l.Ativo == true)
            .ToList();

        cboLivro.DataSource = livrosDisponiveis;
        cboLivro.DisplayMember = "Titulo";
        cboLivro.ValueMember = "Id";
        cboLivro.SelectedIndex = -1;


        cboFiltroLeitor.DataSource = _leitorController.Listar();
        cboFiltroLeitor.DisplayMember = "Nome";
        cboFiltroLeitor.ValueMember = "Id";
        cboFiltroLeitor.SelectedIndex = -1;
        }

        private void CarregarGrid()
        {
        dgvEmprestimos.DataSource = _emprestimoController.Listar();


        if (dgvEmprestimos.Columns["Id"] != null) dgvEmprestimos.Columns["Id"].Visible = false;
        if (dgvEmprestimos.Columns["LeitorId"] != null) dgvEmprestimos.Columns["LeitorId"].Visible = false;
        if (dgvEmprestimos.Columns["LivroId"] != null) dgvEmprestimos.Columns["LivroId"].Visible = false;
        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cboLeitor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEmprestar_Click(object sender, EventArgs e)
        {
        if (cboLeitor.SelectedValue == null)
        {
        MessageBox.Show("Por favor, selecione um Leitor válido para o empréstimo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
        }

        if (cboLivro.SelectedValue == null)
        {
        MessageBox.Show("Por favor, selecione um Livro disponível para o empréstimo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
        }

        var novoEmprestimo = new Emprestimos
        {
            LeitorId = (int)cboLeitor.SelectedValue,
            LivroId = (int)cboLivro.SelectedValue,
            DataEmprestimo = dtpEmprestimo.Value,
            DataDevolucao = dtpDevolucao.Value,
            Devolvido = false
        };


        _emprestimoController.Inserir(novoEmprestimo);


        CarregarGrid();
        CarregarCombos();
        Limpar();

        MessageBox.Show("Empréstimo registrado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvEmprestimos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        if (e.RowIndex < 0) return;

        var row = dgvEmprestimos.Rows[e.RowIndex];


        if (dgvEmprestimos.Columns["Id"] != null && row.Cells["Id"].Value != null)
        {
        _idEmprestimoSelecionado = Convert.ToInt32(row.Cells["Id"].Value);
        }


        if (dgvEmprestimos.Columns["Devolvido"] != null && row.Cells["Devolvido"].Value != null)
        {
        bool isDevolvido = Convert.ToBoolean(row.Cells["Devolvido"].Value);


        btnDevolver.Enabled = !isDevolvido;
        }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
        if (_idEmprestimoSelecionado == 0)
        {
        MessageBox.Show("Selecione um empréstimo em aberto na tabela primeiro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
        }

        var confirmacao = MessageBox.Show("Confirmar a devolução deste livro?", "Registrar Devolução", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (confirmacao == DialogResult.Yes)
        {

        _emprestimoController.Devolver(_idEmprestimoSelecionado);


        CarregarGrid();
        CarregarCombos();
        Limpar();

        MessageBox.Show("Devolução registrada com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        }

        private void cboFiltroLeitor_SelectedIndexChanged(object sender, EventArgs e)
        {
        if (cboFiltroLeitor.SelectedValue != null && cboFiltroLeitor.Focused)
            {
                int idLeitor = (int)cboFiltroLeitor.SelectedValue;
        
                
                dgvEmprestimos.DataSource = _emprestimoController.ListarPorLeitor(idLeitor);
            }
        }

        private void Limpar()
        {
            cboLeitor.SelectedIndex = -1;
            cboLivro.SelectedIndex = -1;
            cboFiltroLeitor.SelectedIndex = -1; 
            dtpEmprestimo.Value = DateTime.Today;
            dtpDevolucao.Value = DateTime.Today.AddDays(7);
            _idEmprestimoSelecionado = 0;
            btnDevolver.Enabled = false;
    
            CarregarGrid();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

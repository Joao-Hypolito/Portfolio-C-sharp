﻿using System;
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
    public partial class frmLivros : Form
    {
        private readonly ControllerLivros _livroController = new();
        public frmLivros()
        {
        InitializeComponent();
        }

        private void frmLivros_Load(object sender, EventArgs e)
        {
        CarregarGrid();
        }

        private void CarregarGrid()
        {
        dgvLivros.DataSource = _livroController.Listar();


        if (dgvLivros.Columns["Id"] != null)
        {
        dgvLivros.Columns["Id"].Visible = false;
        }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
        _livroController.Inserir(new Livros
        {
            Titulo = txtTitulo.Text,
            Autor = txtAutor.Text,
            ISBN = string.IsNullOrWhiteSpace(txtISBN.Text) ? null : txtISBN.Text,
            Categoria = txtCategoria.Text,
            Quantidade = (int)nudQuantidade.Value,
            Ativo = chkAtivo.Checked
        });

        CarregarGrid();
        Limpar();
        MessageBox.Show("Livro salvo com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
        if (string.IsNullOrEmpty(txtId.Text))
        {
        MessageBox.Show("Selecione um livro na tabela primeiro para editar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
        }

        _livroController.Atuaisar(new Livros
        {
            Id = int.Parse(txtId.Text),
            Titulo = txtTitulo.Text,
            Autor = txtAutor.Text,
            ISBN = string.IsNullOrWhiteSpace(txtISBN.Text) ? null : txtISBN.Text,
            Categoria = txtCategoria.Text,
            Quantidade = (int)nudQuantidade.Value,
            Ativo = chkAtivo.Checked
        });

        Limpar();
        CarregarGrid();
        MessageBox.Show("Edição efetuada com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNovo_Click(object sender, EventArgs e)
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
        txtTitulo.Clear();
        txtAutor.Clear();
        txtISBN.Clear();
        txtCategoria.Clear();
        nudQuantidade.Value = 0;
        chkAtivo.Checked = true;
        if (cboFiltroLivro.Items.Count > 0) 
        {
        cboFiltroLivro.SelectedIndex = -1;
        }
        CarregarGrid();
        }

        private void dgvLivros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        if (e.RowIndex < 0) return;
        var row = dgvLivros.Rows[e.RowIndex];
        txtId.Text = row.Cells["Id"].Value?.ToString();
        txtTitulo.Text = row.Cells["Titulo"].Value?.ToString();
        txtAutor.Text = row.Cells["Autor"].Value?.ToString();
        txtCategoria.Text = row.Cells["Categoria"].Value?.ToString();
        nudQuantidade.Value = row.Cells["Quantidade"].Value != null ? Convert.ToDecimal(row.Cells["Quantidade"].Value) : 0;
        chkAtivo.Checked = row.Cells["Ativo"].Value != null && Convert.ToBoolean(row.Cells["Ativo"].Value);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
        if (string.IsNullOrEmpty(txtId.Text))
        {
        MessageBox.Show("Selecione um leitor na tabela para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
        }

        var confirmacao = MessageBox.Show("Deseja realmente excluir este leitor?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (confirmacao == DialogResult.Yes)
        {
        try
        {
        
        int idLeitor = int.Parse(txtId.Text);

        
        _livroController.Excluir(idLeitor);

        CarregarGrid();
        Limpar();
        MessageBox.Show("Leitor excluído com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception)
        {
        
        MessageBox.Show("Não é possível excluir este leitor pois ele possui histórico de empréstimos vinculado!",
                        "Erro ao Excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        }
        }

        private void cboFiltroLivro_SelectedIndexChanged(object sender, EventArgs e)
        {
        if (cboFiltroLivro.SelectedValue != null && cboFiltroLivro.Focused)
        {
        int idLeitor = (int)cboFiltroLivro.SelectedValue;

        
        dgvLivros.DataSource = _livroController.ListarPorLivro(idLeitor);
        }
        }

        private void dgvLivros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmLivros_Load_1(object sender, EventArgs e)
        {

        }
    }
}

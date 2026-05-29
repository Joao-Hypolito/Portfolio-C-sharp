namespace Sistema_Biblioteca_Crud
{
    partial class frmLivros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
        if (disposing && (components != null))
        {
        components.Dispose();
        }
        base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
        button1 = new Button();
        btnSalvar = new Button();
        btnEditar = new Button();
        btnExcluir = new Button();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        label6 = new Label();
        txtTitulo = new TextBox();
        txtAutor = new TextBox();
        txtCategoria = new TextBox();
        chkAtivo = new CheckBox();
        dgvLivros = new DataGridView();
        Titulo = new DataGridViewTextBoxColumn();
        Id = new DataGridViewTextBoxColumn();
        Autor = new DataGridViewTextBoxColumn();
        Categoria = new DataGridViewTextBoxColumn();
        Quantidade = new DataGridViewTextBoxColumn();
        Ativo = new DataGridViewCheckBoxColumn();
        txtISBN = new MaskedTextBox();
        nudQuantidade = new NumericUpDown();
        statusStrip1 = new StatusStrip();
        btnLimpar = new Button();
        txtId = new TextBox();
        cboFiltroLivro = new ComboBox();
        ((System.ComponentModel.ISupportInitialize)dgvLivros).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudQuantidade).BeginInit();
        SuspendLayout();
        // 
        // button1
        // 
        button1.BackColor = SystemColors.HotTrack;
        button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        button1.ForeColor = SystemColors.ButtonFace;
        button1.Location = new Point(87, 51);
        button1.Name = "button1";
        button1.Size = new Size(171, 60);
        button1.TabIndex = 0;
        button1.Text = "Novo";
        button1.UseVisualStyleBackColor = false;
        button1.Click += btnNovo_Click;
        // 
        // btnSalvar
        // 
        btnSalvar.BackColor = Color.LimeGreen;
        btnSalvar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnSalvar.ForeColor = SystemColors.ButtonFace;
        btnSalvar.Location = new Point(275, 51);
        btnSalvar.Name = "btnSalvar";
        btnSalvar.Size = new Size(171, 60);
        btnSalvar.TabIndex = 1;
        btnSalvar.Text = "Salvar";
        btnSalvar.UseVisualStyleBackColor = false;
        btnSalvar.Click += btnSalvar_Click;
        // 
        // btnEditar
        // 
        btnEditar.BackColor = Color.DarkOrange;
        btnEditar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnEditar.ForeColor = SystemColors.ControlLight;
        btnEditar.Location = new Point(465, 51);
        btnEditar.Name = "btnEditar";
        btnEditar.Size = new Size(171, 60);
        btnEditar.TabIndex = 2;
        btnEditar.Text = "Editar";
        btnEditar.UseVisualStyleBackColor = false;
        btnEditar.Click += btnEditar_Click;
        // 
        // btnExcluir
        // 
        btnExcluir.BackColor = Color.Red;
        btnExcluir.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnExcluir.ForeColor = SystemColors.ControlLight;
        btnExcluir.Location = new Point(654, 51);
        btnExcluir.Name = "btnExcluir";
        btnExcluir.Size = new Size(171, 60);
        btnExcluir.TabIndex = 3;
        btnExcluir.Text = "Excluir";
        btnExcluir.UseVisualStyleBackColor = false;
        btnExcluir.Click += btnExcluir_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.Location = new Point(87, 2);
        label1.Name = "label1";
        label1.Size = new Size(200, 31);
        label1.TabIndex = 5;
        label1.Text = "Acervo de Livros";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label2.Location = new Point(87, 138);
        label2.Name = "label2";
        label2.Size = new Size(183, 31);
        label2.TabIndex = 6;
        label2.Text = "Dados do Livro";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label3.Location = new Point(93, 182);
        label3.Name = "label3";
        label3.Size = new Size(56, 21);
        label3.TabIndex = 7;
        label3.Text = "Título";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label4.Location = new Point(93, 241);
        label4.Name = "label4";
        label4.Size = new Size(53, 21);
        label4.TabIndex = 8;
        label4.Text = "Autor";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label5.Location = new Point(93, 291);
        label5.Name = "label5";
        label5.Size = new Size(81, 21);
        label5.TabIndex = 9;
        label5.Text = "Categoria";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label6.Location = new Point(351, 241);
        label6.Name = "label6";
        label6.Size = new Size(52, 21);
        label6.TabIndex = 10;
        label6.Text = "ISBN";
        // 
        // txtTitulo
        // 
        txtTitulo.Location = new Point(93, 215);
        txtTitulo.Name = "txtTitulo";
        txtTitulo.Size = new Size(237, 23);
        txtTitulo.TabIndex = 11;
        // 
        // txtAutor
        // 
        txtAutor.Location = new Point(93, 265);
        txtAutor.Name = "txtAutor";
        txtAutor.Size = new Size(237, 23);
        txtAutor.TabIndex = 12;
        // 
        // txtCategoria
        // 
        txtCategoria.Location = new Point(93, 315);
        txtCategoria.Name = "txtCategoria";
        txtCategoria.Size = new Size(237, 23);
        txtCategoria.TabIndex = 13;
        // 
        // chkAtivo
        // 
        chkAtivo.AutoSize = true;
        chkAtivo.Checked = true;
        chkAtivo.CheckState = CheckState.Checked;
        chkAtivo.Location = new Point(502, 319);
        chkAtivo.Name = "chkAtivo";
        chkAtivo.Size = new Size(111, 19);
        chkAtivo.TabIndex = 5;
        chkAtivo.Text = "Ativo no Acervo";
        chkAtivo.UseVisualStyleBackColor = true;
        // 
        // dgvLivros
        // 
        dgvLivros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvLivros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvLivros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvLivros.Columns.AddRange(new DataGridViewColumn[] { Titulo, Id, Autor, Categoria, Quantidade, Ativo });
        dgvLivros.Location = new Point(93, 373);
        dgvLivros.MultiSelect = false;
        dgvLivros.Name = "dgvLivros";
        dgvLivros.ReadOnly = true;
        dgvLivros.Size = new Size(1272, 150);
        dgvLivros.TabIndex = 15;
        dgvLivros.CellClick += dgvLivros_CellClick;
        dgvLivros.CellContentClick += dgvLivros_CellContentClick;
        // 
        // Titulo
        // 
        Titulo.DataPropertyName = "Titulo";
        Titulo.HeaderText = "Título";
        Titulo.Name = "Titulo";
        Titulo.ReadOnly = true;
        // 
        // Id
        // 
        Id.DataPropertyName = "Id";
        Id.HeaderText = "ID";
        Id.Name = "Id";
        Id.ReadOnly = true;
        Id.Visible = false;
        // 
        // Autor
        // 
        Autor.DataPropertyName = "Autor";
        Autor.HeaderText = "Autor";
        Autor.Name = "Autor";
        Autor.ReadOnly = true;
        // 
        // Categoria
        // 
        Categoria.DataPropertyName = "Categoria";
        Categoria.HeaderText = "Categoria";
        Categoria.Name = "Categoria";
        Categoria.ReadOnly = true;
        // 
        // Quantidade
        // 
        Quantidade.DataPropertyName = "Quantidade";
        Quantidade.HeaderText = "Quantidade";
        Quantidade.Name = "Quantidade";
        Quantidade.ReadOnly = true;
        // 
        // Ativo
        // 
        Ativo.DataPropertyName = "Ativo";
        Ativo.HeaderText = "Ativo";
        Ativo.Name = "Ativo";
        Ativo.ReadOnly = true;
        Ativo.Visible = false;
        // 
        // txtISBN
        // 
        txtISBN.Location = new Point(351, 265);
        txtISBN.Name = "txtISBN";
        txtISBN.Size = new Size(187, 23);
        txtISBN.TabIndex = 16;
        // 
        // nudQuantidade
        // 
        nudQuantidade.Location = new Point(351, 315);
        nudQuantidade.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
        nudQuantidade.Name = "nudQuantidade";
        nudQuantidade.Size = new Size(120, 23);
        nudQuantidade.TabIndex = 4;
        nudQuantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // statusStrip1
        // 
        statusStrip1.Location = new Point(0, 532);
        statusStrip1.Name = "statusStrip1";
        statusStrip1.Size = new Size(1445, 22);
        statusStrip1.TabIndex = 18;
        statusStrip1.Text = "statusStrip1";
        // 
        // btnLimpar
        // 
        btnLimpar.BackColor = Color.DimGray;
        btnLimpar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnLimpar.ForeColor = SystemColors.ControlLight;
        btnLimpar.Location = new Point(853, 51);
        btnLimpar.Name = "btnLimpar";
        btnLimpar.Size = new Size(171, 60);
        btnLimpar.TabIndex = 19;
        btnLimpar.Text = "Limpar";
        btnLimpar.UseVisualStyleBackColor = false;
        btnLimpar.Click += btnLimpar_Click;
        // 
        // txtId
        // 
        txtId.Location = new Point(571, 265);
        txtId.Name = "txtId";
        txtId.Size = new Size(100, 23);
        txtId.TabIndex = 20;
        txtId.Visible = false;
        // 
        // cboFiltroLivro
        // 
        cboFiltroLivro.FormattingEnabled = true;
        cboFiltroLivro.Location = new Point(93, 344);
        cboFiltroLivro.Name = "cboFiltroLivro";
        cboFiltroLivro.Size = new Size(121, 23);
        cboFiltroLivro.TabIndex = 68;
        cboFiltroLivro.Text = "Todos os livros";
        cboFiltroLivro.SelectedIndexChanged += cboFiltroLivro_SelectedIndexChanged;
        // 
        // frmLivros
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1445, 554);
        Controls.Add(cboFiltroLivro);
        Controls.Add(txtId);
        Controls.Add(btnLimpar);
        Controls.Add(statusStrip1);
        Controls.Add(nudQuantidade);
        Controls.Add(txtISBN);
        Controls.Add(dgvLivros);
        Controls.Add(chkAtivo);
        Controls.Add(txtCategoria);
        Controls.Add(txtAutor);
        Controls.Add(txtTitulo);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(btnExcluir);
        Controls.Add(btnEditar);
        Controls.Add(btnSalvar);
        Controls.Add(button1);
        Name = "frmLivros";
        Text = "forms";
        Load += frmLivros_Load_1;
        ((System.ComponentModel.ISupportInitialize)dgvLivros).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudQuantidade).EndInit();
        ResumeLayout(false);
        PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnExcluir;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtTitulo;
        private TextBox txtAutor;
        private TextBox txtCategoria;
        private CheckBox chkAtivo;
        private DataGridView dgvLivros;
        private MaskedTextBox txtISBN;
        private NumericUpDown nudQuantidade;
        private StatusStrip statusStrip1;
        private Button btnLimpar;
        private TextBox txtId;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Autor;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewCheckBoxColumn Ativo;
        private ComboBox cboFiltroLivro;
    }
}
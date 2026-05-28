namespace Sistema_Biblioteca_Crud
{
    partial class frmEmprestimo
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
        label1 = new Label();
        gbNovoEmp = new GroupBox();
        cboLeitor = new ComboBox();
        cboLivro = new ComboBox();
        label7 = new Label();
        label8 = new Label();
        label2 = new Label();
        dgvEmprestimos = new DataGridView();
        statusStrip1 = new StatusStrip();
        dtpEmprestimo = new DateTimePicker();
        dtpDevolucao = new DateTimePicker();
        gbEmAberto = new GroupBox();
        label3 = new Label();
        label4 = new Label();
        btnEmprestar = new Button();
        btnDevolver = new Button();
        lblFeedback = new Label();
        txtId = new TextBox();
        cboFiltroLeitor = new ComboBox();
        label5 = new Label();
        Leitor = new DataGridViewTextBoxColumn();
        Livro = new DataGridViewTextBoxColumn();
        Id = new DataGridViewTextBoxColumn();
        Emprestimo = new DataGridViewTextBoxColumn();
        Devolvido = new DataGridViewTextBoxColumn();
        Status = new DataGridViewCheckBoxColumn();
        ((System.ComponentModel.ISupportInitialize)dgvEmprestimos).BeginInit();
        gbEmAberto.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.Location = new Point(22, 21);
        label1.Name = "label1";
        label1.Size = new Size(292, 31);
        label1.TabIndex = 39;
        label1.Text = "Controle de Emprestimos";
        // 
        // gbNovoEmp
        // 
        gbNovoEmp.Location = new Point(16, 104);
        gbNovoEmp.Name = "gbNovoEmp";
        gbNovoEmp.Size = new Size(815, 130);
        gbNovoEmp.TabIndex = 53;
        gbNovoEmp.TabStop = false;
        gbNovoEmp.Text = "■ Novo Empréstimo";
        // 
        // cboLeitor
        // 
        cboLeitor.DisplayMember = "Nome";
        cboLeitor.FormattingEnabled = true;
        cboLeitor.Location = new Point(22, 145);
        cboLeitor.Name = "cboLeitor";
        cboLeitor.Size = new Size(795, 23);
        cboLeitor.TabIndex = 0;
        cboLeitor.ValueMember = "Id";
        cboLeitor.SelectedIndexChanged += cboLeitor_SelectedIndexChanged;
        // 
        // cboLivro
        // 
        cboLivro.FormattingEnabled = true;
        cboLivro.Location = new Point(22, 195);
        cboLivro.Name = "cboLivro";
        cboLivro.Size = new Size(795, 23);
        cboLivro.TabIndex = 54;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(22, 177);
        label7.Name = "label7";
        label7.Size = new Size(93, 15);
        label7.TabIndex = 55;
        label7.Text = " Livro disponível";
        label7.Click += label7_Click;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(28, 127);
        label8.Name = "label8";
        label8.Size = new Size(37, 15);
        label8.TabIndex = 56;
        label8.Text = "Leitor";
        label8.Click += label8_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label2.Location = new Point(22, 70);
        label2.Name = "label2";
        label2.Size = new Size(211, 31);
        label2.TabIndex = 40;
        label2.Text = "Novo Emprestimo";
        // 
        // dgvEmprestimos
        // 
        dgvEmprestimos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvEmprestimos.Columns.AddRange(new DataGridViewColumn[] { Leitor, Livro, Id, Emprestimo, Devolvido, Status });
        dgvEmprestimos.Location = new Point(22, 379);
        dgvEmprestimos.Name = "dgvEmprestimos";
        dgvEmprestimos.ReadOnly = true;
        dgvEmprestimos.Size = new Size(1272, 150);
        dgvEmprestimos.TabIndex = 49;
        dgvEmprestimos.CellContentClick += dgvEmprestimos_CellClick;
        // 
        // statusStrip1
        // 
        statusStrip1.Location = new Point(0, 541);
        statusStrip1.Name = "statusStrip1";
        statusStrip1.Size = new Size(1317, 22);
        statusStrip1.TabIndex = 52;
        statusStrip1.Text = "statusStrip1";
        // 
        // dtpEmprestimo
        // 
        dtpEmprestimo.Location = new Point(511, 283);
        dtpEmprestimo.Name = "dtpEmprestimo";
        dtpEmprestimo.Size = new Size(200, 23);
        dtpEmprestimo.TabIndex = 57;
        dtpEmprestimo.Value = new DateTime(2026, 5, 28, 8, 27, 55, 0);
        // 
        // dtpDevolucao
        // 
        dtpDevolucao.Location = new Point(735, 283);
        dtpDevolucao.Name = "dtpDevolucao";
        dtpDevolucao.Size = new Size(200, 23);
        dtpDevolucao.TabIndex = 58;
        dtpDevolucao.Value = new DateTime(2026, 5, 28, 8, 28, 2, 0);
        // 
        // gbEmAberto
        // 
        gbEmAberto.Controls.Add(cboFiltroLeitor);
        gbEmAberto.Controls.Add(label5);
        gbEmAberto.Controls.Add(btnDevolver);
        gbEmAberto.Controls.Add(btnEmprestar);
        gbEmAberto.Location = new Point(16, 240);
        gbEmAberto.Name = "gbEmAberto";
        gbEmAberto.Size = new Size(478, 126);
        gbEmAberto.TabIndex = 59;
        gbEmAberto.TabStop = false;
        gbEmAberto.Text = "■ Empréstimos em Aberto";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(511, 250);
        label3.Name = "label3";
        label3.Size = new Size(98, 15);
        label3.TabIndex = 60;
        label3.Text = "Data Empréstimo";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(735, 250);
        label4.Name = "label4";
        label4.Size = new Size(90, 15);
        label4.TabIndex = 61;
        label4.Text = "Data Devolução";
        // 
        // btnEmprestar
        // 
        btnEmprestar.Location = new Point(6, 25);
        btnEmprestar.Name = "btnEmprestar";
        btnEmprestar.Size = new Size(172, 23);
        btnEmprestar.TabIndex = 62;
        btnEmprestar.Text = "■ Registrar Empréstimo\r\n";
        btnEmprestar.UseVisualStyleBackColor = true;
        btnEmprestar.Click += btnEmprestar_Click;
        // 
        // btnDevolver
        // 
        btnDevolver.Location = new Point(196, 25);
        btnDevolver.Name = "btnDevolver";
        btnDevolver.Size = new Size(155, 23);
        btnDevolver.TabIndex = 63;
        btnDevolver.Text = "■ Registrar Devolucao\r\n";
        btnDevolver.UseVisualStyleBackColor = true;
        btnDevolver.Click += btnDevolver_Click;
        // 
        // lblFeedback
        // 
        lblFeedback.Location = new Point(1180, 328);
        lblFeedback.Name = "lblFeedback";
        lblFeedback.Size = new Size(100, 23);
        lblFeedback.TabIndex = 65;
        lblFeedback.Text = "label6";
        lblFeedback.Visible = false;
        // 
        // txtId
        // 
        txtId.Location = new Point(676, 325);
        txtId.Name = "txtId";
        txtId.Size = new Size(100, 23);
        txtId.TabIndex = 66;
        txtId.Visible = false;
        // 
        // cboFiltroLeitor
        // 
        cboFiltroLeitor.FormattingEnabled = true;
        cboFiltroLeitor.Location = new Point(128, 65);
        cboFiltroLeitor.Name = "cboFiltroLeitor";
        cboFiltroLeitor.Size = new Size(121, 23);
        cboFiltroLeitor.TabIndex = 67;
        cboFiltroLeitor.Text = "Todos os leitores";
        cboFiltroLeitor.SelectedIndexChanged += cboFiltroLeitor_SelectedIndexChanged;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(12, 65);
        label5.Name = "label5";
        label5.Size = new Size(91, 15);
        label5.TabIndex = 68;
        label5.Text = "Filtrar por leitor:";
        // 
        // Leitor
        // 
        Leitor.DataPropertyName = "NomeLeitor";
        Leitor.HeaderText = "Leitor";
        Leitor.Name = "Leitor";
        Leitor.ReadOnly = true;
        // 
        // Livro
        // 
        Livro.DataPropertyName = "TituloLivro";
        Livro.HeaderText = "Livro";
        Livro.Name = "Livro";
        Livro.ReadOnly = true;
        // 
        // Id
        // 
        Id.DataPropertyName = "Id";
        Id.HeaderText = "Id";
        Id.Name = "Id";
        Id.ReadOnly = true;
        Id.Visible = false;
        // 
        // Emprestimo
        // 
        Emprestimo.DataPropertyName = "DataEmprestimo";
        Emprestimo.HeaderText = "Emprest.";
        Emprestimo.Name = "Emprestimo";
        Emprestimo.ReadOnly = true;
        // 
        // Devolvido
        // 
        Devolvido.DataPropertyName = "Devolvido";
        Devolvido.HeaderText = "Devolucao";
        Devolvido.Name = "Devolvido";
        Devolvido.ReadOnly = true;
        // 
        // Status
        // 
        Status.DataPropertyName = "Devolvido";
        Status.HeaderText = "Staus";
        Status.Name = "Status";
        Status.ReadOnly = true;
        Status.Visible = false;
        // 
        // frmEmprestimo
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1317, 563);
        Controls.Add(txtId);
        Controls.Add(lblFeedback);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(dtpDevolucao);
        Controls.Add(dtpEmprestimo);
        Controls.Add(label8);
        Controls.Add(label7);
        Controls.Add(cboLivro);
        Controls.Add(cboLeitor);
        Controls.Add(gbNovoEmp);
        Controls.Add(statusStrip1);
        Controls.Add(dgvEmprestimos);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(gbEmAberto);
        Name = "frmEmprestimo";
        Text = "frmEmprestimo";
        Load += frmEmprestimo_Load;
        ((System.ComponentModel.ISupportInitialize)dgvEmprestimos).EndInit();
        gbEmAberto.ResumeLayout(false);
        gbEmAberto.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
        }

        #endregion
        private Label label1;
        private GroupBox gbNovoEmp;
        private ComboBox cboLeitor;
        private ComboBox cboLivro;
        private Label label7;
        private Label label8;
        private Label label2;
        private DataGridView dgvEmprestimos;
        private StatusStrip statusStrip1;
        private DateTimePicker dtpEmprestimo;
        private DateTimePicker dtpDevolucao;
        private GroupBox gbEmAberto;
        private Label label3;
        private Label label4;
        private Button btnEmprestar;
        private Button btnDevolver;
        private Label lblFeedback;
        private TextBox txtId;
        private ComboBox cboFiltroLeitor;
        private Label label5;
        private DataGridViewTextBoxColumn Leitor;
        private DataGridViewTextBoxColumn Livro;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Emprestimo;
        private DataGridViewTextBoxColumn Devolvido;
        private DataGridViewCheckBoxColumn Status;
    }
}
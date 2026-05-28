namespace Sistema_Biblioteca_Crud
{
    partial class frmLeitores
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
        mtbTelefone = new MaskedTextBox();
        dgvLeitores = new DataGridView();
        chkAtivo = new CheckBox();
        txtTurma = new TextBox();
        txtEmail = new TextBox();
        txtNome = new TextBox();
        label6 = new Label();
        label5 = new Label();
        label4 = new Label();
        label3 = new Label();
        label2 = new Label();
        label1 = new Label();
        btnLimpar = new Button();
        btnExcluir = new Button();
        btnEditar = new Button();
        button2 = new Button();
        btnNovo = new Button();
        txtId = new TextBox();
        Nome = new DataGridViewTextBoxColumn();
        Email = new DataGridViewTextBoxColumn();
        Telefone = new DataGridViewTextBoxColumn();
        Id = new DataGridViewTextBoxColumn();
        Turma = new DataGridViewTextBoxColumn();
        Ativo = new DataGridViewCheckBoxColumn();
        ((System.ComponentModel.ISupportInitialize)dgvLeitores).BeginInit();
        SuspendLayout();
        // 
        // mtbTelefone
        // 
        mtbTelefone.Location = new Point(337, 320);
        mtbTelefone.Name = "mtbTelefone";
        mtbTelefone.Size = new Size(187, 23);
        mtbTelefone.TabIndex = 33;
        // 
        // dgvLeitores
        // 
        dgvLeitores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvLeitores.Columns.AddRange(new DataGridViewColumn[] { Nome, Email, Telefone, Id, Turma, Ativo });
        dgvLeitores.Location = new Point(79, 418);
        dgvLeitores.Name = "dgvLeitores";
        dgvLeitores.Size = new Size(1272, 150);
        dgvLeitores.TabIndex = 32;
        dgvLeitores.CellContentClick += dgvLeitores_CellContentClick;
        // 
        // chkAtivo
        // 
        chkAtivo.AutoSize = true;
        chkAtivo.Location = new Point(327, 374);
        chkAtivo.Name = "chkAtivo";
        chkAtivo.Size = new Size(158, 19);
        chkAtivo.TabIndex = 31;
        chkAtivo.Text = "Leitor Ativo na Biblioteca";
        chkAtivo.UseVisualStyleBackColor = true;
        // 
        // txtTurma
        // 
        txtTurma.Location = new Point(79, 370);
        txtTurma.Name = "txtTurma";
        txtTurma.Size = new Size(237, 23);
        txtTurma.TabIndex = 30;
        // 
        // txtEmail
        // 
        txtEmail.Location = new Point(79, 320);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(237, 23);
        txtEmail.TabIndex = 29;
        // 
        // txtNome
        // 
        txtNome.Location = new Point(79, 270);
        txtNome.Name = "txtNome";
        txtNome.Size = new Size(237, 23);
        txtNome.TabIndex = 28;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label6.Location = new Point(337, 296);
        label6.Name = "label6";
        label6.Size = new Size(74, 21);
        label6.TabIndex = 27;
        label6.Text = "Telefone";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label5.Location = new Point(79, 346);
        label5.Name = "label5";
        label5.Size = new Size(58, 21);
        label5.TabIndex = 26;
        label5.Text = "Turma";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label4.Location = new Point(79, 296);
        label4.Name = "label4";
        label4.Size = new Size(51, 21);
        label4.TabIndex = 25;
        label4.Text = "Email";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label3.Location = new Point(79, 237);
        label3.Name = "label3";
        label3.Size = new Size(134, 21);
        label3.TabIndex = 24;
        label3.Text = "Nome Completo";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label2.Location = new Point(79, 183);
        label2.Name = "label2";
        label2.Size = new Size(191, 31);
        label2.TabIndex = 23;
        label2.Text = "Dados do Leitor";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.Location = new Point(79, 47);
        label1.Name = "label1";
        label1.Size = new Size(239, 31);
        label1.TabIndex = 22;
        label1.Text = "Cadastro de Leitores";
        label1.Click += label1_Click;
        // 
        // btnLimpar
        // 
        btnLimpar.BackColor = SystemColors.AppWorkspace;
        btnLimpar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnLimpar.ForeColor = SystemColors.ControlLight;
        btnLimpar.Location = new Point(835, 96);
        btnLimpar.Name = "btnLimpar";
        btnLimpar.Size = new Size(171, 60);
        btnLimpar.TabIndex = 21;
        btnLimpar.Text = "Limpar";
        btnLimpar.UseVisualStyleBackColor = false;
        btnLimpar.Click += btnLimpar_Click;
        // 
        // btnExcluir
        // 
        btnExcluir.BackColor = Color.Red;
        btnExcluir.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnExcluir.ForeColor = SystemColors.ControlLight;
        btnExcluir.Location = new Point(646, 96);
        btnExcluir.Name = "btnExcluir";
        btnExcluir.Size = new Size(171, 60);
        btnExcluir.TabIndex = 20;
        btnExcluir.Text = "Excluir";
        btnExcluir.UseVisualStyleBackColor = false;
        btnExcluir.Click += btnExcluir_Click;
        // 
        // btnEditar
        // 
        btnEditar.BackColor = Color.DarkOrange;
        btnEditar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnEditar.ForeColor = SystemColors.ControlLight;
        btnEditar.Location = new Point(457, 96);
        btnEditar.Name = "btnEditar";
        btnEditar.Size = new Size(171, 60);
        btnEditar.TabIndex = 19;
        btnEditar.Text = "Editar";
        btnEditar.UseVisualStyleBackColor = false;
        btnEditar.Click += btnEditar_Click;
        // 
        // button2
        // 
        button2.BackColor = Color.LimeGreen;
        button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        button2.ForeColor = SystemColors.ButtonFace;
        button2.Location = new Point(267, 96);
        button2.Name = "button2";
        button2.Size = new Size(171, 60);
        button2.TabIndex = 18;
        button2.Text = "Salvar";
        button2.UseVisualStyleBackColor = false;
        button2.Click += button2_Click;
        // 
        // btnNovo
        // 
        btnNovo.BackColor = SystemColors.HotTrack;
        btnNovo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnNovo.ForeColor = SystemColors.ButtonFace;
        btnNovo.Location = new Point(79, 96);
        btnNovo.Name = "btnNovo";
        btnNovo.Size = new Size(171, 60);
        btnNovo.TabIndex = 17;
        btnNovo.Text = "Novo";
        btnNovo.UseVisualStyleBackColor = false;
        btnNovo.Click += btnNovo_Click_1;
        // 
        // txtId
        // 
        txtId.Location = new Point(554, 320);
        txtId.Name = "txtId";
        txtId.Size = new Size(100, 23);
        txtId.TabIndex = 34;
        txtId.Visible = false;
        // 
        // Nome
        // 
        Nome.DataPropertyName = "Nome";
        Nome.HeaderText = "Nome";
        Nome.Name = "Nome";
        // 
        // Email
        // 
        Email.DataPropertyName = "Email";
        Email.HeaderText = "E-mail";
        Email.Name = "Email";
        // 
        // Telefone
        // 
        Telefone.DataPropertyName = "Telefone";
        Telefone.HeaderText = "Telefone";
        Telefone.Name = "Telefone";
        // 
        // Id
        // 
        Id.DataPropertyName = "Id";
        Id.HeaderText = "Id";
        Id.Name = "Id";
        Id.Visible = false;
        // 
        // Turma
        // 
        Turma.HeaderText = "Turma";
        Turma.Name = "Turma";
        Turma.Visible = false;
        // 
        // Ativo
        // 
        Ativo.HeaderText = "Ativo";
        Ativo.Name = "Ativo";
        Ativo.Visible = false;
        // 
        // frmLeitores
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1431, 615);
        Controls.Add(txtId);
        Controls.Add(mtbTelefone);
        Controls.Add(dgvLeitores);
        Controls.Add(chkAtivo);
        Controls.Add(txtTurma);
        Controls.Add(txtEmail);
        Controls.Add(txtNome);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(btnLimpar);
        Controls.Add(btnExcluir);
        Controls.Add(btnEditar);
        Controls.Add(button2);
        Controls.Add(btnNovo);
        Name = "frmLeitores";
        Text = "frmLeitores";
        ((System.ComponentModel.ISupportInitialize)dgvLeitores).EndInit();
        ResumeLayout(false);
        PerformLayout();
        }

        #endregion

        private MaskedTextBox mtbTelefone;
        private DataGridView dgvLeitores;
        private CheckBox chkAtivo;
        private TextBox txtTurma;
        private TextBox txtEmail;
        private TextBox txtNome;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnLimpar;
        private Button btnExcluir;
        private Button btnEditar;
        private Button button2;
        private Button btnNovo;
        private TextBox txtId;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Telefone;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Turma;
        private DataGridViewCheckBoxColumn Ativo;
    }
}
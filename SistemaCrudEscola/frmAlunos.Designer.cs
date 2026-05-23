namespace EscolaBD
{
    partial class frmAlunos
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtTurma = new TextBox();
            dtpDataNascimento = new DateTimePicker();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnLimpar = new Button();
            btnNotas = new Button();
            btnVoltar = new Button();
            dgvAlunos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAlunos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 45);
            label1.Name = "label1";
            label1.Size = new Size(31, 30);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 45);
            label2.Name = "label2";
            label2.Size = new Size(70, 30);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(483, 45);
            label3.Name = "label3";
            label3.Size = new Size(71, 30);
            label3.TabIndex = 2;
            label3.Text = "E-mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 138);
            label4.Name = "label4";
            label4.Size = new Size(203, 30);
            label4.TabIndex = 3;
            label4.Text = "Data de Nascimento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(320, 138);
            label5.Name = "label5";
            label5.Size = new Size(72, 30);
            label5.TabIndex = 4;
            label5.Text = "Turma";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(37, 78);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 35);
            txtId.TabIndex = 5;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(158, 78);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(307, 35);
            txtNome.TabIndex = 6;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(483, 78);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(335, 35);
            txtEmail.TabIndex = 7;
            // 
            // txtTurma
            // 
            txtTurma.Location = new Point(320, 171);
            txtTurma.Name = "txtTurma";
            txtTurma.Size = new Size(145, 35);
            txtTurma.TabIndex = 8;
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Format = DateTimePickerFormat.Short;
            dtpDataNascimento.Location = new Point(40, 170);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(200, 35);
            dtpDataNascimento.TabIndex = 9;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Green;
            btnSalvar.ForeColor = SystemColors.Control;
            btnSalvar.Location = new Point(37, 241);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(121, 44);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(255, 128, 0);
            btnEditar.ForeColor = SystemColors.Control;
            btnEditar.Location = new Point(164, 241);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(121, 44);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Red;
            btnExcluir.ForeColor = SystemColors.Control;
            btnExcluir.Location = new Point(291, 241);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(121, 44);
            btnExcluir.TabIndex = 12;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(64, 64, 64);
            btnLimpar.ForeColor = SystemColors.Control;
            btnLimpar.Location = new Point(418, 241);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(121, 44);
            btnLimpar.TabIndex = 13;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnNotas
            // 
            btnNotas.BackColor = Color.Navy;
            btnNotas.ForeColor = SystemColors.Control;
            btnNotas.Location = new Point(545, 241);
            btnNotas.Name = "btnNotas";
            btnNotas.Size = new Size(121, 44);
            btnNotas.TabIndex = 14;
            btnNotas.Text = "Ver Notas";
            btnNotas.UseVisualStyleBackColor = false;
            btnNotas.Click += btnNotas_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Gray;
            btnVoltar.Location = new Point(697, 241);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(121, 44);
            btnVoltar.TabIndex = 15;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // dgvAlunos
            // 
            dgvAlunos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlunos.Location = new Point(37, 310);
            dgvAlunos.Name = "dgvAlunos";
            dgvAlunos.Size = new Size(781, 150);
            dgvAlunos.TabIndex = 16;
            dgvAlunos.CellClick += dgvAlunos_CellClick;
            dgvAlunos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // frmAlunos
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 472);
            Controls.Add(dgvAlunos);
            Controls.Add(btnVoltar);
            Controls.Add(btnNotas);
            Controls.Add(btnLimpar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(dtpDataNascimento);
            Controls.Add(txtTurma);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAlunos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Alunos";
            Load += frmAlunos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAlunos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtTurma;
        private DateTimePicker dtpDataNascimento;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnLimpar;
        private Button btnNotas;
        private Button btnVoltar;
        private DataGridView dgvAlunos;
    }
}
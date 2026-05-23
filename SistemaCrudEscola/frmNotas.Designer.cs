namespace EscolaBD
{
    partial class frmNotas
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
            label2 = new Label();
            txtDisciplina = new TextBox();
            label1 = new Label();
            txtValor = new TextBox();
            label3 = new Label();
            txtPeriodo = new TextBox();
            label4 = new Label();
            dgvNotas = new DataGridView();
            btnVoltar = new Button();
            btnLimpar = new Button();
            btnExcluir = new Button();
            btnEditar = new Button();
            btnSalvar = new Button();
            txtId = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvNotas).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 102);
            label2.Margin = new Padding(8, 0, 8, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 26;
            label2.Text = "Disciplina";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtDisciplina
            // 
            txtDisciplina.Location = new Point(22, 135);
            txtDisciplina.Margin = new Padding(8);
            txtDisciplina.Name = "txtDisciplina";
            txtDisciplina.Size = new Size(272, 33);
            txtDisciplina.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(310, 102);
            label1.Margin = new Padding(8, 0, 8, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 28;
            label1.Text = "Valor (0-10)";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(310, 135);
            txtValor.Margin = new Padding(8);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(111, 33);
            txtValor.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(437, 102);
            label3.Margin = new Padding(8, 0, 8, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 30;
            label3.Text = "Período";
            // 
            // txtPeriodo
            // 
            txtPeriodo.Location = new Point(437, 135);
            txtPeriodo.Margin = new Padding(8);
            txtPeriodo.Name = "txtPeriodo";
            txtPeriodo.Size = new Size(284, 33);
            txtPeriodo.TabIndex = 29;
            // 
            // label4
            // 
            label4.BackColor = Color.Navy;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(22, 9);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(788, 78);
            label4.TabIndex = 31;
            label4.Text = "Cadastro de Notas";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // dgvNotas
            // 
            dgvNotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNotas.Location = new Point(22, 266);
            dgvNotas.Name = "dgvNotas";
            dgvNotas.Size = new Size(791, 174);
            dgvNotas.TabIndex = 38;
            dgvNotas.CellClick += dgvNotas_CellClick;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Gray;
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(695, 196);
            btnVoltar.Margin = new Padding(5);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(118, 38);
            btnVoltar.TabIndex = 37;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(64, 64, 64);
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(406, 196);
            btnLimpar.Margin = new Padding(5);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(118, 38);
            btnLimpar.TabIndex = 35;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Red;
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(278, 196);
            btnExcluir.Margin = new Padding(5);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(118, 38);
            btnExcluir.TabIndex = 34;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(255, 128, 0);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(150, 196);
            btnEditar.Margin = new Padding(5);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(118, 38);
            btnEditar.TabIndex = 33;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Green;
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(22, 196);
            btnSalvar.Margin = new Padding(5);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(118, 38);
            btnSalvar.TabIndex = 32;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(557, 201);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 33);
            txtId.TabIndex = 40;
            txtId.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(557, 168);
            label5.Name = "label5";
            label5.Size = new Size(28, 25);
            label5.TabIndex = 39;
            label5.Text = "Id";
            label5.Visible = false;
            // 
            // frmNotas
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 466);
            Controls.Add(txtId);
            Controls.Add(label5);
            Controls.Add(dgvNotas);
            Controls.Add(btnVoltar);
            Controls.Add(btnLimpar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPeriodo);
            Controls.Add(label1);
            Controls.Add(txtValor);
            Controls.Add(label2);
            Controls.Add(txtDisciplina);
            Font = new Font("Segoe UI", 14.25F);
            Margin = new Padding(5);
            Name = "frmNotas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Notas de Alunos";
            Load += frmNotas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNotas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox txtDisciplina;
        private Label label1;
        private TextBox txtValor;
        private Label label3;
        private TextBox txtPeriodo;
        private Label label4;
        private DataGridView dgvNotas;
        private Button btnVoltar;
        private Button btnLimpar;
        private Button btnExcluir;
        private Button btnEditar;
        private Button btnSalvar;
        private TextBox txtId;
        private Label label5;
    }
}
namespace EscolaBD
{
    partial class frmProfessores
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
            dgvProfessores = new DataGridView();
            btnVoltar = new Button();
            btnLimpar = new Button();
            btnExcluir = new Button();
            btnEditar = new Button();
            btnSalvar = new Button();
            label4 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            txtEspecialidade = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtId = new TextBox();
            label5 = new Label();
            dtpAdmissao = new DateTimePicker();
            label9 = new Label();
            mtbTelefone = new MaskedTextBox();
            chkAtivo = new CheckBox();
            mtbCPF = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProfessores).BeginInit();
            SuspendLayout();
            // 
            // dgvProfessores
            // 
            dgvProfessores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProfessores.Location = new Point(5, 267);
            dgvProfessores.Name = "dgvProfessores";
            dgvProfessores.Size = new Size(791, 174);
            dgvProfessores.TabIndex = 53;
            dgvProfessores.CellContentClick += dgvProfessores_CellContentClick;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Gray;
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(517, 197);
            btnVoltar.Margin = new Padding(5);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(118, 38);
            btnVoltar.TabIndex = 52;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(64, 64, 64);
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(389, 197);
            btnLimpar.Margin = new Padding(5);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(118, 38);
            btnLimpar.TabIndex = 51;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Red;
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(261, 197);
            btnExcluir.Margin = new Padding(5);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(118, 38);
            btnExcluir.TabIndex = 50;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(255, 128, 0);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(133, 197);
            btnEditar.Margin = new Padding(5);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(118, 38);
            btnEditar.TabIndex = 49;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Green;
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(5, 197);
            btnSalvar.Margin = new Padding(5);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(118, 38);
            btnSalvar.TabIndex = 48;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.Navy;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(5, 10);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(788, 41);
            label4.TabIndex = 47;
            label4.Text = "Cadastro de Professores";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(407, 138);
            label3.Margin = new Padding(8, 0, 8, 0);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 46;
            label3.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(395, 161);
            txtEmail.Margin = new Padding(8);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(95, 23);
            txtEmail.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(169, 67);
            label1.Margin = new Padding(8, 0, 8, 0);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 44;
            label1.Text = "CPF";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 67);
            label2.Margin = new Padding(8, 0, 8, 0);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 42;
            label2.Text = "Nome";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(10, 90);
            txtNome.Margin = new Padding(8);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(143, 23);
            txtNome.TabIndex = 41;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtEspecialidade
            // 
            txtEspecialidade.Location = new Point(363, 90);
            txtEspecialidade.Margin = new Padding(8);
            txtEspecialidade.Name = "txtEspecialidade";
            txtEspecialidade.Size = new Size(144, 23);
            txtEspecialidade.TabIndex = 56;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(389, 67);
            label6.Margin = new Padding(8, 0, 8, 0);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 57;
            label6.Text = "Especialidade";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(530, 67);
            label7.Margin = new Padding(8, 0, 8, 0);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 59;
            label7.Text = "Telefone";
            // 
            // txtId
            // 
            txtId.Location = new Point(235, 161);
            txtId.Margin = new Padding(8);
            txtId.Name = "txtId";
            txtId.Size = new Size(144, 23);
            txtId.TabIndex = 62;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(235, 138);
            label5.Margin = new Padding(8, 0, 8, 0);
            label5.Name = "label5";
            label5.Size = new Size(17, 15);
            label5.TabIndex = 63;
            label5.Text = "Id";
            // 
            // dtpAdmissao
            // 
            dtpAdmissao.Format = DateTimePickerFormat.Short;
            dtpAdmissao.Location = new Point(12, 161);
            dtpAdmissao.Name = "dtpAdmissao";
            dtpAdmissao.Size = new Size(200, 23);
            dtpAdmissao.TabIndex = 64;
            dtpAdmissao.ValueChanged += dtpAdmissao_ValueChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 138);
            label9.Margin = new Padding(8, 0, 8, 0);
            label9.Name = "label9";
            label9.Size = new Size(102, 15);
            label9.TabIndex = 65;
            label9.Text = "Data de Admissao";
            // 
            // mtbTelefone
            // 
            mtbTelefone.Location = new Point(518, 90);
            mtbTelefone.Name = "mtbTelefone";
            mtbTelefone.Size = new Size(178, 23);
            mtbTelefone.TabIndex = 66;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Checked = true;
            chkAtivo.CheckState = CheckState.Checked;
            chkAtivo.Location = new Point(537, 165);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(106, 19);
            chkAtivo.TabIndex = 68;
            chkAtivo.Text = "Professor Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // mtbCPF
            // 
            mtbCPF.Location = new Point(164, 90);
            mtbCPF.Name = "mtbCPF";
            mtbCPF.Size = new Size(178, 23);
            mtbCPF.TabIndex = 69;
            // 
            // frmProfessores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mtbCPF);
            Controls.Add(chkAtivo);
            Controls.Add(mtbTelefone);
            Controls.Add(label9);
            Controls.Add(dtpAdmissao);
            Controls.Add(label5);
            Controls.Add(txtId);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtEspecialidade);
            Controls.Add(dgvProfessores);
            Controls.Add(btnVoltar);
            Controls.Add(btnLimpar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Name = "frmProfessores";
            Text = "frmProfessores";
            Load += frmProfessores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProfessores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvProfessores;
        private Button btnVoltar;
        private Button btnLimpar;
        private Button btnExcluir;
        private Button btnEditar;
        private Button btnSalvar;
        private Label label4;
        private Label label3;
        private TextBox txtEmail;
        private Label label1;
        private Label label2;
        private TextBox txtNome;
        private TextBox txtEspecialidade;
        private Label label6;
        private Label label7;
        private TextBox txtId;
        private Label label5;
        private DateTimePicker dtpAdmissao;
        private Label label9;
        private MaskedTextBox mtbTelefone;
        private CheckBox chkAtivo;
        private MaskedTextBox mtbCPF;
    }
}
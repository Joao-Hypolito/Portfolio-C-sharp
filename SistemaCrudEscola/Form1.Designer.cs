namespace EscolaBD
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAlunos = new Button();
            btnSair = new Button();
            buttonNotas = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnAlunos
            // 
            btnAlunos.BackColor = Color.Teal;
            btnAlunos.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAlunos.ForeColor = Color.White;
            btnAlunos.Location = new Point(58, 144);
            btnAlunos.Name = "btnAlunos";
            btnAlunos.Size = new Size(353, 128);
            btnAlunos.TabIndex = 0;
            btnAlunos.Text = "Cadastro de Alunos";
            btnAlunos.UseVisualStyleBackColor = false;
            btnAlunos.Click += btnAlunos_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(255, 128, 0);
            btnSair.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(58, 313);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(353, 125);
            btnSair.TabIndex = 1;
            btnSair.Text = "Sair do Sistema";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // buttonNotas
            // 
            buttonNotas.BackColor = Color.Indigo;
            buttonNotas.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonNotas.ForeColor = Color.White;
            buttonNotas.Location = new Point(446, 144);
            buttonNotas.Name = "buttonNotas";
            buttonNotas.Size = new Size(353, 128);
            buttonNotas.TabIndex = 2;
            buttonNotas.Text = "Notas e Disciplina";
            buttonNotas.UseVisualStyleBackColor = false;
            buttonNotas.Click += buttonNotas_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkRed;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(446, 313);
            button1.Name = "button1";
            button1.Size = new Size(353, 128);
            button1.TabIndex = 3;
            button1.Text = "Cadastro de Professores";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 489);
            Controls.Add(button1);
            Controls.Add(buttonNotas);
            Controls.Add(btnSair);
            Controls.Add(btnAlunos);
            Name = "frmPrincipal";
            Text = "Exemplo Banco de Dados - Escola";
            WindowState = FormWindowState.Maximized;
            Load += frmPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAlunos;
        private Button btnSair;
        private Button buttonNotas;
        private Button button1;
    }
}

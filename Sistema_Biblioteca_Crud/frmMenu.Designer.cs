namespace Sistema_Biblioteca_Crud
{
    partial class frmMenu
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
        btnLivros = new Button();
        btnLeitores = new Button();
        btnEmprestimo = new Button();
        btnSair = new Button();
        SuspendLayout();
        // 
        // btnLivros
        // 
        btnLivros.BackColor = Color.DodgerBlue;
        btnLivros.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnLivros.ForeColor = SystemColors.ButtonHighlight;
        btnLivros.Location = new Point(93, 137);
        btnLivros.Name = "btnLivros";
        btnLivros.Size = new Size(232, 89);
        btnLivros.TabIndex = 0;
        btnLivros.Text = "Livros";
        btnLivros.UseVisualStyleBackColor = false;
        btnLivros.Click += btnLivros_Click;
        // 
        // btnLeitores
        // 
        btnLeitores.BackColor = Color.ForestGreen;
        btnLeitores.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnLeitores.ForeColor = SystemColors.ControlLightLight;
        btnLeitores.Location = new Point(344, 137);
        btnLeitores.Name = "btnLeitores";
        btnLeitores.Size = new Size(232, 89);
        btnLeitores.TabIndex = 1;
        btnLeitores.Text = "Leitores";
        btnLeitores.UseVisualStyleBackColor = false;
        btnLeitores.Click += btnLeitores_Click;
        // 
        // btnEmprestimo
        // 
        btnEmprestimo.BackColor = Color.DarkViolet;
        btnEmprestimo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnEmprestimo.ForeColor = SystemColors.ButtonHighlight;
        btnEmprestimo.Location = new Point(599, 137);
        btnEmprestimo.Name = "btnEmprestimo";
        btnEmprestimo.Size = new Size(232, 89);
        btnEmprestimo.TabIndex = 2;
        btnEmprestimo.Text = "Emprestimos";
        btnEmprestimo.UseVisualStyleBackColor = false;
        btnEmprestimo.Click += btnEmprestimo_Click;
        // 
        // btnSair
        // 
        btnSair.BackColor = SystemColors.ControlDarkDark;
        btnSair.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnSair.ForeColor = SystemColors.ButtonFace;
        btnSair.Location = new Point(855, 137);
        btnSair.Name = "btnSair";
        btnSair.Size = new Size(232, 89);
        btnSair.TabIndex = 3;
        btnSair.Text = "Sair";
        btnSair.UseVisualStyleBackColor = false;
        btnSair.Click += btnSair_Click;
        // 
        // frmMenu
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1235, 404);
        Controls.Add(btnSair);
        Controls.Add(btnEmprestimo);
        Controls.Add(btnLeitores);
        Controls.Add(btnLivros);
        Name = "frmMenu";
        Text = "Form1";
        Load += Form1_Load;
        ResumeLayout(false);
        }

        #endregion

        private Button btnLivros;
        private Button btnLeitores;
        private Button btnEmprestimo;
        private Button btnSair;
    }
}

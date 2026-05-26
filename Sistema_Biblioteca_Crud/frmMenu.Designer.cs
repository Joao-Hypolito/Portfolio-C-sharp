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
        btnLivros.Location = new Point(276, 240);
        btnLivros.Name = "btnLivros";
        btnLivros.Size = new Size(75, 23);
        btnLivros.TabIndex = 0;
        btnLivros.Text = "Livros";
        btnLivros.UseVisualStyleBackColor = true;
        // 
        // btnLeitores
        // 
        btnLeitores.Location = new Point(377, 240);
        btnLeitores.Name = "btnLeitores";
        btnLeitores.Size = new Size(75, 23);
        btnLeitores.TabIndex = 1;
        btnLeitores.Text = "Leitores";
        btnLeitores.UseVisualStyleBackColor = true;
        // 
        // btnEmprestimo
        // 
        btnEmprestimo.Location = new Point(735, 240);
        btnEmprestimo.Name = "btnEmprestimo";
        btnEmprestimo.Size = new Size(75, 23);
        btnEmprestimo.TabIndex = 2;
        btnEmprestimo.Text = "Emprestimos";
        btnEmprestimo.UseVisualStyleBackColor = true;
        // 
        // btnSair
        // 
        btnSair.Location = new Point(850, 240);
        btnSair.Name = "btnSair";
        btnSair.Size = new Size(75, 23);
        btnSair.TabIndex = 3;
        btnSair.Text = "button4";
        btnSair.UseVisualStyleBackColor = true;
        // 
        // frmMenu
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1288, 523);
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

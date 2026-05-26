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
        button2 = new Button();
        button3 = new Button();
        button4 = new Button();
        button5 = new Button();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        label6 = new Label();
        textBox1 = new TextBox();
        textBox2 = new TextBox();
        textBox3 = new TextBox();
        checkBox1 = new CheckBox();
        dataGridView1 = new DataGridView();
        maskedTextBox1 = new MaskedTextBox();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // button1
        // 
        button1.BackColor = SystemColors.HotTrack;
        button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        button1.ForeColor = SystemColors.ButtonFace;
        button1.Location = new Point(93, 70);
        button1.Name = "button1";
        button1.Size = new Size(171, 60);
        button1.TabIndex = 0;
        button1.Text = "Novo";
        button1.UseVisualStyleBackColor = false;
        // 
        // button2
        // 
        button2.BackColor = Color.LimeGreen;
        button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        button2.ForeColor = SystemColors.ButtonFace;
        button2.Location = new Point(281, 70);
        button2.Name = "button2";
        button2.Size = new Size(171, 60);
        button2.TabIndex = 1;
        button2.Text = "Salvar";
        button2.UseVisualStyleBackColor = false;
        // 
        // button3
        // 
        button3.BackColor = Color.DarkOrange;
        button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        button3.ForeColor = SystemColors.ControlLight;
        button3.Location = new Point(471, 70);
        button3.Name = "button3";
        button3.Size = new Size(171, 60);
        button3.TabIndex = 2;
        button3.Text = "Editar";
        button3.UseVisualStyleBackColor = false;
        // 
        // button4
        // 
        button4.BackColor = Color.Red;
        button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        button4.ForeColor = SystemColors.ControlLight;
        button4.Location = new Point(660, 70);
        button4.Name = "button4";
        button4.Size = new Size(171, 60);
        button4.TabIndex = 3;
        button4.Text = "Excluir";
        button4.UseVisualStyleBackColor = false;
        // 
        // button5
        // 
        button5.BackColor = SystemColors.AppWorkspace;
        button5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        button5.ForeColor = SystemColors.ControlLight;
        button5.Location = new Point(849, 70);
        button5.Name = "button5";
        button5.Size = new Size(171, 60);
        button5.TabIndex = 4;
        button5.Text = "Limpar";
        button5.UseVisualStyleBackColor = false;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.Location = new Point(93, 21);
        label1.Name = "label1";
        label1.Size = new Size(200, 31);
        label1.TabIndex = 5;
        label1.Text = "Acervo de Livros";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label2.Location = new Point(93, 157);
        label2.Name = "label2";
        label2.Size = new Size(183, 31);
        label2.TabIndex = 6;
        label2.Text = "Dados do Livro";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label3.Location = new Point(93, 211);
        label3.Name = "label3";
        label3.Size = new Size(56, 21);
        label3.TabIndex = 7;
        label3.Text = "Título";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label4.Location = new Point(93, 270);
        label4.Name = "label4";
        label4.Size = new Size(53, 21);
        label4.TabIndex = 8;
        label4.Text = "Autor";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label5.Location = new Point(93, 320);
        label5.Name = "label5";
        label5.Size = new Size(81, 21);
        label5.TabIndex = 9;
        label5.Text = "Categoria";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label6.Location = new Point(351, 270);
        label6.Name = "label6";
        label6.Size = new Size(53, 21);
        label6.TabIndex = 10;
        label6.Text = "ISRN";
        // 
        // textBox1
        // 
        textBox1.Location = new Point(93, 244);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(237, 23);
        textBox1.TabIndex = 11;
        // 
        // textBox2
        // 
        textBox2.Location = new Point(93, 294);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(237, 23);
        textBox2.TabIndex = 12;
        // 
        // textBox3
        // 
        textBox3.Location = new Point(93, 344);
        textBox3.Name = "textBox3";
        textBox3.Size = new Size(237, 23);
        textBox3.TabIndex = 13;
        // 
        // checkBox1
        // 
        checkBox1.AutoSize = true;
        checkBox1.Location = new Point(341, 348);
        checkBox1.Name = "checkBox1";
        checkBox1.Size = new Size(111, 19);
        checkBox1.TabIndex = 14;
        checkBox1.Text = "Ativo no Acervo";
        checkBox1.UseVisualStyleBackColor = true;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(93, 392);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new Size(1272, 150);
        dataGridView1.TabIndex = 15;
        // 
        // maskedTextBox1
        // 
        maskedTextBox1.Location = new Point(351, 294);
        maskedTextBox1.Name = "maskedTextBox1";
        maskedTextBox1.Size = new Size(187, 23);
        maskedTextBox1.TabIndex = 16;
        // 
        // frmLivros
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1445, 554);
        Controls.Add(maskedTextBox1);
        Controls.Add(dataGridView1);
        Controls.Add(checkBox1);
        Controls.Add(textBox3);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(button5);
        Controls.Add(button4);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Name = "frmLivros";
        Text = "forms";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private CheckBox checkBox1;
        private DataGridView dataGridView1;
        private MaskedTextBox maskedTextBox1;
    }
}
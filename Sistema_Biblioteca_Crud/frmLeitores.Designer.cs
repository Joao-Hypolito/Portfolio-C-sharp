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
        maskedTextBox1 = new MaskedTextBox();
        dataGridView1 = new DataGridView();
        checkBox1 = new CheckBox();
        textBox3 = new TextBox();
        textBox2 = new TextBox();
        textBox1 = new TextBox();
        label6 = new Label();
        label5 = new Label();
        label4 = new Label();
        label3 = new Label();
        label2 = new Label();
        label1 = new Label();
        button5 = new Button();
        button4 = new Button();
        button3 = new Button();
        button2 = new Button();
        button1 = new Button();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // maskedTextBox1
        // 
        maskedTextBox1.Location = new Point(337, 320);
        maskedTextBox1.Name = "maskedTextBox1";
        maskedTextBox1.Size = new Size(187, 23);
        maskedTextBox1.TabIndex = 33;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(79, 418);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new Size(1272, 150);
        dataGridView1.TabIndex = 32;
        // 
        // checkBox1
        // 
        checkBox1.AutoSize = true;
        checkBox1.Location = new Point(327, 374);
        checkBox1.Name = "checkBox1";
        checkBox1.Size = new Size(158, 19);
        checkBox1.TabIndex = 31;
        checkBox1.Text = "Leitor Ativo na Biblioteca";
        checkBox1.UseVisualStyleBackColor = true;
        // 
        // textBox3
        // 
        textBox3.Location = new Point(79, 370);
        textBox3.Name = "textBox3";
        textBox3.Size = new Size(237, 23);
        textBox3.TabIndex = 30;
        // 
        // textBox2
        // 
        textBox2.Location = new Point(79, 320);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(237, 23);
        textBox2.TabIndex = 29;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(79, 270);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(237, 23);
        textBox1.TabIndex = 28;
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
        // button5
        // 
        button5.BackColor = SystemColors.AppWorkspace;
        button5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        button5.ForeColor = SystemColors.ControlLight;
        button5.Location = new Point(835, 96);
        button5.Name = "button5";
        button5.Size = new Size(171, 60);
        button5.TabIndex = 21;
        button5.Text = "Limpar";
        button5.UseVisualStyleBackColor = false;
        // 
        // button4
        // 
        button4.BackColor = Color.Red;
        button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        button4.ForeColor = SystemColors.ControlLight;
        button4.Location = new Point(646, 96);
        button4.Name = "button4";
        button4.Size = new Size(171, 60);
        button4.TabIndex = 20;
        button4.Text = "Excluir";
        button4.UseVisualStyleBackColor = false;
        // 
        // button3
        // 
        button3.BackColor = Color.DarkOrange;
        button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        button3.ForeColor = SystemColors.ControlLight;
        button3.Location = new Point(457, 96);
        button3.Name = "button3";
        button3.Size = new Size(171, 60);
        button3.TabIndex = 19;
        button3.Text = "Editar";
        button3.UseVisualStyleBackColor = false;
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
        // 
        // button1
        // 
        button1.BackColor = SystemColors.HotTrack;
        button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        button1.ForeColor = SystemColors.ButtonFace;
        button1.Location = new Point(79, 96);
        button1.Name = "button1";
        button1.Size = new Size(171, 60);
        button1.TabIndex = 17;
        button1.Text = "Novo";
        button1.UseVisualStyleBackColor = false;
        // 
        // frmLeitores
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1431, 615);
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
        Name = "frmLeitores";
        Text = "frmLeitores";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBox1;
        private DataGridView dataGridView1;
        private CheckBox checkBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}
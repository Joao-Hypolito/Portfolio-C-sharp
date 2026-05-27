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
        maskedTextBox1 = new MaskedTextBox();
        dataGridView1 = new DataGridView();
        checkBox1 = new CheckBox();
        textBox1 = new TextBox();
        label6 = new Label();
        label5 = new Label();
        label4 = new Label();
        label3 = new Label();
        label2 = new Label();
        label1 = new Label();
        button2 = new Button();
        button1 = new Button();
        maskedTextBox2 = new MaskedTextBox();
        statusStrip1 = new StatusStrip();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // maskedTextBox1
        // 
        maskedTextBox1.Location = new Point(22, 346);
        maskedTextBox1.Name = "maskedTextBox1";
        maskedTextBox1.Size = new Size(187, 23);
        maskedTextBox1.TabIndex = 50;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(22, 392);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new Size(1272, 150);
        dataGridView1.TabIndex = 49;
        // 
        // checkBox1
        // 
        checkBox1.AutoSize = true;
        checkBox1.Location = new Point(270, 348);
        checkBox1.Name = "checkBox1";
        checkBox1.Size = new Size(158, 19);
        checkBox1.TabIndex = 48;
        checkBox1.Text = "Leitor Ativo na Biblioteca";
        checkBox1.UseVisualStyleBackColor = true;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(22, 244);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(237, 23);
        textBox1.TabIndex = 45;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label6.Location = new Point(280, 270);
        label6.Name = "label6";
        label6.Size = new Size(74, 21);
        label6.TabIndex = 44;
        label6.Text = "Telefone";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label5.Location = new Point(22, 320);
        label5.Name = "label5";
        label5.Size = new Size(44, 21);
        label5.TabIndex = 43;
        label5.Text = "Data";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label4.Location = new Point(22, 270);
        label4.Name = "label4";
        label4.Size = new Size(51, 21);
        label4.TabIndex = 42;
        label4.Text = "Email";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label3.Location = new Point(22, 211);
        label3.Name = "label3";
        label3.Size = new Size(134, 21);
        label3.TabIndex = 41;
        label3.Text = "Nome Completo";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label2.Location = new Point(22, 157);
        label2.Name = "label2";
        label2.Size = new Size(211, 31);
        label2.TabIndex = 40;
        label2.Text = "Novo Emprestimo";
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
        // button2
        // 
        button2.BackColor = Color.LimeGreen;
        button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        button2.ForeColor = SystemColors.ButtonFace;
        button2.Location = new Point(210, 70);
        button2.Name = "button2";
        button2.Size = new Size(171, 60);
        button2.TabIndex = 35;
        button2.Text = "Salvar";
        button2.UseVisualStyleBackColor = false;
        // 
        // button1
        // 
        button1.BackColor = SystemColors.HotTrack;
        button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        button1.ForeColor = SystemColors.ButtonFace;
        button1.Location = new Point(22, 70);
        button1.Name = "button1";
        button1.Size = new Size(171, 60);
        button1.TabIndex = 34;
        button1.Text = "Novo";
        button1.UseVisualStyleBackColor = false;
        // 
        // maskedTextBox2
        // 
        maskedTextBox2.Location = new Point(565, 270);
        maskedTextBox2.Name = "maskedTextBox2";
        maskedTextBox2.Size = new Size(187, 23);
        maskedTextBox2.TabIndex = 51;
        // 
        // statusStrip1
        // 
        statusStrip1.Location = new Point(0, 541);
        statusStrip1.Name = "statusStrip1";
        statusStrip1.Size = new Size(1317, 22);
        statusStrip1.TabIndex = 52;
        statusStrip1.Text = "statusStrip1";
        // 
        // frmEmprestimo
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1317, 563);
        Controls.Add(statusStrip1);
        Controls.Add(maskedTextBox2);
        Controls.Add(maskedTextBox1);
        Controls.Add(dataGridView1);
        Controls.Add(checkBox1);
        Controls.Add(textBox1);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(button2);
        Controls.Add(button1);
        Name = "frmEmprestimo";
        Text = "frmEmprestimo";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBox1;
        private DataGridView dataGridView1;
        private CheckBox checkBox1;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
        private MaskedTextBox maskedTextBox2;
        private StatusStrip statusStrip1;
    }
}
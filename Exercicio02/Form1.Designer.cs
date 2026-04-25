namespace Exercicio02
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            LsResultado = new TextBox();
            button1 = new Button();
            LsVeredito = new TextBox();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonShadow;
            label1.Location = new Point(441, 78);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Nota 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonShadow;
            label2.Location = new Point(441, 121);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Nota 2:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonShadow;
            label3.Location = new Point(441, 162);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "Nota 3:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonShadow;
            label4.Location = new Point(441, 204);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 3;
            label4.Text = "Nota 4:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(512, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(512, 118);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(512, 159);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(512, 201);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 7;
            // 
            // LsResultado
            // 
            LsResultado.Location = new Point(461, 302);
            LsResultado.MaxLength = 36000;
            LsResultado.Name = "LsResultado";
            LsResultado.Size = new Size(202, 23);
            LsResultado.TabIndex = 8;
            LsResultado.TextAlign = HorizontalAlignment.Center;
            LsResultado.TextChanged += textResultado_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Coral;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(500, 247);
            button1.Name = "button1";
            button1.Size = new Size(125, 49);
            button1.TabIndex = 9;
            button1.Text = "Verificar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // LsVeredito
            // 
            LsVeredito.Location = new Point(512, 367);
            LsVeredito.Name = "LsVeredito";
            LsVeredito.Size = new Size(100, 23);
            LsVeredito.TabIndex = 10;
            LsVeredito.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(521, 338);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 11;
            label5.Text = "Veredito Final:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonShadow;
            label6.Font = new Font("Times New Roman", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(461, 31);
            label6.Name = "label6";
            label6.Size = new Size(198, 23);
            label6.TabIndex = 12;
            label6.Text = "Calcular Média Final";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1288, 567);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(LsVeredito);
            Controls.Add(button1);
            Controls.Add(LsResultado);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox LsResultado;
        private Button button1;
        private TextBox LsVeredito;
        private Label label5;
        private Label label6;
    }
}

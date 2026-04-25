namespace WinFormsApp1
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
            lblTextA = new Label();
            button1 = new Button();
            LsResultado = new ListBox();
            textBox1 = new TextBox();
            lblTextB = new Label();
            lblTextC = new Label();
            lblTextD = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // lblTextA
            // 
            lblTextA.AutoSize = true;
            lblTextA.Location = new Point(551, 114);
            lblTextA.Name = "lblTextA";
            lblTextA.Size = new Size(62, 15);
            lblTextA.TabIndex = 0;
            lblTextA.Text = "Número A";
            lblTextA.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(634, 278);
            button1.Name = "button1";
            button1.Size = new Size(100, 42);
            button1.TabIndex = 1;
            button1.Text = "RESULTADO";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // LsResultado
            // 
            LsResultado.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LsResultado.FormattingEnabled = true;
            LsResultado.Location = new Point(514, 326);
            LsResultado.Name = "LsResultado";
            LsResultado.Size = new Size(346, 137);
            LsResultado.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(634, 114);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // lblTextB
            // 
            lblTextB.AutoSize = true;
            lblTextB.Location = new Point(551, 154);
            lblTextB.Name = "lblTextB";
            lblTextB.Size = new Size(61, 15);
            lblTextB.TabIndex = 4;
            lblTextB.Text = "Número B";
            // 
            // lblTextC
            // 
            lblTextC.AutoSize = true;
            lblTextC.Location = new Point(551, 202);
            lblTextC.Name = "lblTextC";
            lblTextC.Size = new Size(62, 15);
            lblTextC.TabIndex = 5;
            lblTextC.Text = "Número C";
            // 
            // lblTextD
            // 
            lblTextD.AutoSize = true;
            lblTextD.Location = new Point(551, 252);
            lblTextD.Name = "lblTextD";
            lblTextD.Size = new Size(62, 15);
            lblTextD.TabIndex = 6;
            lblTextD.Text = "Número D";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(634, 154);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(634, 202);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(634, 249);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 9;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(866, 373);
            button2.Name = "button2";
            button2.Size = new Size(109, 50);
            button2.TabIndex = 10;
            button2.Text = "Limpar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1433, 566);
            Controls.Add(button2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(lblTextD);
            Controls.Add(lblTextC);
            Controls.Add(lblTextB);
            Controls.Add(textBox1);
            Controls.Add(LsResultado);
            Controls.Add(button1);
            Controls.Add(lblTextA);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTextA;
        private Button button1;
        private ListBox LsResultado;
        private TextBox textBox1;
        private Label lblTextB;
        private Label lblTextC;
        private Label lblTextD;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button2;
    }
}

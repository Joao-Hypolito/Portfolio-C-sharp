namespace Exercicio04
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
            listBox = new ListBox();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // listBox
            // 
            listBox.BackColor = SystemColors.MenuBar;
            listBox.Font = new Font("Times New Roman", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            listBox.FormattingEnabled = true;
            listBox.Location = new Point(480, 202);
            listBox.Name = "listBox";
            listBox.Size = new Size(363, 276);
            listBox.TabIndex = 0;
            listBox.SelectedIndexChanged += listBox_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(619, 165);
            button1.Name = "button1";
            button1.Size = new Size(83, 31);
            button1.TabIndex = 1;
            button1.Text = "Comecar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(445, 135);
            label1.Name = "label1";
            label1.Size = new Size(438, 21);
            label1.TabIndex = 2;
            label1.Text = "Mostrar Todas as Opcoes para se chegar no resultado 7";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(619, 498);
            button2.Name = "button2";
            button2.Size = new Size(83, 30);
            button2.TabIndex = 3;
            button2.Text = "Limpar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1213, 683);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(listBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox;
        private Button button1;
        private Label label1;
        private Button button2;
    }
}

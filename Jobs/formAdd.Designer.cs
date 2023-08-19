namespace Jobs
{
    partial class formAdd
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            btnCancelar = new Button();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 122);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 0;
            label1.Text = "compania";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 55);
            label2.Name = "label2";
            label2.Size = new Size(27, 25);
            label2.TabIndex = 1;
            label2.Text = "id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 186);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 2;
            label3.Text = "funcao";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 245);
            label4.Name = "label4";
            label4.Size = new Size(104, 25);
            label4.TabIndex = 3;
            label4.Text = "pagamento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 303);
            label5.Name = "label5";
            label5.Size = new Size(134, 25);
            label5.TabIndex = 4;
            label5.Text = "horas semanais";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(74, 366);
            label6.Name = "label6";
            label6.Size = new Size(86, 25);
            label6.TabIndex = 5;
            label6.Text = "descricao";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(197, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(197, 119);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(197, 183);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(197, 242);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(197, 297);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 31);
            textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(197, 369);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(150, 31);
            textBox6.TabIndex = 11;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(571, 339);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(178, 52);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(385, 339);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(167, 52);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Salvar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // formAdd
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(btnCancelar);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formAdd";
            Text = "formAdd";
            Load += formAdd_Load;
            Leave += formAdd_Leave;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button btnCancelar;
        private Button btnAdd;
    }
}
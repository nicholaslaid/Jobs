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
            txtId = new TextBox();
            txtCompany = new TextBox();
            txtFunction = new TextBox();
            txtPayment = new TextBox();
            txtHours = new TextBox();
            txtDesc = new TextBox();
            btnCancelar = new Button();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 69);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 0;
            label1.Text = "Compania";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 32);
            label2.Name = "label2";
            label2.Size = new Size(28, 25);
            label2.TabIndex = 1;
            label2.Text = "Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 103);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 2;
            label3.Text = "Função";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 140);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 3;
            label4.Text = "Pagamento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 177);
            label5.Name = "label5";
            label5.Size = new Size(137, 25);
            label5.TabIndex = 4;
            label5.Text = "Horas semanais";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(69, 231);
            label6.Name = "label6";
            label6.Size = new Size(88, 25);
            label6.TabIndex = 5;
            label6.Text = "Descrição";
            // 
            // txtId
            // 
            txtId.Location = new Point(161, 29);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(150, 31);
            txtId.TabIndex = 6;
            // 
            // txtCompany
            // 
            txtCompany.Location = new Point(161, 66);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(150, 31);
            txtCompany.TabIndex = 7;
            // 
            // txtFunction
            // 
            txtFunction.Location = new Point(161, 103);
            txtFunction.Name = "txtFunction";
            txtFunction.Size = new Size(150, 31);
            txtFunction.TabIndex = 8;
            // 
            // txtPayment
            // 
            txtPayment.Location = new Point(161, 140);
            txtPayment.Name = "txtPayment";
            txtPayment.Size = new Size(150, 31);
            txtPayment.TabIndex = 9;
            // 
            // txtHours
            // 
            txtHours.Location = new Point(161, 177);
            txtHours.Name = "txtHours";
            txtHours.Size = new Size(150, 31);
            txtHours.TabIndex = 10;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(161, 231);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(578, 165);
            txtDesc.TabIndex = 11;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(561, 424);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(178, 52);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(375, 424);
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
            ClientSize = new Size(768, 495);
            Controls.Add(btnAdd);
            Controls.Add(btnCancelar);
            Controls.Add(txtDesc);
            Controls.Add(txtHours);
            Controls.Add(txtPayment);
            Controls.Add(txtFunction);
            Controls.Add(txtCompany);
            Controls.Add(txtId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formAdd";
            Text = "formAdd";
            FormClosing += formAdd_FormClosing;
            Load += formAdd_Load;
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
        private TextBox txtId;
        private TextBox txtCompany;
        private TextBox txtFunction;
        private TextBox txtPayment;
        private TextBox txtHours;
        private TextBox txtDesc;
        private Button btnCancelar;
        private Button btnAdd;
    }
}